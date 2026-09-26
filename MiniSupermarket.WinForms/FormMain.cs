/*
 -Họ Và Tên: Nguyễn Văn Hà
-Lớp :CCQ2211D
-Mô Tả: FormMain - màn hình Menu chính, hiện sau khi đăng nhập thành công.
        Hiển thị lời chào theo Role đang đăng nhập (SessionManager.CurrentRole)
        và các nút điều hướng tới từng màn hình quản lý (Nhóm hàng, Khách hàng...).
        Kiểu "danh sách nút đơn giản": mọi Role đều thấy đủ nút, quyền hạn
        chi tiết (ví dụ chỉ Admin mới Xóa được) vẫn do Web API kiểm soát
        thông qua [Authorize(Roles = "...")], form chỉ hiển thị thông báo
        403 nếu bị từ chối.
 */
namespace MiniSupermarket.WinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Xin chào, quyền: {SessionManager.CurrentRole}";
        }

        // Mở màn hình Quản lý Nhóm hàng
        private void btnCategoryManagement_Click(object sender, EventArgs e)
        {
            var form = new FormCategoryManagement();
            form.ShowDialog(); // Mở dạng Modal, quay lại Menu chính khi đóng
        }

        // Mở màn hình Quản lý Khách hàng
        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            var form = new FormCustomerManagement();
            form.ShowDialog();
        }

        // Đăng xuất: xóa phiên làm việc và quay lại màn hình đăng nhập
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            SessionManager.JwtToken = string.Empty;
            SessionManager.CurrentRole = string.Empty;

            // Chỉ cần đóng FormMain: FormLogin gốc đang chờ ở mainForm.ShowDialog()
            // sẽ tự hiện lại chính nó (xem FormLogin.cs), không cần tạo instance mới.
            this.Close();
        }
    }
}