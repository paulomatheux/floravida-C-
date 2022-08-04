using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace floravida
{
    public partial class Login : Form
    {

        DataTable table = new DataTable();
        public Login() {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e) {
            Conexao con = new Conexao();
            this.painel2.Location = new Point((this.Size.Width / 2) - (this.painel2.Size.Width / 2),
                (this.Size.Height / 2 ) - (this.painel2.Size.Height / 2) - 30);

            this.labeluser.Location = new Point((this.Size.Width / 2) - (this.labeluser.Size.Width / 2), painel2.Top + 40);
            this.logintext.Location = new Point((this.Size.Width / 2) - (this.logintext.Size.Width / 2), labeluser.Bottom + 3);

            this.labelpass.Location = new Point((this.Size.Width / 2) - (this.labelpass.Size.Width / 2), logintext.Bottom + 8);
            this.passtext.Location = new Point((this.Size.Width / 2) - (this.passtext.Size.Width / 2), labelpass.Bottom + 3);

            this.btnlogin.Location = new Point((this.painel2.Width / 2) - (this.btnlogin.Size.Width / 2), passtext.Bottom - 40);
        }

        private void Btnlogin_Click(object sender, EventArgs e) {
            string login = logintext.Text;
            string pass = passtext.Text;

            if (login.Length == 0) {
                MessageBox.Show("Insira seu nome de usuário.");
                logintext.Focus();
                return;
            } else if (pass.Length == 0) {
                MessageBox.Show("Insira sua senha.");
                passtext.Focus();
                return;
            } else { 
            string sql = "SELECT user, pass FROM users WHERE user ='" + login + "' AND pass ='" + pass + "'";
            table = Conexao.Consulta(sql);
                if (table.Rows.Count == 1) {
                    this.Hide();
                    Estoque est = new Estoque();
                    est.ShowDialog();
                    this.Close();
                } else {
                    MessageBox.Show("Usuário e/ou senha incorreto(s)", "Tente novamente");
                }
            }
        }
    }
}
