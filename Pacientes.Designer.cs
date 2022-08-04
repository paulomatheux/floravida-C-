
namespace floravida
{
	partial class Pacientes
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.datagrid = new Guna.UI2.WinForms.Guna2DataGridView();
			this.btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
			this.SuspendLayout();
			// 
			// datagrid
			// 
			this.datagrid.AllowUserToAddRows = false;
			this.datagrid.AllowUserToDeleteRows = false;
			this.datagrid.AllowUserToOrderColumns = true;
			this.datagrid.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
			this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
			this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.datagrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this.datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.datagrid.ColumnHeadersHeight = 35;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagrid.DefaultCellStyle = dataGridViewCellStyle3;
			this.datagrid.EnableHeadersVisualStyles = false;
			this.datagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
			this.datagrid.Location = new System.Drawing.Point(177, 35);
			this.datagrid.MaximumSize = new System.Drawing.Size(0, 800);
			this.datagrid.MinimumSize = new System.Drawing.Size(665, 370);
			this.datagrid.MultiSelect = false;
			this.datagrid.Name = "datagrid";
			this.datagrid.ReadOnly = true;
			this.datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.datagrid.RowHeadersVisible = false;
			this.datagrid.RowHeadersWidth = 51;
			this.datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.datagrid.RowTemplate.Height = 24;
			this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.datagrid.ShowCellErrors = false;
			this.datagrid.ShowRowErrors = false;
			this.datagrid.Size = new System.Drawing.Size(665, 391);
			this.datagrid.TabIndex = 3;
			this.datagrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen;
			this.datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
			this.datagrid.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.datagrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
			this.datagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
			this.datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
			this.datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.datagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.datagrid.ThemeStyle.HeaderStyle.Height = 35;
			this.datagrid.ThemeStyle.ReadOnly = true;
			this.datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
			this.datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.datagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.datagrid.ThemeStyle.RowsStyle.Height = 24;
			this.datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
			this.datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.datagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellDoubleClick);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Animated = true;
			this.btnCadastrar.AnimatedGIF = true;
			this.btnCadastrar.BorderColor = System.Drawing.Color.Transparent;
			this.btnCadastrar.BorderRadius = 10;
			this.btnCadastrar.BorderThickness = 1;
			this.btnCadastrar.CheckedState.Parent = this.btnCadastrar;
			this.btnCadastrar.CustomImages.Parent = this.btnCadastrar;
			this.btnCadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCadastrar.DisabledState.Parent = this.btnCadastrar;
			this.btnCadastrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
			this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnCadastrar.ForeColor = System.Drawing.Color.White;
			this.btnCadastrar.HoverState.Parent = this.btnCadastrar;
			this.btnCadastrar.Location = new System.Drawing.Point(12, 35);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.ShadowDecoration.Parent = this.btnCadastrar;
			this.btnCadastrar.Size = new System.Drawing.Size(140, 40);
			this.btnCadastrar.TabIndex = 16;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// guna2Button3
			// 
			this.guna2Button3.Animated = true;
			this.guna2Button3.AnimatedGIF = true;
			this.guna2Button3.BorderColor = System.Drawing.Color.Transparent;
			this.guna2Button3.BorderRadius = 10;
			this.guna2Button3.BorderThickness = 1;
			this.guna2Button3.CheckedState.Parent = this.guna2Button3;
			this.guna2Button3.CustomImages.Parent = this.guna2Button3;
			this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button3.DisabledState.Parent = this.guna2Button3;
			this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
			this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.guna2Button3.ForeColor = System.Drawing.Color.White;
			this.guna2Button3.HoverState.Parent = this.guna2Button3;
			this.guna2Button3.Location = new System.Drawing.Point(12, 81);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
			this.guna2Button3.Size = new System.Drawing.Size(140, 40);
			this.guna2Button3.TabIndex = 17;
			this.guna2Button3.Text = "Voltar";
			this.guna2Button3.Click += new System.EventHandler(this.voltar_Click);
			// 
			// Pacientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(894, 450);
			this.Controls.Add(this.guna2Button3);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.datagrid);
			this.Name = "Pacientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Pacientes";
			((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Guna.UI2.WinForms.Guna2DataGridView datagrid;
		private Guna.UI2.WinForms.Guna2Button btnCadastrar;
		private Guna.UI2.WinForms.Guna2Button guna2Button3;
	}
}