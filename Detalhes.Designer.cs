
namespace floravida
{
	partial class Detalhes
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblnome = new System.Windows.Forms.Label();
			this.lbldata = new System.Windows.Forms.Label();
			this.lblsus = new System.Windows.Forms.Label();
			this.datagrid = new Guna.UI2.WinForms.Guna2DataGridView();
			this.btnpdf = new Guna.UI2.WinForms.Guna2Button();
			this.btnvisualizar = new Guna.UI2.WinForms.Guna2Button();
			this.btnvoltar = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
			this.SuspendLayout();
			// 
			// lblnome
			// 
			this.lblnome.AutoSize = true;
			this.lblnome.Font = new System.Drawing.Font("Open Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblnome.ForeColor = System.Drawing.Color.White;
			this.lblnome.Location = new System.Drawing.Point(187, 9);
			this.lblnome.Name = "lblnome";
			this.lblnome.Size = new System.Drawing.Size(348, 23);
			this.lblnome.TabIndex = 0;
			this.lblnome.Text = "Paulo Matheus Armando de Oliveira Silva";
			// 
			// lbldata
			// 
			this.lbldata.AutoSize = true;
			this.lbldata.Font = new System.Drawing.Font("Open Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
			this.lbldata.ForeColor = System.Drawing.Color.White;
			this.lbldata.Location = new System.Drawing.Point(187, 55);
			this.lbldata.Name = "lbldata";
			this.lbldata.Size = new System.Drawing.Size(49, 23);
			this.lbldata.TabIndex = 1;
			this.lbldata.Text = "Data";
			// 
			// lblsus
			// 
			this.lblsus.AutoSize = true;
			this.lblsus.Font = new System.Drawing.Font("Open Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblsus.ForeColor = System.Drawing.Color.White;
			this.lblsus.Location = new System.Drawing.Point(187, 32);
			this.lblsus.Name = "lblsus";
			this.lblsus.Size = new System.Drawing.Size(41, 23);
			this.lblsus.TabIndex = 2;
			this.lblsus.Text = "SUS";
			// 
			// datagrid
			// 
			this.datagrid.AllowUserToAddRows = false;
			this.datagrid.AllowUserToDeleteRows = false;
			this.datagrid.AllowUserToOrderColumns = true;
			this.datagrid.AllowUserToResizeRows = false;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
			this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
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
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.datagrid.ColumnHeadersHeight = 35;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagrid.DefaultCellStyle = dataGridViewCellStyle11;
			this.datagrid.EnableHeadersVisualStyles = false;
			this.datagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
			this.datagrid.Location = new System.Drawing.Point(180, 104);
			this.datagrid.MaximumSize = new System.Drawing.Size(0, 800);
			this.datagrid.MinimumSize = new System.Drawing.Size(590, 370);
			this.datagrid.MultiSelect = false;
			this.datagrid.Name = "datagrid";
			this.datagrid.ReadOnly = true;
			this.datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.datagrid.RowHeadersVisible = false;
			this.datagrid.RowHeadersWidth = 51;
			this.datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.datagrid.RowTemplate.Height = 24;
			this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.datagrid.Size = new System.Drawing.Size(590, 370);
			this.datagrid.TabIndex = 4;
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
			// 
			// btnpdf
			// 
			this.btnpdf.Animated = true;
			this.btnpdf.AnimatedGIF = true;
			this.btnpdf.BorderColor = System.Drawing.Color.Transparent;
			this.btnpdf.BorderRadius = 10;
			this.btnpdf.BorderThickness = 1;
			this.btnpdf.CheckedState.Parent = this.btnpdf;
			this.btnpdf.CustomImages.Parent = this.btnpdf;
			this.btnpdf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnpdf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnpdf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnpdf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnpdf.DisabledState.Parent = this.btnpdf;
			this.btnpdf.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
			this.btnpdf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnpdf.ForeColor = System.Drawing.Color.White;
			this.btnpdf.HoverState.Parent = this.btnpdf;
			this.btnpdf.Location = new System.Drawing.Point(23, 104);
			this.btnpdf.Name = "btnpdf";
			this.btnpdf.ShadowDecoration.Parent = this.btnpdf;
			this.btnpdf.Size = new System.Drawing.Size(140, 40);
			this.btnpdf.TabIndex = 20;
			this.btnpdf.Text = "PDF";
			this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
			// 
			// btnvisualizar
			// 
			this.btnvisualizar.Animated = true;
			this.btnvisualizar.AnimatedGIF = true;
			this.btnvisualizar.BorderColor = System.Drawing.Color.Transparent;
			this.btnvisualizar.BorderRadius = 10;
			this.btnvisualizar.BorderThickness = 1;
			this.btnvisualizar.CheckedState.Parent = this.btnvisualizar;
			this.btnvisualizar.CustomImages.Parent = this.btnvisualizar;
			this.btnvisualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnvisualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnvisualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnvisualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnvisualizar.DisabledState.Parent = this.btnvisualizar;
			this.btnvisualizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
			this.btnvisualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnvisualizar.ForeColor = System.Drawing.Color.White;
			this.btnvisualizar.HoverState.Parent = this.btnvisualizar;
			this.btnvisualizar.Location = new System.Drawing.Point(23, 150);
			this.btnvisualizar.Name = "btnvisualizar";
			this.btnvisualizar.ShadowDecoration.Parent = this.btnvisualizar;
			this.btnvisualizar.Size = new System.Drawing.Size(140, 40);
			this.btnvisualizar.TabIndex = 21;
			this.btnvisualizar.Text = "Visualizar";
			this.btnvisualizar.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// btnvoltar
			// 
			this.btnvoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnvoltar.Animated = true;
			this.btnvoltar.AnimatedGIF = true;
			this.btnvoltar.BorderColor = System.Drawing.Color.Transparent;
			this.btnvoltar.BorderRadius = 10;
			this.btnvoltar.BorderThickness = 1;
			this.btnvoltar.CheckedState.Parent = this.btnvoltar;
			this.btnvoltar.CustomImages.Parent = this.btnvoltar;
			this.btnvoltar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnvoltar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnvoltar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnvoltar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnvoltar.DisabledState.Parent = this.btnvoltar;
			this.btnvoltar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
			this.btnvoltar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnvoltar.ForeColor = System.Drawing.Color.White;
			this.btnvoltar.HoverState.Parent = this.btnvoltar;
			this.btnvoltar.Location = new System.Drawing.Point(23, 434);
			this.btnvoltar.Name = "btnvoltar";
			this.btnvoltar.ShadowDecoration.Parent = this.btnvoltar;
			this.btnvoltar.Size = new System.Drawing.Size(140, 40);
			this.btnvoltar.TabIndex = 22;
			this.btnvoltar.Text = "Voltar";
			this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
			// 
			// Detalhes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(802, 498);
			this.Controls.Add(this.btnvoltar);
			this.Controls.Add(this.btnvisualizar);
			this.Controls.Add(this.btnpdf);
			this.Controls.Add(this.datagrid);
			this.Controls.Add(this.lblsus);
			this.Controls.Add(this.lbldata);
			this.Controls.Add(this.lblnome);
			this.Name = "Detalhes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Detalhes";
			((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblnome;
		private System.Windows.Forms.Label lbldata;
		private System.Windows.Forms.Label lblsus;
		private Guna.UI2.WinForms.Guna2DataGridView datagrid;
		private Guna.UI2.WinForms.Guna2Button btnpdf;
		private Guna.UI2.WinForms.Guna2Button btnvisualizar;
		private Guna.UI2.WinForms.Guna2Button btnvoltar;
	}
}