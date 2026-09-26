/*
 -Họ Và Tên: Nguyễn Văn Hà
-Lớp :CCQ2211D
-Mô Tả: FormLogin - màn hình đăng nhập đầu tiên của ứng dụng WinForms,
        gửi tài khoản/mật khẩu tới API (POST /api/auth/login), nhận
        về JWT Token và Role, lưu vào SessionManager, sau đó mở màn
        hình Menu chính (FormMain) thay vì mở thẳng một Form quản lý cụ thể.
 */

using System.Net.Http.Json;
using System.Text.Json;

namespace MiniSupermarket.WinForms
{
    public partial class FormLogin : Form
    {
        private static readonly HttpClient _client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7101/api/")
        };

        public FormLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var loginData = new { Username = username, Password = password };
                var response = await _client.PostAsJsonAsync("auth/login", loginData);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    using var doc = JsonDocument.Parse(jsonString);

                    SessionManager.JwtToken = doc.RootElement.GetProperty("token").GetString() ?? string.Empty;
                    SessionManager.CurrentRole = doc.RootElement.GetProperty("role").GetString() ?? string.Empty;

                    MessageBox.Show($"Đăng nhập thành công với quyền: {SessionManager.CurrentRole}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở màn hình Menu chính thay vì mở thẳng FormCategoryManagement
                    FormMain mainForm = new FormMain();
                    this.Hide();
                    mainForm.ShowDialog();

                    // Sau khi FormMain đóng lại (do bấm Đăng xuất hoặc đóng cửa sổ),
                    // hiện lại chính FormLogin này thay vì Close() nó.
                    // Lưu ý: Program.cs gọi Application.Run(new FormLogin()) nên FormLogin
                    // là Form chính của ứng dụng - nếu Close() ở đây, toàn bộ app sẽ thoát
                    // theo, dù người dùng chỉ vừa Đăng xuất chứ không muốn tắt chương trình.
                    txtUser.Clear();
                    txtPass.Clear();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến Server: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}