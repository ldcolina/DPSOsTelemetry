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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTemporizador1 = new System.Windows.Forms.Label();
            this.DatosOperativos = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tlpVariables = new System.Windows.Forms.TableLayoutPanel();
            this.PresionTuberiaProduccion = new System.Windows.Forms.CheckBox();
            this.PresionTuberiaProduccionMin = new System.Windows.Forms.TextBox();
            this.PresionTuberiaProduccionMax = new System.Windows.Forms.TextBox();
            this.PresionTuberiaRevestimiento = new System.Windows.Forms.CheckBox();
            this.PresionTuberiaRevestimientoMin = new System.Windows.Forms.TextBox();
            this.PresionTuberiaRevestimientoMax = new System.Windows.Forms.TextBox();
            this.PresionLineaDescarga = new System.Windows.Forms.CheckBox();
            this.PresionLineaDescargaMin = new System.Windows.Forms.TextBox();
            this.PresionLineaDescargaMax = new System.Windows.Forms.TextBox();
            this.TemperaturaSuperficie = new System.Windows.Forms.CheckBox();
            this.TemperaturaSuperficieMin = new System.Windows.Forms.TextBox();
            this.TemperaturaSuperficieMax = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tlpVariables2 = new System.Windows.Forms.TableLayoutPanel();
            this.GastoLiquidoPruebaProduccion = new System.Windows.Forms.CheckBox();
            this.GastoLiquidoPruebaProduccionMin = new System.Windows.Forms.TextBox();
            this.GastoLiquidoPruebaProduccionMax = new System.Windows.Forms.TextBox();
            this.PorcentajeAguaSedimento = new System.Windows.Forms.CheckBox();
            this.PorcentajeAguaSedimentoMin = new System.Windows.Forms.TextBox();
            this.PorcentajeAguaSedimentoMax = new System.Windows.Forms.TextBox();
            this.GravedadPetroleo = new System.Windows.Forms.CheckBox();
            this.GravedadPetroleoMin = new System.Windows.Forms.TextBox();
            this.GravedadPetroleoMax = new System.Windows.Forms.TextBox();
            this.GastoLiquido = new System.Windows.Forms.CheckBox();
            this.GastoAceite = new System.Windows.Forms.CheckBox();
            this.GastoLiquidoMin = new System.Windows.Forms.TextBox();
            this.GastoAceiteMin = new System.Windows.Forms.TextBox();
            this.GastoLiquidoMax = new System.Windows.Forms.TextBox();
            this.GastoAceiteMax = new System.Windows.Forms.TextBox();
            this.RelacionGasAceite = new System.Windows.Forms.CheckBox();
            this.GastoGas = new System.Windows.Forms.CheckBox();
            this.RelacionGasAceiteMin = new System.Windows.Forms.TextBox();
            this.GastoGasMin = new System.Windows.Forms.TextBox();
            this.RelacionGasAceiteMax = new System.Windows.Forms.TextBox();
            this.GastoGasMax = new System.Windows.Forms.TextBox();
            this.Emulsion = new System.Windows.Forms.CheckBox();
            this.EmulsionMin = new System.Windows.Forms.TextBox();
            this.EmulsionMax = new System.Windows.Forms.TextBox();
            this.SalinidadAgua = new System.Windows.Forms.CheckBox();
            this.SalinidadAguaMin = new System.Windows.Forms.TextBox();
            this.SalinidadAguaMax = new System.Windows.Forms.TextBox();
            this.GravedadEspecificaGasProducido = new System.Windows.Forms.CheckBox();
            this.GravedadEspecificaGasProducidoMin = new System.Windows.Forms.TextBox();
            this.GravedadEspecificaGasProducidoMax = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tlpVariables.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tlpVariables2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tabControl2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(596, 516);
            this.tableLayoutPanel2.TabIndex = 4;
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 485);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(590, 28);
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
            this.DatosOperativos.Size = new System.Drawing.Size(468, 22);
            this.DatosOperativos.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(590, 476);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.tlpVariables);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(582, 447);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "DatosOperativos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tlpVariables
            // 
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
            this.tlpVariables.Controls.Add(this.PresionLineaDescarga, 0, 3);
            this.tlpVariables.Controls.Add(this.PresionLineaDescargaMin, 0, 4);
            this.tlpVariables.Controls.Add(this.PresionLineaDescargaMax, 1, 4);
            this.tlpVariables.Controls.Add(this.TemperaturaSuperficie, 3, 3);
            this.tlpVariables.Controls.Add(this.TemperaturaSuperficieMin, 3, 4);
            this.tlpVariables.Controls.Add(this.TemperaturaSuperficieMax, 4, 4);
            this.tlpVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVariables.Location = new System.Drawing.Point(3, 3);
            this.tlpVariables.Name = "tlpVariables";
            this.tlpVariables.RowCount = 6;
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables.Size = new System.Drawing.Size(576, 441);
            this.tlpVariables.TabIndex = 4;
            // 
            // PresionTuberiaProduccion
            // 
            this.PresionTuberiaProduccion.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.PresionTuberiaProduccion, 2);
            this.PresionTuberiaProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaProduccion.Location = new System.Drawing.Point(3, 3);
            this.PresionTuberiaProduccion.Name = "PresionTuberiaProduccion";
            this.PresionTuberiaProduccion.Size = new System.Drawing.Size(272, 20);
            this.PresionTuberiaProduccion.TabIndex = 0;
            this.PresionTuberiaProduccion.Text = "PresionTuberiaProduccion";
            this.PresionTuberiaProduccion.UseVisualStyleBackColor = true;
            // 
            // PresionTuberiaProduccionMin
            // 
            this.PresionTuberiaProduccionMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaProduccionMin.Location = new System.Drawing.Point(3, 29);
            this.PresionTuberiaProduccionMin.Name = "PresionTuberiaProduccionMin";
            this.PresionTuberiaProduccionMin.Size = new System.Drawing.Size(133, 22);
            this.PresionTuberiaProduccionMin.TabIndex = 1;
            // 
            // PresionTuberiaProduccionMax
            // 
            this.PresionTuberiaProduccionMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaProduccionMax.Location = new System.Drawing.Point(142, 29);
            this.PresionTuberiaProduccionMax.Name = "PresionTuberiaProduccionMax";
            this.PresionTuberiaProduccionMax.Size = new System.Drawing.Size(133, 22);
            this.PresionTuberiaProduccionMax.TabIndex = 2;
            // 
            // PresionTuberiaRevestimiento
            // 
            this.PresionTuberiaRevestimiento.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.PresionTuberiaRevestimiento, 2);
            this.PresionTuberiaRevestimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaRevestimiento.Location = new System.Drawing.Point(301, 3);
            this.PresionTuberiaRevestimiento.Name = "PresionTuberiaRevestimiento";
            this.PresionTuberiaRevestimiento.Size = new System.Drawing.Size(272, 20);
            this.PresionTuberiaRevestimiento.TabIndex = 3;
            this.PresionTuberiaRevestimiento.Text = "PresionTuberiaRevestimiento";
            this.PresionTuberiaRevestimiento.UseVisualStyleBackColor = true;
            // 
            // PresionTuberiaRevestimientoMin
            // 
            this.PresionTuberiaRevestimientoMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaRevestimientoMin.Location = new System.Drawing.Point(301, 29);
            this.PresionTuberiaRevestimientoMin.Name = "PresionTuberiaRevestimientoMin";
            this.PresionTuberiaRevestimientoMin.Size = new System.Drawing.Size(133, 22);
            this.PresionTuberiaRevestimientoMin.TabIndex = 4;
            // 
            // PresionTuberiaRevestimientoMax
            // 
            this.PresionTuberiaRevestimientoMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaRevestimientoMax.Location = new System.Drawing.Point(440, 29);
            this.PresionTuberiaRevestimientoMax.Name = "PresionTuberiaRevestimientoMax";
            this.PresionTuberiaRevestimientoMax.Size = new System.Drawing.Size(133, 22);
            this.PresionTuberiaRevestimientoMax.TabIndex = 5;
            // 
            // PresionLineaDescarga
            // 
            this.PresionLineaDescarga.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.PresionLineaDescarga, 2);
            this.PresionLineaDescarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionLineaDescarga.Location = new System.Drawing.Point(3, 77);
            this.PresionLineaDescarga.Name = "PresionLineaDescarga";
            this.PresionLineaDescarga.Size = new System.Drawing.Size(272, 20);
            this.PresionLineaDescarga.TabIndex = 6;
            this.PresionLineaDescarga.Text = "PresionLineaDescarga";
            this.PresionLineaDescarga.UseVisualStyleBackColor = true;
            // 
            // PresionLineaDescargaMin
            // 
            this.PresionLineaDescargaMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionLineaDescargaMin.Location = new System.Drawing.Point(3, 103);
            this.PresionLineaDescargaMin.Name = "PresionLineaDescargaMin";
            this.PresionLineaDescargaMin.Size = new System.Drawing.Size(133, 22);
            this.PresionLineaDescargaMin.TabIndex = 7;
            // 
            // PresionLineaDescargaMax
            // 
            this.PresionLineaDescargaMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionLineaDescargaMax.Location = new System.Drawing.Point(142, 103);
            this.PresionLineaDescargaMax.Name = "PresionLineaDescargaMax";
            this.PresionLineaDescargaMax.Size = new System.Drawing.Size(133, 22);
            this.PresionLineaDescargaMax.TabIndex = 8;
            // 
            // TemperaturaSuperficie
            // 
            this.TemperaturaSuperficie.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.TemperaturaSuperficie, 2);
            this.TemperaturaSuperficie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemperaturaSuperficie.Location = new System.Drawing.Point(301, 77);
            this.TemperaturaSuperficie.Name = "TemperaturaSuperficie";
            this.TemperaturaSuperficie.Size = new System.Drawing.Size(272, 20);
            this.TemperaturaSuperficie.TabIndex = 9;
            this.TemperaturaSuperficie.Text = "TemperaturaSuperficie";
            this.TemperaturaSuperficie.UseVisualStyleBackColor = true;
            // 
            // TemperaturaSuperficieMin
            // 
            this.TemperaturaSuperficieMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemperaturaSuperficieMin.Location = new System.Drawing.Point(301, 103);
            this.TemperaturaSuperficieMin.Name = "TemperaturaSuperficieMin";
            this.TemperaturaSuperficieMin.Size = new System.Drawing.Size(133, 22);
            this.TemperaturaSuperficieMin.TabIndex = 10;
            // 
            // TemperaturaSuperficieMax
            // 
            this.TemperaturaSuperficieMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemperaturaSuperficieMax.Location = new System.Drawing.Point(440, 103);
            this.TemperaturaSuperficieMax.Name = "TemperaturaSuperficieMax";
            this.TemperaturaSuperficieMax.Size = new System.Drawing.Size(133, 22);
            this.TemperaturaSuperficieMax.TabIndex = 11;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.tlpVariables2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(582, 447);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "DatosProduccion";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tlpVariables2
            // 
            this.tlpVariables2.ColumnCount = 5;
            this.tlpVariables2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVariables2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVariables2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVariables2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVariables2.Controls.Add(this.GastoLiquidoPruebaProduccion, 0, 0);
            this.tlpVariables2.Controls.Add(this.GastoLiquidoPruebaProduccionMin, 0, 1);
            this.tlpVariables2.Controls.Add(this.GastoLiquidoPruebaProduccionMax, 1, 1);
            this.tlpVariables2.Controls.Add(this.PorcentajeAguaSedimento, 3, 0);
            this.tlpVariables2.Controls.Add(this.PorcentajeAguaSedimentoMin, 3, 1);
            this.tlpVariables2.Controls.Add(this.PorcentajeAguaSedimentoMax, 4, 1);
            this.tlpVariables2.Controls.Add(this.GravedadPetroleo, 0, 9);
            this.tlpVariables2.Controls.Add(this.GravedadPetroleoMin, 0, 10);
            this.tlpVariables2.Controls.Add(this.GravedadPetroleoMax, 1, 10);
            this.tlpVariables2.Controls.Add(this.GastoLiquido, 0, 6);
            this.tlpVariables2.Controls.Add(this.GastoAceite, 0, 3);
            this.tlpVariables2.Controls.Add(this.GastoLiquidoMin, 0, 7);
            this.tlpVariables2.Controls.Add(this.GastoAceiteMin, 0, 4);
            this.tlpVariables2.Controls.Add(this.GastoLiquidoMax, 1, 7);
            this.tlpVariables2.Controls.Add(this.GastoAceiteMax, 1, 4);
            this.tlpVariables2.Controls.Add(this.RelacionGasAceite, 3, 6);
            this.tlpVariables2.Controls.Add(this.GastoGas, 3, 3);
            this.tlpVariables2.Controls.Add(this.RelacionGasAceiteMin, 3, 7);
            this.tlpVariables2.Controls.Add(this.GastoGasMin, 3, 4);
            this.tlpVariables2.Controls.Add(this.RelacionGasAceiteMax, 4, 7);
            this.tlpVariables2.Controls.Add(this.GastoGasMax, 4, 4);
            this.tlpVariables2.Controls.Add(this.Emulsion, 3, 9);
            this.tlpVariables2.Controls.Add(this.EmulsionMin, 3, 10);
            this.tlpVariables2.Controls.Add(this.EmulsionMax, 4, 10);
            this.tlpVariables2.Controls.Add(this.SalinidadAgua, 0, 12);
            this.tlpVariables2.Controls.Add(this.SalinidadAguaMin, 0, 13);
            this.tlpVariables2.Controls.Add(this.SalinidadAguaMax, 1, 13);
            this.tlpVariables2.Controls.Add(this.GravedadEspecificaGasProducido, 3, 12);
            this.tlpVariables2.Controls.Add(this.GravedadEspecificaGasProducidoMin, 3, 13);
            this.tlpVariables2.Controls.Add(this.GravedadEspecificaGasProducidoMax, 4, 13);
            this.tlpVariables2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVariables2.Location = new System.Drawing.Point(3, 3);
            this.tlpVariables2.Name = "tlpVariables2";
            this.tlpVariables2.RowCount = 15;
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariables2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariables2.Size = new System.Drawing.Size(576, 441);
            this.tlpVariables2.TabIndex = 5;
            // 
            // GastoLiquidoPruebaProduccion
            // 
            this.GastoLiquidoPruebaProduccion.AutoSize = true;
            this.tlpVariables2.SetColumnSpan(this.GastoLiquidoPruebaProduccion, 2);
            this.GastoLiquidoPruebaProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoLiquidoPruebaProduccion.Location = new System.Drawing.Point(3, 3);
            this.GastoLiquidoPruebaProduccion.Name = "GastoLiquidoPruebaProduccion";
            this.GastoLiquidoPruebaProduccion.Size = new System.Drawing.Size(272, 20);
            this.GastoLiquidoPruebaProduccion.TabIndex = 0;
            this.GastoLiquidoPruebaProduccion.Text = "GastoLiquidoPruebaProduccion";
            this.GastoLiquidoPruebaProduccion.UseVisualStyleBackColor = true;
            // 
            // GastoLiquidoPruebaProduccionMin
            // 
            this.GastoLiquidoPruebaProduccionMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoLiquidoPruebaProduccionMin.Location = new System.Drawing.Point(3, 29);
            this.GastoLiquidoPruebaProduccionMin.Name = "GastoLiquidoPruebaProduccionMin";
            this.GastoLiquidoPruebaProduccionMin.Size = new System.Drawing.Size(133, 22);
            this.GastoLiquidoPruebaProduccionMin.TabIndex = 1;
            // 
            // GastoLiquidoPruebaProduccionMax
            // 
            this.GastoLiquidoPruebaProduccionMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoLiquidoPruebaProduccionMax.Location = new System.Drawing.Point(142, 29);
            this.GastoLiquidoPruebaProduccionMax.Name = "GastoLiquidoPruebaProduccionMax";
            this.GastoLiquidoPruebaProduccionMax.Size = new System.Drawing.Size(133, 22);
            this.GastoLiquidoPruebaProduccionMax.TabIndex = 2;
            // 
            // PorcentajeAguaSedimento
            // 
            this.PorcentajeAguaSedimento.AutoSize = true;
            this.tlpVariables2.SetColumnSpan(this.PorcentajeAguaSedimento, 2);
            this.PorcentajeAguaSedimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PorcentajeAguaSedimento.Location = new System.Drawing.Point(301, 3);
            this.PorcentajeAguaSedimento.Name = "PorcentajeAguaSedimento";
            this.PorcentajeAguaSedimento.Size = new System.Drawing.Size(272, 20);
            this.PorcentajeAguaSedimento.TabIndex = 3;
            this.PorcentajeAguaSedimento.Text = "PorcentajeAguaSedimento";
            this.PorcentajeAguaSedimento.UseVisualStyleBackColor = true;
            // 
            // PorcentajeAguaSedimentoMin
            // 
            this.PorcentajeAguaSedimentoMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PorcentajeAguaSedimentoMin.Location = new System.Drawing.Point(301, 29);
            this.PorcentajeAguaSedimentoMin.Name = "PorcentajeAguaSedimentoMin";
            this.PorcentajeAguaSedimentoMin.Size = new System.Drawing.Size(133, 22);
            this.PorcentajeAguaSedimentoMin.TabIndex = 4;
            // 
            // PorcentajeAguaSedimentoMax
            // 
            this.PorcentajeAguaSedimentoMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PorcentajeAguaSedimentoMax.Location = new System.Drawing.Point(440, 29);
            this.PorcentajeAguaSedimentoMax.Name = "PorcentajeAguaSedimentoMax";
            this.PorcentajeAguaSedimentoMax.Size = new System.Drawing.Size(133, 22);
            this.PorcentajeAguaSedimentoMax.TabIndex = 5;
            // 
            // GravedadPetroleo
            // 
            this.GravedadPetroleo.AutoSize = true;
            this.tlpVariables2.SetColumnSpan(this.GravedadPetroleo, 2);
            this.GravedadPetroleo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GravedadPetroleo.Location = new System.Drawing.Point(3, 225);
            this.GravedadPetroleo.Name = "GravedadPetroleo";
            this.GravedadPetroleo.Size = new System.Drawing.Size(272, 20);
            this.GravedadPetroleo.TabIndex = 18;
            this.GravedadPetroleo.Text = "GravedadPetroleo";
            this.GravedadPetroleo.UseVisualStyleBackColor = true;
            // 
            // GravedadPetroleoMin
            // 
            this.GravedadPetroleoMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GravedadPetroleoMin.Location = new System.Drawing.Point(3, 251);
            this.GravedadPetroleoMin.Name = "GravedadPetroleoMin";
            this.GravedadPetroleoMin.Size = new System.Drawing.Size(133, 22);
            this.GravedadPetroleoMin.TabIndex = 19;
            // 
            // GravedadPetroleoMax
            // 
            this.GravedadPetroleoMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GravedadPetroleoMax.Location = new System.Drawing.Point(142, 251);
            this.GravedadPetroleoMax.Name = "GravedadPetroleoMax";
            this.GravedadPetroleoMax.Size = new System.Drawing.Size(133, 22);
            this.GravedadPetroleoMax.TabIndex = 20;
            // 
            // GastoLiquido
            // 
            this.GastoLiquido.AutoSize = true;
            this.tlpVariables2.SetColumnSpan(this.GastoLiquido, 2);
            this.GastoLiquido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoLiquido.Location = new System.Drawing.Point(3, 151);
            this.GastoLiquido.Name = "GastoLiquido";
            this.GastoLiquido.Size = new System.Drawing.Size(272, 20);
            this.GastoLiquido.TabIndex = 12;
            this.GastoLiquido.Text = "GastoLiquido";
            this.GastoLiquido.UseVisualStyleBackColor = true;
            // 
            // GastoAceite
            // 
            this.GastoAceite.AutoSize = true;
            this.tlpVariables2.SetColumnSpan(this.GastoAceite, 2);
            this.GastoAceite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoAceite.Location = new System.Drawing.Point(3, 77);
            this.GastoAceite.Name = "GastoAceite";
            this.GastoAceite.Size = new System.Drawing.Size(272, 20);
            this.GastoAceite.TabIndex = 6;
            this.GastoAceite.Text = "GastoAceite";
            this.GastoAceite.UseVisualStyleBackColor = true;
            // 
            // GastoLiquidoMin
            // 
            this.GastoLiquidoMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoLiquidoMin.Location = new System.Drawing.Point(3, 177);
            this.GastoLiquidoMin.Name = "GastoLiquidoMin";
            this.GastoLiquidoMin.Size = new System.Drawing.Size(133, 22);
            this.GastoLiquidoMin.TabIndex = 13;
            // 
            // GastoAceiteMin
            // 
            this.GastoAceiteMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoAceiteMin.Location = new System.Drawing.Point(3, 103);
            this.GastoAceiteMin.Name = "GastoAceiteMin";
            this.GastoAceiteMin.Size = new System.Drawing.Size(133, 22);
            this.GastoAceiteMin.TabIndex = 7;
            // 
            // GastoLiquidoMax
            // 
            this.GastoLiquidoMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoLiquidoMax.Location = new System.Drawing.Point(142, 177);
            this.GastoLiquidoMax.Name = "GastoLiquidoMax";
            this.GastoLiquidoMax.Size = new System.Drawing.Size(133, 22);
            this.GastoLiquidoMax.TabIndex = 14;
            // 
            // GastoAceiteMax
            // 
            this.GastoAceiteMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoAceiteMax.Location = new System.Drawing.Point(142, 103);
            this.GastoAceiteMax.Name = "GastoAceiteMax";
            this.GastoAceiteMax.Size = new System.Drawing.Size(133, 22);
            this.GastoAceiteMax.TabIndex = 8;
            // 
            // RelacionGasAceite
            // 
            this.RelacionGasAceite.AutoSize = true;
            this.tlpVariables2.SetColumnSpan(this.RelacionGasAceite, 2);
            this.RelacionGasAceite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RelacionGasAceite.Location = new System.Drawing.Point(301, 151);
            this.RelacionGasAceite.Name = "RelacionGasAceite";
            this.RelacionGasAceite.Size = new System.Drawing.Size(272, 20);
            this.RelacionGasAceite.TabIndex = 15;
            this.RelacionGasAceite.Text = "RelacionGasAceite";
            this.RelacionGasAceite.UseVisualStyleBackColor = true;
            // 
            // GastoGas
            // 
            this.GastoGas.AutoSize = true;
            this.tlpVariables2.SetColumnSpan(this.GastoGas, 2);
            this.GastoGas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoGas.Location = new System.Drawing.Point(301, 77);
            this.GastoGas.Name = "GastoGas";
            this.GastoGas.Size = new System.Drawing.Size(272, 20);
            this.GastoGas.TabIndex = 9;
            this.GastoGas.Text = "GastoGas";
            this.GastoGas.UseVisualStyleBackColor = true;
            // 
            // RelacionGasAceiteMin
            // 
            this.RelacionGasAceiteMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RelacionGasAceiteMin.Location = new System.Drawing.Point(301, 177);
            this.RelacionGasAceiteMin.Name = "RelacionGasAceiteMin";
            this.RelacionGasAceiteMin.Size = new System.Drawing.Size(133, 22);
            this.RelacionGasAceiteMin.TabIndex = 16;
            // 
            // GastoGasMin
            // 
            this.GastoGasMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoGasMin.Location = new System.Drawing.Point(301, 103);
            this.GastoGasMin.Name = "GastoGasMin";
            this.GastoGasMin.Size = new System.Drawing.Size(133, 22);
            this.GastoGasMin.TabIndex = 10;
            // 
            // RelacionGasAceiteMax
            // 
            this.RelacionGasAceiteMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RelacionGasAceiteMax.Location = new System.Drawing.Point(440, 177);
            this.RelacionGasAceiteMax.Name = "RelacionGasAceiteMax";
            this.RelacionGasAceiteMax.Size = new System.Drawing.Size(133, 22);
            this.RelacionGasAceiteMax.TabIndex = 17;
            // 
            // GastoGasMax
            // 
            this.GastoGasMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoGasMax.Location = new System.Drawing.Point(440, 103);
            this.GastoGasMax.Name = "GastoGasMax";
            this.GastoGasMax.Size = new System.Drawing.Size(133, 22);
            this.GastoGasMax.TabIndex = 11;
            // 
            // Emulsion
            // 
            this.Emulsion.AutoSize = true;
            this.tlpVariables2.SetColumnSpan(this.Emulsion, 2);
            this.Emulsion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Emulsion.Location = new System.Drawing.Point(301, 225);
            this.Emulsion.Name = "Emulsion";
            this.Emulsion.Size = new System.Drawing.Size(272, 20);
            this.Emulsion.TabIndex = 21;
            this.Emulsion.Text = "Emulsion";
            this.Emulsion.UseVisualStyleBackColor = true;
            // 
            // EmulsionMin
            // 
            this.EmulsionMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmulsionMin.Location = new System.Drawing.Point(301, 251);
            this.EmulsionMin.Name = "EmulsionMin";
            this.EmulsionMin.Size = new System.Drawing.Size(133, 22);
            this.EmulsionMin.TabIndex = 22;
            // 
            // EmulsionMax
            // 
            this.EmulsionMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmulsionMax.Location = new System.Drawing.Point(440, 251);
            this.EmulsionMax.Name = "EmulsionMax";
            this.EmulsionMax.Size = new System.Drawing.Size(133, 22);
            this.EmulsionMax.TabIndex = 23;
            // 
            // SalinidadAgua
            // 
            this.SalinidadAgua.AutoSize = true;
            this.tlpVariables2.SetColumnSpan(this.SalinidadAgua, 2);
            this.SalinidadAgua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalinidadAgua.Location = new System.Drawing.Point(3, 299);
            this.SalinidadAgua.Name = "SalinidadAgua";
            this.SalinidadAgua.Size = new System.Drawing.Size(272, 20);
            this.SalinidadAgua.TabIndex = 24;
            this.SalinidadAgua.Text = "SalinidadAgua";
            this.SalinidadAgua.UseVisualStyleBackColor = true;
            // 
            // SalinidadAguaMin
            // 
            this.SalinidadAguaMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalinidadAguaMin.Location = new System.Drawing.Point(3, 325);
            this.SalinidadAguaMin.Name = "SalinidadAguaMin";
            this.SalinidadAguaMin.Size = new System.Drawing.Size(133, 22);
            this.SalinidadAguaMin.TabIndex = 25;
            // 
            // SalinidadAguaMax
            // 
            this.SalinidadAguaMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalinidadAguaMax.Location = new System.Drawing.Point(142, 325);
            this.SalinidadAguaMax.Name = "SalinidadAguaMax";
            this.SalinidadAguaMax.Size = new System.Drawing.Size(133, 22);
            this.SalinidadAguaMax.TabIndex = 26;
            // 
            // GravedadEspecificaGasProducido
            // 
            this.GravedadEspecificaGasProducido.AutoSize = true;
            this.tlpVariables2.SetColumnSpan(this.GravedadEspecificaGasProducido, 2);
            this.GravedadEspecificaGasProducido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GravedadEspecificaGasProducido.Location = new System.Drawing.Point(301, 299);
            this.GravedadEspecificaGasProducido.Name = "GravedadEspecificaGasProducido";
            this.GravedadEspecificaGasProducido.Size = new System.Drawing.Size(272, 20);
            this.GravedadEspecificaGasProducido.TabIndex = 27;
            this.GravedadEspecificaGasProducido.Text = "GravedadEspecificaGasProducido";
            this.GravedadEspecificaGasProducido.UseVisualStyleBackColor = true;
            // 
            // GravedadEspecificaGasProducidoMin
            // 
            this.GravedadEspecificaGasProducidoMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GravedadEspecificaGasProducidoMin.Location = new System.Drawing.Point(301, 325);
            this.GravedadEspecificaGasProducidoMin.Name = "GravedadEspecificaGasProducidoMin";
            this.GravedadEspecificaGasProducidoMin.Size = new System.Drawing.Size(133, 22);
            this.GravedadEspecificaGasProducidoMin.TabIndex = 28;
            // 
            // GravedadEspecificaGasProducidoMax
            // 
            this.GravedadEspecificaGasProducidoMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GravedadEspecificaGasProducidoMax.Location = new System.Drawing.Point(440, 325);
            this.GravedadEspecificaGasProducidoMax.Name = "GravedadEspecificaGasProducidoMax";
            this.GravedadEspecificaGasProducidoMax.Size = new System.Drawing.Size(133, 22);
            this.GravedadEspecificaGasProducidoMax.TabIndex = 29;
            // 
            // TomaInformacion
            // 
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "TomaInformacion";
            this.Size = new System.Drawing.Size(596, 516);
            this.Load += new System.EventHandler(this.TomaInformacion_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tlpVariables.ResumeLayout(false);
            this.tlpVariables.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tlpVariables2.ResumeLayout(false);
            this.tlpVariables2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lbTemporizador1;
        private TextBox DatosOperativos;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TableLayoutPanel tlpVariables;
        private CheckBox PresionTuberiaProduccion;
        private TextBox PresionTuberiaProduccionMin;
        private TextBox PresionTuberiaProduccionMax;
        private CheckBox PresionTuberiaRevestimiento;
        private TextBox PresionTuberiaRevestimientoMin;
        private TextBox PresionTuberiaRevestimientoMax;
        private CheckBox PresionLineaDescarga;
        private TextBox PresionLineaDescargaMin;
        private TextBox PresionLineaDescargaMax;
        private CheckBox TemperaturaSuperficie;
        private TextBox TemperaturaSuperficieMin;
        private TextBox TemperaturaSuperficieMax;
        private TabPage tabPage4;
        private TableLayoutPanel tlpVariables2;
        private CheckBox GastoLiquidoPruebaProduccion;
        private TextBox GastoLiquidoPruebaProduccionMin;
        private TextBox GastoLiquidoPruebaProduccionMax;
        private CheckBox PorcentajeAguaSedimento;
        private TextBox PorcentajeAguaSedimentoMin;
        private TextBox PorcentajeAguaSedimentoMax;
        private CheckBox GravedadPetroleo;
        private TextBox GravedadPetroleoMin;
        private TextBox GravedadPetroleoMax;
        private CheckBox GastoLiquido;
        private CheckBox GastoAceite;
        private TextBox GastoLiquidoMin;
        private TextBox GastoAceiteMin;
        private TextBox GastoLiquidoMax;
        private TextBox GastoAceiteMax;
        private CheckBox RelacionGasAceite;
        private CheckBox GastoGas;
        private TextBox RelacionGasAceiteMin;
        private TextBox GastoGasMin;
        private TextBox RelacionGasAceiteMax;
        private TextBox GastoGasMax;
        private CheckBox Emulsion;
        private TextBox EmulsionMin;
        private TextBox EmulsionMax;
        private CheckBox SalinidadAgua;
        private TextBox SalinidadAguaMin;
        private TextBox SalinidadAguaMax;
        private CheckBox GravedadEspecificaGasProducido;
        private TextBox GravedadEspecificaGasProducidoMin;
        private TextBox GravedadEspecificaGasProducidoMax;
    }
}