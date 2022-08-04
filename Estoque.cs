using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace floravida
{
    public partial class Estoque : Form {

        DataTable table = new DataTable();

        public Estoque() {
            InitializeComponent();
            showData();
            this.btncadastro.Location = new Point(this.Left + 15, this.datagrid.Top);
            this.btndispensa.Location = new Point(this.Left + 15, this.btncadastro.Bottom + 5);
            this.btnpdf.Location = new Point(this.Left + 15, this.btndispensa.Bottom + 5);
            this.datagrid.SetBounds(this.btncadastro.Right + 10, this.btncadastro.Top, this.datagrid.Width, this.datagrid.Height);
        }

		public void showData() {
            int perc = 0;
            string sql = "SELECT nome AS Medicamento, qtd AS Quantidade, lote AS Lote, validade AS Validade FROM produtos" +
                " ORDER BY nome ASC";
            table = Conexao.Consulta(sql); ;
            datagrid.DataSource = table;
            DataGridViewColumn colmed = datagrid.Columns[0];
            DataGridViewColumn colqtd = datagrid.Columns[1];
            DataGridViewColumn collote = datagrid.Columns[2];
            DataGridViewColumn colvali = datagrid.Columns[3];
            perc = datagrid.Size.Width;
            colmed.Width = 150;
            colqtd.Width = 50;
            collote.Width = 50;
            colvali.Width = 100;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarProd cadpd = new CadastrarProd("", "", "", "", false);
            cadpd.ShowDialog();
            this.Close();
        }

        private void btnaltera_Click(object sender, EventArgs e)
        {
            int linha = datagrid.SelectedRows.Count;
            string content = datagrid.CurrentRow.Cells[linha].ToString();
            Console.WriteLine(content);

        }

        private void datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            this.datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (e.RowIndex > -1)
            {
                var n = this.datagrid[0, e.RowIndex].Value.ToString();
                var q = this.datagrid[1, e.RowIndex].Value.ToString();
                var l = this.datagrid[2, e.RowIndex].Value.ToString();
                var v = this.datagrid[3, e.RowIndex].Value.ToString();
                this.Hide();
                CadastrarProd cad = new CadastrarProd(n, q, l, v, true);
                cad.ShowDialog();
                this.Close();
            }
        }

        private void btndispensa_Click(object sender, EventArgs e) {
            this.Hide();
            Dispensa dis = new Dispensa();
            dis.ShowDialog();
            this.Close();
        }

		private void históricoToolStripMenuItem_Click(object sender, EventArgs e) {
            Historico his = new Historico();
            this.Hide();
            his.ShowDialog();
            this.Close();
		}

		private void áreasToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            Microareas mic = new Microareas();
            mic.ShowDialog();
            this.Close();
		}

		private void btnpdf_Click(object sender, EventArgs e) {
            Conexao.GeraPdf(table, " de Estoque ");
        }

		private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e) {
            this.Hide();
            Usuarios es = new Usuarios();
            es.ShowDialog();
            this.Close();
        }

		private void pacientesToolStripMenuItem_Click(object sender, EventArgs e) {
            Pacientes his = new Pacientes();
            this.Hide();
            his.ShowDialog();
            this.Close();
        }
	}
}
