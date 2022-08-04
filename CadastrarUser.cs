using System;
using System.Data;
using System.Windows.Forms;

namespace floravida
{
	public partial class CadastrarUser : Form
	{
		public CadastrarUser()
		{
			InitializeComponent();
		}

		private void guna2Button1_Click(object sender, EventArgs e) {
			string cpf = "";
			string tel = "";

			for (int a = 0; a < maskedCPF.Text.Length; a++) {
				if (!maskedCPF.Text.Substring(a, 1).Equals(" "))
				{
					cpf += maskedCPF.Text.Substring(a, 1);
				}
			}

			for (int b = 0; b < maskedTel.Text.Length; b++)
			{
				if (!maskedTel.Text.Substring(b, 1).Equals(" "))
				{
					tel += maskedTel.Text.Substring(b, 1);
				}
			}

			DateTime dataNasc;
			dataNasc = DateTime.Parse(dateNasc.Text);

			if (txtNome.Text.Length == 0)
			{
				Console.WriteLine("Insira seu nome completo");
			}
			else if (txtUser.Text.Length < 5)
			{
				Console.WriteLine("Insira um nome de usuário com pelo menos 5 caracteres");
			}
			else if (txtPass.Text.Length < 5)
			{
				Console.WriteLine("Insira uma senha com pelo menos 5 caracteres");
			}
			else if (tel.Length != 14)
			{
				Console.WriteLine("Corrija seu Tel");
			}
			else if ((DateTime.Now.Year - dataNasc.Year) < 15)
			{
				Console.WriteLine("Verifique sua data de nascimento");
			}
			else if (cpf.Length != 14)
			{
				Console.WriteLine("Corrija seu CPF");
			}
			else if (txtEmail.Text.Length == 0)
			{
				Console.WriteLine("Corrija seu E-mail");
			}
			else if (!txtEmail.Text.Contains("@"))
			{
				Console.WriteLine("Insira um formato de E-mail correto");
			}
			else if (txtEmailConf.Text.Length == 0 | txtEmailConf.Text.ToString().CompareTo(txtEmail.Text.ToString()) != 0)
			{
				Console.WriteLine("Confirme o seu E-mail");
			}
			else if (txtAsc.Text.Length == 0)
			{
				Console.WriteLine("Confirme seu ASC");
			}
			else
			{
				Console.WriteLine("Good to go");
				DataTable table = new DataTable();
				string sql;
				sql = "SELECT user FROM users WHERE user ='" + txtUser.Text + "'";
				table = Conexao.Consulta(sql);
				if (table.Rows.Count > 0)
				{
					Console.WriteLine("Este nome de usuário já foi escolhido");
				}
				else
				{
					sql = "INSERT INTO users(nome, user, pass, tel, nascimento, cpf, email, asc) VALUES ('" +
						txtNome.Text + "', '" + txtUser.Text + "', '" + txtPass.Text + "', '" + maskedTel.Text + "', '" + dateNasc.Text
						+ "', '" + maskedCPF.Text + "', '" + txtEmail.Text + "', '" + txtAsc.Text + "')";
					Conexao.Cadastra(sql);
				}
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e) {
			if (txtNome.Text.Length == 0) { 
				this.Hide();
				Estoque est = new Estoque();
				est.ShowDialog();
				this.Close();
			}
		}
	}
}