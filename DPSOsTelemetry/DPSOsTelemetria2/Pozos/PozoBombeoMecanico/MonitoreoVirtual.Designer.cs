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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tlpVariables = new System.Windows.Forms.TableLayoutPanel();
            this.PresionTuberiaProduccion = new System.Windows.Forms.Label();
            this.PresionTuberiaRevestimiento = new System.Windows.Forms.Label();
            this.PresionEntradaBomba = new System.Windows.Forms.Label();
            this.SumergenciaEfectivaBomba = new System.Windows.Forms.Label();
            this.PresionLineaDescarga = new System.Windows.Forms.Label();
            this.NivelFluidoPozoTr = new System.Windows.Forms.Label();
            this.TemperaturaSuperficie = new System.Windows.Forms.Label();
            this.VelocidadUnidadBombeo = new System.Windows.Forms.Label();
            this.VelocidadMotor = new System.Windows.Forms.Label();
            this.LongitudCarrera = new System.Windows.Forms.Label();
            this.EficienciaLlenado = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tlpVariables2 = new System.Windows.Forms.TableLayoutPanel();
            this.GastoLiquidoPruebaProduccion = new System.Windows.Forms.Label();
            this.PorcentajeAguaSedimento = new System.Windows.Forms.Label();
            this.GravedadPetroleo = new System.Windows.Forms.Label();
            this.GastoLiquido = new System.Windows.Forms.Label();
            this.GastoAceite = new System.Windows.Forms.Label();
            this.RelacionGasAceite = new System.Windows.Forms.Label();
            this.GastoGas = new System.Windows.Forms.Label();
            this.Emulsion = new System.Windows.Forms.Label();
            this.SalinidadAgua = new System.Windows.Forms.Label();
            this.GravedadEspecificaGasProducido = new System.Windows.Forms.Label();
            this.CargaSobreBarraPulida = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvTablaHistorico = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.DatosOperativos = new System.Windows.Forms.Label();
            this.DatosOperativosSends = new System.Windows.Forms.Label();
            this.DatosOperativosComplete = new System.Windows.Forms.Label();
            this.DatosOperativosFails = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new DevExpress.XtraCharts.ChartControl();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.CartaDinagrafica = new System.Windows.Forms.Label();
            this.CartaDinagraficaSends = new System.Windows.Forms.Label();
            this.CartaDinagraficaComplete = new System.Windows.Forms.Label();
            this.CartaDinagraficaFails = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tlpVariables.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tlpVariables2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaHistorico)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 415);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(780, 355);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.tlpVariables);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(772, 326);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "DatosOperativos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tlpVariables
            // 
            this.tlpVariables.ColumnCount = 3;
            this.tlpVariables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVariables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVariables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.Controls.Add(this.PresionTuberiaProduccion, 0, 0);
            this.tlpVariables.Controls.Add(this.PresionTuberiaRevestimiento, 2, 0);
            this.tlpVariables.Controls.Add(this.PresionEntradaBomba, 0, 6);
            this.tlpVariables.Controls.Add(this.SumergenciaEfectivaBomba, 0, 4);
            this.tlpVariables.Controls.Add(this.PresionLineaDescarga, 0, 2);
            this.tlpVariables.Controls.Add(this.NivelFluidoPozoTr, 2, 4);
            this.tlpVariables.Controls.Add(this.TemperaturaSuperficie, 2, 2);
            this.tlpVariables.Controls.Add(this.VelocidadUnidadBombeo, 2, 6);
            this.tlpVariables.Controls.Add(this.VelocidadMotor, 0, 8);
            this.tlpVariables.Controls.Add(this.LongitudCarrera, 2, 8);
            this.tlpVariables.Controls.Add(this.EficienciaLlenado, 0, 10);
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
            this.tlpVariables.Size = new System.Drawing.Size(766, 320);
            this.tlpVariables.TabIndex = 4;
            // 
            // PresionTuberiaProduccion
            // 
            this.PresionTuberiaProduccion.AutoSize = true;
            this.PresionTuberiaProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaProduccion.Location = new System.Drawing.Point(3, 0);
            this.PresionTuberiaProduccion.Name = "PresionTuberiaProduccion";
            this.PresionTuberiaProduccion.Size = new System.Drawing.Size(367, 16);
            this.PresionTuberiaProduccion.TabIndex = 0;
            this.PresionTuberiaProduccion.Text = "PresionTuberiaProduccion";
            // 
            // PresionTuberiaRevestimiento
            // 
            this.PresionTuberiaRevestimiento.AutoSize = true;
            this.PresionTuberiaRevestimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaRevestimiento.Location = new System.Drawing.Point(396, 0);
            this.PresionTuberiaRevestimiento.Name = "PresionTuberiaRevestimiento";
            this.PresionTuberiaRevestimiento.Size = new System.Drawing.Size(367, 16);
            this.PresionTuberiaRevestimiento.TabIndex = 3;
            this.PresionTuberiaRevestimiento.Text = "PresionTuberiaRevestimiento";
            // 
            // PresionEntradaBomba
            // 
            this.PresionEntradaBomba.AutoSize = true;
            this.PresionEntradaBomba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionEntradaBomba.Location = new System.Drawing.Point(3, 108);
            this.PresionEntradaBomba.Name = "PresionEntradaBomba";
            this.PresionEntradaBomba.Size = new System.Drawing.Size(367, 16);
            this.PresionEntradaBomba.TabIndex = 18;
            this.PresionEntradaBomba.Text = "PresionEntradaBomba";
            // 
            // SumergenciaEfectivaBomba
            // 
            this.SumergenciaEfectivaBomba.AutoSize = true;
            this.SumergenciaEfectivaBomba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SumergenciaEfectivaBomba.Location = new System.Drawing.Point(3, 72);
            this.SumergenciaEfectivaBomba.Name = "SumergenciaEfectivaBomba";
            this.SumergenciaEfectivaBomba.Size = new System.Drawing.Size(367, 16);
            this.SumergenciaEfectivaBomba.TabIndex = 12;
            this.SumergenciaEfectivaBomba.Text = "SumergenciaEfectivaBomba";
            // 
            // PresionLineaDescarga
            // 
            this.PresionLineaDescarga.AutoSize = true;
            this.PresionLineaDescarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionLineaDescarga.Location = new System.Drawing.Point(3, 36);
            this.PresionLineaDescarga.Name = "PresionLineaDescarga";
            this.PresionLineaDescarga.Size = new System.Drawing.Size(367, 16);
            this.PresionLineaDescarga.TabIndex = 6;
            this.PresionLineaDescarga.Text = "PresionLineaDescarga";
            // 
            // NivelFluidoPozoTr
            // 
            this.NivelFluidoPozoTr.AutoSize = true;
            this.NivelFluidoPozoTr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NivelFluidoPozoTr.Location = new System.Drawing.Point(396, 72);
            this.NivelFluidoPozoTr.Name = "NivelFluidoPozoTr";
            this.NivelFluidoPozoTr.Size = new System.Drawing.Size(367, 16);
            this.NivelFluidoPozoTr.TabIndex = 15;
            this.NivelFluidoPozoTr.Text = "NivelFluidoPozoTr";
            // 
            // TemperaturaSuperficie
            // 
            this.TemperaturaSuperficie.AutoSize = true;
            this.TemperaturaSuperficie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemperaturaSuperficie.Location = new System.Drawing.Point(396, 36);
            this.TemperaturaSuperficie.Name = "TemperaturaSuperficie";
            this.TemperaturaSuperficie.Size = new System.Drawing.Size(367, 16);
            this.TemperaturaSuperficie.TabIndex = 9;
            this.TemperaturaSuperficie.Text = "TemperaturaSuperficie";
            // 
            // VelocidadUnidadBombeo
            // 
            this.VelocidadUnidadBombeo.AutoSize = true;
            this.VelocidadUnidadBombeo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VelocidadUnidadBombeo.Location = new System.Drawing.Point(396, 108);
            this.VelocidadUnidadBombeo.Name = "VelocidadUnidadBombeo";
            this.VelocidadUnidadBombeo.Size = new System.Drawing.Size(367, 16);
            this.VelocidadUnidadBombeo.TabIndex = 21;
            this.VelocidadUnidadBombeo.Text = "VelocidadUnidadBombeo";
            // 
            // VelocidadMotor
            // 
            this.VelocidadMotor.AutoSize = true;
            this.VelocidadMotor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VelocidadMotor.Location = new System.Drawing.Point(3, 144);
            this.VelocidadMotor.Name = "VelocidadMotor";
            this.VelocidadMotor.Size = new System.Drawing.Size(367, 16);
            this.VelocidadMotor.TabIndex = 24;
            this.VelocidadMotor.Text = "VelocidadMotor";
            // 
            // LongitudCarrera
            // 
            this.LongitudCarrera.AutoSize = true;
            this.LongitudCarrera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LongitudCarrera.Location = new System.Drawing.Point(396, 144);
            this.LongitudCarrera.Name = "LongitudCarrera";
            this.LongitudCarrera.Size = new System.Drawing.Size(367, 16);
            this.LongitudCarrera.TabIndex = 27;
            this.LongitudCarrera.Text = "LongitudCarrera";
            // 
            // EficienciaLlenado
            // 
            this.EficienciaLlenado.AutoSize = true;
            this.EficienciaLlenado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EficienciaLlenado.Location = new System.Drawing.Point(3, 180);
            this.EficienciaLlenado.Name = "EficienciaLlenado";
            this.EficienciaLlenado.Size = new System.Drawing.Size(367, 16);
            this.EficienciaLlenado.TabIndex = 30;
            this.EficienciaLlenado.Text = "EficienciaLlenado";
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.tlpVariables2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(772, 326);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "DatosProduccion";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tlpVariables2
            // 
            this.tlpVariables2.ColumnCount = 3;
            this.tlpVariables2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVariables2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVariables2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.Controls.Add(this.GastoLiquidoPruebaProduccion, 0, 0);
            this.tlpVariables2.Controls.Add(this.PorcentajeAguaSedimento, 2, 0);
            this.tlpVariables2.Controls.Add(this.GravedadPetroleo, 0, 6);
            this.tlpVariables2.Controls.Add(this.GastoLiquido, 0, 4);
            this.tlpVariables2.Controls.Add(this.GastoAceite, 0, 2);
            this.tlpVariables2.Controls.Add(this.RelacionGasAceite, 2, 4);
            this.tlpVariables2.Controls.Add(this.GastoGas, 2, 2);
            this.tlpVariables2.Controls.Add(this.Emulsion, 2, 6);
            this.tlpVariables2.Controls.Add(this.SalinidadAgua, 0, 8);
            this.tlpVariables2.Controls.Add(this.GravedadEspecificaGasProducido, 2, 8);
            this.tlpVariables2.Controls.Add(this.CargaSobreBarraPulida, 0, 10);
            this.tlpVariables2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVariables2.Location = new System.Drawing.Point(3, 3);
            this.tlpVariables2.Name = "tlpVariables2";
            this.tlpVariables2.RowCount = 12;
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.Size = new System.Drawing.Size(766, 320);
            this.tlpVariables2.TabIndex = 5;
            // 
            // GastoLiquidoPruebaProduccion
            // 
            this.GastoLiquidoPruebaProduccion.AutoSize = true;
            this.GastoLiquidoPruebaProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoLiquidoPruebaProduccion.Location = new System.Drawing.Point(3, 0);
            this.GastoLiquidoPruebaProduccion.Name = "GastoLiquidoPruebaProduccion";
            this.GastoLiquidoPruebaProduccion.Size = new System.Drawing.Size(367, 16);
            this.GastoLiquidoPruebaProduccion.TabIndex = 0;
            this.GastoLiquidoPruebaProduccion.Text = "GastoLiquidoPruebaProduccion";
            // 
            // PorcentajeAguaSedimento
            // 
            this.PorcentajeAguaSedimento.AutoSize = true;
            this.PorcentajeAguaSedimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PorcentajeAguaSedimento.Location = new System.Drawing.Point(396, 0);
            this.PorcentajeAguaSedimento.Name = "PorcentajeAguaSedimento";
            this.PorcentajeAguaSedimento.Size = new System.Drawing.Size(367, 16);
            this.PorcentajeAguaSedimento.TabIndex = 3;
            this.PorcentajeAguaSedimento.Text = "PorcentajeAguaSedimento";
            // 
            // GravedadPetroleo
            // 
            this.GravedadPetroleo.AutoSize = true;
            this.GravedadPetroleo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GravedadPetroleo.Location = new System.Drawing.Point(3, 108);
            this.GravedadPetroleo.Name = "GravedadPetroleo";
            this.GravedadPetroleo.Size = new System.Drawing.Size(367, 16);
            this.GravedadPetroleo.TabIndex = 18;
            this.GravedadPetroleo.Text = "GravedadPetroleo";
            // 
            // GastoLiquido
            // 
            this.GastoLiquido.AutoSize = true;
            this.GastoLiquido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoLiquido.Location = new System.Drawing.Point(3, 72);
            this.GastoLiquido.Name = "GastoLiquido";
            this.GastoLiquido.Size = new System.Drawing.Size(367, 16);
            this.GastoLiquido.TabIndex = 12;
            this.GastoLiquido.Text = "GastoLiquido";
            // 
            // GastoAceite
            // 
            this.GastoAceite.AutoSize = true;
            this.GastoAceite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoAceite.Location = new System.Drawing.Point(3, 36);
            this.GastoAceite.Name = "GastoAceite";
            this.GastoAceite.Size = new System.Drawing.Size(367, 16);
            this.GastoAceite.TabIndex = 6;
            this.GastoAceite.Text = "GastoAceite";
            // 
            // RelacionGasAceite
            // 
            this.RelacionGasAceite.AutoSize = true;
            this.RelacionGasAceite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RelacionGasAceite.Location = new System.Drawing.Point(396, 72);
            this.RelacionGasAceite.Name = "RelacionGasAceite";
            this.RelacionGasAceite.Size = new System.Drawing.Size(367, 16);
            this.RelacionGasAceite.TabIndex = 15;
            this.RelacionGasAceite.Text = "RelacionGasAceite";
            // 
            // GastoGas
            // 
            this.GastoGas.AutoSize = true;
            this.GastoGas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoGas.Location = new System.Drawing.Point(396, 36);
            this.GastoGas.Name = "GastoGas";
            this.GastoGas.Size = new System.Drawing.Size(367, 16);
            this.GastoGas.TabIndex = 9;
            this.GastoGas.Text = "GastoGas";
            // 
            // Emulsion
            // 
            this.Emulsion.AutoSize = true;
            this.Emulsion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Emulsion.Location = new System.Drawing.Point(396, 108);
            this.Emulsion.Name = "Emulsion";
            this.Emulsion.Size = new System.Drawing.Size(367, 16);
            this.Emulsion.TabIndex = 21;
            this.Emulsion.Text = "Emulsion";
            // 
            // SalinidadAgua
            // 
            this.SalinidadAgua.AutoSize = true;
            this.SalinidadAgua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalinidadAgua.Location = new System.Drawing.Point(3, 144);
            this.SalinidadAgua.Name = "SalinidadAgua";
            this.SalinidadAgua.Size = new System.Drawing.Size(367, 16);
            this.SalinidadAgua.TabIndex = 24;
            this.SalinidadAgua.Text = "SalinidadAgua";
            // 
            // GravedadEspecificaGasProducido
            // 
            this.GravedadEspecificaGasProducido.AutoSize = true;
            this.GravedadEspecificaGasProducido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GravedadEspecificaGasProducido.Location = new System.Drawing.Point(396, 144);
            this.GravedadEspecificaGasProducido.Name = "GravedadEspecificaGasProducido";
            this.GravedadEspecificaGasProducido.Size = new System.Drawing.Size(367, 16);
            this.GravedadEspecificaGasProducido.TabIndex = 27;
            this.GravedadEspecificaGasProducido.Text = "GravedadEspecificaGasProducido";
            // 
            // CargaSobreBarraPulida
            // 
            this.CargaSobreBarraPulida.AutoSize = true;
            this.CargaSobreBarraPulida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CargaSobreBarraPulida.Location = new System.Drawing.Point(3, 180);
            this.CargaSobreBarraPulida.Name = "CargaSobreBarraPulida";
            this.CargaSobreBarraPulida.Size = new System.Drawing.Size(367, 16);
            this.CargaSobreBarraPulida.TabIndex = 30;
            this.CargaSobreBarraPulida.Text = "CargaSobreBarraPulida";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvTablaHistorico);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(772, 326);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvTablaHistorico
            // 
            this.dgvTablaHistorico.AllowUserToAddRows = false;
            this.dgvTablaHistorico.AllowUserToDeleteRows = false;
            this.dgvTablaHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTablaHistorico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTablaHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablaHistorico.Location = new System.Drawing.Point(3, 3);
            this.dgvTablaHistorico.MultiSelect = false;
            this.dgvTablaHistorico.Name = "dgvTablaHistorico";
            this.dgvTablaHistorico.ReadOnly = true;
            this.dgvTablaHistorico.RowHeadersWidth = 51;
            this.dgvTablaHistorico.RowTemplate.Height = 24;
            this.dgvTablaHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaHistorico.Size = new System.Drawing.Size(766, 320);
            this.dgvTablaHistorico.TabIndex = 0;
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 364);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(780, 48);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // DatosOperativos
            // 
            this.DatosOperativos.AutoSize = true;
            this.DatosOperativos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosOperativos.Location = new System.Drawing.Point(393, 0);
            this.DatosOperativos.Name = "DatosOperativos";
            this.tableLayoutPanel4.SetRowSpan(this.DatosOperativos, 3);
            this.DatosOperativos.Size = new System.Drawing.Size(384, 48);
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
            this.DatosOperativosSends.Size = new System.Drawing.Size(384, 16);
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
            this.DatosOperativosComplete.Size = new System.Drawing.Size(384, 16);
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
            this.DatosOperativosFails.Size = new System.Drawing.Size(384, 16);
            this.DatosOperativosFails.TabIndex = 2;
            this.DatosOperativosFails.Text = "DatosOperativosFails";
            this.DatosOperativosFails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(786, 415);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // chart1
            // 
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Legend.Name = "Default Legend";
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart1.Size = new System.Drawing.Size(780, 355);
            this.chart1.TabIndex = 7;
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
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 364);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(780, 48);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // CartaDinagrafica
            // 
            this.CartaDinagrafica.AutoSize = true;
            this.CartaDinagrafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartaDinagrafica.Location = new System.Drawing.Point(393, 0);
            this.CartaDinagrafica.Name = "CartaDinagrafica";
            this.tableLayoutPanel6.SetRowSpan(this.CartaDinagrafica, 3);
            this.CartaDinagrafica.Size = new System.Drawing.Size(384, 48);
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
            this.CartaDinagraficaSends.Size = new System.Drawing.Size(384, 16);
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
            this.CartaDinagraficaComplete.Size = new System.Drawing.Size(384, 16);
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
            this.CartaDinagraficaFails.Size = new System.Drawing.Size(384, 16);
            this.CartaDinagraficaFails.TabIndex = 2;
            this.CartaDinagraficaFails.Text = "CartaDinagraficaFails";
            this.CartaDinagraficaFails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MonitoreoVirtual
            // 
            this.Controls.Add(this.tabControl1);
            this.Name = "MonitoreoVirtual";
            this.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tlpVariables.ResumeLayout(false);
            this.tlpVariables.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tlpVariables2.ResumeLayout(false);
            this.tlpVariables2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaHistorico)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label DatosOperativos;
        private Label DatosOperativosSends;
        private Label DatosOperativosComplete;
        private Label DatosOperativosFails;
        private TableLayoutPanel tableLayoutPanel5;
        internal DevExpress.XtraCharts.ChartControl chart1;
        private TableLayoutPanel tableLayoutPanel6;
        private Label CartaDinagrafica;
        private Label CartaDinagraficaSends;
        private Label CartaDinagraficaComplete;
        private Label CartaDinagraficaFails;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TableLayoutPanel tlpVariables;
        private Label PresionTuberiaProduccion;
        private Label PresionTuberiaRevestimiento;
        private Label PresionEntradaBomba;
        private Label SumergenciaEfectivaBomba;
        private Label PresionLineaDescarga;
        private Label NivelFluidoPozoTr;
        private Label TemperaturaSuperficie;
        private Label VelocidadUnidadBombeo;
        private Label VelocidadMotor;
        private Label LongitudCarrera;
        private Label EficienciaLlenado;
        private TabPage tabPage4;
        private TableLayoutPanel tlpVariables2;
        private Label GastoLiquidoPruebaProduccion;
        private Label PorcentajeAguaSedimento;
        private Label GravedadPetroleo;
        private Label GastoLiquido;
        private Label GastoAceite;
        private Label RelacionGasAceite;
        private Label GastoGas;
        private Label Emulsion;
        private Label SalinidadAgua;
        private Label GravedadEspecificaGasProducido;
        private Label CargaSobreBarraPulida;
        private TabPage tabPage5;
        private DataGridView dgvTablaHistorico;
    }
}