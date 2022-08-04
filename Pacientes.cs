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
	public partial class Pacientes : Form
	{
		public Pacientes()	{
			InitializeComponent();
			tabela();
		}

		public void tabela() {
			DataTable table = new DataTable();
			string sql = "SELECT * FROM paciente";
			table = Conexao.Consulta(sql);
			for (int a = 0; a < table.Rows.Count; a++) {
				DateTime data = DateTime.Parse(table.Rows[a][1].ToString());
				int idade = DateTime.Now.Year - data.Year;
				if (DateTime.Now.DayOfYear < data.DayOfYear) {
					idade = idade - 1;
				}
				table.Rows[a]["Idade"] = data.ToShortDateString() + " " + idade + " Anos";
			}
			this.datagrid.DataSource = table;
		}

		private void voltar_Click(object sender, EventArgs e) {
			this.Hide();
			Estoque es = new Estoque();
			es.ShowDialog();
			this.Close();
		}

		private void datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			this.datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			if(e.RowIndex > -1) {
				var n = this.datagrid[0, e.RowIndex].Value.ToString();
				var i = this.datagrid[1, e.RowIndex].Value.ToString();
				var s = this.datagrid[2, e.RowIndex].Value.ToString();
				var q = this.datagrid[3, e.RowIndex].Value.ToString();
				var p = this.datagrid[4, e.RowIndex].Value.ToString();
				var a = this.datagrid[5, e.RowIndex].Value.ToString();
				var sus = this.datagrid[6, e.RowIndex].Value.ToString();
				this.Hide();
				CadastrarPaciente pac = new CadastrarPaciente(n, i, s, q, p, a, sus);
				pac.ShowDialog();
				this.Close();
			}
		}

		private void btnCadastrar_Click(object sender, EventArgs e) {
			this.Hide();
			CadastrarPaciente cad = new CadastrarPaciente("", "", "", "", "", "", "");
			cad.ShowDialog();
			this.Close();
		}
	}
}
