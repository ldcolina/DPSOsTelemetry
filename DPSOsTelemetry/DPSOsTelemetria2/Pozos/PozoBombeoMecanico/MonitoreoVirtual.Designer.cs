using System.Windows.Forms;

namespace DPSOsTelemetria2.Pozos.PozoBombeoMecanico
{
    partial class MonitoreoVirtual
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
            this.DatosOperativos = new System.Windows.Forms.Label();
            this.DatosOperativosSends = new System.Windows.Forms.Label();
            this.DatosOperativosComplete = new System.Windows.Forms.Label();
            this.DatosOperativosFails = new System.Windows.Forms.Label();
            this.tlpVariables = new System.Windows.Forms.TableLayoutPanel();
            this.DoPresionTuberiaProduccion = new System.Windows.Forms.Label();
            this.DoPresionTuberiaRevestimiento = new System.Windows.Forms.Label();
            this.DoPresionEntradaBomba = new System.Windows.Forms.Label();
            this.DoSumergenciaEfectivaBomba = new System.Windows.Forms.Label();
            this.DoPresionLineaDescarga = new System.Windows.Forms.Label();
            this.DoNivelFluidoPozoTr = new System.Windows.Forms.Label();
            this.DoTemperaturaSuperficie = new System.Windows.Forms.Label();
            this.DoVelocidadUnidadBombeo = new System.Windows.Forms.Label();
            this.DoVelocidadMotor = new System.Windows.Forms.Label();
            this.DoLongitudCarrera = new System.Windows.Forms.Label();
            this.DoEficienciaLlenado = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.CartaDinagrafica = new System.Windows.Forms.Label();
            this.CartaDinagraficaSends = new System.Windows.Forms.Label();
            this.CartaDinagraficaComplete = new System.Windows.Forms.Label();
            this.CartaDinagraficaFails = new System.Windows.Forms.Label();
            this.chart1 = new DevExpress.XtraCharts.ChartControl();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 415);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(740, 369);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.DatosOperativos, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.DatosOperativosSends, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.DatosOperativosComplete, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.DatosOperativosFails, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 318);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(734, 48);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // DatosOperativos
            // 
            this.DatosOperativos.AutoSize = true;
            this.DatosOperativos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosOperativos.Location = new System.Drawing.Point(370, 0);
            this.DatosOperativos.Name = "DatosOperativos";
            this.tableLayoutPanel4.SetRowSpan(this.DatosOperativos, 3);
            this.DatosOperativos.Size = new System.Drawing.Size(361, 48);
            this.DatosOperativos.TabIndex = 3;
            this.DatosOperativos.Text = "DatosOperativos";
            this.DatosOperativos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DatosOperativosSends
            // 
            this.DatosOperativosSends.AutoSize = true;
            this.DatosOperativosSends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosOperativosSends.Location = new System.Drawing.Point(3, 0);
            this.DatosOperativosSends.Name = "DatosOperativosSends";
            this.DatosOperativosSends.Size = new System.Drawing.Size(361, 16);
            this.DatosOperativosSends.TabIndex = 0;
            this.DatosOperativosSends.Text = "DatosOperativosSends";
            this.DatosOperativosSends.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DatosOperativosComplete
            // 
            this.DatosOperativosComplete.AutoSize = true;
            this.DatosOperativosComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosOperativosComplete.Location = new System.Drawing.Point(3, 16);
            this.DatosOperativosComplete.Name = "DatosOperativosComplete";
            this.DatosOperativosComplete.Size = new System.Drawing.Size(361, 16);
            this.DatosOperativosComplete.TabIndex = 1;
            this.DatosOperativosComplete.Text = "DatosOperativosComplete";
            this.DatosOperativosComplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DatosOperativosFails
            // 
            this.DatosOperativosFails.AutoSize = true;
            this.DatosOperativosFails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosOperativosFails.Location = new System.Drawing.Point(3, 32);
            this.DatosOperativosFails.Name = "DatosOperativosFails";
            this.DatosOperativosFails.Size = new System.Drawing.Size(361, 16);
            this.DatosOperativosFails.TabIndex = 2;
            this.DatosOperativosFails.Text = "DatosOperativosFails";
            this.DatosOperativosFails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tlpVariables.Controls.Add(this.DoPresionTuberiaRevestimiento, 3, 0);
            this.tlpVariables.Controls.Add(this.DoPresionEntradaBomba, 0, 6);
            this.tlpVariables.Controls.Add(this.DoSumergenciaEfectivaBomba, 0, 4);
            this.tlpVariables.Controls.Add(this.DoPresionLineaDescarga, 0, 2);
            this.tlpVariables.Controls.Add(this.DoNivelFluidoPozoTr, 3, 4);
            this.tlpVariables.Controls.Add(this.DoTemperaturaSuperficie, 3, 2);
            this.tlpVariables.Controls.Add(this.DoVelocidadUnidadBombeo, 3, 6);
            this.tlpVariables.Controls.Add(this.DoVelocidadMotor, 0, 8);
            this.tlpVariables.Controls.Add(this.DoLongitudCarrera, 3, 8);
            this.tlpVariables.Controls.Add(this.DoEficienciaLlenado, 0, 10);
            this.tlpVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVariables.Location = new System.Drawing.Point(3, 3);
            this.tlpVariables.Name = "tlpVariables";
            this.tlpVariables.RowCount = 12;
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.Size = new System.Drawing.Size(734, 309);
            this.tlpVariables.TabIndex = 3;
            // 
            // DoPresionTuberiaProduccion
            // 
            this.DoPresionTuberiaProduccion.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoPresionTuberiaProduccion, 2);
            this.DoPresionTuberiaProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionTuberiaProduccion.Location = new System.Drawing.Point(3, 0);
            this.DoPresionTuberiaProduccion.Name = "DoPresionTuberiaProduccion";
            this.DoPresionTuberiaProduccion.Size = new System.Drawing.Size(350, 16);
            this.DoPresionTuberiaProduccion.TabIndex = 0;
            this.DoPresionTuberiaProduccion.Text = "DoPresionTuberiaProduccion";
            // 
            // DoPresionTuberiaRevestimiento
            // 
            this.DoPresionTuberiaRevestimiento.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoPresionTuberiaRevestimiento, 2);
            this.DoPresionTuberiaRevestimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionTuberiaRevestimiento.Location = new System.Drawing.Point(379, 0);
            this.DoPresionTuberiaRevestimiento.Name = "DoPresionTuberiaRevestimiento";
            this.DoPresionTuberiaRevestimiento.Size = new System.Drawing.Size(352, 16);
            this.DoPresionTuberiaRevestimiento.TabIndex = 3;
            this.DoPresionTuberiaRevestimiento.Text = "DoPresionTuberiaRevestimiento";
            // 
            // DoPresionEntradaBomba
            // 
            this.DoPresionEntradaBomba.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoPresionEntradaBomba, 2);
            this.DoPresionEntradaBomba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionEntradaBomba.Location = new System.Drawing.Point(3, 108);
            this.DoPresionEntradaBomba.Name = "DoPresionEntradaBomba";
            this.DoPresionEntradaBomba.Size = new System.Drawing.Size(350, 16);
            this.DoPresionEntradaBomba.TabIndex = 18;
            this.DoPresionEntradaBomba.Text = "DoPresionEntradaBomba";
            // 
            // DoSumergenciaEfectivaBomba
            // 
            this.DoSumergenciaEfectivaBomba.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoSumergenciaEfectivaBomba, 2);
            this.DoSumergenciaEfectivaBomba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoSumergenciaEfectivaBomba.Location = new System.Drawing.Point(3, 72);
            this.DoSumergenciaEfectivaBomba.Name = "DoSumergenciaEfectivaBomba";
            this.DoSumergenciaEfectivaBomba.Size = new System.Drawing.Size(350, 16);
            this.DoSumergenciaEfectivaBomba.TabIndex = 12;
            this.DoSumergenciaEfectivaBomba.Text = "DoSumergenciaEfectivaBomba";
            // 
            // DoPresionLineaDescarga
            // 
            this.DoPresionLineaDescarga.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoPresionLineaDescarga, 2);
            this.DoPresionLineaDescarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoPresionLineaDescarga.Location = new System.Drawing.Point(3, 36);
            this.DoPresionLineaDescarga.Name = "DoPresionLineaDescarga";
            this.DoPresionLineaDescarga.Size = new System.Drawing.Size(350, 16);
            this.DoPresionLineaDescarga.TabIndex = 6;
            this.DoPresionLineaDescarga.Text = "DoPresionLineaDescarga";
            // 
            // DoNivelFluidoPozoTr
            // 
            this.DoNivelFluidoPozoTr.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoNivelFluidoPozoTr, 2);
            this.DoNivelFluidoPozoTr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoNivelFluidoPozoTr.Location = new System.Drawing.Point(379, 72);
            this.DoNivelFluidoPozoTr.Name = "DoNivelFluidoPozoTr";
            this.DoNivelFluidoPozoTr.Size = new System.Drawing.Size(352, 16);
            this.DoNivelFluidoPozoTr.TabIndex = 15;
            this.DoNivelFluidoPozoTr.Text = "DoNivelFluidoPozoTr";
            // 
            // DoTemperaturaSuperficie
            // 
            this.DoTemperaturaSuperficie.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoTemperaturaSuperficie, 2);
            this.DoTemperaturaSuperficie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoTemperaturaSuperficie.Location = new System.Drawing.Point(379, 36);
            this.DoTemperaturaSuperficie.Name = "DoTemperaturaSuperficie";
            this.DoTemperaturaSuperficie.Size = new System.Drawing.Size(352, 16);
            this.DoTemperaturaSuperficie.TabIndex = 9;
            this.DoTemperaturaSuperficie.Text = "DoTemperaturaSuperficie";
            // 
            // DoVelocidadUnidadBombeo
            // 
            this.DoVelocidadUnidadBombeo.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoVelocidadUnidadBombeo, 2);
            this.DoVelocidadUnidadBombeo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoVelocidadUnidadBombeo.Location = new System.Drawing.Point(379, 108);
            this.DoVelocidadUnidadBombeo.Name = "DoVelocidadUnidadBombeo";
            this.DoVelocidadUnidadBombeo.Size = new System.Drawing.Size(352, 16);
            this.DoVelocidadUnidadBombeo.TabIndex = 21;
            this.DoVelocidadUnidadBombeo.Text = "DoVelocidadUnidadBombeo";
            // 
            // DoVelocidadMotor
            // 
            this.DoVelocidadMotor.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoVelocidadMotor, 2);
            this.DoVelocidadMotor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoVelocidadMotor.Location = new System.Drawing.Point(3, 144);
            this.DoVelocidadMotor.Name = "DoVelocidadMotor";
            this.DoVelocidadMotor.Size = new System.Drawing.Size(350, 16);
            this.DoVelocidadMotor.TabIndex = 24;
            this.DoVelocidadMotor.Text = "DoVelocidadMotor";
            // 
            // DoLongitudCarrera
            // 
            this.DoLongitudCarrera.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoLongitudCarrera, 2);
            this.DoLongitudCarrera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoLongitudCarrera.Location = new System.Drawing.Point(379, 144);
            this.DoLongitudCarrera.Name = "DoLongitudCarrera";
            this.DoLongitudCarrera.Size = new System.Drawing.Size(352, 16);
            this.DoLongitudCarrera.TabIndex = 27;
            this.DoLongitudCarrera.Text = "DoLongitudCarrera";
            // 
            // DoEficienciaLlenado
            // 
            this.DoEficienciaLlenado.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.DoEficienciaLlenado, 2);
            this.DoEficienciaLlenado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoEficienciaLlenado.Location = new System.Drawing.Point(3, 180);
            this.DoEficienciaLlenado.Name = "DoEficienciaLlenado";
            this.DoEficienciaLlenado.Size = new System.Drawing.Size(350, 16);
            this.DoEficienciaLlenado.TabIndex = 30;
            this.DoEficienciaLlenado.Text = "DoEficienciaLlenado";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(786, 415);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(23, 23);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(740, 369);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.CartaDinagrafica, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.CartaDinagraficaSends, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.CartaDinagraficaComplete, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.CartaDinagraficaFails, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 318);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(734, 48);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // CartaDinagrafica
            // 
            this.CartaDinagrafica.AutoSize = true;
            this.CartaDinagrafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartaDinagrafica.Location = new System.Drawing.Point(370, 0);
            this.CartaDinagrafica.Name = "CartaDinagrafica";
            this.tableLayoutPanel6.SetRowSpan(this.CartaDinagrafica, 3);
            this.CartaDinagrafica.Size = new System.Drawing.Size(361, 48);
            this.CartaDinagrafica.TabIndex = 3;
            this.CartaDinagrafica.Text = "CartaDinagrafica";
            this.CartaDinagrafica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CartaDinagraficaSends
            // 
            this.CartaDinagraficaSends.AutoSize = true;
            this.CartaDinagraficaSends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartaDinagraficaSends.Location = new System.Drawing.Point(3, 0);
            this.CartaDinagraficaSends.Name = "CartaDinagraficaSends";
            this.CartaDinagraficaSends.Size = new System.Drawing.Size(361, 16);
            this.CartaDinagraficaSends.TabIndex = 0;
            this.CartaDinagraficaSends.Text = "CartaDinagraficaSends";
            this.CartaDinagraficaSends.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CartaDinagraficaComplete
            // 
            this.CartaDinagraficaComplete.AutoSize = true;
            this.CartaDinagraficaComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartaDinagraficaComplete.Location = new System.Drawing.Point(3, 16);
            this.CartaDinagraficaComplete.Name = "CartaDinagraficaComplete";
            this.CartaDinagraficaComplete.Size = new System.Drawing.Size(361, 16);
            this.CartaDinagraficaComplete.TabIndex = 1;
            this.CartaDinagraficaComplete.Text = "CartaDinagraficaComplete";
            this.CartaDinagraficaComplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CartaDinagraficaFails
            // 
            this.CartaDinagraficaFails.AutoSize = true;
            this.CartaDinagraficaFails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartaDinagraficaFails.Location = new System.Drawing.Point(3, 32);
            this.CartaDinagraficaFails.Name = "CartaDinagraficaFails";
            this.CartaDinagraficaFails.Size = new System.Drawing.Size(361, 16);
            this.CartaDinagraficaFails.TabIndex = 2;
            this.CartaDinagraficaFails.Text = "CartaDinagraficaFails";
            this.CartaDinagraficaFails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chart1
            // 
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Legend.Name = "Default Legend";
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart1.Size = new System.Drawing.Size(734, 309);
            this.chart1.TabIndex = 7;
            // 
            // MonitoreoVirtual
            // 
            this.Controls.Add(this.tabControl1);
            this.Name = "MonitoreoVirtual";
            this.Size = new System.Drawing.Size(800, 450);
            
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tlpVariables;
        private Label DoPresionTuberiaProduccion;
        private Label DoPresionTuberiaRevestimiento;
        private Label DoPresionEntradaBomba;
        private Label DoSumergenciaEfectivaBomba;
        private Label DoPresionLineaDescarga;
        private Label DoNivelFluidoPozoTr;
        private Label DoTemperaturaSuperficie;
        private Label DoVelocidadUnidadBombeo;
        private Label DoVelocidadMotor;
        private Label DoLongitudCarrera;
        private Label DoEficienciaLlenado;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel4;
        private Label DatosOperativos;
        private Label DatosOperativosSends;
        private Label DatosOperativosComplete;
        private Label DatosOperativosFails;
        private TableLayoutPanel tableLayoutPanel6;
        private Label CartaDinagrafica;
        private Label CartaDinagraficaSends;
        private Label CartaDinagraficaComplete;
        private Label CartaDinagraficaFails;
        internal DevExpress.XtraCharts.ChartControl chart1;
    }
}