using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CustomControls.RJControls;
namespace floravida
{
    public partial class Historico : Form
    {
        DataTable table = new DataTable();
        CustomMaskedTextBox masked = new CustomMaskedTextBox();
        Guna2DateTimePicker data1, data2;
        Guna2CircleButton check1, check2, check3;
        String cpf;
        Color red = new Color();
        Color green = new Color();
        DataView dv;

        public Historico() {
            InitializeComponent();
            tabela();
            this.masked.PromptChar = true;
            masked.Enabled = false;
        }

        public void tabela() {
            string sql = "SELECT paciente AS Paciente, id AS SUS, data AS Data FROM historico ORDER BY data DESC";
            table = Conexao.Consulta(sql);
            datagrid.DataSource = table;
        }

        private void datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            this.datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sus;
            string paciente;
            DateTime date = new DateTime();
            if (e.RowIndex > -1) {
                paciente = table.Rows[e.RowIndex][0].ToString();
                sus = table.Rows[e.RowIndex][1].ToString();
                date = DateTime.Parse(table.Rows[e.RowIndex][2].ToString());
                Console.WriteLine(sus + " - " + date.Date.ToString("dd/MM/yyyy"));
                Detalhes det = new Detalhes(paciente, sus, date.Date.ToString("yyyy-MM-dd"));
                this.Hide();
                det.ShowDialog();
                this.Close();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e) {
            this.Hide();
            Estoque est = new Estoque();
            est.ShowDialog();
            this.Close();
        }

        private void btnpdf_Click(object sender, EventArgs e) {
            CreateMyForm();
        }

        public void CreateMyForm() {
            Form form1 = new Form();

            red = Color.FromArgb(250, 67, 67);
            green = Color.FromArgb(97, 242, 94);

            RJButton button1 = new RJButton();
            RJButton button2 = new RJButton();

            data1 = new Guna2DateTimePicker();
            data2 = new Guna2DateTimePicker();

            check1 = new Guna2CircleButton();
            check2 = new Guna2CircleButton();
            check3 = new Guna2CircleButton();

            masked.SetBounds(10, 10, 140, 40);
            masked.BorderRadius = 10;
            masked.BorderColor = red;
            masked.Mask = "000,0000,0000,0000";
            masked.PtpChar = ' ';
            masked._TextChanged += Masked__TextChanged;

            check1.SetBounds(masked.Right + 10, masked.Top + 5, 20, 20);
            check1.FillColor = red;
            check1.CheckedState.FillColor = green;
            check1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
			check1.CheckedChanged += Check1_CheckedChanged;

            data1.Format = DateTimePickerFormat.Short;
            data2.Format = DateTimePickerFormat.Short;
            data1.Enabled = false;
            data2.Enabled = false;
            data1.FillColor = red;
            data2.FillColor = red;

            data1.BorderRadius = 15;
            data2.BorderRadius = 15;
            data1.SetBounds(masked.Left, masked.Bottom + 10, 140, 40);
            data2.SetBounds(data1.Left, data1.Bottom + 10, 140, 40);

            check2.SetBounds(data1.Right + 10, data1.Top + 10, 20, 20);
            check2.FillColor = red;
            check2.CheckedState.FillColor = green;
            check2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            check2.CheckedChanged += Check2_CheckedChanged;

            check3.SetBounds(data2.Right + 10, data2.Top + 10, 20, 20);
            check3.FillColor = red;
            check3.CheckedState.FillColor = green;
            check3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            check3.CheckedChanged += Check3_CheckedChanged;
            check3.Enabled = false;

            button1.BorderRadius = 15;
            button2.BorderRadius = 15;

            button1.Text = "OK";
            button1.Height = 40;
            button1.Width = 70;
            button1.Location = new Point(data2.Left, data2.Bottom + 10);

            button2.Text = "Cancelar";
            button2.Height = 40;
            button2.Width = 70;
            button2.Location = new Point(button1.Right + 10, button1.Top);

            form1.Width = check1.Right + 30;
            form1.Height = button2.Bottom + 40;

            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;

            form1.Text = "Escolha o período";

            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            form1.AcceptButton = button1;
            form1.CancelButton = button2;
            form1.StartPosition = FormStartPosition.CenterScreen;

            form1.Controls.Add(masked);
            form1.Controls.Add(check1);
            form1.Controls.Add(check2);
            form1.Controls.Add(check3);
            form1.Controls.Add(button1);
            form1.Controls.Add(button2);
            form1.Controls.Add(data1);
            form1.Controls.Add(data2);
            form1.ShowDialog();

            if (form1.DialogResult == DialogResult.OK) {
                String sql = "";
                String tipo;
                DateTime date1, date2;
                date1 = DateTime.Parse(data1.Text);
                date2 = DateTime.Parse(data2.Text);

                    if (data1.Enabled == true && data2.Enabled == true && date1.CompareTo(date2) > 0) {
                        MessageBox.Show("Insira um período válido");
                        return;
                    } else if (masked.Enabled == true && cpf.Length == 18 && data1.Enabled == false && data2.Enabled == false) {
                        sql = "SELECT produto AS Medicamento, qtd AS Quantidade, lote AS Lote, data AS Data FROM detalhes "
                        + "WHERE id ='" + cpf + "' ORDER BY data";
                    tipo = " de Histórico Geral SUS " + cpf + " ";
                    } else if (masked.Enabled == true && cpf.Length == 18 && data1.Enabled == true && data2.Enabled == false) {
                        sql = "SELECT produto AS Medicamento, qtd AS Quantidade, lote AS Lote, data AS Data FROM detalhes "
                        + "WHERE id ='" + cpf + "' AND data ='" + date1.Date.ToString("yyyy-MM-dd") + "' ORDER BY data";
                    tipo = " de Histórico Geral SUS " + cpf + " ";
                } else if (masked.Enabled == true && cpf.Length == 18 && data1.Enabled == true && data2.Enabled == true) {
                        sql = "SELECT produto AS Medicamento, qtd AS Quantidade, lote AS Lote, data AS Data FROM detalhes "
                            + "WHERE id ='" + cpf + "' AND data BETWEEN '" + date1.Date.ToString("yyyy-MM-dd") + "' AND '" + date2.Date.ToString("yyyy-MM-dd") 
                            + "' ORDER BY data";
                    tipo = " de Histórico Geral SUS " + cpf + " ";
                } else if (masked.Enabled == false && data1.Enabled == true && data2.Enabled == true) {
                        sql = "SELECT id AS SUS, produto AS Medicamento, qtd AS Quantidade, lote AS Lote, data AS Data FROM detalhes "
                            + "WHERE data BETWEEN '" + date1.Date.ToString("yyyy-MM-dd") + "' AND '" + date2.Date.ToString("yyyy-MM-dd") 
                            + "' ORDER BY data";
                    tipo = " de Histórico Geral ";
                } else if (masked.Enabled == false && data1.Enabled == true && data2.Enabled == false) {
                        sql = "SELECT id AS SUS, produto AS Medicamento, qtd AS Quantidade, lote AS Lote, data AS Data FROM detalhes "
                            + "WHERE data ='" + date1.Date.ToString("yyyy-MM-dd") + "' ORDER BY data";
                    tipo = " de Histórico Geral ";
                } else if (masked.Enabled == false && data1.Enabled == false && data2.Enabled == false) {
                        sql = "SELECT id AS SUS, produto AS Medicamento, qtd AS Quantidade, lote AS Lote, data AS Data FROM detalhes";
                    tipo = " de Histórico Geral ";
                } else {
                        MessageBox.Show("Verifique o código sus");
                        return;
                }

                    DataTable tabela = Conexao.Consulta(sql);
                    if (tabela.Rows.Count > 0) {
                    Conexao.GeraPdf(tabela, tipo);
                    } else {
                        MessageBox.Show("Nenhum registro encontrado no período especificado", "Tente novamente");
                    }

                masked.Enabled = false;
                masked.ResetText();
            } else {
                form1.Close();
            }
        }

