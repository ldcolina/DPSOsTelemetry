namespace DPSOsTelemetria.Configuraciones
{
    partial class Actualizaciones
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.VersionNotes = new System.Windows.Forms.Label();
            this.ReleaseNotes = new System.Windows.Forms.Label();
            this.txbNovedades = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 404);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MainLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.VersionNotes, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ReleaseNotes, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txbNovedades, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(714, 358);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DPSOsTelemetria.Resources.antenna_with_signal_lines_symbol_icon_icons_com_565731;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel2.SetRowSpan(this.pictureBox1, 3);
            this.pictureBox1.Size = new System.Drawing.Size(144, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.Location = new System.Drawing.Point(153, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(558, 50);
            this.MainLabel.TabIndex = 1;
            this.MainLabel.Text = "MainLabel";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VersionNotes
            // 
            this.VersionNotes.AutoSize = true;
            this.VersionNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VersionNotes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.VersionNotes.Location = new System.Drawing.Point(153, 50);
            this.VersionNotes.Name = "VersionNotes";
            this.VersionNotes.Size = new System.Drawing.Size(558, 50);
            this.VersionNotes.TabIndex = 2;
            this.VersionNotes.Text = "VersionNotes";
            this.VersionNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReleaseNotes
            // 
            this.ReleaseNotes.AutoSize = true;
            this.ReleaseNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReleaseNotes.Location = new System.Drawing.Point(153, 100);
            this.ReleaseNotes.Name = "ReleaseNotes";
            this.ReleaseNotes.Size = new System.Drawing.Size(558, 50);
            this.ReleaseNotes.TabIndex = 3;
            this.ReleaseNotes.Text = "ReleaseNotes";
            this.ReleaseNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbNovedades
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txbNovedades, 2);
            this.txbNovedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbNovedades.Location = new System.Drawing.Point(3, 153);
            this.txbNovedades.Multiline = true;
            this.txbNovedades.Name = "txbNovedades";
            this.txbNovedades.ReadOnly = true;
            this.txbNovedades.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txbNovedades.Size = new System.Drawing.Size(708, 202);
            this.txbNovedades.TabIndex = 4;
            // 
            // Actualizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Actualizaciones";
            this.Size = new System.Drawing.Size(760, 404);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label MainLabel;
        private Label VersionNotes;
        private Label ReleaseNotes;
        private TextBox txbNovedades;
    }
}
