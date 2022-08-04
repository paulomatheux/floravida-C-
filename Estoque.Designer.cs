
namespace floravida
{
    partial class Estoque
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
			this.datagrid = new Guna.UI2.WinForms.Guna2DataGridView();
			this.miniToolStrip = new System.Windows.Forms.MenuStrip();
			this.usuáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.áreasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnpdf = new Guna.UI2.WinForms.Guna2Button();
			this.btndispensa = new Guna.UI2.WinForms.Guna2Button();
			this.btncadastro = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
			this.miniToolStrip.SuspendLayout();
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
			this.datagrid.Location = new System.Drawing.Point(172, 60);
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
			this.datagrid.Size = new System.Drawing.Size(850, 420);
			this.datagrid.TabIndex = 2;
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
			// miniToolStrip
			// 
			this.miniToolStrip.AccessibleName = "Nova seleção de item";
			this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
			this.miniToolStrip.AutoSize = false;
			this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.miniToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem1,
            this.históricoToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.áreasToolStripMenuItem});
			this.miniToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
			this.miniToolStrip.Name = "miniToolStrip";
			this.miniToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.miniToolStrip.Size = new System.Drawing.Size(1052, 30);
			this.miniToolStrip.TabIndex = 7;
			// 
			// usuáriosToolStripMenuItem1
			// 
			this.usuáriosToolStripMenuItem1.Name = "usuáriosToolStripMenuItem1";
			this.usuáriosToolStripMenuItem1.Size = new System.Drawing.Size(79, 24);
			this.usuáriosToolStripMenuItem1.Text = "Usuários";
			this.usuáriosToolStripMenuItem1.Click += new System.EventHandler(this.usuáriosToolStripMenuItem1_Click);
			// 
			// históricoToolStripMenuItem
			// 
			this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
			this.históricoToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
			this.históricoToolStripMenuItem.Text = "Histórico";
			this.históricoToolStripMenuItem.Click += new System.EventHandler(this.históricoToolStripMenuItem_Click);
			// 
			// pacientesToolStripMenuItem
			// 
			this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
			this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
			this.pacientesToolStripMenuItem.Text = "Pacientes";
			this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
			// 
			// áreasToolStripMenuItem
			// 
			this.áreasToolStripMenuItem.Name = "áreasToolStripMenuItem";
			this.áreasToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
			this.áreasToolStripMenuItem.Text = "Áreas";
			this.áreasToolStripMenuItem.Click += new System.EventHandler(this.áreasToolStripMenuItem_Click);
			// 
			// btnpdf
			// 
			this.btnpdf.Animated = true;
			this.btnpdf.AnimatedGIF = true;
			this.btnpdf.BorderRadius = 10;
			this.btnpdf.CheckedState.Parent = this.btnpdf;
			this.btnpdf.CustomImages.Parent = this.btnpdf;
			this.btnpdf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnpdf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnpdf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnpdf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnpdf.DisabledState.Parent = this.btnpdf;
			this.btnpdf.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
			this.btnpdf.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnpdf.ForeColor = System.Drawing.Color.White;
			this.btnpdf.HoverState.Parent = this.btnpdf;
			this.btnpdf.Location = new System.Drawing.Point(19, 153);
			this.btnpdf.Margin = new System.Windows.Forms.Padding(10, 50, 10, 10);
			this.btnpdf.Name = "btnpdf";
			this.btnpdf.ShadowDecoration.Parent = this.btnpdf;
			this.btnpdf.Size = new System.Drawing.Size(140, 40);
			this.btnpdf.TabIndex = 6;
			this.btnpdf.Text = "PDF";
			this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
			// 
			// btndispensa
			// 
			this.btndispensa.Animated = true;
			this.btndispensa.AnimatedGIF = true;
			this.btndispensa.BorderRadius = 10;
			this.btndispensa.CheckedState.Parent = this.btndispensa;
			this.btndispensa.CustomImages.Parent = this.btndispensa;
			this.btndispensa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btndispensa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btndispensa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btndispensa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btndispensa.DisabledState.Parent = this.btndispensa;
			this.btndispensa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
			this.btndispensa.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btndispensa.ForeColor = System.Drawing.Color.White;
			this.btndispensa.HoverState.Parent = this.btndispensa;
			this.btndispensa.Location = new System.Drawing.Point(19, 106);
			this.btndispensa.Margin = new System.Windows.Forms.Padding(10);
			this.btndispensa.Name = "btndispensa";
			this.btndispensa.ShadowDecoration.Parent = this.btndispensa;
			this.btndispensa.Size = new System.Drawing.Size(140, 40);
			this.btndispensa.TabIndex = 5;
			this.btndispensa.Text = "Dispensa";
			this.btndispensa.Click += new System.EventHandler(this.btndispensa_Click);
			// 
			// btncadastro
			// 
			this.btncadastro.Animated = true;
			this.btncadastro.AnimatedGIF = true;
			this.btncadastro.BorderRadius = 10;
			this.btncadastro.CheckedState.Parent = this.btncadastro;
			this.btncadastro.CustomImages.Parent = this.btncadastro;
			this.btncadastro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btncadastro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btncadastro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btncadastro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btncadastro.DisabledState.Parent = this.btncadastro;
			this.btncadastro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
			this.btncadastro.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btncadastro.ForeColor = System.Drawing.Color.White;
			this.btncadastro.HoverState.Parent = this.btncadastro;
			this.btncadastro.Location = new System.Drawing.Point(19, 60);
			this.btncadastro.Margin = new System.Windows.Forms.Padding(10);
			this.btncadastro.Name = "btncadastro";
			this.btncadastro.ShadowDecoration.Parent = this.btncadastro;
			this.btncadastro.Size = new System.Drawing.Size(140, 40);
			this.btncadastro.TabIndex = 3;
			this.btncadastro.Text = "Cadastrar";
			this.btncadastro.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// Estoque
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(1052, 513);
			this.Controls.Add(this.miniToolStrip);
			this.Controls.Add(this.btncadastro);
			this.Controls.Add(this.datagrid);
			this.Controls.Add(this.btndispensa);
			this.Controls.Add(this.btnpdf);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(990, 560);
			this.Name = "Estoque";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Controle Floravida 2.0";
			((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
			this.miniToolStrip.ResumeLayout(false);
			this.miniToolStrip.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView datagrid;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áreasToolStripMenuItem;
		private Guna.UI2.WinForms.Guna2Button btnpdf;
		private Guna.UI2.WinForms.Guna2Button btndispensa;
		private Guna.UI2.WinForms.Guna2Button btncadastro;
	}
}