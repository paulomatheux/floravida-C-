
namespace floravida
{
	partial class CadastrarPaciente
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
			this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtMoradores = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.txtSexo = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txtArea = new Guna.UI2.WinForms.Guna2ComboBox();
			this.dateNasc = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.txtPatologia = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
			this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
			this.txtSus = new CustomControls.RJControls.CustomMaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.txtMoradores)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNome
			// 
			this.txtNome.BorderColor = System.Drawing.Color.DarkSeaGreen;
			this.txtNome.BorderRadius = 10;
			this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNome.DefaultText = "";
			this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNome.DisabledState.Parent = this.txtNome;
			this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtNome.FocusedState.Parent = this.txtNome;
			this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtNome.ForeColor = System.Drawing.Color.Black;
			this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtNome.HoverState.Parent = this.txtNome;
			this.txtNome.Location = new System.Drawing.Point(71, 93);
			this.txtNome.Name = "txtNome";
			this.txtNome.PasswordChar = '\0';
			this.txtNome.PlaceholderText = "";
			this.txtNome.SelectedText = "";
			this.txtNome.ShadowDecoration.Parent = this.txtNome;
			this.txtNome.Size = new System.Drawing.Size(667, 36);
			this.txtNome.TabIndex = 0;
			// 
			// txtMoradores
			// 
			this.txtMoradores.BackColor = System.Drawing.Color.Transparent;
			this.txtMoradores.BorderColor = System.Drawing.Color.DarkSeaGreen;
			this.txtMoradores.BorderRadius = 10;
			this.txtMoradores.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMoradores.DisabledState.Parent = this.txtMoradores;
			this.txtMoradores.FocusedState.Parent = this.txtMoradores;
			this.txtMoradores.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtMoradores.ForeColor = System.Drawing.Color.Black;
			this.txtMoradores.Location = new System.Drawing.Point(525, 297);
			this.txtMoradores.Name = "txtMoradores";
			this.txtMoradores.ShadowDecoration.Parent = this.txtMoradores;
			this.txtMoradores.Size = new System.Drawing.Size(100, 45);
			this.txtMoradores.TabIndex = 1;
			// 
			// txtSexo
			// 
			this.txtSexo.BackColor = System.Drawing.Color.Transparent;
			this.txtSexo.BorderColor = System.Drawing.Color.DarkSeaGreen;
			this.txtSexo.BorderRadius = 10;
			this.txtSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.txtSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txtSexo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSexo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSexo.FocusedState.Parent = this.txtSexo;
			this.txtSexo.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtSexo.ForeColor = System.Drawing.Color.Black;
			this.txtSexo.HoverState.Parent = this.txtSexo;
			this.txtSexo.ItemHeight = 30;
			this.txtSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
			this.txtSexo.ItemsAppearance.Parent = this.txtSexo;
			this.txtSexo.Location = new System.Drawing.Point(71, 297);
			this.txtSexo.Name = "txtSexo";
			this.txtSexo.ShadowDecoration.Parent = this.txtSexo;
			this.txtSexo.Size = new System.Drawing.Size(190, 36);
			this.txtSexo.StartIndex = 0;
			this.txtSexo.TabIndex = 2;
			// 
			// txtArea
			// 
			this.txtArea.BackColor = System.Drawing.Color.Transparent;
			this.txtArea.BorderColor = System.Drawing.Color.DarkSeaGreen;
			this.txtArea.BorderRadius = 10;
			this.txtArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.txtArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txtArea.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtArea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtArea.FocusedState.Parent = this.txtArea;
			this.txtArea.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtArea.ForeColor = System.Drawing.Color.Black;
			this.txtArea.HoverState.Parent = this.txtArea;
			this.txtArea.ItemHeight = 30;
			this.txtArea.Items.AddRange(new object[] {
            "Microárea 01",
            "Microárea 02",
            "Microárea 03",
            "Microárea 04",
            "Microárea 05",
            "Microárea 06",
            "Microárea 07",
            "Microárea 08",
            "Outro"});
			this.txtArea.ItemsAppearance.Parent = this.txtArea;
			this.txtArea.Location = new System.Drawing.Point(291, 297);
			this.txtArea.Name = "txtArea";
			this.txtArea.ShadowDecoration.Parent = this.txtArea;
			this.txtArea.Size = new System.Drawing.Size(190, 36);
			this.txtArea.StartIndex = 0;
			this.txtArea.TabIndex = 4;
			// 
			// dateNasc
			// 
			this.dateNasc.BorderColor = System.Drawing.Color.DarkSeaGreen;
			this.dateNasc.BorderRadius = 10;
			this.dateNasc.CheckedState.Parent = this.dateNasc;
			this.dateNasc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
			this.dateNasc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.dateNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateNasc.HoverState.Parent = this.dateNasc;
			this.dateNasc.Location = new System.Drawing.Point(71, 158);
			this.dateNasc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dateNasc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dateNasc.Name = "dateNasc";
			this.dateNasc.ShadowDecoration.Parent = this.dateNasc;
			this.dateNasc.Size = new System.Drawing.Size(180, 36);
			this.dateNasc.TabIndex = 5;
			this.dateNasc.Value = new System.DateTime(2021, 8, 17, 15, 30, 31, 610);
			// 
			// txtPatologia
			// 
			this.txtPatologia.BorderColor = System.Drawing.Color.DarkSeaGreen;
			this.txtPatologia.BorderRadius = 10;
			this.txtPatologia.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPatologia.DefaultText = "";
			this.txtPatologia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPatologia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPatologia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPatologia.DisabledState.Parent = this.txtPatologia;
			this.txtPatologia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPatologia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPatologia.FocusedState.Parent = this.txtPatologia;
			this.txtPatologia.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtPatologia.ForeColor = System.Drawing.Color.Black;
			this.txtPatologia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPatologia.HoverState.Parent = this.txtPatologia;
			this.txtPatologia.Location = new System.Drawing.Point(71, 371);
			this.txtPatologia.Name = "txtPatologia";
			this.txtPatologia.PasswordChar = '\0';
			this.txtPatologia.PlaceholderText = "";
			this.txtPatologia.SelectedText = "";
			this.txtPatologia.ShadowDecoration.Parent = this.txtPatologia;
			this.txtPatologia.Size = new System.Drawing.Size(410, 36);
			this.txtPatologia.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.LightGreen;
			this.label1.Location = new System.Drawing.Point(68, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "Nome Completo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.LightGreen;
			this.label2.Location = new System.Drawing.Point(68, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "Data de nascimento";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.LightGreen;
			this.label3.Location = new System.Drawing.Point(68, 277);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Sexo";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.LightGreen;
			this.label4.Location = new System.Drawing.Point(522, 277);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "N de moradores";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.LightGreen;
			this.label5.Location = new System.Drawing.Point(68, 351);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "Patologia";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.LightGreen;
			this.label6.Location = new System.Drawing.Point(288, 277);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 17);
			this.label6.TabIndex = 13;
			this.label6.Text = "Área";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.LightGreen;
			this.label7.Location = new System.Drawing.Point(71, 211);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 17);
			this.label7.TabIndex = 14;
			this.label7.Text = "SUS";
			// 
			// btnSalvar
			// 
			this.btnSalvar.Animated = true;
			this.btnSalvar.AnimatedGIF = true;
			this.btnSalvar.BorderColor = System.Drawing.Color.Transparent;
			this.btnSalvar.BorderRadius = 10;
			this.btnSalvar.BorderThickness = 1;
			this.btnSalvar.CheckedState.Parent = this.btnSalvar;
			this.btnSalvar.CustomImages.Parent = this.btnSalvar;
			this.btnSalvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSalvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSalvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSalvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSalvar.DisabledState.Parent = this.btnSalvar;
			this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
			this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnSalvar.ForeColor = System.Drawing.Color.White;
			this.btnSalvar.HoverState.Parent = this.btnSalvar;
			this.btnSalvar.Location = new System.Drawing.Point(290, 470);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.ShadowDecoration.Parent = this.btnSalvar;
			this.btnSalvar.Size = new System.Drawing.Size(140, 40);
			this.btnSalvar.TabIndex = 15;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Animated = true;
			this.btnCancelar.AnimatedGIF = true;
			this.btnCancelar.BorderColor = System.Drawing.Color.Transparent;
			this.btnCancelar.BorderRadius = 10;
			this.btnCancelar.BorderThickness = 1;
			this.btnCancelar.CheckedState.Parent = this.btnCancelar;
			this.btnCancelar.CustomImages.Parent = this.btnCancelar;
			this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCancelar.DisabledState.Parent = this.btnCancelar;
			this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
			this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnCancelar.ForeColor = System.Drawing.Color.White;
			this.btnCancelar.HoverState.Parent = this.btnCancelar;
			this.btnCancelar.Location = new System.Drawing.Point(449, 470);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
			this.btnCancelar.Size = new System.Drawing.Size(140, 40);
			this.btnCancelar.TabIndex = 16;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// txtSus
			// 
			this.txtSus.BackColor = System.Drawing.SystemColors.Window;
			this.txtSus.BorderColor = System.Drawing.Color.DarkSeaGreen;
			this.txtSus.BorderFocusColor = System.Drawing.Color.HotPink;
			this.txtSus.BorderRadius = 10;
			this.txtSus.BorderSize = 1;
			this.txtSus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSus.ForeColor = System.Drawing.Color.Black;
			this.txtSus.Format = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtSus.Location = new System.Drawing.Point(71, 235);
			this.txtSus.Margin = new System.Windows.Forms.Padding(4);
			this.txtSus.Mask = "000,0000,0000,0000";
			this.txtSus.Multiline = false;
			this.txtSus.Name = "txtSus";
			this.txtSus.Padding = new System.Windows.Forms.Padding(7);
			this.txtSus.PromptChar = true;
			this.txtSus.PtpChar = ' ';
			this.txtSus.Selectlength = 0;
			this.txtSus.Size = new System.Drawing.Size(190, 35);
			this.txtSus.TabIndex = 7;
			this.txtSus.UnderlinedStyle = false;
			// 
			// CadastrarPaciente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(802, 527);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSus);
			this.Controls.Add(this.txtPatologia);
			this.Controls.Add(this.dateNasc);
			this.Controls.Add(this.txtArea);
			this.Controls.Add(this.txtSexo);
			this.Controls.Add(this.txtMoradores);
			this.Controls.Add(this.txtNome);
			this.Name = "CadastrarPaciente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CadastrarPaciente";
			((System.ComponentModel.ISupportInitialize)(this.txtMoradores)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2TextBox txtNome;
		private Guna.UI2.WinForms.Guna2ComboBox txtSexo;
		private Guna.UI2.WinForms.Guna2ComboBox txtArea;
		private Guna.UI2.WinForms.Guna2DateTimePicker dateNasc;
		private Guna.UI2.WinForms.Guna2TextBox txtPatologia;
		private CustomControls.RJControls.CustomMaskedTextBox txtSus;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private Guna.UI2.WinForms.Guna2Button btnSalvar;
		private Guna.UI2.WinForms.Guna2Button btnCancelar;
		private Guna.UI2.WinForms.Guna2NumericUpDown txtMoradores;
	}
}