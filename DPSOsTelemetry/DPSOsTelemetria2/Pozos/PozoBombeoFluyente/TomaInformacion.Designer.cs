using System.Windows.Forms;

namespace DPSOsTelemetria2.Pozos.PozoBombeoFluyente
{
    partial class TomaInformacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any Languages being used.
        /// </summary>
        /// <param name="disposing">true if managed Languages should be disposed; otherwise, false.</param>
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTemporizador1 = new System.Windows.Forms.Label();
            this.DatosOperativos = new System.Windows.Forms.TextBox();
            this.tlpVariables = new System.Windows.Forms.TableLayoutPanel();
            this.presionTuberiaProduccion = new System.Windows.Forms.CheckBox();
            this.presionTuberiaProduccionMin = new System.Windows.Forms.TextBox();
            this.presionTuberiaProduccionMax = new System.Windows.Forms.TextBox();
            this.presionTuberiaRevestimiento = new System.Windows.Forms.CheckBox();
            this.presionTuberiaRevestimientoMin = new System.Windows.Forms.TextBox();
            this.presionTuberiaRevestimientoMax = new System.Windows.Forms.TextBox();
            this.presionDisponible = new System.Windows.Forms.CheckBox();
            this.presionLineaDescarga = new System.Windows.Forms.CheckBox();
            this.presionDisponibleMin = new System.Windows.Forms.TextBox();
            this.presionLineaDescargaMin = new System.Windows.Forms.TextBox();
            this.presionDisponibleMax = new System.Windows.Forms.TextBox();
            this.presionLineaDescargaMax = new System.Windows.Forms.TextBox();
            this.temperaturaSuperficie = new System.Windows.Forms.CheckBox();
            this.temperaturaSuperficieMin = new System.Windows.Forms.TextBox();
            this.temperaturaSuperficieMax = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tlpVariables.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 516);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tlpVariables, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(550, 470);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lbTemporizador1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.DatosOperativos, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 434);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(544, 33);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // lbTemporizador1
            // 
            this.lbTemporizador1.AutoSize = true;
            this.lbTemporizador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTemporizador1.Location = new System.Drawing.Point(3, 0);
            this.lbTemporizador1.Name = "lbTemporizador1";
            this.lbTemporizador1.Size = new System.Drawing.Size(115, 33);
            this.lbTemporizador1.TabIndex = 0;
            this.lbTemporizador1.Text = "lbTemporizador";
            this.lbTemporizador1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DatosOperativos
            // 
            this.DatosOperativos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosOperativos.Location = new System.Drawing.Point(124, 3);
            this.DatosOperativos.Name = "DatosOperativos";
            this.DatosOperativos.Size = new System.Drawing.Size(417, 27);
            this.DatosOperativos.TabIndex = 0;
            // 
            // tlpVariables
            // 
            this.tlpVariables.AutoScroll = true;
            this.tlpVariables.ColumnCount = 5;
            this.tlpVariables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVariables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVariables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVariables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVariables.Controls.Add(this.presionTuberiaProduccion, 0, 0);
            this.tlpVariables.Controls.Add(this.presionTuberiaProduccionMin, 0, 1);
            this.tlpVariables.Controls.Add(this.presionTuberiaProduccionMax, 1, 1);
            this.tlpVariables.Controls.Add(this.presionTuberiaRevestimiento, 3, 0);
            this.tlpVariables.Controls.Add(this.presionTuberiaRevestimientoMin, 3, 1);
            this.tlpVariables.Controls.Add(this.presionTuberiaRevestimientoMax, 4, 1);
            this.tlpVariables.Controls.Add(this.presionDisponible, 0, 6);
            this.tlpVariables.Controls.Add(this.presionLineaDescarga, 0, 3);
            this.tlpVariables.Controls.Add(this.presionDisponibleMin, 0, 7);
            this.tlpVariables.Controls.Add(this.presionLineaDescargaMin, 0, 4);
            this.tlpVariables.Controls.Add(this.presionDisponibleMax, 1, 7);
            this.tlpVariables.Controls.Add(this.presionLineaDescargaMax, 1, 4);
            this.tlpVariables.Controls.Add(this.temperaturaSuperficie, 3, 3);
            this.tlpVariables.Controls.Add(this.temperaturaSuperficieMin, 3, 4);
            this.tlpVariables.Controls.Add(this.temperaturaSuperficieMax, 4, 4);
            this.tlpVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVariables.Location = new System.Drawing.Point(3, 3);
            this.tlpVariables.Name = "tlpVariables";
            this.tlpVariables.RowCount = 12;
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.Size = new System.Drawing.Size(544, 425);
            this.tlpVariables.TabIndex = 3;
            // 
            // presionTuberiaProduccion
            // 
            this.presionTuberiaProduccion.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.presionTuberiaProduccion, 2);
            this.presionTuberiaProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionTuberiaProduccion.Location = new System.Drawing.Point(3, 3);
            this.presionTuberiaProduccion.Name = "presionTuberiaProduccion";
            this.presionTuberiaProduccion.Size = new System.Drawing.Size(256, 24);
            this.presionTuberiaProduccion.TabIndex = 0;
            this.presionTuberiaProduccion.Text = "presionTuberiaProduccion";
            this.presionTuberiaProduccion.UseVisualStyleBackColor = true;
            // 
            // presionTuberiaProduccionMin
            // 
            this.presionTuberiaProduccionMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionTuberiaProduccionMin.Location = new System.Drawing.Point(3, 33);
            this.presionTuberiaProduccionMin.Name = "presionTuberiaProduccionMin";
            this.presionTuberiaProduccionMin.Size = new System.Drawing.Size(125, 27);
            this.presionTuberiaProduccionMin.TabIndex = 1;
            // 
            // presionTuberiaProduccionMax
            // 
            this.presionTuberiaProduccionMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionTuberiaProduccionMax.Location = new System.Drawing.Point(134, 33);
            this.presionTuberiaProduccionMax.Name = "presionTuberiaProduccionMax";
            this.presionTuberiaProduccionMax.Size = new System.Drawing.Size(125, 27);
            this.presionTuberiaProduccionMax.TabIndex = 2;
            // 
            // presionTuberiaRevestimiento
            // 
            this.presionTuberiaRevestimiento.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.presionTuberiaRevestimiento, 2);
            this.presionTuberiaRevestimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionTuberiaRevestimiento.Location = new System.Drawing.Point(285, 3);
            this.presionTuberiaRevestimiento.Name = "presionTuberiaRevestimiento";
            this.presionTuberiaRevestimiento.Size = new System.Drawing.Size(256, 24);
            this.presionTuberiaRevestimiento.TabIndex = 3;
            this.presionTuberiaRevestimiento.Text = "presionTuberiaRevestimiento";
            this.presionTuberiaRevestimiento.UseVisualStyleBackColor = true;
            // 
            // presionTuberiaRevestimientoMin
            // 
            this.presionTuberiaRevestimientoMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionTuberiaRevestimientoMin.Location = new System.Drawing.Point(285, 33);
            this.presionTuberiaRevestimientoMin.Name = "presionTuberiaRevestimientoMin";
            this.presionTuberiaRevestimientoMin.Size = new System.Drawing.Size(125, 27);
            this.presionTuberiaRevestimientoMin.TabIndex = 4;
            // 
            // presionTuberiaRevestimientoMax
            // 
            this.presionTuberiaRevestimientoMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionTuberiaRevestimientoMax.Location = new System.Drawing.Point(416, 33);
            this.presionTuberiaRevestimientoMax.Name = "presionTuberiaRevestimientoMax";
            this.presionTuberiaRevestimientoMax.Size = new System.Drawing.Size(125, 27);
            this.presionTuberiaRevestimientoMax.TabIndex = 5;
            // 
            // presionDisponible
            // 
            this.presionDisponible.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.presionDisponible, 2);
            this.presionDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionDisponible.Location = new System.Drawing.Point(3, 169);
            this.presionDisponible.Name = "presionDisponible";
            this.presionDisponible.Size = new System.Drawing.Size(256, 24);
            this.presionDisponible.TabIndex = 6;
            this.presionDisponible.Text = "presionDisponible";
            this.presionDisponible.UseVisualStyleBackColor = true;
            // 
            // presionLineaDescarga
            // 
            this.presionLineaDescarga.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.presionLineaDescarga, 2);
            this.presionLineaDescarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionLineaDescarga.Location = new System.Drawing.Point(3, 86);
            this.presionLineaDescarga.Name = "presionLineaDescarga";
            this.presionLineaDescarga.Size = new System.Drawing.Size(256, 24);
            this.presionLineaDescarga.TabIndex = 12;
            this.presionLineaDescarga.Text = "presionLineaDescarga";
            this.presionLineaDescarga.UseVisualStyleBackColor = true;
            // 
            // presionDisponibleMin
            // 
            this.presionDisponibleMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionDisponibleMin.Location = new System.Drawing.Point(3, 199);
            this.presionDisponibleMin.Name = "presionDisponibleMin";
            this.presionDisponibleMin.Size = new System.Drawing.Size(125, 27);
            this.presionDisponibleMin.TabIndex = 7;
            // 
            // presionLineaDescargaMin
            // 
            this.presionLineaDescargaMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionLineaDescargaMin.Location = new System.Drawing.Point(3, 116);
            this.presionLineaDescargaMin.Name = "presionLineaDescargaMin";
            this.presionLineaDescargaMin.Size = new System.Drawing.Size(125, 27);
            this.presionLineaDescargaMin.TabIndex = 13;
            // 
            // presionDisponibleMax
            // 
            this.presionDisponibleMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionDisponibleMax.Location = new System.Drawing.Point(134, 199);
            this.presionDisponibleMax.Name = "presionDisponibleMax";
            this.presionDisponibleMax.Size = new System.Drawing.Size(125, 27);
            this.presionDisponibleMax.TabIndex = 8;
            // 
            // presionLineaDescargaMax
            // 
            this.presionLineaDescargaMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionLineaDescargaMax.Location = new System.Drawing.Point(134, 116);
            this.presionLineaDescargaMax.Name = "presionLineaDescargaMax";
            this.presionLineaDescargaMax.Size = new System.Drawing.Size(125, 27);
            this.presionLineaDescargaMax.TabIndex = 14;
            // 
            // temperaturaSuperficie
            // 
            this.temperaturaSuperficie.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.temperaturaSuperficie, 2);
            this.temperaturaSuperficie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperaturaSuperficie.Location = new System.Drawing.Point(285, 86);
            this.temperaturaSuperficie.Name = "temperaturaSuperficie";
            this.temperaturaSuperficie.Size = new System.Drawing.Size(256, 24);
            this.temperaturaSuperficie.TabIndex = 15;
            this.temperaturaSuperficie.Text = "temperaturaSuperficie";
            this.temperaturaSuperficie.UseVisualStyleBackColor = true;
            // 
            // temperaturaSuperficieMin
            // 
            this.temperaturaSuperficieMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperaturaSuperficieMin.Location = new System.Drawing.Point(285, 116);
            this.temperaturaSuperficieMin.Name = "temperaturaSuperficieMin";
            this.temperaturaSuperficieMin.Size = new System.Drawing.Size(125, 27);
            this.temperaturaSuperficieMin.TabIndex = 16;
            // 
            // temperaturaSuperficieMax
            // 
            this.temperaturaSuperficieMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperaturaSuperficieMax.Location = new System.Drawing.Point(416, 116);
            this.temperaturaSuperficieMax.Name = "temperaturaSuperficieMax";
            this.temperaturaSuperficieMax.Size = new System.Drawing.Size(125, 27);
            this.temperaturaSuperficieMax.TabIndex = 17;
            // 
            // TomaInformacion
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TomaInformacion";
            this.Size = new System.Drawing.Size(596, 516);
            this.Load += new System.EventHandler(this.TomaInformacion_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tlpVariables.ResumeLayout(false);
            this.tlpVariables.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lbTemporizador1;
        private TextBox DatosOperativos;
        private TableLayoutPanel tlpVariables;
        private CheckBox presionTuberiaProduccion;
        private TextBox presionTuberiaProduccionMin;
        private TextBox presionTuberiaProduccionMax;
        private CheckBox presionTuberiaRevestimiento;
        private TextBox presionTuberiaRevestimientoMin;
        private TextBox presionTuberiaRevestimientoMax;
        private CheckBox presionLineaDescarga;
        private CheckBox temperaturaSuperficie;
        private TextBox presionLineaDescargaMin;
        private TextBox presionLineaDescargaMax;
        private TextBox temperaturaSuperficieMin;
        private TextBox temperaturaSuperficieMax;
        private CheckBox presionDisponible;
        private TextBox presionDisponibleMin;
        private TextBox presionDisponibleMax;
    }
}