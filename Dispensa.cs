using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace floravida
{
	public partial class Dispensa : Form {
		public DataTable table = new DataTable();
		public DataTable table2 = new DataTable();
        public DataTable tabelaux = new DataTable();

		public DataRow row;
        public DataRow[] r;
        public DataGridViewRow grow;
        public DataColumn column;
        public String paciente;
        DataView dv;
        public Dispensa() {
            InitializeComponent();
			showData();
			tabletwo();
            tabelauxiliar();
            this.datapicker.Enabled = false;
            this.btnconcluir.Enabled = false;
            this.btndesfazer.Enabled = false;
            this.txtresponsavel.Enabled = false;
            this.datatable1.Enabled = false;
            this.datatable2.Enabled = false;
            this.txtpesquisa.Enabled = false;
            this.comboBox.Enabled = false;
            dv = table.DefaultView;
        }

		public void showData() {
			string sql = "SELECT nome AS Medicamento, qtd AS Quantidade, lote AS Lote, validade AS Validade FROM produtos " +
                "ORDER BY nome";
			table = Conexao.Consulta(sql);
			datatable1.DataSource = table;
		}

		public void tabletwo() {
			column = new DataColumn();
			column.ColumnName = "Medicamento";
			table2.Columns.Add(column);

			column = new DataColumn();
			column.ColumnName = "Quantidade";
			table2.Columns.Add(column);
        }

        public void tabelauxiliar() {
            column = new DataColumn();
            column.ColumnName = "Index DT1";
            tabelaux.Columns.Add(column);
            
            column = new DataColumn();
            column.ColumnName = "Index DT2";
            tabelaux.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "Medicamento";
            tabelaux.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "Quantidade DT1";
            tabelaux.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "Quantidade DT2";
            tabelaux.Columns.Add(column);
		}

        private void datatable1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			this.datatable1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			if (e.RowIndex > -1){
				var n = this.datatable1[0, e.RowIndex].Value.ToString();
                int q = Int32.Parse(this.datatable1[1, e.RowIndex].Value.ToString());

                CreateMyForm(n, q, e.RowIndex);
            }
        }


        public void CreateMyForm(string n, int q, int index) {
            Form form1 = new Form();
            form1.Width = 250;
            form1.Height = 180;

            RJButton button1 = new RJButton();
            RJButton button2 = new RJButton();

            button1.BorderRadius = 15;
            button2.BorderRadius = 15;

            Guna2NumericUpDown qtd = new Guna2NumericUpDown();
            qtd.Value = 1;
            qtd.Maximum = 10000;
            qtd.Minimum = 0;
            qtd.Increment = 1;
            qtd.Location = new Point(25, 30);
            qtd.Height = 30;
			qtd.Width = 150;
            qtd.BorderRadius = 15;

			button1.Text = "OK";
            button1.Height = 40;
            button1.Width = 70;
            button1.Location = new Point(qtd.Left, qtd.Bottom + 10);

            button2.Text = "Cancelar";
            button2.Height = 40;
            button2.Width = 70;
            button2.Location = new Point(button1.Right + 10, button1.Top);

            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;


            form1.Text = "Quantidade";

            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            form1.AcceptButton = button1;
            form1.CancelButton = button2;
            form1.StartPosition = FormStartPosition.CenterScreen;

            form1.Controls.Add(button1);
            form1.Controls.Add(button2);
            form1.Controls.Add(qtd);
            form1.ShowDialog();

            if (form1.DialogResult == DialogResult.OK) {
                var value = q - qtd.Value;
                if (value < 0 || qtd.Value == 0 || qtd.Value < 0) {
                    MessageBox.Show("Insira um valor válido", "Verifique o Estoque");
                } else {
                    r = table2.Select("Medicamento = '" + n + "'");

                    if (r.Length > 0) {
                        int rindex = table2.Rows.IndexOf(r[0]);
                        int valor = Int32.Parse(table2.Rows[rindex][1].ToString());
                        row = tabelaux.NewRow();
                        row["Index DT1"] = index;
                        row["Index DT2"] = rindex;
                        row["Medicamento"] = n;
                        row["Quantidade DT1"] = q;
                        row["Quantidade DT2"] = valor;
                        tabelaux.Rows.Add(row);

                        table.Rows[index].SetField("Quantidade", value);
                        table2.Rows[rindex].SetField("Quantidade", valor + qtd.Value);
                    }  else  {
                        Console.WriteLine(tabelaux.Rows.Count);
                        row = tabelaux.NewRow();
                        row["Index DT1"] = index;
                        row["Index DT2"] = table2.Rows.Count;
                        row["Medicamento"] = n.ToString();
                        row["Quantidade DT1"] = q;
                        row["Quantidade DT2"] = 0;
                        tabelaux.Rows.Add(row);

                        table.Rows[index].SetField("Quantidade", value);
                        row = table2.NewRow();
                        row["Medicamento"] = n.ToString();
                        row["Quantidade"] = qtd.Value;
                        table2.Rows.Add(row);
                        datatable2.DataSource = table2;
                    }
                }
                this.btnvoltar.Text = "Cancelar";
                form1.Close();
            } else {
                form1.Close();
            }
        }

		private void guna2Button3_Click(object sender, EventArgs e) {
            int tamanho = tabelaux.Rows.Count;
            if (tamanho > 0) {
                int lin = tamanho - 1; //ultimo index
                int col = tabelaux.Columns.Count - 1; //5 colunas
                int index;
                int quantidade;

                index = Int32.Parse(tabelaux.Rows[lin][col - 4].ToString());     // INDEX DT1
                quantidade = Int32.Parse(tabelaux.Rows[lin][col - 1].ToString());// QUANTIDADE DT1
                table.Rows[index].SetField("Quantidade", quantidade);

                index = Int32.Parse(tabelaux.Rows[lin][col - 3].ToString());     // INDEX DT2
                quantidade = Int32.Parse(tabelaux.Rows[lin][col].ToString());    // QUANTIDADE DT2
                
                if (quantidade == 0) {
                    table2.Rows[index].Delete();
                    tabelaux.Rows[lin].Delete();
                } else {
                    table2.Rows[index].SetField("Quantidade", quantidade);
                    tabelaux.Rows[lin].Delete();
                }
            } else {
                Console.WriteLine("Sem items na tabela!");
                this.btndesfazer.Text = "Voltar";
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e) {
            if (table2.Rows.Count == 0) {
                MessageBox.Show("Nenhum medicamento foi selecionado");
                return;
            } else if (txtresponsavel.TextLength == 0) {
                MessageBox.Show("Informe quem está autorizando a dispenss.");
                return;
			} else {
                string sql = "INSERT INTO historico(id, data, agente, paciente, receitado) VALUES ('"
                    + maskedText.Text + "', '" + datapicker.Text + "', '" + "Admin" + "', '"
                    + paciente + "', '" + txtresponsavel.Text + "')";
                Conexao.Cadastra(sql);

                for (int c = 0; c < table2.Rows.Count; c++) {
                    string medicamento = table2.Rows[c][0].ToString();
                    int qtd = Int32.Parse(table2.Rows[c][1].ToString());
                    string sus = maskedText.Text;
                    string lote = "error";
                    r = table.Select("Medicamento = '" + medicamento + "'");
                    if (r.Length > 0) {
                        int index = table.Rows.IndexOf(r[0]);
                        int quantidade = Int32.Parse(table.Rows[index][1].ToString());
                        lote = table.Rows[index][2].ToString();

                        sql = "UPDATE produtos SET qtd =" + quantidade + " WHERE nome ='" + medicamento + "'";
                        Conexao.Cadastra(sql);
                    }

                    sql = "INSERT INTO detalhes(id, produto, lote, qtd, data, cdg) VALUES ('"
                        + sus + "', '" + medicamento + "', '" + lote + "', '" + qtd + "', '" + datapicker.Text
                        + "', '" + "codigo" + "')";
                    Conexao.Cadastra(sql);
                }
			}
		}

		private void guna2Button1_Click(object sender, EventArgs e) {
                string sql = "SELECT * FROM paciente WHERE sus ='" + maskedText.Text + "'";
                DataTable table = new DataTable();
                table = Conexao.Consulta(sql);
                if (table.Rows.Count > 0) {
                    MessageBox.Show(table.Rows[0][0].ToString());
                paciente = table.Rows[0][0].ToString();
                this.datapicker.Enabled = true;
                this.btnconcluir.Enabled = true;
                this.btndesfazer.Enabled = true;
                this.txtresponsavel.Enabled = true;
                this.datatable1.Enabled = true;
                this.datatable2.Enabled = true;
                this.txtpesquisa.Enabled = true;
                this.comboBox.Enabled = true;
                this.btnreceita.Enabled = false;
                this.maskedText.Enabled = false;
            } else {
                MessageBox.Show("Verifique o código SUS");
                }
            }

		private void btnvoltar_Click(object sender, EventArgs e) {
            this.Hide();
            Estoque est = new Estoque();
            est.ShowDialog();
            this.Close();
		}

        private void txtpesquisa_TextChanged(object sender, EventArgs e) {
            if (comboBox.SelectedIndex == 0) {
                dv = table.DefaultView;
                dv.RowFilter = "" + comboBox.Text + " LIKE '%" + txtpesquisa.Text + "%'";
                datatable1.DataSource = dv;
            } else if (comboBox.SelectedIndex == 1) {
                table.DefaultView.RowFilter = "CONVERT (Quantidade, 'System.String') LIKE '%" + txtpesquisa.Text + "%'";
                table.DefaultView.Sort = "Quantidade asc";
                datatable1.DataSource = table;
            } else if (comboBox.SelectedIndex == 2) {
                table.DefaultView.RowFilter = "CONVERT (Lote, 'System.String') LIKE '%" + txtpesquisa.Text + "%'";
                table.DefaultView.Sort = "Lote asc";
                datatable1.DataSource = table;
            } else if (comboBox.SelectedIndex == 3) {
                table.DefaultView.RowFilter = "CONVERT (Validade, 'System.String') LIKE '%" + txtpesquisa.Text + "%'";
                table.DefaultView.Sort = "Validade asc";
                datatable1.DataSource = table;
            } 
        }
	}
}
