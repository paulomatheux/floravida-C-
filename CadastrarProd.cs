using System;
using System.Drawing;
using System.Windows.Forms;

namespace floravida
{
    public partial class CadastrarProd : Form
    {
        bool alter = false;
        string nome;

		public CadastrarProd(String n, String q, String l, String v, Boolean a)
        {
            this.alter = a;
            this.nome = n;

            InitializeComponent();
            if (a == true)
            {
                btncancelar.Text = "Cancelar";
                btnSalvar.Text = "Modificar";
                txtnome.Text = n;
                txtquantidade.Text = q;
                txtlote.Text = l;
                txtvalidade.Text = v;
            }

            /*this.lblnome.Location = new Point(this.Left + 20, this.Top + 20);
            this.txtnome.Location = new Point(this.Left + 20, this.lblnome.Bottom + 4);

            this.lbllote.Location = new Point(this.Left + 20, this.txtnome.Bottom + 8);
            this.txtlote.Location = new Point(this.Left + 20, this.lbllote.Bottom + 4);

            this.lblvalidade.Location = new Point(this.Left + 20, this.txtlote.Bottom + 8);
            this.txtvalidade.Location = new Point(this.Left + 20, this.lblvalidade.Bottom + 4);
            
            this.lblquantidade.Location = new Point(this.Left + 20, this.txtvalidade.Bottom + 8);
            this.txtquantidade.Location = new Point(this.Left + 20, this.lblquantidade.Bottom + 4);*/
           
            this.btnSalvar.Location = new Point((this.Size.Width / 2) - (this.btnSalvar.Size.Width + 5), this.txtquantidade.Bottom + 30);
            this.btncancelar.Location = new Point((this.Size.Width / 2) + 5, this.txtquantidade.Bottom + 30);
        }

        private void guna2Button1_Click(object sender, EventArgs e) { //botão salvar / modificar
            string sql;
            if (txtnome.TextLength == 0 | txtlote.TextLength == 0) {
                MessageBox.Show("Verifique os campos!");
            } else {
                if (alter == true) {
                    sql = "UPDATE produtos SET nome ='" + txtnome.Text + "', qtd ='" + txtquantidade.Text
                        + "', lote ='" + txtlote.Text + "', validade ='" + txtvalidade.Text + 
                        "' WHERE nome ='" + nome + "'";
                }
                else
                {
                    sql = "INSERT INTO produtos(nome, qtd, lote, validade) VALUES ('" + txtnome.Text + "', '" +
                            txtquantidade.Text + "', '" + txtlote.Text + "', '" + txtvalidade.Text + "')";

                    }
                    Conexao.Cadastra(sql);
                    this.Hide();
                    Estoque est = new Estoque();
                    est.ShowDialog();
                    this.Close();
                }
		}
        
        private void btncancelar_Click(object sender, EventArgs e) {
            this.Hide();
            Estoque est = new Estoque();
            est.ShowDialog();
            this.Close();
        }
    }
}
