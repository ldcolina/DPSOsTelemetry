using System.Windows.Forms;

namespace DPSOsTelemetria.Pozos.PozoBombeoNeumatico
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tlpVariables = new System.Windows.Forms.TableLayoutPanel();
            this.PresionSeparacion = new System.Windows.Forms.Label();
            this.PresionTuberiaProduccion = new System.Windows.Forms.Label();
            this.PresionTuberiaRevestimiento = new System.Windows.Forms.Label();
            this.PresionLineaDescarga = new System.Windows.Forms.Label();
            this.TemperaturaSuperficie = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tlpVariables2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpUser = new System.Windows.Forms.TableLayoutPanel();
            this.GravedadEspecificaGasInyeccion = new System.Windows.Forms.Label();
            this.tlpMeteringValve = new System.Windows.Forms.TableLayoutPanel();
            this.PresionDisponible3 = new System.Windows.Forms.Label();
            this.AjusteValvula = new System.Windows.Forms.Label();
            this.tlpPlateOrifice = new System.Windows.Forms.TableLayoutPanel();
            this.PresionDisponible2 = new System.Windows.Forms.Label();
            this.PresionDiferencial = new System.Windows.Forms.Label();
            this.DiametroOrificio = new System.Windows.Forms.Label();
            this.tlpManualValveControl = new System.Windows.Forms.TableLayoutPanel();
            this.PresionDisponible1 = new System.Windows.Forms.Label();
            this.NroVuelta = new System.Windows.Forms.Label();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTablaHistorico = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.DatosOperativos = new System.Windows.Forms.Label();
            this.DatosOperativosSends = new System.Windows.Forms.Label();
            this.DatosOperativosComplete = new System.Windows.Forms.Label();
            this.DatosOperativosFails = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tlpVariables.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tlpVariables2.SuspendLayout();
            this.tlpUser.SuspendLayout();
            this.tlpMeteringValve.SuspendLayout();
            this.tlpPlateOrifice.SuspendLayout();
            this.tlpManualValveControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaHistorico)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(758, 673);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(752, 622);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.tlpVariables);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(744, 596);
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
            this.tlpVariables.Controls.Add(this.PresionSeparacion, 0, 4);
            this.tlpVariables.Controls.Add(this.PresionTuberiaProduccion, 0, 0);
            this.tlpVariables.Controls.Add(this.PresionTuberiaRevestimiento, 2, 0);
            this.tlpVariables.Controls.Add(this.PresionLineaDescarga, 0, 2);
            this.tlpVariables.Controls.Add(this.TemperaturaSuperficie, 2, 2);
            this.tlpVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVariables.Location = new System.Drawing.Point(3, 3);
            this.tlpVariables.Name = "tlpVariables";
            this.tlpVariables.RowCount = 6;
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.Size = new System.Drawing.Size(738, 590);
            this.tlpVariables.TabIndex = 4;
            // 
            // PresionSeparacion
            // 
            this.PresionSeparacion.AutoSize = true;
            this.PresionSeparacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionSeparacion.Location = new System.Drawing.Point(3, 66);
            this.PresionSeparacion.Name = "PresionSeparacion";
            this.PresionSeparacion.Size = new System.Drawing.Size(353, 13);
            this.PresionSeparacion.TabIndex = 10;
            this.PresionSeparacion.Text = "PresionSeparacion";
            // 
            // PresionTuberiaProduccion
            // 
            this.PresionTuberiaProduccion.AutoSize = true;
            this.PresionTuberiaProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaProduccion.Location = new System.Drawing.Point(3, 0);
            this.PresionTuberiaProduccion.Name = "PresionTuberiaProduccion";
            this.PresionTuberiaProduccion.Size = new System.Drawing.Size(353, 13);
            this.PresionTuberiaProduccion.TabIndex = 0;
            this.PresionTuberiaProduccion.Text = "PresionTuberiaProduccion";
            // 
            // PresionTuberiaRevestimiento
            // 
            this.PresionTuberiaRevestimiento.AutoSize = true;
            this.PresionTuberiaRevestimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaRevestimiento.Location = new System.Drawing.Point(382, 0);
            this.PresionTuberiaRevestimiento.Name = "PresionTuberiaRevestimiento";
            this.PresionTuberiaRevestimiento.Size = new System.Drawing.Size(353, 13);
            this.PresionTuberiaRevestimiento.TabIndex = 3;
            this.PresionTuberiaRevestimiento.Text = "PresionTuberiaRevestimiento";
            // 
            // PresionLineaDescarga
            // 
            this.PresionLineaDescarga.AutoSize = true;
            this.PresionLineaDescarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionLineaDescarga.Location = new System.Drawing.Point(3, 33);
            this.PresionLineaDescarga.Name = "PresionLineaDescarga";
            this.PresionLineaDescarga.Size = new System.Drawing.Size(353, 13);
            this.PresionLineaDescarga.TabIndex = 6;
            this.PresionLineaDescarga.Text = "PresionLineaDescarga";
            // 
            // TemperaturaSuperficie
            // 
            this.TemperaturaSuperficie.AutoSize = true;
            this.TemperaturaSuperficie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemperaturaSuperficie.Location = new System.Drawing.Point(382, 33);
            this.TemperaturaSuperficie.Name = "TemperaturaSuperficie";
            this.TemperaturaSuperficie.Size = new System.Drawing.Size(353, 13);
            this.TemperaturaSuperficie.TabIndex = 9;
            this.TemperaturaSuperficie.Text = "TemperaturaSuperficie";
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.tlpVariables2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(744, 596);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "DatosProduccion";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tlpVariables2
            // 
            this.tlpVariables2.AutoScroll = true;
            this.tlpVariables2.ColumnCount = 3;
            this.tlpVariables2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVariables2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVariables2.Controls.Add(this.tlpUser, 0, 13);
            this.tlpVariables2.Controls.Add(this.tlpMeteringValve, 0, 12);
            this.tlpVariables2.Controls.Add(this.tlpPlateOrifice, 0, 11);
            this.tlpVariables2.Controls.Add(this.tlpManualValveControl, 0, 10);
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
            this.tlpVariables2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVariables2.Location = new System.Drawing.Point(3, 3);
            this.tlpVariables2.Name = "tlpVariables2";
            this.tlpVariables2.RowCount = 15;
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
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.Size = new System.Drawing.Size(738, 590);
            this.tlpVariables2.TabIndex = 5;
            // 
            // tlpUser
            // 
            this.tlpUser.AutoSize = true;
            this.tlpUser.ColumnCount = 3;
            this.tlpVariables2.SetColumnSpan(this.tlpUser, 3);
            this.tlpUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUser.Controls.Add(this.GravedadEspecificaGasInyeccion, 0, 0);
            this.tlpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUser.Location = new System.Drawing.Point(0, 237);
            this.tlpUser.Margin = new System.Windows.Forms.Padding(0);
            this.tlpUser.Name = "tlpUser";
            this.tlpUser.RowCount = 1;
            this.tlpUser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUser.Size = new System.Drawing.Size(738, 13);
            this.tlpUser.TabIndex = 34;
            // 
            // GravedadEspecificaGasInyeccion
            // 
            this.GravedadEspecificaGasInyeccion.AutoSize = true;
            this.GravedadEspecificaGasInyeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GravedadEspecificaGasInyeccion.Location = new System.Drawing.Point(0, 0);
            this.GravedadEspecificaGasInyeccion.Margin = new System.Windows.Forms.Padding(0);
            this.GravedadEspecificaGasInyeccion.Name = "GravedadEspecificaGasInyeccion";
            this.GravedadEspecificaGasInyeccion.Size = new System.Drawing.Size(359, 13);
            this.GravedadEspecificaGasInyeccion.TabIndex = 0;
            this.GravedadEspecificaGasInyeccion.Text = "GravedadEspecificaGasInyeccion";
            // 
            // tlpMeteringValve
            // 
            this.tlpMeteringValve.AutoSize = true;
            this.tlpMeteringValve.ColumnCount = 3;
            this.tlpVariables2.SetColumnSpan(this.tlpMeteringValve, 3);
            this.tlpMeteringValve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMeteringValve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeteringValve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMeteringValve.Controls.Add(this.PresionDisponible3, 0, 0);
            this.tlpMeteringValve.Controls.Add(this.AjusteValvula, 2, 0);
            this.tlpMeteringValve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMeteringValve.Location = new System.Drawing.Point(0, 224);
            this.tlpMeteringValve.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMeteringValve.Name = "tlpMeteringValve";
            this.tlpMeteringValve.RowCount = 1;
            this.tlpMeteringValve.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMeteringValve.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeteringValve.Size = new System.Drawing.Size(738, 13);
            this.tlpMeteringValve.TabIndex = 33;
            // 
            // PresionDisponible3
            // 
            this.PresionDisponible3.AutoSize = true;
            this.PresionDisponible3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionDisponible3.Location = new System.Drawing.Point(3, 0);
            this.PresionDisponible3.Name = "PresionDisponible3";
            this.PresionDisponible3.Size = new System.Drawing.Size(353, 13);
            this.PresionDisponible3.TabIndex = 0;
            this.PresionDisponible3.Text = "PresionDisponible";
            // 
            // AjusteValvula
            // 
            this.AjusteValvula.AutoSize = true;
            this.AjusteValvula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AjusteValvula.Location = new System.Drawing.Point(382, 0);
            this.AjusteValvula.Name = "AjusteValvula";
            this.AjusteValvula.Size = new System.Drawing.Size(353, 13);
            this.AjusteValvula.TabIndex = 1;
            this.AjusteValvula.Text = "AjusteValvula";
            // 
            // tlpPlateOrifice
            // 
            this.tlpPlateOrifice.AutoSize = true;
            this.tlpPlateOrifice.ColumnCount = 3;
            this.tlpVariables2.SetColumnSpan(this.tlpPlateOrifice, 3);
            this.tlpPlateOrifice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlateOrifice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPlateOrifice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlateOrifice.Controls.Add(this.PresionDisponible2, 0, 0);
            this.tlpPlateOrifice.Controls.Add(this.PresionDiferencial, 2, 0);
            this.tlpPlateOrifice.Controls.Add(this.DiametroOrificio, 0, 2);
            this.tlpPlateOrifice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlateOrifice.Location = new System.Drawing.Point(0, 178);
            this.tlpPlateOrifice.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPlateOrifice.Name = "tlpPlateOrifice";
            this.tlpPlateOrifice.RowCount = 3;
            this.tlpPlateOrifice.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlateOrifice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPlateOrifice.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlateOrifice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPlateOrifice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPlateOrifice.Size = new System.Drawing.Size(738, 46);
            this.tlpPlateOrifice.TabIndex = 32;
            // 
            // PresionDisponible2
            // 
            this.PresionDisponible2.AutoSize = true;
            this.PresionDisponible2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionDisponible2.Location = new System.Drawing.Point(3, 0);
            this.PresionDisponible2.Name = "PresionDisponible2";
            this.PresionDisponible2.Size = new System.Drawing.Size(353, 13);
            this.PresionDisponible2.TabIndex = 0;
            this.PresionDisponible2.Text = "PresionDisponible";
            // 
            // PresionDiferencial
            // 
            this.PresionDiferencial.AutoSize = true;
            this.PresionDiferencial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionDiferencial.Location = new System.Drawing.Point(382, 0);
            this.PresionDiferencial.Name = "PresionDiferencial";
            this.PresionDiferencial.Size = new System.Drawing.Size(353, 13);
            this.PresionDiferencial.TabIndex = 1;
            this.PresionDiferencial.Text = "PresionDiferencial";
            // 
            // DiametroOrificio
            // 
            this.DiametroOrificio.AutoSize = true;
            this.DiametroOrificio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiametroOrificio.Location = new System.Drawing.Point(3, 33);
            this.DiametroOrificio.Name = "DiametroOrificio";
            this.DiametroOrificio.Size = new System.Drawing.Size(353, 13);
            this.DiametroOrificio.TabIndex = 2;
            this.DiametroOrificio.Text = "DiametroOrificio";
            // 
            // tlpManualValveControl
            // 
            this.tlpManualValveControl.AutoSize = true;
            this.tlpManualValveControl.ColumnCount = 3;
            this.tlpVariables2.SetColumnSpan(this.tlpManualValveControl, 3);
            this.tlpManualValveControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpManualValveControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpManualValveControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpManualValveControl.Controls.Add(this.PresionDisponible1, 0, 0);
            this.tlpManualValveControl.Controls.Add(this.NroVuelta, 2, 0);
            this.tlpManualValveControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpManualValveControl.Location = new System.Drawing.Point(0, 165);
            this.tlpManualValveControl.Margin = new System.Windows.Forms.Padding(0);
            this.tlpManualValveControl.Name = "tlpManualValveControl";
            this.tlpManualValveControl.RowCount = 1;
            this.tlpManualValveControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpManualValveControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpManualValveControl.Size = new System.Drawing.Size(738, 13);
            this.tlpManualValveControl.TabIndex = 31;
            // 
            // PresionDisponible1
            // 
            this.PresionDisponible1.AutoSize = true;
            this.PresionDisponible1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionDisponible1.Location = new System.Drawing.Point(3, 0);
            this.PresionDisponible1.Name = "PresionDisponible1";
            this.PresionDisponible1.Size = new System.Drawing.Size(353, 13);
            this.PresionDisponible1.TabIndex = 0;
            this.PresionDisponible1.Text = "PresionDisponible";
            // 
            // NroVuelta
            // 
            this.NroVuelta.AutoSize = true;
            this.NroVuelta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NroVuelta.Location = new System.Drawing.Point(382, 0);
            this.NroVuelta.Name = "NroVuelta";
            this.NroVuelta.Size = new System.Drawing.Size(353, 13);
            this.NroVuelta.TabIndex = 1;
            this.NroVuelta.Text = "NroVuelta";
            // 
            // GastoLiquidoPruebaProduccion
            // 
            this.GastoLiquidoPruebaProduccion.AutoSize = true;
            this.GastoLiquidoPruebaProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoLiquidoPruebaProduccion.Location = new System.Drawing.Point(3, 0);
            this.GastoLiquidoPruebaProduccion.Name = "GastoLiquidoPruebaProduccion";
            this.GastoLiquidoPruebaProduccion.Size = new System.Drawing.Size(353, 13);
            this.GastoLiquidoPruebaProduccion.TabIndex = 0;
            this.GastoLiquidoPruebaProduccion.Text = "GastoLiquidoPruebaProduccion";
            // 
            // PorcentajeAguaSedimento
            // 
            this.PorcentajeAguaSedimento.AutoSize = true;
            this.PorcentajeAguaSedimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PorcentajeAguaSedimento.Location = new System.Drawing.Point(382, 0);
            this.PorcentajeAguaSedimento.Name = "PorcentajeAguaSedimento";
            this.PorcentajeAguaSedimento.Size = new System.Drawing.Size(353, 13);
            this.PorcentajeAguaSedimento.TabIndex = 3;
            this.PorcentajeAguaSedimento.Text = "PorcentajeAguaSedimento";
            // 
            // GravedadPetroleo
            // 
            this.GravedadPetroleo.AutoSize = true;
            this.GravedadPetroleo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GravedadPetroleo.Location = new System.Drawing.Point(3, 99);
            this.GravedadPetroleo.Name = "GravedadPetroleo";
            this.GravedadPetroleo.Size = new System.Drawing.Size(353, 13);
            this.GravedadPetroleo.TabIndex = 18;
            this.GravedadPetroleo.Text = "GravedadPetroleo";
            // 
            // GastoLiquido
            // 
            this.GastoLiquido.AutoSize = true;
            this.GastoLiquido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoLiquido.Location = new System.Drawing.Point(3, 66);
            this.GastoLiquido.Name = "GastoLiquido";
            this.GastoLiquido.Size = new System.Drawing.Size(353, 13);
            this.GastoLiquido.TabIndex = 12;
            this.GastoLiquido.Text = "GastoLiquido";
            // 
            // GastoAceite
            // 
            this.GastoAceite.AutoSize = true;
            this.GastoAceite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoAceite.Location = new System.Drawing.Point(3, 33);
            this.GastoAceite.Name = "GastoAceite";
            this.GastoAceite.Size = new System.Drawing.Size(353, 13);
            this.GastoAceite.TabIndex = 6;
            this.GastoAceite.Text = "GastoAceite";
            // 
            // RelacionGasAceite
            // 
            this.RelacionGasAceite.AutoSize = true;
            this.RelacionGasAceite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RelacionGasAceite.Location = new System.Drawing.Point(382, 66);
            this.RelacionGasAceite.Name = "RelacionGasAceite";
            this.RelacionGasAceite.Size = new System.Drawing.Size(353, 13);
            this.RelacionGasAceite.TabIndex = 15;
            this.RelacionGasAceite.Text = "RelacionGasAceite";
            // 
            // GastoGas
            // 
            this.GastoGas.AutoSize = true;
            this.GastoGas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoGas.Location = new System.Drawing.Point(382, 33);
            this.GastoGas.Name = "GastoGas";
            this.GastoGas.Size = new System.Drawing.Size(353, 13);
            this.GastoGas.TabIndex = 9;
            this.GastoGas.Text = "GastoGas";
            // 
            // Emulsion
            // 
            this.Emulsion.AutoSize = true;
            this.Emulsion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Emulsion.Location = new System.Drawing.Point(382, 99);
            this.Emulsion.Name = "Emulsion";
            this.Emulsion.Size = new System.Drawing.Size(353, 13);
            this.Emulsion.TabIndex = 21;
            this.Emulsion.Text = "Emulsion";
            // 
            // SalinidadAgua
            // 
            this.SalinidadAgua.AutoSize = true;
            this.SalinidadAgua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalinidadAgua.Location = new System.Drawing.Point(3, 132);
            this.SalinidadAgua.Name = "SalinidadAgua";
            this.SalinidadAgua.Size = new System.Drawing.Size(353, 13);
            this.SalinidadAgua.TabIndex = 24;
            this.SalinidadAgua.Text = "SalinidadAgua";
            // 
            // GravedadEspecificaGasProducido
            // 
            this.GravedadEspecificaGasProducido.AutoSize = true;
            this.GravedadEspecificaGasProducido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GravedadEspecificaGasProducido.Location = new System.Drawing.Point(382, 132);
            this.GravedadEspecificaGasProducido.Name = "GravedadEspecificaGasProducido";
            this.GravedadEspecificaGasProducido.Size = new System.Drawing.Size(353, 13);
            this.GravedadEspecificaGasProducido.TabIndex = 27;
            this.GravedadEspecificaGasProducido.Text = "GravedadEspecificaGasProducido";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTablaHistorico);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 596);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.dgvTablaHistorico.Size = new System.Drawing.Size(738, 590);
            this.dgvTablaHistorico.TabIndex = 1;
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 631);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(752, 39);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // DatosOperativos
            // 
            this.DatosOperativos.AutoSize = true;
            this.DatosOperativos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosOperativos.Location = new System.Drawing.Point(379, 0);
            this.DatosOperativos.Name = "DatosOperativos";
            this.tableLayoutPanel4.SetRowSpan(this.DatosOperativos, 3);
            this.DatosOperativos.Size = new System.Drawing.Size(370, 39);
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
            this.DatosOperativosSends.Size = new System.Drawing.Size(370, 13);
            this.DatosOperativosSends.TabIndex = 0;
            this.DatosOperativosSends.Text = "DatosOperativosSends";
            this.DatosOperativosSends.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DatosOperativosComplete
            // 
            this.DatosOperativosComplete.AutoSize = true;
            this.DatosOperativosComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosOperativosComplete.Location = new System.Drawing.Point(3, 13);
            this.DatosOperativosComplete.Name = "DatosOperativosComplete";
            this.DatosOperativosComplete.Size = new System.Drawing.Size(370, 13);
            this.DatosOperativosComplete.TabIndex = 1;
            this.DatosOperativosComplete.Text = "DatosOperativosComplete";
            this.DatosOperativosComplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DatosOperativosFails
            // 
            this.DatosOperativosFails.AutoSize = true;
            this.DatosOperativosFails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosOperativosFails.Location = new System.Drawing.Point(3, 26);
            this.DatosOperativosFails.Name = "DatosOperativosFails";
            this.DatosOperativosFails.Size = new System.Drawing.Size(370, 13);
            this.DatosOperativosFails.TabIndex = 2;
            this.DatosOperativosFails.Text = "DatosOperativosFails";
            this.DatosOperativosFails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MonitoreoVirtual
            // 
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "MonitoreoVirtual";
            this.Size = new System.Drawing.Size(758, 673);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tlpVariables.ResumeLayout(false);
            this.tlpVariables.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tlpVariables2.ResumeLayout(false);
            this.tlpVariables2.PerformLayout();
            this.tlpUser.ResumeLayout(false);
            this.tlpUser.PerformLayout();
            this.tlpMeteringValve.ResumeLayout(false);
            this.tlpMeteringValve.PerformLayout();
            this.tlpPlateOrifice.ResumeLayout(false);
            this.tlpPlateOrifice.PerformLayout();
            this.tlpManualValveControl.ResumeLayout(false);
            this.tlpManualValveControl.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaHistorico)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TableLayoutPanel tlpVariables;
        private Label PresionTuberiaProduccion;
        private Label PresionTuberiaRevestimiento;
        private Label PresionLineaDescarga;
        private Label TemperaturaSuperficie;
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
        private TabPage tabPage1;
        private DataGridView dgvTablaHistorico;
        private TableLayoutPanel tableLayoutPanel4;
        private Label DatosOperativos;
        private Label DatosOperativosSends;
        private Label DatosOperativosComplete;
        private Label DatosOperativosFails;
        private Label PresionSeparacion;
        private TableLayoutPanel tlpManualValveControl;
        private Label PresionDisponible1;
        private Label NroVuelta;
        private TableLayoutPanel tlpPlateOrifice;
        private Label PresionDisponible2;
        private Label PresionDiferencial;
        private Label DiametroOrificio;
        private TableLayoutPanel tlpMeteringValve;
        private Label PresionDisponible3;
        private Label AjusteValvula;
        private TableLayoutPanel tlpUser;
        private Label GravedadEspecificaGasInyeccion;
    }
}