		private void Masked__TextChanged(object sender, EventArgs e) {
            cpf = masked.Text.Replace(" ", "");
            Console.WriteLine(cpf);
		}

		private void Check1_CheckedChanged(object sender, EventArgs e) {
            if (masked.Enabled == false) { 
                masked.Enabled = true;
                masked.BorderColor = green;
            } else {
                masked.Enabled = false;
                masked.BorderColor = red;
            }
		}
        
        private void Check2_CheckedChanged(object sender, EventArgs e) { 
			if (data1.Enabled == false) {
                data1.Enabled = true;
                data1.FillColor = green;
                check3.Enabled = true;
            } else {
                data1.Enabled = false;
                check3.Enabled = false;
                check3.Checked = false;
                data2.Enabled = false;
                data1.FillColor = red;
            }
		}

        private void Check3_CheckedChanged(object sender, EventArgs e) {
            if (data2.Enabled == false && data1.Enabled == true) {
                data2.Enabled = true;
                data2.FillColor = green;
            } else {
                data2.Enabled = false;
                data2.FillColor = red;
            }
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e) {
            if (comboBox.SelectedIndex == 0) {
                table.DefaultView.RowFilter = "CONVERT (Paciente, 'System.String') LIKE '%" + txtpesquisa.Text + "%'";
                table.DefaultView.Sort = "Paciente asc";
                datagrid.DataSource = table;
            } else if (comboBox.SelectedIndex == 1) {
                table.DefaultView.RowFilter = "CONVERT (SUS, 'System.String') LIKE '%" + txtpesquisa.Text + "%'";
                table.DefaultView.Sort = "SUS asc";
                datagrid.DataSource = table;
            } else if (comboBox.SelectedIndex == 2) {
                table.DefaultView.RowFilter = "CONVERT (Data, 'System.String') LIKE '%" + txtpesquisa.Text + "%'";
                table.DefaultView.Sort = "Data asc";
                datagrid.DataSource = table;
            }
        }
	}
}
