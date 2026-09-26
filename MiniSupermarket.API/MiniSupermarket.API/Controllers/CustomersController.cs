/*
    -Họ Và Tên: Nguyễn Văn Hà
    -Lớp: CCQ2211D
    -Mô Tả: Controller CustomersController thuộc namespace MiniSupermarket.API.Controllers,
           quản lý các chức năng CRUD và tìm kiếm cho phân hệ Khách hàng
           thân thiết (Bài tập mở rộng Buổi 3), sử dụng SupermarketDbContext
           (EF Core) và async/await, theo cùng mẫu bảo mật JWT với
           CategoriesController.
*/
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MiniSupermarket.API.Data;
using MiniSupermarket.API.Models;

namespace MiniSupermarket.API.Controllers
{
    [Route("api/[controller]")] // Định tuyến cơ sở: /api/customers
    [ApiController]
    [Authorize]
    public class CustomersController : ControllerBase
    {
        private readonly SupermarketDbContext _context;

        public CustomersController(SupermarketDbContext context)
        {
            _context = context;
        }

        // 1. GET /api/customers: Lấy toàn bộ danh sách khách hàng
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var list = await _context.Customers.AsNoTracking().ToListAsync();
            return Ok(list);
        }

        // 2. GET /api/customers/{id}: Lấy chi tiết khách hàng theo mã định danh
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound(new { message = "Không tìm thấy khách hàng!" });
            }
            return Ok(customer);
        }

        // 3. GET /api/customers/search?keyword=...: Tìm kiếm theo tên hoặc số điện thoại
        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return BadRequest(new { message = "Vui lòng nhập từ khóa tìm kiếm!" });
            }
            var result = await _context.Customers
                .Where(c => c.CustomerName.Contains(keyword) || c.PhoneNumber.Contains(keyword))
                .ToListAsync();
            return Ok(result);
        }

        // 4. POST /api/customers: Thêm mới khách hàng thành viên
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Customer newCustomer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Customers.Add(newCustomer);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = newCustomer.CustomerId }, newCustomer);
        }

        // 5. PUT /api/customers/{id}: Cập nhật thông tin và hạng thẻ của khách hàng
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Customer updateCustomer)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound(new { message = "Không tìm thấy khách hàng cần sửa!" });
            }

            customer.CustomerName = updateCustomer.CustomerName;
            customer.PhoneNumber = updateCustomer.PhoneNumber;
            customer.Address = updateCustomer.Address;
            customer.RewardPoints = updateCustomer.RewardPoints;
            customer.MembershipRank = updateCustomer.MembershipRank;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // 6. DELETE /api/customers/{id}: Xóa tài khoản khách hàng khỏi hệ thống
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound(new { message = "Không tìm thấy khách hàng cần xóa!" });
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}