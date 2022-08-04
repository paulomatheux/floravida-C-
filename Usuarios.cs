using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace floravida
{
	public partial class Usuarios : Form
	{
		public Usuarios()
		{
			InitializeComponent();
			tabela();
		}

		public void tabela() {
			DataTable table = new DataTable();
			string sql = "SELECT user AS Usuário, tel AS Telefone FROM users";
			table = Conexao.Consulta(sql);
			this.datagrid.DataSource = table;
		}

		private void btnVoltar_Click(object sender, EventArgs e) {
			this.Hide();
			Estoque es = new Estoque();
			es.ShowDialog();
			this.Close();
		}

		private void btnpdf_Click(object sender, EventArgs e) {
			this.Hide();
			CadastrarUser cad = new CadastrarUser();
			cad.ShowDialog();
			this.Close();
		}
	}
}
