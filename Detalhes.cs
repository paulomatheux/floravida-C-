using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace floravida
{
	public partial class Detalhes : Form { 
		String sus;
		String data;
		String paciente;
		DataTable table = new DataTable();
        Color red = new Color();
        Color green = new Color();
        Guna2CircleButton check;
        DateTime date;
        Guna2DateTimePicker data2;
		public Detalhes(String paciente, String sus, String data) {
			InitializeComponent();
            this.sus = sus;
			this.data = data;
			this.paciente = paciente;
			pesquisa();
            campos();
			//this.lblnome.SetBounds((this.Size.Width / 2) - this.lblnome.Width / 2, this.lblnome.Top, this.Size.Width, this.Size.Height);
			//this.lblsus.SetBounds((this.Size.Width / 2) - this.lblsus.Width / 2, this.lblnome.Bottom + 2, this.Size.Width, this.Size.Height);
			//this.lbldata.SetBounds(this.lblnome.Right + 5, this.lblnome.Top, this.Size.Width, this.Size.Height);
        }


		public void pesquisa() {
			string sql = "SELECT produto AS Medicamento, lote AS Lote, qtd AS Quantidade FROM detalhes" +
				" WHERE id ='" + sus + "' AND data ='" + data + "'";
			Console.WriteLine(sql);
			table = Conexao.Consulta(sql);
			this.datagrid.DataSource = table;
		}

		public void campos() {
            date = DateTime.Parse(data);
			this.lblnome.Text = paciente;
            this.lbldata.Text = date.Date.ToString("dd/MM/yyyy");
			this.lblsus.Text = sus;
		}

		private void guna2Button1_Click(object sender, EventArgs e)		{
            CreateMyForm();
		}

        public void CreateMyForm()        {
            Form form1 = new Form();

            RJButton button1 = new RJButton();
            RJButton button2 = new RJButton();

            red = Color.FromArgb(250, 67, 67);
            green = Color.FromArgb(97, 242, 94);

            Guna2DateTimePicker data1 = new Guna2DateTimePicker();
            data2 = new Guna2DateTimePicker();
            check = new Guna2CircleButton();

            data1.Format = DateTimePickerFormat.Short;
            data2.Format = DateTimePickerFormat.Short;
            data1.FillColor = green;
            data2.FillColor = green;
            data2.Enabled = false;

            data1.BorderRadius = 15;
            data2.BorderRadius = 15;
            data1.SetBounds(10, 10, 140, 40);
            data2.SetBounds(data1.Left, data1.Bottom + 10, 140, 40);

            check.SetBounds(data2.Right + 10, data2.Top + 10, 20, 20);
            check.FillColor = red;
            check.CheckedState.FillColor = green;
            check.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
			check.CheckedChanged += Check_CheckedChanged;

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

            form1.Width = check.Right + 30;
            form1.Height = button2.Bottom + 40;

            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;

            form1.Text = "Escolha o período";

            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            form1.AcceptButton = button1;
            form1.CancelButton = button2;
            form1.StartPosition = FormStartPosition.CenterScreen;

            form1.Controls.Add(check);
            form1.Controls.Add(button1);
            form1.Controls.Add(button2);
            form1.Controls.Add(data1);
            form1.Controls.Add(data2);
            form1.ShowDialog();

            if (form1.DialogResult == DialogResult.OK) {
                DateTime date1, date2;
                date1 = DateTime.Parse(data1.Text);
                date2 = DateTime.Parse(data2.Text);
                String sql = "";

                if (data2.Enabled == true && date1.CompareTo(date2) > 0) {
                    Console.WriteLine("Insira um período de tempo válido");
                    return;
                } else if (data2.Enabled == false) {
                    sql = "SELECT produto AS Medicamento, qtd AS Quantidade, lote AS Lote, data AS Data FROM detalhes "
                        + "WHERE id ='" + sus + "' AND data  ='" + date1.Date.ToString("yyyy-MM-dd") + "' ORDER BY data DESC";
                    table = Conexao.Consulta(sql);
                    this.lbldata.Text = date1.Date.ToString("dd/MM/yyyy");
                } else {
                    sql = "SELECT produto AS Medicamento, qtd AS Quantidade, lote AS Lote, data AS Data FROM detalhes "
                        + "WHERE id ='" + sus + "' AND data BETWEEN '" + date1.Date.ToString("yyyy-MM-dd") + "' AND '" + date2.Date.ToString("yyyy-MM-dd") 
                        + "' ORDER BY data DESC";
                    table = Conexao.Consulta(sql);
                    this.lbldata.Text = date1.Date.ToString("dd/MM/yyyy") + " - " + date2.Date.ToString("dd/MM/yyyy");
                }
                if (table.Rows.Count > 0) {
                    datagrid.DataSource = table;
                    datagrid.Refresh();
                } else {
                    MessageBox.Show("Nenhum registro encontrado no período especificado", "Tente novamente");
                }
            } else {
                form1.Close();
            }
        }

		private void Check_CheckedChanged(object sender, EventArgs e) {
            if (data2.Enabled == false) {
                data2.Enabled = true;
                data2.FillColor = green;
            } else {
                data2.Enabled = false;
            }
		}

		private void btnvoltar_Click(object sender, EventArgs e) {
            this.Hide();
            Historico est = new Historico();
            est.ShowDialog();
            this.Close();
        }

		private void btnpdf_Click(object sender, EventArgs e) {
            Conexao.GeraPdf(table, sus + " do Paciente " + paciente + " ");
        }
	}
}
