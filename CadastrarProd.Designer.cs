
namespace floravida
{
    partial class CadastrarProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
			this.btncancelar = new Guna.UI2.WinForms.Guna2Button();
			this.txtvalidade = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.txtquantidade = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.txtnome = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtlote = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbllote = new System.Windows.Forms.Label();
			this.lblquantidade = new System.Windows.Forms.Label();
			this.lblvalidade = new System.Windows.Forms.Label();
			this.lblnome = new System.Windows.Forms.Label();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			((System.ComponentModel.ISupportInitialize)(this.txtquantidade)).BeginInit();
			this.guna2Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSalvar
			// 
			this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSalvar.BorderRadius = 10;
			this.btnSalvar.CheckedState.Parent = this.btnSalvar;
			this.btnSalvar.CustomImages.Parent = this.btnSalvar;
			this.btnSalvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSalvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSalvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSalvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSalvar.DisabledState.Parent = this.btnSalvar;
			this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
			this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnSalvar.ForeColor = System.Drawing.Color.White;
			this.btnSalvar.HoverState.Parent = this.btnSalvar;
			this.btnSalvar.Location = new System.Drawing.Point(192, 378);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.ShadowDecoration.Parent = this.btnSalvar;
			this.btnSalvar.Size = new System.Drawing.Size(140, 40);
			this.btnSalvar.TabIndex = 0;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// btncancelar
			// 
			this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btncancelar.BorderRadius = 10;
			this.btncancelar.CheckedState.Parent = this.btncancelar;
			this.btncancelar.CustomImages.Parent = this.btncancelar;
			this.btncancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btncancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btncancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btncancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btncancelar.DisabledState.Parent = this.btncancelar;
			this.btncancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
			this.btncancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btncancelar.ForeColor = System.Drawing.Color.White;
			this.btncancelar.HoverState.Parent = this.btncancelar;
			this.btncancelar.Location = new System.Drawing.Point(355, 378);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.ShadowDecoration.Parent = this.btncancelar;
			this.btncancelar.Size = new System.Drawing.Size(140, 40);
			this.btncancelar.TabIndex = 1;
			this.btncancelar.Text = "Voltar";
			this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
			// 
			// txtvalidade
			// 
			this.txtvalidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtvalidade.Animated = true;
			this.txtvalidade.BorderRadius = 10;
			this.txtvalidade.CheckedState.Parent = this.txtvalidade;
			this.txtvalidade.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
			this.txtvalidade.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtvalidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtvalidade.HoverState.Parent = this.txtvalidade;
			this.txtvalidade.Location = new System.Drawing.Point(102, 218);
			this.txtvalidade.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.txtvalidade.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.txtvalidade.Name = "txtvalidade";
			this.txtvalidade.ShadowDecoration.Parent = this.txtvalidade;
			this.txtvalidade.Size = new System.Drawing.Size(160, 36);
			this.txtvalidade.TabIndex = 2;
			this.txtvalidade.Value = new System.DateTime(2021, 8, 6, 1, 17, 24, 710);
			// 
			// txtquantidade
			// 
			this.txtquantidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtquantidade.BackColor = System.Drawing.Color.Transparent;
			this.txtquantidade.BorderColor = System.Drawing.Color.ForestGreen;
			this.txtquantidade.BorderRadius = 10;
			this.txtquantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtquantidade.DisabledState.Parent = this.txtquantidade;
			this.txtquantidade.FocusedState.Parent = this.txtquantidade;
			this.txtquantidade.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtquantidade.ForeColor = System.Drawing.Color.Black;
			this.txtquantidade.Location = new System.Drawing.Point(102, 293);
			this.txtquantidade.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.txtquantidade.Name = "txtquantidade";
			this.txtquantidade.ShadowDecoration.Parent = this.txtquantidade;
			this.txtquantidade.Size = new System.Drawing.Size(160, 36);
			this.txtquantidade.TabIndex = 3;
			this.txtquantidade.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
			this.txtquantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtnome
			// 
			this.txtnome.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtnome.Animated = true;
			this.txtnome.BorderColor = System.Drawing.Color.ForestGreen;
			this.txtnome.BorderRadius = 10;
			this.txtnome.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtnome.DefaultText = "";
			this.txtnome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtnome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtnome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtnome.DisabledState.Parent = this.txtnome;
			this.txtnome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtnome.FillColor = System.Drawing.Color.WhiteSmoke;
			this.txtnome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtnome.FocusedState.Parent = this.txtnome;
			this.txtnome.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtnome.ForeColor = System.Drawing.Color.Black;
			this.txtnome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtnome.HoverState.Parent = this.txtnome;
			this.txtnome.Location = new System.Drawing.Point(102, 72);
			this.txtnome.Name = "txtnome";
			this.txtnome.PasswordChar = '\0';
			this.txtnome.PlaceholderText = "Medicamento";
			this.txtnome.SelectedText = "";
			this.txtnome.ShadowDecoration.Parent = this.txtnome;
			this.txtnome.Size = new System.Drawing.Size(455, 36);
			this.txtnome.TabIndex = 4;
			// 
			// txtlote
			// 
			this.txtlote.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtlote.BorderColor = System.Drawing.Color.ForestGreen;
			this.txtlote.BorderRadius = 10;
			this.txtlote.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtlote.DefaultText = "";
			this.txtlote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtlote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtlote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtlote.DisabledState.Parent = this.txtlote;
			this.txtlote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtlote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtlote.FocusedState.Parent = this.txtlote;
			this.txtlote.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtlote.ForeColor = System.Drawing.Color.Black;
			this.txtlote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtlote.HoverState.Parent = this.txtlote;
			this.txtlote.Location = new System.Drawing.Point(102, 145);
			this.txtlote.Name = "txtlote";
			this.txtlote.PasswordChar = '\0';
			this.txtlote.PlaceholderText = "Lote";
			this.txtlote.SelectedText = "";
			this.txtlote.ShadowDecoration.Parent = this.txtlote;
			this.txtlote.Size = new System.Drawing.Size(163, 36);
			this.txtlote.TabIndex = 5;
			// 
			// lbllote
			// 
			this.lbllote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbllote.BackColor = System.Drawing.Color.Transparent;
			this.lbllote.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
			this.lbllote.ForeColor = System.Drawing.Color.White;
			this.lbllote.Location = new System.Drawing.Point(94, 114);
			this.lbllote.Margin = new System.Windows.Forms.Padding(0);
			this.lbllote.Name = "lbllote";
			this.lbllote.Size = new System.Drawing.Size(73, 25);
			this.lbllote.TabIndex = 7;
			this.lbllote.Text = "Lote";
			this.lbllote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblquantidade
			// 
			this.lblquantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblquantidade.BackColor = System.Drawing.Color.Transparent;
			this.lblquantidade.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
			this.lblquantidade.ForeColor = System.Drawing.Color.White;
			this.lblquantidade.Location = new System.Drawing.Point(94, 261);
			this.lblquantidade.Margin = new System.Windows.Forms.Padding(0);
			this.lblquantidade.Name = "lblquantidade";
			this.lblquantidade.Size = new System.Drawing.Size(148, 25);
			this.lblquantidade.TabIndex = 8;
			this.lblquantidade.Text = "Quantidade";
			this.lblquantidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblvalidade
			// 
			this.lblvalidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblvalidade.BackColor = System.Drawing.Color.Transparent;
			this.lblvalidade.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
			this.lblvalidade.ForeColor = System.Drawing.Color.White;
			this.lblvalidade.Location = new System.Drawing.Point(94, 187);
			this.lblvalidade.Margin = new System.Windows.Forms.Padding(0);
			this.lblvalidade.Name = "lblvalidade";
			this.lblvalidade.Size = new System.Drawing.Size(117, 25);
			this.lblvalidade.TabIndex = 9;
			this.lblvalidade.Text = "Validade";
			this.lblvalidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblnome
			// 
			this.lblnome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblnome.BackColor = System.Drawing.Color.Transparent;
			this.lblnome.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblnome.ForeColor = System.Drawing.Color.White;
			this.lblnome.Location = new System.Drawing.Point(94, 41);
			this.lblnome.Margin = new System.Windows.Forms.Padding(0);
			this.lblnome.Name = "lblnome";
			this.lblnome.Size = new System.Drawing.Size(170, 25);
			this.lblnome.TabIndex = 6;
			this.lblnome.Text = "Medicamento";
			this.lblnome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
			this.guna2Panel1.BorderColor = System.Drawing.Color.ForestGreen;
			this.guna2Panel1.BorderThickness = 1;
			this.guna2Panel1.Controls.Add(this.txtnome);
			this.guna2Panel1.Controls.Add(this.lblnome);
			this.guna2Panel1.Controls.Add(this.txtvalidade);
			this.guna2Panel1.Controls.Add(this.btncancelar);
			this.guna2Panel1.Controls.Add(this.txtlote);
			this.guna2Panel1.Controls.Add(this.lbllote);
			this.guna2Panel1.Controls.Add(this.btnSalvar);
			this.guna2Panel1.Controls.Add(this.txtquantidade);
			this.guna2Panel1.Controls.Add(this.lblvalidade);
			this.guna2Panel1.Controls.Add(this.lblquantidade);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new System.Drawing.Size(692, 433);
			this.guna2Panel1.TabIndex = 10;
			// 
			// CadastrarProd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(692, 433);
			this.Controls.Add(this.guna2Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximumSize = new System.Drawing.Size(730, 500);
			this.MinimumSize = new System.Drawing.Size(710, 480);
			this.Name = "CadastrarProd";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CadastrarProd";
			((System.ComponentModel.ISupportInitialize)(this.txtquantidade)).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2Button btncancelar;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtvalidade;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtquantidade;
        private Guna.UI2.WinForms.Guna2TextBox txtnome;
        private Guna.UI2.WinForms.Guna2TextBox txtlote;
        private System.Windows.Forms.Label lbllote;
        private System.Windows.Forms.Label lblquantidade;
        private System.Windows.Forms.Label lblvalidade;
        private System.Windows.Forms.Label lblnome;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}