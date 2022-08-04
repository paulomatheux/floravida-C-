
namespace floravida
{
	partial class Usuarios
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
			this.btnvoltar = new Guna.UI2.WinForms.Guna2Button();
			this.btnpdf = new Guna.UI2.WinForms.Guna2Button();
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
			this.datagrid.Location = new System.Drawing.Point(176, 44);
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
			this.datagrid.Size = new System.Drawing.Size(665, 370);
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
			// btnvoltar
			// 
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
			this.btnvoltar.Location = new System.Drawing.Point(12, 90);
			this.btnvoltar.Name = "btnvoltar";
			this.btnvoltar.ShadowDecoration.Parent = this.btnvoltar;
			this.btnvoltar.Size = new System.Drawing.Size(140, 40);
			this.btnvoltar.TabIndex = 20;
			this.btnvoltar.Text = "Voltar";
			this.btnvoltar.Click += new System.EventHandler(this.btnVoltar_Click);
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
			this.btnpdf.Location = new System.Drawing.Point(12, 44);
			this.btnpdf.Name = "btnpdf";
			this.btnpdf.ShadowDecoration.Parent = this.btnpdf;
			this.btnpdf.Size = new System.Drawing.Size(140, 40);
			this.btnpdf.TabIndex = 19;
			this.btnpdf.Text = "Cadastrar";
			this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
			// 
			// Usuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(873, 450);
			this.Controls.Add(this.btnvoltar);
			this.Controls.Add(this.btnpdf);
			this.Controls.Add(this.datagrid);
			this.Name = "Usuarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Usuarios";
			((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2DataGridView datagrid;
		private Guna.UI2.WinForms.Guna2Button btnvoltar;
		private Guna.UI2.WinForms.Guna2Button btnpdf;
	}
}