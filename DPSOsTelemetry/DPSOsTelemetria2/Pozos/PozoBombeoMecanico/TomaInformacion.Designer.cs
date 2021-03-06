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
            this.DoPresionTuberiaProduccion = new System.Windows.Forms.CheckBox();
            this.DoPresionTuberiaProduccionMin = new System.Windows.Forms.TextBox();
            this.DoPresionTuberiaProduccionMax = new System.Windows.Forms.TextBox();
            this.DoPresionTuberiaRevestimiento = new System.Windows.Forms.CheckBox();
            this.DoPresionTuberiaRevestimientoMin = new System.Windows.Forms.TextBox();
            this.DoPresionTuberiaRevestimientoMax = new System.Windows.Forms.TextBox();
            this.DoPresionEntradaBomba = new System.Windows.Forms.CheckBox();
            this.DoPresionEntradaBombaMin = new System.Windows.Forms.TextBox();
            this.DoPresionEntradaBombaMax = new System.Windows.Forms.TextBox();
            this.DoSumergenciaEfectivaBomba = new System.Windows.Forms.CheckBox();
            this.DoPresionLineaDescarga = new System.Windows.Forms.CheckBox();
            this.DoSumergenciaEfectivaBombaMin = new System.Windows.Forms.TextBox();
            this.DoPresionLineaDescargaMin = new System.Windows.Forms.TextBox();
            this.DoSumergenciaEfectivaBombaMax = new System.Windows.Forms.TextBox();
            this.DoPresionLineaDescargaMax = new System.Windows.Forms.TextBox();
            this.DoNivelFluidoPozoTr = new System.Windows.Forms.CheckBox();
            this.DoTemperaturaSuperficie = new System.Windows.Forms.CheckBox();
            this.DoNivelFluidoPozoTrMin = new System.Windows.Forms.TextBox();
            this.DoTemperaturaSuperficieMin = new System.Windows.Forms.TextBox();
            this.DoNivelFluidoPozoTrMax = new System.Windows.Forms.TextBox();
            this.DoTemperaturaSuperficieMax = new System.Windows.Forms.TextBox();
            this.DoVelocidadUnidadBombeo = new System.Windows.Forms.CheckBox();
            this.DoVelocidadUnidadBombeoMin = new System.Windows.Forms.TextBox();
            this.DoVelocidadUnidadBombeoMax = new System.Windows.Forms.TextBox();
            this.DoVelocidadMotor = new System.Windows.Forms.CheckBox();
            this.DoVelocidadMotorMin = new System.Windows.Forms.TextBox();
            this.DoVelocidadMotorMax = new System.Windows.Forms.TextBox();
            this.DoLongitudCarrera = new System.Windows.Forms.CheckBox();
            this.DoLongitudCarreraMin = new System.Windows.Forms.TextBox();
            this.DoLongitudCarreraMax = new System.Windows.Forms.TextBox();
            this.DoEficienciaLlenado = new System.Windows.Forms.CheckBox();
            this.DoEficienciaLlenadoMin = new System.Windows.Forms.TextBox();
            this.DoEficienciaLlenadoMax = new System.Windows.Forms.TextBox();
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
            this.tlpVariables.Controls.Add(this.DoPresionTuberiaProduccion, 0, 0);
            this.tlpVariables.Controls.Add(this.DoPresionTuberiaProduccionMin, 0, 1);
            this.tlpVariables.Controls.Add(this.DoPresionTuberiaProduccionMax, 1, 1);
            this.tlpVariables.Controls.Add(this.DoPresionTuberiaRevestimiento, 3, 0);
            this.tlpVariables.Controls.Add(this.DoPresionTuberiaRevestimientoMin, 3, 1);
            this.tlpVariables.Controls.Add(this.DoPresionTuberiaRevestimientoMax, 4, 1);
            this.tlpVariables.Controls.Add(this.DoPresionEntradaBomba, 0, 9);
            this.tlpVariables.Controls.Add(this.DoPresionEntradaBombaMin, 0, 10);
            this.tlpVariables.Controls.Add(this.DoPresionEntradaBombaMax, 1, 10);
            this.tlpVariables.Controls.Add(this.DoSumergenciaEfectivaBomba, 0, 6);
            this.tlpVariables.Controls.Add(this.DoPresionLineaDescarga, 0, 3);
            this.tlpVariables.Controls.Add(this.DoSumergenciaEfectivaBombaMin, 0, 7);
            this.tlpVariables.Controls.Add(this.DoPresionLineaDescargaMin, 0, 4);
            this.tlpVariables.Controls.Add(this.DoSumergenciaEfectivaBombaMax, 1, 7);
            this.tlpVariables.Controls.Add(this.DoPresionLineaDescargaMax, 1, 4);
            this.tlpVariables.Controls.Add(this.DoNivelFluidoPozoTr, 3, 6);
            this.tlpVariables.Controls.Add(this.DoTemperaturaSuperficie, 3, 3);
            this.tlpVariables.Controls.Add(this.DoNivelFluidoPozoTrMin, 3, 7);
            this.tlpVariables.Controls.Add(this.DoTemperaturaSuperficieMin, 3, 4);
            this.tlpVariables.Controls.Add(this.DoNivelFluidoPozoTrMax, 4, 7);
            this.tlpVariables.Controls.Add(this.DoTemperaturaSuperficieMax, 4, 4);
            this.tlpVariables.Controls.Add(this.DoVelocidadUnidadBombeo, 3, 9);
            this.tlpVariables.Controls.Add(this.DoVelocidadUnidadBombeoMin, 3, 10);
            this.tlpVariables.Controls.Add(this.DoVelocidadUnidadBombeoMax, 4, 10);
            this.tlpVariables.Controls.Add(this.DoVelocidadMotor, 0, 12);
            this.tlpVariables.Controls.Add(this.DoVelocidadMotorMin, 0, 13);
            this.tlpVariables.Controls.Add(this.DoVelocidadMotorMax, 1, 13);
            this.tlpVariables.Controls.Add(this.DoLongitudCarrera, 3, 12);
            this.tlpVariables.Controls.Add(this.DoLongitudCarreraMin, 3, 13);
            this.tlpVariables.Controls.Add(this.DoLongitudCarreraMax, 4, 13);
            this.tlpVariables.Controls.Add(this.DoEficienciaLlenado, 0, 15);
            this.tlpVariables.Controls.Add(this.DoEficienciaLlenadoMin, 0, 16);
            this.tlpVariables.Controls.Add(this.DoEficienciaLlenadoMax, 1, 16);
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
            // DoPresionTuberiaProduccion
            // 
            this.DoPresionTuberiaProduccion.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoPresionTuberiaProduccion, 2);
            this.DoPresionTuberiaProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionTuberiaProduccion.Location = new System.Drawing.Point(3, 3);
            this.DoPresionTuberiaProduccion.Name = "DoPresionTuberiaProduccion";
            this.DoPresionTuberiaProduccion.Size = new System.Drawing.Size(258, 20);
            this.DoPresionTuberiaProduccion.TabIndex = 0;
            this.DoPresionTuberiaProduccion.Text = "DoPresionTuberiaProduccion";
            this.DoPresionTuberiaProduccion.UseVisualStyleBackColor = true;
            // 
            // DoPresionTuberiaProduccionMin
            // 
            this.DoPresionTuberiaProduccionMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionTuberiaProduccionMin.Location = new System.Drawing.Point(3, 29);
            this.DoPresionTuberiaProduccionMin.Name = "DoPresionTuberiaProduccionMin";
            this.DoPresionTuberiaProduccionMin.Size = new System.Drawing.Size(126, 22);
            this.DoPresionTuberiaProduccionMin.TabIndex = 1;
            // 
            // DoPresionTuberiaProduccionMax
            // 
            this.DoPresionTuberiaProduccionMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionTuberiaProduccionMax.Location = new System.Drawing.Point(135, 29);
            this.DoPresionTuberiaProduccionMax.Name = "DoPresionTuberiaProduccionMax";
            this.DoPresionTuberiaProduccionMax.Size = new System.Drawing.Size(126, 22);
            this.DoPresionTuberiaProduccionMax.TabIndex = 2;
            // 
            // DoPresionTuberiaRevestimiento
            // 
            this.DoPresionTuberiaRevestimiento.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoPresionTuberiaRevestimiento, 2);
            this.DoPresionTuberiaRevestimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionTuberiaRevestimiento.Location = new System.Drawing.Point(287, 3);
            this.DoPresionTuberiaRevestimiento.Name = "DoPresionTuberiaRevestimiento";
            this.DoPresionTuberiaRevestimiento.Size = new System.Drawing.Size(258, 20);
            this.DoPresionTuberiaRevestimiento.TabIndex = 3;
            this.DoPresionTuberiaRevestimiento.Text = "DoPresionTuberiaRevestimiento";
            this.DoPresionTuberiaRevestimiento.UseVisualStyleBackColor = true;
            // 
            // DoPresionTuberiaRevestimientoMin
            // 
            this.DoPresionTuberiaRevestimientoMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionTuberiaRevestimientoMin.Location = new System.Drawing.Point(287, 29);
            this.DoPresionTuberiaRevestimientoMin.Name = "DoPresionTuberiaRevestimientoMin";
            this.DoPresionTuberiaRevestimientoMin.Size = new System.Drawing.Size(126, 22);
            this.DoPresionTuberiaRevestimientoMin.TabIndex = 4;
            // 
            // DoPresionTuberiaRevestimientoMax
            // 
            this.DoPresionTuberiaRevestimientoMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionTuberiaRevestimientoMax.Location = new System.Drawing.Point(419, 29);
            this.DoPresionTuberiaRevestimientoMax.Name = "DoPresionTuberiaRevestimientoMax";
            this.DoPresionTuberiaRevestimientoMax.Size = new System.Drawing.Size(126, 22);
            this.DoPresionTuberiaRevestimientoMax.TabIndex = 5;
            // 
            // DoPresionEntradaBomba
            // 
            this.DoPresionEntradaBomba.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoPresionEntradaBomba, 2);
            this.DoPresionEntradaBomba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionEntradaBomba.Location = new System.Drawing.Point(3, 225);
            this.DoPresionEntradaBomba.Name = "DoPresionEntradaBomba";
            this.DoPresionEntradaBomba.Size = new System.Drawing.Size(258, 20);
            this.DoPresionEntradaBomba.TabIndex = 18;
            this.DoPresionEntradaBomba.Text = "DoPresionEntradaBomba";
            this.DoPresionEntradaBomba.UseVisualStyleBackColor = true;
            // 
            // DoPresionEntradaBombaMin
            // 
            this.DoPresionEntradaBombaMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionEntradaBombaMin.Location = new System.Drawing.Point(3, 251);
            this.DoPresionEntradaBombaMin.Name = "DoPresionEntradaBombaMin";
            this.DoPresionEntradaBombaMin.Size = new System.Drawing.Size(126, 22);
            this.DoPresionEntradaBombaMin.TabIndex = 19;
            // 
            // DoPresionEntradaBombaMax
            // 
            this.DoPresionEntradaBombaMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionEntradaBombaMax.Location = new System.Drawing.Point(135, 251);
            this.DoPresionEntradaBombaMax.Name = "DoPresionEntradaBombaMax";
            this.DoPresionEntradaBombaMax.Size = new System.Drawing.Size(126, 22);
            this.DoPresionEntradaBombaMax.TabIndex = 20;
            // 
            // DoSumergenciaEfectivaBomba
            // 
            this.DoSumergenciaEfectivaBomba.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoSumergenciaEfectivaBomba, 2);
            this.DoSumergenciaEfectivaBomba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoSumergenciaEfectivaBomba.Location = new System.Drawing.Point(3, 151);
            this.DoSumergenciaEfectivaBomba.Name = "DoSumergenciaEfectivaBomba";
            this.DoSumergenciaEfectivaBomba.Size = new System.Drawing.Size(258, 20);
            this.DoSumergenciaEfectivaBomba.TabIndex = 12;
            this.DoSumergenciaEfectivaBomba.Text = "DoSumergenciaEfectivaBomba";
            this.DoSumergenciaEfectivaBomba.UseVisualStyleBackColor = true;
            // 
            // DoPresionLineaDescarga
            // 
            this.DoPresionLineaDescarga.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoPresionLineaDescarga, 2);
            this.DoPresionLineaDescarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionLineaDescarga.Location = new System.Drawing.Point(3, 77);
            this.DoPresionLineaDescarga.Name = "DoPresionLineaDescarga";
            this.DoPresionLineaDescarga.Size = new System.Drawing.Size(258, 20);
            this.DoPresionLineaDescarga.TabIndex = 6;
            this.DoPresionLineaDescarga.Text = "DoPresionLineaDescarga";
            this.DoPresionLineaDescarga.UseVisualStyleBackColor = true;
            // 
            // DoSumergenciaEfectivaBombaMin
            // 
            this.DoSumergenciaEfectivaBombaMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoSumergenciaEfectivaBombaMin.Location = new System.Drawing.Point(3, 177);
            this.DoSumergenciaEfectivaBombaMin.Name = "DoSumergenciaEfectivaBombaMin";
            this.DoSumergenciaEfectivaBombaMin.Size = new System.Drawing.Size(126, 22);
            this.DoSumergenciaEfectivaBombaMin.TabIndex = 13;
            // 
            // DoPresionLineaDescargaMin
            // 
            this.DoPresionLineaDescargaMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionLineaDescargaMin.Location = new System.Drawing.Point(3, 103);
            this.DoPresionLineaDescargaMin.Name = "DoPresionLineaDescargaMin";
            this.DoPresionLineaDescargaMin.Size = new System.Drawing.Size(126, 22);
            this.DoPresionLineaDescargaMin.TabIndex = 7;
            // 
            // DoSumergenciaEfectivaBombaMax
            // 
            this.DoSumergenciaEfectivaBombaMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoSumergenciaEfectivaBombaMax.Location = new System.Drawing.Point(135, 177);
            this.DoSumergenciaEfectivaBombaMax.Name = "DoSumergenciaEfectivaBombaMax";
            this.DoSumergenciaEfectivaBombaMax.Size = new System.Drawing.Size(126, 22);
            this.DoSumergenciaEfectivaBombaMax.TabIndex = 14;
            // 
            // DoPresionLineaDescargaMax
            // 
            this.DoPresionLineaDescargaMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionLineaDescargaMax.Location = new System.Drawing.Point(135, 103);
            this.DoPresionLineaDescargaMax.Name = "DoPresionLineaDescargaMax";
            this.DoPresionLineaDescargaMax.Size = new System.Drawing.Size(126, 22);
            this.DoPresionLineaDescargaMax.TabIndex = 8;
            // 
            // DoNivelFluidoPozoTr
            // 
            this.DoNivelFluidoPozoTr.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoNivelFluidoPozoTr, 2);
            this.DoNivelFluidoPozoTr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoNivelFluidoPozoTr.Location = new System.Drawing.Point(287, 151);
            this.DoNivelFluidoPozoTr.Name = "DoNivelFluidoPozoTr";
            this.DoNivelFluidoPozoTr.Size = new System.Drawing.Size(258, 20);
            this.DoNivelFluidoPozoTr.TabIndex = 15;
            this.DoNivelFluidoPozoTr.Text = "DoNivelFluidoPozoTr";
            this.DoNivelFluidoPozoTr.UseVisualStyleBackColor = true;
            // 
            // DoTemperaturaSuperficie
            // 
            this.DoTemperaturaSuperficie.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoTemperaturaSuperficie, 2);
            this.DoTemperaturaSuperficie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoTemperaturaSuperficie.Location = new System.Drawing.Point(287, 77);
            this.DoTemperaturaSuperficie.Name = "DoTemperaturaSuperficie";
            this.DoTemperaturaSuperficie.Size = new System.Drawing.Size(258, 20);
            this.DoTemperaturaSuperficie.TabIndex = 9;
            this.DoTemperaturaSuperficie.Text = "DoTemperaturaSuperficie";
            this.DoTemperaturaSuperficie.UseVisualStyleBackColor = true;
            // 
            // DoNivelFluidoPozoTrMin
            // 
            this.DoNivelFluidoPozoTrMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoNivelFluidoPozoTrMin.Location = new System.Drawing.Point(287, 177);
            this.DoNivelFluidoPozoTrMin.Name = "DoNivelFluidoPozoTrMin";
            this.DoNivelFluidoPozoTrMin.Size = new System.Drawing.Size(126, 22);
            this.DoNivelFluidoPozoTrMin.TabIndex = 16;
            // 
            // DoTemperaturaSuperficieMin
            // 
            this.DoTemperaturaSuperficieMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoTemperaturaSuperficieMin.Location = new System.Drawing.Point(287, 103);
            this.DoTemperaturaSuperficieMin.Name = "DoTemperaturaSuperficieMin";
            this.DoTemperaturaSuperficieMin.Size = new System.Drawing.Size(126, 22);
            this.DoTemperaturaSuperficieMin.TabIndex = 10;
            // 
            // DoNivelFluidoPozoTrMax
            // 
            this.DoNivelFluidoPozoTrMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoNivelFluidoPozoTrMax.Location = new System.Drawing.Point(419, 177);
            this.DoNivelFluidoPozoTrMax.Name = "DoNivelFluidoPozoTrMax";
            this.DoNivelFluidoPozoTrMax.Size = new System.Drawing.Size(126, 22);
            this.DoNivelFluidoPozoTrMax.TabIndex = 17;
            // 
            // DoTemperaturaSuperficieMax
            // 
            this.DoTemperaturaSuperficieMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoTemperaturaSuperficieMax.Location = new System.Drawing.Point(419, 103);
            this.DoTemperaturaSuperficieMax.Name = "DoTemperaturaSuperficieMax";
            this.DoTemperaturaSuperficieMax.Size = new System.Drawing.Size(126, 22);
            this.DoTemperaturaSuperficieMax.TabIndex = 11;
            // 
            // DoVelocidadUnidadBombeo
            // 
            this.DoVelocidadUnidadBombeo.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoVelocidadUnidadBombeo, 2);
            this.DoVelocidadUnidadBombeo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoVelocidadUnidadBombeo.Location = new System.Drawing.Point(287, 225);
            this.DoVelocidadUnidadBombeo.Name = "DoVelocidadUnidadBombeo";
            this.DoVelocidadUnidadBombeo.Size = new System.Drawing.Size(258, 20);
            this.DoVelocidadUnidadBombeo.TabIndex = 21;
            this.DoVelocidadUnidadBombeo.Text = "DoVelocidadUnidadBombeo";
            this.DoVelocidadUnidadBombeo.UseVisualStyleBackColor = true;
            // 
            // DoVelocidadUnidadBombeoMin
            // 
            this.DoVelocidadUnidadBombeoMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoVelocidadUnidadBombeoMin.Location = new System.Drawing.Point(287, 251);
            this.DoVelocidadUnidadBombeoMin.Name = "DoVelocidadUnidadBombeoMin";
            this.DoVelocidadUnidadBombeoMin.Size = new System.Drawing.Size(126, 22);
            this.DoVelocidadUnidadBombeoMin.TabIndex = 22;
            // 
            // DoVelocidadUnidadBombeoMax
            // 
            this.DoVelocidadUnidadBombeoMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoVelocidadUnidadBombeoMax.Location = new System.Drawing.Point(419, 251);
            this.DoVelocidadUnidadBombeoMax.Name = "DoVelocidadUnidadBombeoMax";
            this.DoVelocidadUnidadBombeoMax.Size = new System.Drawing.Size(126, 22);
            this.DoVelocidadUnidadBombeoMax.TabIndex = 23;
            // 
            // DoVelocidadMotor
            // 
            this.DoVelocidadMotor.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoVelocidadMotor, 2);
            this.DoVelocidadMotor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoVelocidadMotor.Location = new System.Drawing.Point(3, 299);
            this.DoVelocidadMotor.Name = "DoVelocidadMotor";
            this.DoVelocidadMotor.Size = new System.Drawing.Size(258, 20);
            this.DoVelocidadMotor.TabIndex = 24;
            this.DoVelocidadMotor.Text = "DoVelocidadMotor";
            this.DoVelocidadMotor.UseVisualStyleBackColor = true;
            // 
            // DoVelocidadMotorMin
            // 
            this.DoVelocidadMotorMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoVelocidadMotorMin.Location = new System.Drawing.Point(3, 325);
            this.DoVelocidadMotorMin.Name = "DoVelocidadMotorMin";
            this.DoVelocidadMotorMin.Size = new System.Drawing.Size(126, 22);
            this.DoVelocidadMotorMin.TabIndex = 25;
            // 
            // DoVelocidadMotorMax
            // 
            this.DoVelocidadMotorMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoVelocidadMotorMax.Location = new System.Drawing.Point(135, 325);
            this.DoVelocidadMotorMax.Name = "DoVelocidadMotorMax";
            this.DoVelocidadMotorMax.Size = new System.Drawing.Size(126, 22);
            this.DoVelocidadMotorMax.TabIndex = 26;
            // 
            // DoLongitudCarrera
            // 
            this.DoLongitudCarrera.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoLongitudCarrera, 2);
            this.DoLongitudCarrera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoLongitudCarrera.Location = new System.Drawing.Point(287, 299);
            this.DoLongitudCarrera.Name = "DoLongitudCarrera";
            this.DoLongitudCarrera.Size = new System.Drawing.Size(258, 20);
            this.DoLongitudCarrera.TabIndex = 27;
            this.DoLongitudCarrera.Text = "DoLongitudCarrera";
            this.DoLongitudCarrera.UseVisualStyleBackColor = true;
            // 
            // DoLongitudCarreraMin
            // 
            this.DoLongitudCarreraMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoLongitudCarreraMin.Location = new System.Drawing.Point(287, 325);
            this.DoLongitudCarreraMin.Name = "DoLongitudCarreraMin";
            this.DoLongitudCarreraMin.Size = new System.Drawing.Size(126, 22);
            this.DoLongitudCarreraMin.TabIndex = 28;
            // 
            // DoLongitudCarreraMax
            // 
            this.DoLongitudCarreraMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoLongitudCarreraMax.Location = new System.Drawing.Point(419, 325);
            this.DoLongitudCarreraMax.Name = "DoLongitudCarreraMax";
            this.DoLongitudCarreraMax.Size = new System.Drawing.Size(126, 22);
            this.DoLongitudCarreraMax.TabIndex = 29;
            // 
            // DoEficienciaLlenado
            // 
            this.DoEficienciaLlenado.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoEficienciaLlenado, 2);
            this.DoEficienciaLlenado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoEficienciaLlenado.Location = new System.Drawing.Point(3, 373);
            this.DoEficienciaLlenado.Name = "DoEficienciaLlenado";
            this.DoEficienciaLlenado.Size = new System.Drawing.Size(258, 20);
            this.DoEficienciaLlenado.TabIndex = 30;
            this.DoEficienciaLlenado.Text = "DoEficienciaLlenado";
            this.DoEficienciaLlenado.UseVisualStyleBackColor = true;
            // 
            // DoEficienciaLlenadoMin
            // 
            this.DoEficienciaLlenadoMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoEficienciaLlenadoMin.Location = new System.Drawing.Point(3, 399);
            this.DoEficienciaLlenadoMin.Name = "DoEficienciaLlenadoMin";
            this.DoEficienciaLlenadoMin.Size = new System.Drawing.Size(126, 22);
            this.DoEficienciaLlenadoMin.TabIndex = 31;
            // 
            // DoEficienciaLlenadoMax
            // 
            this.DoEficienciaLlenadoMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoEficienciaLlenadoMax.Location = new System.Drawing.Point(135, 399);
            this.DoEficienciaLlenadoMax.Name = "DoEficienciaLlenadoMax";
            this.DoEficienciaLlenadoMax.Size = new System.Drawing.Size(126, 22);
            this.DoEficienciaLlenadoMax.TabIndex = 32;
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
        private CheckBox DoPresionTuberiaProduccion;
        private TextBox DoPresionTuberiaProduccionMin;
        private TextBox DoPresionTuberiaProduccionMax;
        private CheckBox DoPresionTuberiaRevestimiento;
        private TextBox DoPresionTuberiaRevestimientoMin;
        private TextBox DoPresionTuberiaRevestimientoMax;
        private CheckBox DoPresionEntradaBomba;
        private TextBox DoPresionEntradaBombaMin;
        private TextBox DoPresionEntradaBombaMax;
        private CheckBox DoSumergenciaEfectivaBomba;
        private CheckBox DoPresionLineaDescarga;
        private TextBox DoSumergenciaEfectivaBombaMin;
        private TextBox DoPresionLineaDescargaMin;
        private TextBox DoSumergenciaEfectivaBombaMax;
        private TextBox DoPresionLineaDescargaMax;
        private CheckBox DoNivelFluidoPozoTr;
        private CheckBox DoTemperaturaSuperficie;
        private TextBox DoNivelFluidoPozoTrMin;
        private TextBox DoTemperaturaSuperficieMin;
        private TextBox DoNivelFluidoPozoTrMax;
        private TextBox DoTemperaturaSuperficieMax;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lbTemporizador2;
        private TextBox CartaDinagrafica;
        private TableLayoutPanel tableLayoutPanel7;
        private CheckBox CCartaDinagrafica;
        private CheckBox DoVelocidadUnidadBombeo;
        private TextBox DoVelocidadUnidadBombeoMin;
        private TextBox DoVelocidadUnidadBombeoMax;
        private CheckBox DoVelocidadMotor;
        private TextBox DoVelocidadMotorMin;
        private TextBox DoVelocidadMotorMax;
        private CheckBox DoLongitudCarrera;
        private TextBox DoLongitudCarreraMin;
        private TextBox DoLongitudCarreraMax;
        private CheckBox DoEficienciaLlenado;
        private TextBox DoEficienciaLlenadoMin;
        private TextBox DoEficienciaLlenadoMax;
        private ComboBox CCartaDinagraficaList;
        private Button CCartaDinagraficaAgregar;
        private Button CCartaDinagraficaEliminar;
        private OpenFileDialog openFileDialog1;
        internal DevExpress.XtraCharts.ChartControl chart1;
    }
}