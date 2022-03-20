using System.Windows.Forms;

namespace DPSOsTelemetria2
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Version = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpVisualizacion = new System.Windows.Forms.TableLayoutPanel();
            this.ptbVisualizacion = new System.Windows.Forms.PictureBox();
            this.Visualizacion = new System.Windows.Forms.Label();
            this.tlpGuia = new System.Windows.Forms.TableLayoutPanel();
            this.ptbGuia = new System.Windows.Forms.PictureBox();
            this.Guia = new System.Windows.Forms.Label();
            this.tlpActualizaciones = new System.Windows.Forms.TableLayoutPanel();
            this.ptbActualizaciones = new System.Windows.Forms.PictureBox();
            this.Actualizaciones = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Terms = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Privacy = new System.Windows.Forms.Label();
            this.LicenseAgreement = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Licenses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tlpVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVisualizacion)).BeginInit();
            this.tlpGuia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGuia)).BeginInit();
            this.tlpActualizaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbActualizaciones)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1MinSize = 60;
            this.splitContainer1.Size = new System.Drawing.Size(752, 603);
            this.splitContainer1.SplitterDistance = 314;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Version, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Copyright, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(255, 603);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Version
            // 
            this.Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(195, 583);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(57, 20);
            this.Version.TabIndex = 3;
            this.Version.Text = "Version";
            this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.tlpVisualizacion, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tlpGuia, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tlpActualizaciones, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(243, 168);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tlpVisualizacion
            // 
            this.tlpVisualizacion.AutoSize = true;
            this.tlpVisualizacion.ColumnCount = 2;
            this.tlpVisualizacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVisualizacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVisualizacion.Controls.Add(this.ptbVisualizacion, 0, 0);
            this.tlpVisualizacion.Controls.Add(this.Visualizacion, 1, 0);
            this.tlpVisualizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVisualizacion.Location = new System.Drawing.Point(3, 59);
            this.tlpVisualizacion.Name = "tlpVisualizacion";
            this.tlpVisualizacion.RowCount = 1;
            this.tlpVisualizacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVisualizacion.Size = new System.Drawing.Size(237, 40);
            this.tlpVisualizacion.TabIndex = 6;
            this.tlpVisualizacion.Click += new System.EventHandler(this.Visualizacion_Click);
            this.tlpVisualizacion.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.tlpVisualizacion.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // ptbVisualizacion
            // 
            this.ptbVisualizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbVisualizacion.Image = global::DPSOsTelemetria2.Properties.Resources.chat_96641;
            this.ptbVisualizacion.Location = new System.Drawing.Point(0, 0);
            this.ptbVisualizacion.Margin = new System.Windows.Forms.Padding(0);
            this.ptbVisualizacion.Name = "ptbVisualizacion";
            this.ptbVisualizacion.Size = new System.Drawing.Size(40, 40);
            this.ptbVisualizacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbVisualizacion.TabIndex = 1;
            this.ptbVisualizacion.TabStop = false;
            this.ptbVisualizacion.Click += new System.EventHandler(this.Visualizacion_Click);
            this.ptbVisualizacion.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.ptbVisualizacion.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // Visualizacion
            // 
            this.Visualizacion.AutoSize = true;
            this.Visualizacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.Visualizacion.Location = new System.Drawing.Point(43, 0);
            this.Visualizacion.Name = "Visualizacion";
            this.Visualizacion.Size = new System.Drawing.Size(102, 40);
            this.Visualizacion.TabIndex = 3;
            this.Visualizacion.Text = "Configuración";
            this.Visualizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Visualizacion.Click += new System.EventHandler(this.Visualizacion_Click);
            this.Visualizacion.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.Visualizacion.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // tlpGuia
            // 
            this.tlpGuia.AutoSize = true;
            this.tlpGuia.ColumnCount = 2;
            this.tlpGuia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpGuia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpGuia.Controls.Add(this.ptbGuia, 0, 0);
            this.tlpGuia.Controls.Add(this.Guia, 1, 0);
            this.tlpGuia.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpGuia.Location = new System.Drawing.Point(3, 3);
            this.tlpGuia.Name = "tlpGuia";
            this.tlpGuia.RowCount = 1;
            this.tlpGuia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGuia.Size = new System.Drawing.Size(237, 40);
            this.tlpGuia.TabIndex = 4;
            this.tlpGuia.Click += new System.EventHandler(this.Guia_Click);
            this.tlpGuia.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.tlpGuia.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // ptbGuia
            // 
            this.ptbGuia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbGuia.Image = global::DPSOsTelemetria2.Properties.Resources.instrucciones;
            this.ptbGuia.Location = new System.Drawing.Point(0, 0);
            this.ptbGuia.Margin = new System.Windows.Forms.Padding(0);
            this.ptbGuia.Name = "ptbGuia";
            this.ptbGuia.Size = new System.Drawing.Size(40, 40);
            this.ptbGuia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbGuia.TabIndex = 0;
            this.ptbGuia.TabStop = false;
            this.ptbGuia.Click += new System.EventHandler(this.Guia_Click);
            this.ptbGuia.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.ptbGuia.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // Guia
            // 
            this.Guia.AutoSize = true;
            this.Guia.Dock = System.Windows.Forms.DockStyle.Left;
            this.Guia.Location = new System.Drawing.Point(43, 0);
            this.Guia.Name = "Guia";
            this.Guia.Size = new System.Drawing.Size(45, 40);
            this.Guia.TabIndex = 2;
            this.Guia.Text = "Guías";
            this.Guia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guia.Click += new System.EventHandler(this.Guia_Click);
            this.Guia.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.Guia.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // tlpActualizaciones
            // 
            this.tlpActualizaciones.AutoSize = true;
            this.tlpActualizaciones.ColumnCount = 2;
            this.tlpActualizaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpActualizaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpActualizaciones.Controls.Add(this.ptbActualizaciones, 0, 0);
            this.tlpActualizaciones.Controls.Add(this.Actualizaciones, 1, 0);
            this.tlpActualizaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpActualizaciones.Location = new System.Drawing.Point(3, 115);
            this.tlpActualizaciones.Name = "tlpActualizaciones";
            this.tlpActualizaciones.RowCount = 1;
            this.tlpActualizaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpActualizaciones.Size = new System.Drawing.Size(237, 40);
            this.tlpActualizaciones.TabIndex = 5;
            this.tlpActualizaciones.Click += new System.EventHandler(this.Actualizacion_Click);
            this.tlpActualizaciones.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.tlpActualizaciones.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // ptbActualizaciones
            // 
            this.ptbActualizaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbActualizaciones.Image = global::DPSOsTelemetria2.Properties.Resources.refresh;
            this.ptbActualizaciones.Location = new System.Drawing.Point(0, 0);
            this.ptbActualizaciones.Margin = new System.Windows.Forms.Padding(0);
            this.ptbActualizaciones.Name = "ptbActualizaciones";
            this.ptbActualizaciones.Size = new System.Drawing.Size(40, 40);
            this.ptbActualizaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbActualizaciones.TabIndex = 1;
            this.ptbActualizaciones.TabStop = false;
            this.ptbActualizaciones.Click += new System.EventHandler(this.Actualizacion_Click);
            this.ptbActualizaciones.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.ptbActualizaciones.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // Actualizaciones
            // 
            this.Actualizaciones.AutoSize = true;
            this.Actualizaciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.Actualizaciones.Location = new System.Drawing.Point(43, 0);
            this.Actualizaciones.Name = "Actualizaciones";
            this.Actualizaciones.Size = new System.Drawing.Size(157, 40);
            this.Actualizaciones.TabIndex = 3;
            this.Actualizaciones.Text = "Buscar actualizaciones";
            this.Actualizaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Actualizaciones.Click += new System.EventHandler(this.Actualizacion_Click);
            this.Actualizaciones.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.Actualizaciones.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Dock = System.Windows.Forms.DockStyle.Left;
            this.Copyright.Location = new System.Drawing.Point(3, 517);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(74, 20);
            this.Copyright.TabIndex = 0;
            this.Copyright.Text = "Copyright";
            this.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.Terms, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.Privacy, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.LicenseAgreement, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.Licenses, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 540);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(249, 40);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // Terms
            // 
            this.Terms.AutoSize = true;
            this.Terms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Terms.Dock = System.Windows.Forms.DockStyle.Left;
            this.Terms.Location = new System.Drawing.Point(3, 0);
            this.Terms.Name = "Terms";
            this.Terms.Size = new System.Drawing.Size(69, 20);
            this.Terms.TabIndex = 0;
            this.Terms.Text = "Términos";
            this.Terms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Terms.Click += new System.EventHandler(this.Terms_Click);
            this.Terms.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.Terms.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(149, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Privacy
            // 
            this.Privacy.AutoSize = true;
            this.Privacy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Privacy.Dock = System.Windows.Forms.DockStyle.Left;
            this.Privacy.Location = new System.Drawing.Point(168, 0);
            this.Privacy.Name = "Privacy";
            this.Privacy.Size = new System.Drawing.Size(78, 20);
            this.Privacy.TabIndex = 2;
            this.Privacy.Text = "Privacidad";
            this.Privacy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Privacy.Click += new System.EventHandler(this.Privacy_Click);
            this.Privacy.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.Privacy.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // LicenseAgreement
            // 
            this.LicenseAgreement.AutoSize = true;
            this.LicenseAgreement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LicenseAgreement.Dock = System.Windows.Forms.DockStyle.Left;
            this.LicenseAgreement.Location = new System.Drawing.Point(3, 20);
            this.LicenseAgreement.Name = "LicenseAgreement";
            this.LicenseAgreement.Size = new System.Drawing.Size(140, 20);
            this.LicenseAgreement.TabIndex = 3;
            this.LicenseAgreement.Text = "Acuerdo de licencia";
            this.LicenseAgreement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LicenseAgreement.Click += new System.EventHandler(this.LicenseAgreement_Click);
            this.LicenseAgreement.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.LicenseAgreement.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(149, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "|";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Licenses
            // 
            this.Licenses.AutoSize = true;
            this.Licenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Licenses.Dock = System.Windows.Forms.DockStyle.Left;
            this.Licenses.Location = new System.Drawing.Point(168, 20);
            this.Licenses.Name = "Licenses";
            this.Licenses.Size = new System.Drawing.Size(68, 20);
            this.Licenses.TabIndex = 5;
            this.Licenses.Text = "Licencias";
            this.Licenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Licenses.Click += new System.EventHandler(this.Licenses_Click);
            this.Licenses.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.Licenses.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 603);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(770, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(770, 650);
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Config_FormClosing);
            this.Load += new System.EventHandler(this.Config_Load);
            this.Shown += new System.EventHandler(this.Config_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tlpVisualizacion.ResumeLayout(false);
            this.tlpVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVisualizacion)).EndInit();
            this.tlpGuia.ResumeLayout(false);
            this.tlpGuia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGuia)).EndInit();
            this.tlpActualizaciones.ResumeLayout(false);
            this.tlpActualizaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbActualizaciones)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label Version;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tlpVisualizacion;
        private PictureBox ptbVisualizacion;
        private Label Visualizacion;
        private TableLayoutPanel tlpGuia;
        private PictureBox ptbGuia;
        private Label Guia;
        private TableLayoutPanel tlpActualizaciones;
        private PictureBox ptbActualizaciones;
        private Label Actualizaciones;
        private Label Copyright;
        private TableLayoutPanel tableLayoutPanel4;
        private Label Terms;
        private Label label3;
        private Label Privacy;
        private Label LicenseAgreement;
        private Label label6;
        private Label Licenses;
    }
}