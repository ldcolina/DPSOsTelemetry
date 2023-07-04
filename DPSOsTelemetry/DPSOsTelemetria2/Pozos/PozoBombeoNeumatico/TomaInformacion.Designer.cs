using System.Windows.Forms;

namespace DPSOsTelemetria2.Pozos.PozoBombeoNeumatico
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
            this.PresionTuberiaProduccion = new System.Windows.Forms.CheckBox();
            this.PresionTuberiaProduccionMin = new System.Windows.Forms.TextBox();
            this.PresionTuberiaProduccionMax = new System.Windows.Forms.TextBox();
            this.PresionTuberiaRevestimiento = new System.Windows.Forms.CheckBox();
            this.PresionTuberiaRevestimientoMin = new System.Windows.Forms.TextBox();
            this.PresionTuberiaRevestimientoMax = new System.Windows.Forms.TextBox();
            this.gravedadEspecificaGasInyeccion = new System.Windows.Forms.CheckBox();
            this.gravedadEspecificaGasInyeccionMin = new System.Windows.Forms.TextBox();
            this.gravedadEspecificaGasInyeccionMax = new System.Windows.Forms.TextBox();
            this.PresionDisponible = new System.Windows.Forms.CheckBox();
            this.PresionLineaDescarga = new System.Windows.Forms.CheckBox();
            this.PresionDisponibleMin = new System.Windows.Forms.TextBox();
            this.PresionLineaDescargaMin = new System.Windows.Forms.TextBox();
            this.PresionDisponibleMax = new System.Windows.Forms.TextBox();
            this.PresionLineaDescargaMax = new System.Windows.Forms.TextBox();
            this.gastoGasInyeccion = new System.Windows.Forms.CheckBox();
            this.TemperaturaSuperficie = new System.Windows.Forms.CheckBox();
            this.gastoGasInyeccionMin = new System.Windows.Forms.TextBox();
            this.TemperaturaSuperficieMin = new System.Windows.Forms.TextBox();
            this.gastoGasInyeccionMax = new System.Windows.Forms.TextBox();
            this.TemperaturaSuperficieMax = new System.Windows.Forms.TextBox();
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
            this.tlpVariables.Controls.Add(this.PresionTuberiaProduccion, 0, 0);
            this.tlpVariables.Controls.Add(this.PresionTuberiaProduccionMin, 0, 1);
            this.tlpVariables.Controls.Add(this.PresionTuberiaProduccionMax, 1, 1);
            this.tlpVariables.Controls.Add(this.PresionTuberiaRevestimiento, 3, 0);
            this.tlpVariables.Controls.Add(this.PresionTuberiaRevestimientoMin, 3, 1);
            this.tlpVariables.Controls.Add(this.PresionTuberiaRevestimientoMax, 4, 1);
            this.tlpVariables.Controls.Add(this.gravedadEspecificaGasInyeccion, 0, 9);
            this.tlpVariables.Controls.Add(this.gravedadEspecificaGasInyeccionMin, 0, 10);
            this.tlpVariables.Controls.Add(this.gravedadEspecificaGasInyeccionMax, 1, 10);
            this.tlpVariables.Controls.Add(this.PresionDisponible, 0, 6);
            this.tlpVariables.Controls.Add(this.PresionLineaDescarga, 0, 3);
            this.tlpVariables.Controls.Add(this.PresionDisponibleMin, 0, 7);
            this.tlpVariables.Controls.Add(this.PresionLineaDescargaMin, 0, 4);
            this.tlpVariables.Controls.Add(this.PresionDisponibleMax, 1, 7);
            this.tlpVariables.Controls.Add(this.PresionLineaDescargaMax, 1, 4);
            this.tlpVariables.Controls.Add(this.gastoGasInyeccion, 3, 6);
            this.tlpVariables.Controls.Add(this.TemperaturaSuperficie, 3, 3);
            this.tlpVariables.Controls.Add(this.gastoGasInyeccionMin, 3, 7);
            this.tlpVariables.Controls.Add(this.TemperaturaSuperficieMin, 3, 4);
            this.tlpVariables.Controls.Add(this.gastoGasInyeccionMax, 4, 7);
            this.tlpVariables.Controls.Add(this.TemperaturaSuperficieMax, 4, 4);
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
            // PresionTuberiaProduccion
            // 
            this.PresionTuberiaProduccion.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.PresionTuberiaProduccion, 2);
            this.PresionTuberiaProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaProduccion.Location = new System.Drawing.Point(3, 3);
            this.PresionTuberiaProduccion.Name = "PresionTuberiaProduccion";
            this.PresionTuberiaProduccion.Size = new System.Drawing.Size(256, 24);
            this.PresionTuberiaProduccion.TabIndex = 0;
            this.PresionTuberiaProduccion.Text = "PresionTuberiaProduccion";
            this.PresionTuberiaProduccion.UseVisualStyleBackColor = true;
            // 
            // PresionTuberiaProduccionMin
            // 
            this.PresionTuberiaProduccionMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaProduccionMin.Location = new System.Drawing.Point(3, 33);
            this.PresionTuberiaProduccionMin.Name = "PresionTuberiaProduccionMin";
            this.PresionTuberiaProduccionMin.Size = new System.Drawing.Size(125, 27);
            this.PresionTuberiaProduccionMin.TabIndex = 1;
            // 
            // PresionTuberiaProduccionMax
            // 
            this.PresionTuberiaProduccionMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaProduccionMax.Location = new System.Drawing.Point(134, 33);
            this.PresionTuberiaProduccionMax.Name = "PresionTuberiaProduccionMax";
            this.PresionTuberiaProduccionMax.Size = new System.Drawing.Size(125, 27);
            this.PresionTuberiaProduccionMax.TabIndex = 2;
            // 
            // PresionTuberiaRevestimiento
            // 
            this.PresionTuberiaRevestimiento.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.PresionTuberiaRevestimiento, 2);
            this.PresionTuberiaRevestimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaRevestimiento.Location = new System.Drawing.Point(285, 3);
            this.PresionTuberiaRevestimiento.Name = "PresionTuberiaRevestimiento";
            this.PresionTuberiaRevestimiento.Size = new System.Drawing.Size(256, 24);
            this.PresionTuberiaRevestimiento.TabIndex = 3;
            this.PresionTuberiaRevestimiento.Text = "PresionTuberiaRevestimiento";
            this.PresionTuberiaRevestimiento.UseVisualStyleBackColor = true;
            // 
            // PresionTuberiaRevestimientoMin
            // 
            this.PresionTuberiaRevestimientoMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaRevestimientoMin.Location = new System.Drawing.Point(285, 33);
            this.PresionTuberiaRevestimientoMin.Name = "PresionTuberiaRevestimientoMin";
            this.PresionTuberiaRevestimientoMin.Size = new System.Drawing.Size(125, 27);
            this.PresionTuberiaRevestimientoMin.TabIndex = 4;
            // 
            // PresionTuberiaRevestimientoMax
            // 
            this.PresionTuberiaRevestimientoMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaRevestimientoMax.Location = new System.Drawing.Point(416, 33);
            this.PresionTuberiaRevestimientoMax.Name = "PresionTuberiaRevestimientoMax";
            this.PresionTuberiaRevestimientoMax.Size = new System.Drawing.Size(125, 27);
            this.PresionTuberiaRevestimientoMax.TabIndex = 5;
            // 
            // gravedadEspecificaGasInyeccion
            // 
            this.gravedadEspecificaGasInyeccion.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.gravedadEspecificaGasInyeccion, 2);
            this.gravedadEspecificaGasInyeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gravedadEspecificaGasInyeccion.Location = new System.Drawing.Point(3, 252);
            this.gravedadEspecificaGasInyeccion.Name = "gravedadEspecificaGasInyeccion";
            this.gravedadEspecificaGasInyeccion.Size = new System.Drawing.Size(256, 24);
            this.gravedadEspecificaGasInyeccion.TabIndex = 18;
            this.gravedadEspecificaGasInyeccion.Text = "gravedadEspecificaGasInyeccion";
            this.gravedadEspecificaGasInyeccion.UseVisualStyleBackColor = true;
            // 
            // gravedadEspecificaGasInyeccionMin
            // 
            this.gravedadEspecificaGasInyeccionMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gravedadEspecificaGasInyeccionMin.Location = new System.Drawing.Point(3, 282);
            this.gravedadEspecificaGasInyeccionMin.Name = "gravedadEspecificaGasInyeccionMin";
            this.gravedadEspecificaGasInyeccionMin.Size = new System.Drawing.Size(125, 27);
            this.gravedadEspecificaGasInyeccionMin.TabIndex = 19;
            // 
            // gravedadEspecificaGasInyeccionMax
            // 
            this.gravedadEspecificaGasInyeccionMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gravedadEspecificaGasInyeccionMax.Location = new System.Drawing.Point(134, 282);
            this.gravedadEspecificaGasInyeccionMax.Name = "gravedadEspecificaGasInyeccionMax";
            this.gravedadEspecificaGasInyeccionMax.Size = new System.Drawing.Size(125, 27);
            this.gravedadEspecificaGasInyeccionMax.TabIndex = 20;
            // 
            // PresionDisponible
            // 
            this.PresionDisponible.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.PresionDisponible, 2);
            this.PresionDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionDisponible.Location = new System.Drawing.Point(3, 169);
            this.PresionDisponible.Name = "PresionDisponible";
            this.PresionDisponible.Size = new System.Drawing.Size(256, 24);
            this.PresionDisponible.TabIndex = 6;
            this.PresionDisponible.Text = "PresionDisponible";
            this.PresionDisponible.UseVisualStyleBackColor = true;
            // 
            // PresionLineaDescarga
            // 
            this.PresionLineaDescarga.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.PresionLineaDescarga, 2);
            this.PresionLineaDescarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionLineaDescarga.Location = new System.Drawing.Point(3, 86);
            this.PresionLineaDescarga.Name = "PresionLineaDescarga";
            this.PresionLineaDescarga.Size = new System.Drawing.Size(256, 24);
            this.PresionLineaDescarga.TabIndex = 12;
            this.PresionLineaDescarga.Text = "PresionLineaDescarga";
            this.PresionLineaDescarga.UseVisualStyleBackColor = true;
            // 
            // PresionDisponibleMin
            // 
            this.PresionDisponibleMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionDisponibleMin.Location = new System.Drawing.Point(3, 199);
            this.PresionDisponibleMin.Name = "PresionDisponibleMin";
            this.PresionDisponibleMin.Size = new System.Drawing.Size(125, 27);
            this.PresionDisponibleMin.TabIndex = 7;
            // 
            // PresionLineaDescargaMin
            // 
            this.PresionLineaDescargaMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionLineaDescargaMin.Location = new System.Drawing.Point(3, 116);
            this.PresionLineaDescargaMin.Name = "PresionLineaDescargaMin";
            this.PresionLineaDescargaMin.Size = new System.Drawing.Size(125, 27);
            this.PresionLineaDescargaMin.TabIndex = 13;
            // 
            // PresionDisponibleMax
            // 
            this.PresionDisponibleMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionDisponibleMax.Location = new System.Drawing.Point(134, 199);
            this.PresionDisponibleMax.Name = "PresionDisponibleMax";
            this.PresionDisponibleMax.Size = new System.Drawing.Size(125, 27);
            this.PresionDisponibleMax.TabIndex = 8;
            // 
            // PresionLineaDescargaMax
            // 
            this.PresionLineaDescargaMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionLineaDescargaMax.Location = new System.Drawing.Point(134, 116);
            this.PresionLineaDescargaMax.Name = "PresionLineaDescargaMax";
            this.PresionLineaDescargaMax.Size = new System.Drawing.Size(125, 27);
            this.PresionLineaDescargaMax.TabIndex = 14;
            // 
            // gastoGasInyeccion
            // 
            this.gastoGasInyeccion.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.gastoGasInyeccion, 2);
            this.gastoGasInyeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gastoGasInyeccion.Location = new System.Drawing.Point(285, 169);
            this.gastoGasInyeccion.Name = "gastoGasInyeccion";
            this.gastoGasInyeccion.Size = new System.Drawing.Size(256, 24);
            this.gastoGasInyeccion.TabIndex = 9;
            this.gastoGasInyeccion.Text = "gastoGasInyeccion";
            this.gastoGasInyeccion.UseVisualStyleBackColor = true;
            // 
            // TemperaturaSuperficie
            // 
            this.TemperaturaSuperficie.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.TemperaturaSuperficie, 2);
            this.TemperaturaSuperficie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemperaturaSuperficie.Location = new System.Drawing.Point(285, 86);
            this.TemperaturaSuperficie.Name = "TemperaturaSuperficie";
            this.TemperaturaSuperficie.Size = new System.Drawing.Size(256, 24);
            this.TemperaturaSuperficie.TabIndex = 15;
            this.TemperaturaSuperficie.Text = "TemperaturaSuperficie";
            this.TemperaturaSuperficie.UseVisualStyleBackColor = true;
            // 
            // gastoGasInyeccionMin
            // 
            this.gastoGasInyeccionMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gastoGasInyeccionMin.Location = new System.Drawing.Point(285, 199);
            this.gastoGasInyeccionMin.Name = "gastoGasInyeccionMin";
            this.gastoGasInyeccionMin.Size = new System.Drawing.Size(125, 27);
            this.gastoGasInyeccionMin.TabIndex = 10;
            // 
            // TemperaturaSuperficieMin
            // 
            this.TemperaturaSuperficieMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemperaturaSuperficieMin.Location = new System.Drawing.Point(285, 116);
            this.TemperaturaSuperficieMin.Name = "TemperaturaSuperficieMin";
            this.TemperaturaSuperficieMin.Size = new System.Drawing.Size(125, 27);
            this.TemperaturaSuperficieMin.TabIndex = 16;
            // 
            // gastoGasInyeccionMax
            // 
            this.gastoGasInyeccionMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gastoGasInyeccionMax.Location = new System.Drawing.Point(416, 199);
            this.gastoGasInyeccionMax.Name = "gastoGasInyeccionMax";
            this.gastoGasInyeccionMax.Size = new System.Drawing.Size(125, 27);
            this.gastoGasInyeccionMax.TabIndex = 11;
            // 
            // TemperaturaSuperficieMax
            // 
            this.TemperaturaSuperficieMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemperaturaSuperficieMax.Location = new System.Drawing.Point(416, 116);
            this.TemperaturaSuperficieMax.Name = "TemperaturaSuperficieMax";
            this.TemperaturaSuperficieMax.Size = new System.Drawing.Size(125, 27);
            this.TemperaturaSuperficieMax.TabIndex = 17;
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
        private CheckBox PresionTuberiaProduccion;
        private TextBox PresionTuberiaProduccionMin;
        private TextBox PresionTuberiaProduccionMax;
        private CheckBox PresionTuberiaRevestimiento;
        private TextBox PresionTuberiaRevestimientoMin;
        private TextBox PresionTuberiaRevestimientoMax;
        private CheckBox gastoGasInyeccion;
        private CheckBox PresionLineaDescarga;
        private CheckBox TemperaturaSuperficie;
        private TextBox gastoGasInyeccionMin;
        private TextBox gastoGasInyeccionMax;
        private TextBox PresionLineaDescargaMin;
        private TextBox PresionLineaDescargaMax;
        private TextBox TemperaturaSuperficieMin;
        private TextBox TemperaturaSuperficieMax;
        private CheckBox gravedadEspecificaGasInyeccion;
        private TextBox gravedadEspecificaGasInyeccionMin;
        private TextBox gravedadEspecificaGasInyeccionMax;
        private CheckBox PresionDisponible;
        private TextBox PresionDisponibleMin;
        private TextBox PresionDisponibleMax;
    }
}