using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace floravida
{
	public partial class CadastrarPaciente : Form {
		public CadastrarPaciente(String nome, String idade, String sex, String qtdmembros, String patologia, String area, String sus) {
			InitializeComponent();

			this.txtSexo.AutoSize = false;
			this.txtArea.AutoSize = false;

			//posições

			this.txtNome.SetBounds((this.Size.Width / 2) - this.txtNome.Size.Width / 2, 70, this.txtNome.Width, this.txtNome.Height);
			this.label1.SetBounds(this.txtNome.Left, this.txtNome.Top - 20, this.label1.Width, this.label1.Height);
			this.label2.SetBounds(this.txtNome.Left, this.txtNome.Bottom + 10, this.label2.Width, this.label2.Height);
			this.dateNasc.SetBounds(this.txtNome.Left, this.label2.Bottom + 10, this.dateNasc.Width, this.dateNasc.Height);
			this.label7.SetBounds(this.txtNome.Left, this.dateNasc.Bottom + 10, this.label7.Width, this.label7.Height);
			this.txtSus.SetBounds(this.txtNome.Left, this.label7.Bottom + 10, this.txtSus.Width, txtSus.Height);
			this.label3.SetBounds(this.txtNome.Left, this.txtSus.Bottom + 10, this.label3.Width, this.label3.Height);
			this.txtSexo.SetBounds(this.txtNome.Left, this.label3.Bottom + 10, this.txtSexo.Width, this.txtSexo.Height);
			this.label6.SetBounds(this.txtArea.Left, this.label3.Top, this.label6.Width, this.label6.Height);
			this.txtArea.SetBounds(this.txtSexo.Right + 20, this.txtSexo.Top, this.txtArea.Width, this.txtSexo.Height);
			this.label4.SetBounds(this.txtMoradores.Left, this.label6.Top, this.label4.Width, this.label4.Height);
			this.txtMoradores.SetBounds(this.txtArea.Right + 20, this.txtSexo.Top, this.txtMoradores.Width, this.txtMoradores.Height);
			this.label5.SetBounds(this.txtNome.Left, this.txtSexo.Bottom + 10, this.label5.Width, this.label5.Height);
			this.txtPatologia.SetBounds(this.txtNome.Left, this.label5.Bottom + 10, this.txtPatologia.Width, this.txtPatologia.Height);

			if (nome.Length > 1) {
				Console.WriteLine(sus);
				this.txtNome.Text = nome;
				this.dateNasc.Text = idade.Substring(0, 10);
				this.txtPatologia.Text = patologia;
				this.txtSexo.SelectedIndex = txtSexo.Items.IndexOf(sex);
				this.txtArea.SelectedIndex = txtArea.Items.IndexOf(area);
				this.txtMoradores.Text = qtdmembros;
				this.txtSus.Text = sus;
			}
		}

		private void guna2Button1_Click(object sender, EventArgs e)	{
			string sql;
			DataTable table = new DataTable();
			sql = "SELECT sus FROM paciente WHERE sus ='" + txtSus.Text + "'";
			table = Conexao.Consulta(sql);
			if (table.Rows.Count > 0) {
				Console.WriteLine("Já existe um paciente cadastrado com esse código!");
			} else { 
				sql = "INSERT INTO paciente(nome, idade, sexo, qtdmembros, patologia, area, sus) VALUES " +
					"('" + txtNome.Text + "', '" + dateNasc.Text + "', '" + txtSexo.Text + "', '" + txtMoradores.ToString()
					+ "', '" + txtPatologia.Text + "', '" + txtArea.Text + "', '" + txtSus.Text + "')";
				Conexao.Cadastra(sql);
				}
			}

		private void btnCancelar_Click(object sender, EventArgs e) {
			this.Hide();
			Pacientes es = new Pacientes();
			es.ShowDialog();
			this.Close();
		}
	}
}
