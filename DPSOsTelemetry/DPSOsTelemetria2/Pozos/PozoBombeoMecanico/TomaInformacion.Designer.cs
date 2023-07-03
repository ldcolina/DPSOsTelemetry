using System.Windows.Forms;

namespace DPSOsTelemetria2.Pozos.PozoBombeoMecanico
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.presionEntradaBomba = new System.Windows.Forms.CheckBox();
            this.presionEntradaBombaMin = new System.Windows.Forms.TextBox();
            this.presionEntradaBombaMax = new System.Windows.Forms.TextBox();
            this.sumergenciaEfectivaBomba = new System.Windows.Forms.CheckBox();
            this.presionLineaDescarga = new System.Windows.Forms.CheckBox();
            this.sumergenciaEfectivaBombaMin = new System.Windows.Forms.TextBox();
            this.presionLineaDescargaMin = new System.Windows.Forms.TextBox();
            this.sumergenciaEfectivaBombaMax = new System.Windows.Forms.TextBox();
            this.presionLineaDescargaMax = new System.Windows.Forms.TextBox();
            this.nivelFluidoPozoTr = new System.Windows.Forms.CheckBox();
            this.temperaturaSuperficie = new System.Windows.Forms.CheckBox();
            this.nivelFluidoPozoTrMin = new System.Windows.Forms.TextBox();
            this.temperaturaSuperficieMin = new System.Windows.Forms.TextBox();
            this.nivelFluidoPozoTrMax = new System.Windows.Forms.TextBox();
            this.temperaturaSuperficieMax = new System.Windows.Forms.TextBox();
            this.velocidadUnidadBombeo = new System.Windows.Forms.CheckBox();
            this.velocidadUnidadBombeoMin = new System.Windows.Forms.TextBox();
            this.velocidadUnidadBombeoMax = new System.Windows.Forms.TextBox();
            this.velocidadMotor = new System.Windows.Forms.CheckBox();
            this.velocidadMotorMin = new System.Windows.Forms.TextBox();
            this.velocidadMotorMax = new System.Windows.Forms.TextBox();
            this.longitudCarrera = new System.Windows.Forms.CheckBox();
            this.longitudCarreraMin = new System.Windows.Forms.TextBox();
            this.longitudCarreraMax = new System.Windows.Forms.TextBox();
            this.eficienciaLlenado = new System.Windows.Forms.CheckBox();
            this.eficienciaLlenadoMin = new System.Windows.Forms.TextBox();
            this.eficienciaLlenadoMax = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTemporizador2 = new System.Windows.Forms.Label();
            this.CartaDinagrafica = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.CCartaDinagrafica = new System.Windows.Forms.CheckBox();
            this.CCartaDinagraficaList = new System.Windows.Forms.ComboBox();
            this.CCartaDinagraficaAgregar = new System.Windows.Forms.Button();
            this.CCartaDinagraficaEliminar = new System.Windows.Forms.Button();
            this.chart1 = new DevExpress.XtraCharts.ChartControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tlpVariables.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(606, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 528);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(554, 482);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 451);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(548, 28);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // lbTemporizador1
            // 
            this.lbTemporizador1.AutoSize = true;
            this.lbTemporizador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTemporizador1.Location = new System.Drawing.Point(3, 0);
            this.lbTemporizador1.Name = "lbTemporizador1";
            this.lbTemporizador1.Size = new System.Drawing.Size(110, 28);
            this.lbTemporizador1.TabIndex = 0;
            this.lbTemporizador1.Text = "lbTemporizador1";
            this.lbTemporizador1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DatosOperativos
            // 
            this.DatosOperativos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosOperativos.Location = new System.Drawing.Point(119, 3);
            this.DatosOperativos.Name = "DatosOperativos";
            this.DatosOperativos.Size = new System.Drawing.Size(426, 22);
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
            this.tlpVariables.Controls.Add(this.presionEntradaBomba, 0, 9);
            this.tlpVariables.Controls.Add(this.presionEntradaBombaMin, 0, 10);
            this.tlpVariables.Controls.Add(this.presionEntradaBombaMax, 1, 10);
            this.tlpVariables.Controls.Add(this.sumergenciaEfectivaBomba, 0, 6);
            this.tlpVariables.Controls.Add(this.presionLineaDescarga, 0, 3);
            this.tlpVariables.Controls.Add(this.sumergenciaEfectivaBombaMin, 0, 7);
            this.tlpVariables.Controls.Add(this.presionLineaDescargaMin, 0, 4);
            this.tlpVariables.Controls.Add(this.sumergenciaEfectivaBombaMax, 1, 7);
            this.tlpVariables.Controls.Add(this.presionLineaDescargaMax, 1, 4);
            this.tlpVariables.Controls.Add(this.nivelFluidoPozoTr, 3, 6);
            this.tlpVariables.Controls.Add(this.temperaturaSuperficie, 3, 3);
            this.tlpVariables.Controls.Add(this.nivelFluidoPozoTrMin, 3, 7);
            this.tlpVariables.Controls.Add(this.temperaturaSuperficieMin, 3, 4);
            this.tlpVariables.Controls.Add(this.nivelFluidoPozoTrMax, 4, 7);
            this.tlpVariables.Controls.Add(this.temperaturaSuperficieMax, 4, 4);
            this.tlpVariables.Controls.Add(this.velocidadUnidadBombeo, 3, 9);
            this.tlpVariables.Controls.Add(this.velocidadUnidadBombeoMin, 3, 10);
            this.tlpVariables.Controls.Add(this.velocidadUnidadBombeoMax, 4, 10);
            this.tlpVariables.Controls.Add(this.velocidadMotor, 0, 12);
            this.tlpVariables.Controls.Add(this.velocidadMotorMin, 0, 13);
            this.tlpVariables.Controls.Add(this.velocidadMotorMax, 1, 13);
            this.tlpVariables.Controls.Add(this.longitudCarrera, 3, 12);
            this.tlpVariables.Controls.Add(this.longitudCarreraMin, 3, 13);
            this.tlpVariables.Controls.Add(this.longitudCarreraMax, 4, 13);
            this.tlpVariables.Controls.Add(this.eficienciaLlenado, 0, 15);
            this.tlpVariables.Controls.Add(this.eficienciaLlenadoMin, 0, 16);
            this.tlpVariables.Controls.Add(this.eficienciaLlenadoMax, 1, 16);
            this.tlpVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVariables.Location = new System.Drawing.Point(3, 3);
            this.tlpVariables.Name = "tlpVariables";
            this.tlpVariables.RowCount = 18;
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
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.Size = new System.Drawing.Size(548, 442);
            this.tlpVariables.TabIndex = 3;
            // 
            // presionTuberiaProduccion
            // 
            this.presionTuberiaProduccion.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.presionTuberiaProduccion, 2);
            this.presionTuberiaProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionTuberiaProduccion.Location = new System.Drawing.Point(3, 3);
            this.presionTuberiaProduccion.Name = "presionTuberiaProduccion";
            this.presionTuberiaProduccion.Size = new System.Drawing.Size(258, 20);
            this.presionTuberiaProduccion.TabIndex = 0;
            this.presionTuberiaProduccion.Text = "presionTuberiaProduccion";
            this.presionTuberiaProduccion.UseVisualStyleBackColor = true;
            // 
            // presionTuberiaProduccionMin
            // 
            this.presionTuberiaProduccionMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionTuberiaProduccionMin.Location = new System.Drawing.Point(3, 29);
            this.presionTuberiaProduccionMin.Name = "presionTuberiaProduccionMin";
            this.presionTuberiaProduccionMin.Size = new System.Drawing.Size(126, 22);
            this.presionTuberiaProduccionMin.TabIndex = 1;
            // 
            // presionTuberiaProduccionMax
            // 
            this.presionTuberiaProduccionMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionTuberiaProduccionMax.Location = new System.Drawing.Point(135, 29);
            this.presionTuberiaProduccionMax.Name = "presionTuberiaProduccionMax";
            this.presionTuberiaProduccionMax.Size = new System.Drawing.Size(126, 22);
            this.presionTuberiaProduccionMax.TabIndex = 2;
            // 
            // presionTuberiaRevestimiento
            // 
            this.presionTuberiaRevestimiento.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.presionTuberiaRevestimiento, 2);
            this.presionTuberiaRevestimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionTuberiaRevestimiento.Location = new System.Drawing.Point(287, 3);
            this.presionTuberiaRevestimiento.Name = "presionTuberiaRevestimiento";
            this.presionTuberiaRevestimiento.Size = new System.Drawing.Size(258, 20);
            this.presionTuberiaRevestimiento.TabIndex = 3;
            this.presionTuberiaRevestimiento.Text = "presionTuberiaRevestimiento";
            this.presionTuberiaRevestimiento.UseVisualStyleBackColor = true;
            // 
            // presionTuberiaRevestimientoMin
            // 
            this.presionTuberiaRevestimientoMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionTuberiaRevestimientoMin.Location = new System.Drawing.Point(287, 29);
            this.presionTuberiaRevestimientoMin.Name = "presionTuberiaRevestimientoMin";
            this.presionTuberiaRevestimientoMin.Size = new System.Drawing.Size(126, 22);
            this.presionTuberiaRevestimientoMin.TabIndex = 4;
            // 
            // presionTuberiaRevestimientoMax
            // 
            this.presionTuberiaRevestimientoMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionTuberiaRevestimientoMax.Location = new System.Drawing.Point(419, 29);
            this.presionTuberiaRevestimientoMax.Name = "presionTuberiaRevestimientoMax";
            this.presionTuberiaRevestimientoMax.Size = new System.Drawing.Size(126, 22);
            this.presionTuberiaRevestimientoMax.TabIndex = 5;
            // 
            // presionEntradaBomba
            // 
            this.presionEntradaBomba.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.presionEntradaBomba, 2);
            this.presionEntradaBomba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionEntradaBomba.Location = new System.Drawing.Point(3, 225);
            this.presionEntradaBomba.Name = "presionEntradaBomba";
            this.presionEntradaBomba.Size = new System.Drawing.Size(258, 20);
            this.presionEntradaBomba.TabIndex = 18;
            this.presionEntradaBomba.Text = "presionEntradaBomba";
            this.presionEntradaBomba.UseVisualStyleBackColor = true;
            // 
            // presionEntradaBombaMin
            // 
            this.presionEntradaBombaMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionEntradaBombaMin.Location = new System.Drawing.Point(3, 251);
            this.presionEntradaBombaMin.Name = "presionEntradaBombaMin";
            this.presionEntradaBombaMin.Size = new System.Drawing.Size(126, 22);
            this.presionEntradaBombaMin.TabIndex = 19;
            // 
            // presionEntradaBombaMax
            // 
            this.presionEntradaBombaMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionEntradaBombaMax.Location = new System.Drawing.Point(135, 251);
            this.presionEntradaBombaMax.Name = "presionEntradaBombaMax";
            this.presionEntradaBombaMax.Size = new System.Drawing.Size(126, 22);
            this.presionEntradaBombaMax.TabIndex = 20;
            // 
            // sumergenciaEfectivaBomba
            // 
            this.sumergenciaEfectivaBomba.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.sumergenciaEfectivaBomba, 2);
            this.sumergenciaEfectivaBomba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sumergenciaEfectivaBomba.Location = new System.Drawing.Point(3, 151);
            this.sumergenciaEfectivaBomba.Name = "sumergenciaEfectivaBomba";
            this.sumergenciaEfectivaBomba.Size = new System.Drawing.Size(258, 20);
            this.sumergenciaEfectivaBomba.TabIndex = 12;
            this.sumergenciaEfectivaBomba.Text = "sumergenciaEfectivaBomba";
            this.sumergenciaEfectivaBomba.UseVisualStyleBackColor = true;
            // 
            // presionLineaDescarga
            // 
            this.presionLineaDescarga.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.presionLineaDescarga, 2);
            this.presionLineaDescarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionLineaDescarga.Location = new System.Drawing.Point(3, 77);
            this.presionLineaDescarga.Name = "presionLineaDescarga";
            this.presionLineaDescarga.Size = new System.Drawing.Size(258, 20);
            this.presionLineaDescarga.TabIndex = 6;
            this.presionLineaDescarga.Text = "presionLineaDescarga";
            this.presionLineaDescarga.UseVisualStyleBackColor = true;
            // 
            // sumergenciaEfectivaBombaMin
            // 
            this.sumergenciaEfectivaBombaMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sumergenciaEfectivaBombaMin.Location = new System.Drawing.Point(3, 177);
            this.sumergenciaEfectivaBombaMin.Name = "sumergenciaEfectivaBombaMin";
            this.sumergenciaEfectivaBombaMin.Size = new System.Drawing.Size(126, 22);
            this.sumergenciaEfectivaBombaMin.TabIndex = 13;
            // 
            // presionLineaDescargaMin
            // 
            this.presionLineaDescargaMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionLineaDescargaMin.Location = new System.Drawing.Point(3, 103);
            this.presionLineaDescargaMin.Name = "presionLineaDescargaMin";
            this.presionLineaDescargaMin.Size = new System.Drawing.Size(126, 22);
            this.presionLineaDescargaMin.TabIndex = 7;
            // 
            // sumergenciaEfectivaBombaMax
            // 
            this.sumergenciaEfectivaBombaMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sumergenciaEfectivaBombaMax.Location = new System.Drawing.Point(135, 177);
            this.sumergenciaEfectivaBombaMax.Name = "sumergenciaEfectivaBombaMax";
            this.sumergenciaEfectivaBombaMax.Size = new System.Drawing.Size(126, 22);
            this.sumergenciaEfectivaBombaMax.TabIndex = 14;
            // 
            // presionLineaDescargaMax
            // 
            this.presionLineaDescargaMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presionLineaDescargaMax.Location = new System.Drawing.Point(135, 103);
            this.presionLineaDescargaMax.Name = "presionLineaDescargaMax";
            this.presionLineaDescargaMax.Size = new System.Drawing.Size(126, 22);
            this.presionLineaDescargaMax.TabIndex = 8;
            // 
            // nivelFluidoPozoTr
            // 
            this.nivelFluidoPozoTr.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.nivelFluidoPozoTr, 2);
            this.nivelFluidoPozoTr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nivelFluidoPozoTr.Location = new System.Drawing.Point(287, 151);
            this.nivelFluidoPozoTr.Name = "nivelFluidoPozoTr";
            this.nivelFluidoPozoTr.Size = new System.Drawing.Size(258, 20);
            this.nivelFluidoPozoTr.TabIndex = 15;
            this.nivelFluidoPozoTr.Text = "nivelFluidoPozoTr";
            this.nivelFluidoPozoTr.UseVisualStyleBackColor = true;
            // 
            // temperaturaSuperficie
            // 
            this.temperaturaSuperficie.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.temperaturaSuperficie, 2);
            this.temperaturaSuperficie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperaturaSuperficie.Location = new System.Drawing.Point(287, 77);
            this.temperaturaSuperficie.Name = "temperaturaSuperficie";
            this.temperaturaSuperficie.Size = new System.Drawing.Size(258, 20);
            this.temperaturaSuperficie.TabIndex = 9;
            this.temperaturaSuperficie.Text = "temperaturaSuperficie";
            this.temperaturaSuperficie.UseVisualStyleBackColor = true;
            // 
            // nivelFluidoPozoTrMin
            // 
            this.nivelFluidoPozoTrMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nivelFluidoPozoTrMin.Location = new System.Drawing.Point(287, 177);
            this.nivelFluidoPozoTrMin.Name = "nivelFluidoPozoTrMin";
            this.nivelFluidoPozoTrMin.Size = new System.Drawing.Size(126, 22);
            this.nivelFluidoPozoTrMin.TabIndex = 16;
            // 
            // temperaturaSuperficieMin
            // 
            this.temperaturaSuperficieMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperaturaSuperficieMin.Location = new System.Drawing.Point(287, 103);
            this.temperaturaSuperficieMin.Name = "temperaturaSuperficieMin";
            this.temperaturaSuperficieMin.Size = new System.Drawing.Size(126, 22);
            this.temperaturaSuperficieMin.TabIndex = 10;
            // 
            // nivelFluidoPozoTrMax
            // 
            this.nivelFluidoPozoTrMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nivelFluidoPozoTrMax.Location = new System.Drawing.Point(419, 177);
            this.nivelFluidoPozoTrMax.Name = "nivelFluidoPozoTrMax";
            this.nivelFluidoPozoTrMax.Size = new System.Drawing.Size(126, 22);
            this.nivelFluidoPozoTrMax.TabIndex = 17;
            // 
            // temperaturaSuperficieMax
            // 
            this.temperaturaSuperficieMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperaturaSuperficieMax.Location = new System.Drawing.Point(419, 103);
            this.temperaturaSuperficieMax.Name = "temperaturaSuperficieMax";
            this.temperaturaSuperficieMax.Size = new System.Drawing.Size(126, 22);
            this.temperaturaSuperficieMax.TabIndex = 11;
            // 
            // velocidadUnidadBombeo
            // 
            this.velocidadUnidadBombeo.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.velocidadUnidadBombeo, 2);
            this.velocidadUnidadBombeo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.velocidadUnidadBombeo.Location = new System.Drawing.Point(287, 225);
            this.velocidadUnidadBombeo.Name = "velocidadUnidadBombeo";
            this.velocidadUnidadBombeo.Size = new System.Drawing.Size(258, 20);
            this.velocidadUnidadBombeo.TabIndex = 21;
            this.velocidadUnidadBombeo.Text = "velocidadUnidadBombeo";
            this.velocidadUnidadBombeo.UseVisualStyleBackColor = true;
            // 
            // velocidadUnidadBombeoMin
            // 
            this.velocidadUnidadBombeoMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.velocidadUnidadBombeoMin.Location = new System.Drawing.Point(287, 251);
            this.velocidadUnidadBombeoMin.Name = "velocidadUnidadBombeoMin";
            this.velocidadUnidadBombeoMin.Size = new System.Drawing.Size(126, 22);
            this.velocidadUnidadBombeoMin.TabIndex = 22;
            // 
            // velocidadUnidadBombeoMax
            // 
            this.velocidadUnidadBombeoMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.velocidadUnidadBombeoMax.Location = new System.Drawing.Point(419, 251);
            this.velocidadUnidadBombeoMax.Name = "velocidadUnidadBombeoMax";
            this.velocidadUnidadBombeoMax.Size = new System.Drawing.Size(126, 22);
            this.velocidadUnidadBombeoMax.TabIndex = 23;
            // 
            // velocidadMotor
            // 
            this.velocidadMotor.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.velocidadMotor, 2);
            this.velocidadMotor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.velocidadMotor.Location = new System.Drawing.Point(3, 299);
            this.velocidadMotor.Name = "velocidadMotor";
            this.velocidadMotor.Size = new System.Drawing.Size(258, 20);
            this.velocidadMotor.TabIndex = 24;
            this.velocidadMotor.Text = "velocidadMotor";
            this.velocidadMotor.UseVisualStyleBackColor = true;
            // 
            // velocidadMotorMin
            // 
            this.velocidadMotorMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.velocidadMotorMin.Location = new System.Drawing.Point(3, 325);
            this.velocidadMotorMin.Name = "velocidadMotorMin";
            this.velocidadMotorMin.Size = new System.Drawing.Size(126, 22);
            this.velocidadMotorMin.TabIndex = 25;
            // 
            // velocidadMotorMax
            // 
            this.velocidadMotorMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.velocidadMotorMax.Location = new System.Drawing.Point(135, 325);
            this.velocidadMotorMax.Name = "velocidadMotorMax";
            this.velocidadMotorMax.Size = new System.Drawing.Size(126, 22);
            this.velocidadMotorMax.TabIndex = 26;
            // 
            // longitudCarrera
            // 
            this.longitudCarrera.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.longitudCarrera, 2);
            this.longitudCarrera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.longitudCarrera.Location = new System.Drawing.Point(287, 299);
            this.longitudCarrera.Name = "longitudCarrera";
            this.longitudCarrera.Size = new System.Drawing.Size(258, 20);
            this.longitudCarrera.TabIndex = 27;
            this.longitudCarrera.Text = "longitudCarrera";
            this.longitudCarrera.UseVisualStyleBackColor = true;
            // 
            // longitudCarreraMin
            // 
            this.longitudCarreraMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.longitudCarreraMin.Location = new System.Drawing.Point(287, 325);
            this.longitudCarreraMin.Name = "longitudCarreraMin";
            this.longitudCarreraMin.Size = new System.Drawing.Size(126, 22);
            this.longitudCarreraMin.TabIndex = 28;
            // 
            // longitudCarreraMax
            // 
            this.longitudCarreraMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.longitudCarreraMax.Location = new System.Drawing.Point(419, 325);
            this.longitudCarreraMax.Name = "longitudCarreraMax";
            this.longitudCarreraMax.Size = new System.Drawing.Size(126, 22);
            this.longitudCarreraMax.TabIndex = 29;
            // 
            // eficienciaLlenado
            // 
            this.eficienciaLlenado.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.eficienciaLlenado, 2);
            this.eficienciaLlenado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eficienciaLlenado.Location = new System.Drawing.Point(3, 373);
            this.eficienciaLlenado.Name = "eficienciaLlenado";
            this.eficienciaLlenado.Size = new System.Drawing.Size(258, 20);
            this.eficienciaLlenado.TabIndex = 30;
            this.eficienciaLlenado.Text = "eficienciaLlenado";
            this.eficienciaLlenado.UseVisualStyleBackColor = true;
            // 
            // eficienciaLlenadoMin
            // 
            this.eficienciaLlenadoMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eficienciaLlenadoMin.Location = new System.Drawing.Point(3, 399);
            this.eficienciaLlenadoMin.Name = "eficienciaLlenadoMin";
            this.eficienciaLlenadoMin.Size = new System.Drawing.Size(126, 22);
            this.eficienciaLlenadoMin.TabIndex = 31;
            // 
            // eficienciaLlenadoMax
            // 
            this.eficienciaLlenadoMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eficienciaLlenadoMax.Location = new System.Drawing.Point(135, 399);
            this.eficienciaLlenadoMax.Name = "eficienciaLlenadoMax";
            this.eficienciaLlenadoMax.Size = new System.Drawing.Size(126, 22);
            this.eficienciaLlenadoMax.TabIndex = 32;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(606, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(600, 528);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(23, 23);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(554, 482);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.lbTemporizador2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.CartaDinagrafica, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 451);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(548, 28);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // lbTemporizador2
            // 
            this.lbTemporizador2.AutoSize = true;
            this.lbTemporizador2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTemporizador2.Location = new System.Drawing.Point(3, 0);
            this.lbTemporizador2.Name = "lbTemporizador2";
            this.lbTemporizador2.Size = new System.Drawing.Size(110, 28);
            this.lbTemporizador2.TabIndex = 0;
            this.lbTemporizador2.Text = "lbTemporizador2";
            this.lbTemporizador2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CartaDinagrafica
            // 
            this.CartaDinagrafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartaDinagrafica.Location = new System.Drawing.Point(119, 3);
            this.CartaDinagrafica.Name = "CartaDinagrafica";
            this.CartaDinagrafica.Size = new System.Drawing.Size(426, 22);
            this.CartaDinagrafica.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoScroll = true;
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.CCartaDinagrafica, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.CCartaDinagraficaList, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.CCartaDinagraficaAgregar, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.CCartaDinagraficaEliminar, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.chart1, 2, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 6;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(548, 442);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // CCartaDinagrafica
            // 
            this.CCartaDinagrafica.AutoSize = true;
            this.CCartaDinagrafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CCartaDinagrafica.Location = new System.Drawing.Point(3, 3);
            this.CCartaDinagrafica.Name = "CCartaDinagrafica";
            this.CCartaDinagrafica.Size = new System.Drawing.Size(194, 20);
            this.CCartaDinagrafica.TabIndex = 0;
            this.CCartaDinagrafica.Text = "CCartaDinagrafica";
            this.CCartaDinagrafica.UseVisualStyleBackColor = true;
            this.CCartaDinagrafica.CheckedChanged += new System.EventHandler(this.CCartaDinagrafica_CheckedChanged);
            // 
            // CCartaDinagraficaList
            // 
            this.CCartaDinagraficaList.Dock = System.Windows.Forms.DockStyle.Top;
            this.CCartaDinagraficaList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CCartaDinagraficaList.FormattingEnabled = true;
            this.CCartaDinagraficaList.Location = new System.Drawing.Point(3, 29);
            this.CCartaDinagraficaList.Name = "CCartaDinagraficaList";
            this.CCartaDinagraficaList.Size = new System.Drawing.Size(194, 24);
            this.CCartaDinagraficaList.TabIndex = 1;
            this.CCartaDinagraficaList.SelectedIndexChanged += new System.EventHandler(this.CCartaDinagraficaList_SelectedIndexChanged);
            // 
            // CCartaDinagraficaAgregar
            // 
            this.CCartaDinagraficaAgregar.AutoSize = true;
            this.CCartaDinagraficaAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CCartaDinagraficaAgregar.Location = new System.Drawing.Point(3, 79);
            this.CCartaDinagraficaAgregar.Name = "CCartaDinagraficaAgregar";
            this.CCartaDinagraficaAgregar.Size = new System.Drawing.Size(194, 30);
            this.CCartaDinagraficaAgregar.TabIndex = 2;
            this.CCartaDinagraficaAgregar.Text = "CCartaDinagraficaAgregar";
            this.CCartaDinagraficaAgregar.UseVisualStyleBackColor = true;
            this.CCartaDinagraficaAgregar.Click += new System.EventHandler(this.CCartaDinagraficaAgregar_Click);
            // 
            // CCartaDinagraficaEliminar
            // 
            this.CCartaDinagraficaEliminar.AutoSize = true;
            this.CCartaDinagraficaEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CCartaDinagraficaEliminar.Location = new System.Drawing.Point(3, 115);
            this.CCartaDinagraficaEliminar.Name = "CCartaDinagraficaEliminar";
            this.CCartaDinagraficaEliminar.Size = new System.Drawing.Size(194, 30);
            this.CCartaDinagraficaEliminar.TabIndex = 3;
            this.CCartaDinagraficaEliminar.Text = "CCartaDinagraficaEliminar";
            this.CCartaDinagraficaEliminar.UseVisualStyleBackColor = true;
            this.CCartaDinagraficaEliminar.Click += new System.EventHandler(this.CCartaDinagraficaEliminar_Click);
            // 
            // chart1
            // 
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Legend.Name = "Default Legend";
            this.chart1.Location = new System.Drawing.Point(216, 3);
            this.chart1.Name = "chart1";
            this.tableLayoutPanel7.SetRowSpan(this.chart1, 6);
            this.chart1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart1.Size = new System.Drawing.Size(329, 436);
            this.chart1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TomaInformacion
            // 
            this.Controls.Add(this.tabControl1);
            this.Name = "TomaInformacion";
            this.Size = new System.Drawing.Size(614, 563);
            this.Load += new System.EventHandler(this.TomaInformacion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tlpVariables.ResumeLayout(false);
            this.tlpVariables.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
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
        private CheckBox presionEntradaBomba;
        private TextBox presionEntradaBombaMin;
        private TextBox presionEntradaBombaMax;
        private CheckBox sumergenciaEfectivaBomba;
        private CheckBox presionLineaDescarga;
        private TextBox sumergenciaEfectivaBombaMin;
        private TextBox presionLineaDescargaMin;
        private TextBox sumergenciaEfectivaBombaMax;
        private TextBox presionLineaDescargaMax;
        private CheckBox nivelFluidoPozoTr;
        private CheckBox temperaturaSuperficie;
        private TextBox nivelFluidoPozoTrMin;
        private TextBox temperaturaSuperficieMin;
        private TextBox nivelFluidoPozoTrMax;
        private TextBox temperaturaSuperficieMax;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lbTemporizador2;
        private TextBox CartaDinagrafica;
        private TableLayoutPanel tableLayoutPanel7;
        private CheckBox CCartaDinagrafica;
        private CheckBox velocidadUnidadBombeo;
        private TextBox velocidadUnidadBombeoMin;
        private TextBox velocidadUnidadBombeoMax;
        private CheckBox velocidadMotor;
        private TextBox velocidadMotorMin;
        private TextBox velocidadMotorMax;
        private CheckBox longitudCarrera;
        private TextBox longitudCarreraMin;
        private TextBox longitudCarreraMax;
        private CheckBox eficienciaLlenado;
        private TextBox eficienciaLlenadoMin;
        private TextBox eficienciaLlenadoMax;
        private ComboBox CCartaDinagraficaList;
        private Button CCartaDinagraficaAgregar;
        private Button CCartaDinagraficaEliminar;
        private OpenFileDialog openFileDialog1;
        internal DevExpress.XtraCharts.ChartControl chart1;
    }
}