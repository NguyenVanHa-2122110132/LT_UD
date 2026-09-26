/*
 -Họ Và Tên: Nguyễn Văn Hà
-Lớp :CCQ2211D
-Mô Tả: Form quản lý Khách hàng thân thiết (CRUD) - Bài tập mở rộng Buổi 3,
        kết nối tới Web API MiniSupermarket.API qua HttpClient để
        Thêm/Sửa/Xóa/Tìm kiếm khách hàng và hiển thị danh sách lên
        DataGridView. Cấu trúc theo đúng mẫu FormCategoryManagement.
 */
using System.Net.Http.Json;
using System.Windows.Forms;
using System.Net.Http.Headers;

namespace MiniSupermarket.WinForms
{
    public partial class FormCustomerManagement : Form
    {
        // Khởi tạo HttpClient tĩnh kết nối trực tiếp đến Web API
        // (Đảm bảo số Port https://localhost:7101 khớp với API của bạn)
        private static readonly HttpClient _client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7101/api/")
        };

        public FormCustomerManagement()
        {
            InitializeComponent();
            // Đính kèm Bearer Token vào Header, dùng chung cho mọi lời gọi API bên dưới
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.JwtToken);
        }

        // Sự kiện Form vừa bật lên: Tự động tải dữ liệu từ API lên bảng
        private async void FormCustomerManagement_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        // Hàm dùng chung: Gọi API GET lấy danh sách và đổ lên DataGridView
        private async Task LoadDataAsync()
        {
            try
            {
                // Gửi request GET tới endpoint "customers", tự động giải tuần tự hóa
                // chuỗi JSON thành List<CustomerDto>
                var customers = await _client.GetFromJsonAsync<List<CustomerDto>>("customers");
                dgvCustomers.DataSource = customers; // Gán nguồn dữ liệu cho bảng hiển thị
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối Server: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Tải lại dữ liệu (Refresh)
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        // Sự kiện khi click vào một dòng trên DataGridView: Đưa dữ liệu lên các
        // ô nhập (TextBox) để chuẩn bị Sửa/Xóa
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
                txtCustomerId.Text = row.Cells["CustomerId"].Value.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = row.Cells["Address"]?.Value?.ToString() ?? string.Empty;
                txtRewardPoints.Text = row.Cells["RewardPoints"].Value.ToString();
                txtMembershipRank.Text = row.Cells["MembershipRank"].Value.ToString();
            }
        }

        // Nút THÊM MỚI (CREATE): Gửi dữ liệu POST lên Web API
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var newCustomer = new
            {
                CustomerName = txtCustomerName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Address = txtAddress.Text,
                RewardPoints = int.TryParse(txtRewardPoints.Text, out int points) ? points : 0,
                MembershipRank = string.IsNullOrWhiteSpace(txtMembershipRank.Text) ? "Chuẩn" : txtMembershipRank.Text
            };

            // Gửi request POST kèm theo đối tượng dạng JSON
            var response = await _client.PostAsJsonAsync("customers", newCustomer);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDataAsync(); // Tải lại danh sách mới
                ClearInputs(); // Xóa sạch ô nhập
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Nút CẬP NHẬT (UPDATE): Gửi dữ liệu PUT lên Web API theo ID
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerId.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = int.Parse(txtCustomerId.Text);
            var updateCustomer = new
            {
                CustomerId = id,
                CustomerName = txtCustomerName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Address = txtAddress.Text,
                RewardPoints = int.TryParse(txtRewardPoints.Text, out int points) ? points : 0,
                MembershipRank = txtMembershipRank.Text
            };

            // Gửi request PUT kèm ID trên đường dẫn URI
            var response = await _client.PutAsJsonAsync($"customers/{id}", updateCustomer);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDataAsync();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Nút XÓA (DELETE): Gửi request DELETE lên Web API theo ID
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerId.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = int.Parse(txtCustomerId.Text);
            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa khách hàng ID = {id}?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var response = await _client.DeleteAsync($"customers/{id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDataAsync();
                    ClearInputs();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Bạn không có quyền xóa khách hàng (chỉ Admin)!", "Từ chối truy cập",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Nút TÌM KIẾM (SEARCH): Gọi API lọc khách hàng theo tên hoặc số điện thoại
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await PerformSearchAsync();
        }

        // (Tùy chọn nâng cao) Gõ đến đâu tự động tìm đến đó giống hệt bên Nhóm hàng:
        // Bạn có thể gán sự kiện TextChanged này cho ô txtKeyword trong thiết kế Form Designer
        private async void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            await PerformSearchAsync();
        }

        // Hàm dùng chung xử lý tìm kiếm an toàn, tránh lỗi URL với tiếng Việt và khoảng trắng
        private async Task PerformSearchAsync()
        {
            string keyword = txtKeyword.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                await LoadDataAsync(); // Nếu ô tìm kiếm trống thì tải lại toàn bộ danh sách
                return;
            }

            try
            {
                // Mã hóa từ khóa sang định dạng URL an toàn (xử lý tốt tiếng Việt có dấu như "đồ" hay khoảng trắng)
                string encodedKeyword = Uri.EscapeDataString(keyword);

                // Gọi API dạng: GET /api/customers/search?keyword=abc
                var result = await _client.GetFromJsonAsync<List<CustomerDto>>(
                    $"customers/search?keyword={encodedKeyword}");

                dgvCustomers.DataSource = result;
            }
            catch (Exception)
            {
                // Nếu không tìm thấy kết quả, gán danh sách rỗng lên bảng để tránh văng lỗi
                dgvCustomers.DataSource = new List<CustomerDto>();
            }
        }

        // Hàm phụ trợ: Xóa trắng các ô nhập liệu sau khi thao tác xong
        private void ClearInputs()
        {
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
            txtRewardPoints.Text = "";
            txtMembershipRank.Text = "";
        }
    }

    // Lớp DTO trung gian tại Client hứng dữ liệu JSON trả về từ Server
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string? Address { get; set; }
        public int RewardPoints { get; set; }
        public string MembershipRank { get; set; } = string.Empty;
    }
}