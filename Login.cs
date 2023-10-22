using Final.Model.LoginModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final {
    public partial class Login : Form {
        public static UserModel model = new UserModel();

        public Login() {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e) {
            LoginContext context = new LoginContext();
            var username = string.IsNullOrEmpty(TbUsername.Text) ? null : TbUsername.Text;
            var password = string.IsNullOrEmpty(TbPassword.Text) ? null : TbPassword.Text;
            if (username == null || password == null) {
                MessageBox.Show("Nhập đầy đủ thông tin");
                return;
            } else {
                var user = context.Logins.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user == null) {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    return;
                } else {
                    model.Username = username;
                    model.Password = password;
                    switch (user.Username) {
                        case "admin":
                            model.Role = UserRole.ADMIN;
                            break;
                        case "employee":
                            model.Role = UserRole.EMPLOYEE;
                            break;
                    }
                    Main main = new Main();
                    main.Show();
                    Hide();
                    TbPassword.Text = string.Empty;
                    TbUsername.Text = string.Empty;
                    main.FormClosed += Main_FormClosed;
                }
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e) {
            Show();
        }
    }
}
