using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace floravida
{
	public partial class Microareas : Form
	{
		public Microareas()	{
			InitializeComponent();
			tabela();
		}

		public void tabela() {
			DataTable table = new DataTable();
			string sql = "SELECT agente AS Agente, nome AS Área FROM microarea";
			table = Conexao.Consulta(sql);
			this.datagrid.DataSource = table;
		}

		private void guna2Button2_Click(object sender, EventArgs e)	{
			this.Hide();
			Estoque es = new Estoque();
			es.ShowDialog();
			this.Close();
		}

		private void guna2Button3_Click(object sender, EventArgs e) {
			this.Hide();
			Estoque es = new Estoque();
			es.ShowDialog();
			this.Close();
		}

		private void guna2Button1_Click(object sender, EventArgs e)	{

		}
	}
}
