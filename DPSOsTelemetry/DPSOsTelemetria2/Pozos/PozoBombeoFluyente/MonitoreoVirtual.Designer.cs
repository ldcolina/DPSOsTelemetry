using System.Windows.Forms;

namespace DPSOsTelemetria2.Pozos.PozoBombeoFluyente
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
            this.PresionTuberiaProduccion = new System.Windows.Forms.Label();
            this.PresionTuberiaRevestimiento = new System.Windows.Forms.Label();
            this.PresionLineaDescarga = new System.Windows.Forms.Label();
            this.TemperaturaSuperficie = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(672, 423);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(666, 363);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.tlpVariables);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(658, 334);
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
            this.tlpVariables.Controls.Add(this.PresionLineaDescarga, 0, 2);
            this.tlpVariables.Controls.Add(this.TemperaturaSuperficie, 2, 2);
            this.tlpVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVariables.Location = new System.Drawing.Point(3, 3);
            this.tlpVariables.Name = "tlpVariables";
            this.tlpVariables.RowCount = 4;
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
            this.tlpVariables.Size = new System.Drawing.Size(652, 328);
            this.tlpVariables.TabIndex = 4;
            // 
            // PresionTuberiaProduccion
            // 
            this.PresionTuberiaProduccion.AutoSize = true;
            this.PresionTuberiaProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaProduccion.Location = new System.Drawing.Point(3, 0);
            this.PresionTuberiaProduccion.Name = "PresionTuberiaProduccion";
            this.PresionTuberiaProduccion.Size = new System.Drawing.Size(310, 16);
            this.PresionTuberiaProduccion.TabIndex = 0;
            this.PresionTuberiaProduccion.Text = "PresionTuberiaProduccion";
            // 
            // PresionTuberiaRevestimiento
            // 
            this.PresionTuberiaRevestimiento.AutoSize = true;
            this.PresionTuberiaRevestimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaRevestimiento.Location = new System.Drawing.Point(339, 0);
            this.PresionTuberiaRevestimiento.Name = "PresionTuberiaRevestimiento";
            this.PresionTuberiaRevestimiento.Size = new System.Drawing.Size(310, 16);
            this.PresionTuberiaRevestimiento.TabIndex = 3;
            this.PresionTuberiaRevestimiento.Text = "PresionTuberiaRevestimiento";
            // 
            // PresionLineaDescarga
            // 
            this.PresionLineaDescarga.AutoSize = true;
            this.PresionLineaDescarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionLineaDescarga.Location = new System.Drawing.Point(3, 36);
            this.PresionLineaDescarga.Name = "PresionLineaDescarga";
            this.PresionLineaDescarga.Size = new System.Drawing.Size(310, 16);
            this.PresionLineaDescarga.TabIndex = 6;
            this.PresionLineaDescarga.Text = "PresionLineaDescarga";
            // 
            // TemperaturaSuperficie
            // 
            this.TemperaturaSuperficie.AutoSize = true;
            this.TemperaturaSuperficie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemperaturaSuperficie.Location = new System.Drawing.Point(339, 36);
            this.TemperaturaSuperficie.Name = "TemperaturaSuperficie";
            this.TemperaturaSuperficie.Size = new System.Drawing.Size(310, 16);
            this.TemperaturaSuperficie.TabIndex = 9;
            this.TemperaturaSuperficie.Text = "TemperaturaSuperficie";
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.tlpVariables2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(658, 334);
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
            this.tlpVariables2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVariables2.Location = new System.Drawing.Point(3, 3);
            this.tlpVariables2.Name = "tlpVariables2";
            this.tlpVariables2.RowCount = 10;
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
            this.tlpVariables2.Size = new System.Drawing.Size(652, 328);
            this.tlpVariables2.TabIndex = 5;
            // 
            // GastoLiquidoPruebaProduccion
            // 
            this.GastoLiquidoPruebaProduccion.AutoSize = true;
            this.GastoLiquidoPruebaProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoLiquidoPruebaProduccion.Location = new System.Drawing.Point(3, 0);
            this.GastoLiquidoPruebaProduccion.Name = "GastoLiquidoPruebaProduccion";
            this.GastoLiquidoPruebaProduccion.Size = new System.Drawing.Size(310, 16);
            this.GastoLiquidoPruebaProduccion.TabIndex = 0;
            this.GastoLiquidoPruebaProduccion.Text = "GastoLiquidoPruebaProduccion";
            // 
            // PorcentajeAguaSedimento
            // 
            this.PorcentajeAguaSedimento.AutoSize = true;
            this.PorcentajeAguaSedimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PorcentajeAguaSedimento.Location = new System.Drawing.Point(339, 0);
            this.PorcentajeAguaSedimento.Name = "PorcentajeAguaSedimento";
            this.PorcentajeAguaSedimento.Size = new System.Drawing.Size(310, 16);
            this.PorcentajeAguaSedimento.TabIndex = 3;
            this.PorcentajeAguaSedimento.Text = "PorcentajeAguaSedimento";
            // 
            // GravedadPetroleo
            // 
            this.GravedadPetroleo.AutoSize = true;
            this.GravedadPetroleo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GravedadPetroleo.Location = new System.Drawing.Point(3, 108);
            this.GravedadPetroleo.Name = "GravedadPetroleo";
            this.GravedadPetroleo.Size = new System.Drawing.Size(310, 16);
            this.GravedadPetroleo.TabIndex = 18;
            this.GravedadPetroleo.Text = "GravedadPetroleo";
            // 
            // GastoLiquido
            // 
            this.GastoLiquido.AutoSize = true;
            this.GastoLiquido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoLiquido.Location = new System.Drawing.Point(3, 72);
            this.GastoLiquido.Name = "GastoLiquido";
            this.GastoLiquido.Size = new System.Drawing.Size(310, 16);
            this.GastoLiquido.TabIndex = 12;
            this.GastoLiquido.Text = "GastoLiquido";
            // 
            // GastoAceite
            // 
            this.GastoAceite.AutoSize = true;
            this.GastoAceite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoAceite.Location = new System.Drawing.Point(3, 36);
            this.GastoAceite.Name = "GastoAceite";
            this.GastoAceite.Size = new System.Drawing.Size(310, 16);
            this.GastoAceite.TabIndex = 6;
            this.GastoAceite.Text = "GastoAceite";
            // 
            // RelacionGasAceite
            // 
            this.RelacionGasAceite.AutoSize = true;
            this.RelacionGasAceite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RelacionGasAceite.Location = new System.Drawing.Point(339, 72);
            this.RelacionGasAceite.Name = "RelacionGasAceite";
            this.RelacionGasAceite.Size = new System.Drawing.Size(310, 16);
            this.RelacionGasAceite.TabIndex = 15;
            this.RelacionGasAceite.Text = "RelacionGasAceite";
            // 
            // GastoGas
            // 
            this.GastoGas.AutoSize = true;
            this.GastoGas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GastoGas.Location = new System.Drawing.Point(339, 36);
            this.GastoGas.Name = "GastoGas";
            this.GastoGas.Size = new System.Drawing.Size(310, 16);
            this.GastoGas.TabIndex = 9;
            this.GastoGas.Text = "GastoGas";
            // 
            // Emulsion
            // 
            this.Emulsion.AutoSize = true;
            this.Emulsion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Emulsion.Location = new System.Drawing.Point(339, 108);
            this.Emulsion.Name = "Emulsion";
            this.Emulsion.Size = new System.Drawing.Size(310, 16);
            this.Emulsion.TabIndex = 21;
            this.Emulsion.Text = "Emulsion";
            // 
            // SalinidadAgua
            // 
            this.SalinidadAgua.AutoSize = true;
            this.SalinidadAgua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalinidadAgua.Location = new System.Drawing.Point(3, 144);
            this.SalinidadAgua.Name = "SalinidadAgua";
            this.SalinidadAgua.Size = new System.Drawing.Size(310, 16);
            this.SalinidadAgua.TabIndex = 24;
            this.SalinidadAgua.Text = "SalinidadAgua";
            // 
            // GravedadEspecificaGasProducido
            // 
            this.GravedadEspecificaGasProducido.AutoSize = true;
            this.GravedadEspecificaGasProducido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GravedadEspecificaGasProducido.Location = new System.Drawing.Point(339, 144);
            this.GravedadEspecificaGasProducido.Name = "GravedadEspecificaGasProducido";
            this.GravedadEspecificaGasProducido.Size = new System.Drawing.Size(310, 16);
            this.GravedadEspecificaGasProducido.TabIndex = 27;
            this.GravedadEspecificaGasProducido.Text = "GravedadEspecificaGasProducido";
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 372);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(666, 48);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // DatosOperativos
            // 
            this.DatosOperativos.AutoSize = true;
            this.DatosOperativos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosOperativos.Location = new System.Drawing.Point(336, 0);
            this.DatosOperativos.Name = "DatosOperativos";
            this.tableLayoutPanel4.SetRowSpan(this.DatosOperativos, 3);
            this.DatosOperativos.Size = new System.Drawing.Size(327, 48);
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
            this.DatosOperativosSends.Size = new System.Drawing.Size(327, 16);
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
            this.DatosOperativosComplete.Size = new System.Drawing.Size(327, 16);
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
            this.DatosOperativosFails.Size = new System.Drawing.Size(327, 16);
            this.DatosOperativosFails.TabIndex = 2;
            this.DatosOperativosFails.Text = "DatosOperativosFails";
            this.DatosOperativosFails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MonitoreoVirtual
            // 
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "MonitoreoVirtual";
            this.Size = new System.Drawing.Size(672, 423);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tlpVariables.ResumeLayout(false);
            this.tlpVariables.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tlpVariables2.ResumeLayout(false);
            this.tlpVariables2.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel4;
        private Label DatosOperativos;
        private Label DatosOperativosSends;
        private Label DatosOperativosComplete;
        private Label DatosOperativosFails;
    }
}