/*
    -Họ Và Tên: Nguyễn Văn Hà
    -Lớp: CCQ2211D
    -Mô Tả: Controller CategoriesController thuộc namespace MiniSupermarket.API.Controllers,
           quản lý các chức năng CRUD cho danh mục nhóm hàng.
           Buổi 3: tái cấu trúc toàn bộ, thay dữ liệu mẫu In-Memory bằng
           SupermarketDbContext (EF Core) truy vấn trực tiếp SQL Server,
           sử dụng async/await cho toàn bộ thao tác dữ liệu. Giữ nguyên
           toàn bộ cơ chế phân quyền JWT ([Authorize]) đã xây dựng ở Buổi 2.
*/
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MiniSupermarket.API.Data;
using MiniSupermarket.API.Models;

namespace MiniSupermarket.API.Controllers
{
    [Route("api/[controller]")] // Định tuyến cơ sở: /api/categories
    [ApiController]
    [Authorize]
    public class CategoriesController : ControllerBase
    {
        private readonly SupermarketDbContext _context;

        // Tiêm DbContext thông qua Constructor Injection
        public CategoriesController(SupermarketDbContext context)
        {
            _context = context;
        }

        // 1. READ: Lấy toàn bộ danh sách nhóm hàng từ SQL Server (GET /api/categories)
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var list = await _context.Categories.AsNoTracking().ToListAsync();
            return Ok(list);
        }

        // 2. READ: Lấy chi tiết một nhóm hàng theo ID (GET /api/categories/{id})
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cat = await _context.Categories.FindAsync(id);
            if (cat == null)
            {
                // Trả về mã lỗi 404 nếu không tìm thấy ID tương ứng
                return NotFound(new { message = "Không tìm thấy nhóm hàng!" });
            }
            return Ok(cat);
        }

        // 3. SEARCH: Tìm kiếm nhóm hàng theo từ khóa qua Query String (GET /api/categories/search?keyword=...)
        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return BadRequest(new { message = "Vui lòng nhập từ khóa!" });
            }
            // EF Core dịch biểu thức LINQ thành câu lệnh SQL LIKE tương ứng
            var result = await _context.Categories
                .Where(c => c.CategoryName.Contains(keyword))
                .ToListAsync();
            return Ok(result);
        }

        // 4. CREATE: Thêm mới nhóm hàng vào Database (POST /api/categories)
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Category newCat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Categories.Add(newCat);
            await _context.SaveChangesAsync(); // Lưu thay đổi vào SQL Server

            // Trả về mã 201 Created kèm đường dẫn dẫn tới bản ghi mới tạo
            return CreatedAtAction(nameof(GetById), new { id = newCat.CategoryId }, newCat);
        }

        // 5. UPDATE: Cập nhật thông tin nhóm hàng vào Database (PUT /api/categories/{id})
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Category updateCat)
        {
            var cat = await _context.Categories.FindAsync(id);
            if (cat == null)
            {
                return NotFound(new { message = "Không tìm thấy nhóm hàng cần sửa!" });
            }
            // Cập nhật giá trị mới
            cat.CategoryName = updateCat.CategoryName;
            cat.Description = updateCat.Description;

            await _context.SaveChangesAsync();

            // Trả về mã 204 NoContent biểu thị cập nhật thành công nhưng không cần trả về dữ liệu mới
            return NoContent();
        }

        // 6. DELETE: Xóa nhóm hàng khỏi Database (DELETE /api/categories/{id})
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]//chỉ có admin mới dc xoá
        public async Task<IActionResult> Delete(int id)
        {
            var cat = await _context.Categories.FindAsync(id);
            if (cat == null)
            {
                return NotFound(new { message = "Không tìm thấy nhóm hàng cần xóa!" });
            }

            _context.Categories.Remove(cat);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                // Ràng buộc khóa ngoại: nhóm hàng đang chứa sản phẩm trực thuộc thì không xóa được
                return BadRequest(new { message = "Không thể xóa: nhóm hàng đang chứa sản phẩm trực thuộc!" });
            }
            return NoContent();
        }

        // Kiểm tra quyền Admin (Chỉ tài khoản có Role = Admin mới được gọi)
        [HttpGet("admin-dashboard")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAdminDashboard()
        {
            return Ok(new { message = "Chào mừng Admin! Bạn có toàn quyền quản trị hệ thống siêu thị mini." });
        }

        // Kiểm tra quyền chung cho nhân viên (Cả Admin và Cashier đều gọi được)
        [HttpGet("staff-pos")]
        [Authorize(Roles = "Admin,Cashier")]
        public IActionResult GetStaffPos()
        {
            return Ok(new { message = "Màn hình POS Thu ngân sẵn sàng phục vụ bán hàng." });
        }
    }
}