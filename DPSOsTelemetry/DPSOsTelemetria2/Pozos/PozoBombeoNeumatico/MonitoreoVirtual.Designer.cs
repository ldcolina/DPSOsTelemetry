using System.Windows.Forms;

namespace DPSOsTelemetria2.Pozos.PozoBombeoNeumatico
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpVariables = new System.Windows.Forms.TableLayoutPanel();
            this.PresionTuberiaProduccion = new System.Windows.Forms.Label();
            this.PresionTuberiaRevestimiento = new System.Windows.Forms.Label();
            this.gravedadEspecificaGasInyeccion = new System.Windows.Forms.Label();
            this.PresionDisponible = new System.Windows.Forms.Label();
            this.PresionLineaDescarga = new System.Windows.Forms.Label();
            this.gastoGasInyeccion = new System.Windows.Forms.Label();
            this.TemperaturaSuperficie = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DatosOperativos = new System.Windows.Forms.Label();
            this.DatosOperativosSends = new System.Windows.Forms.Label();
            this.DatosOperativosComplete = new System.Windows.Forms.Label();
            this.DatosOperativosFails = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpVariables.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 423);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tlpVariables, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(626, 377);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.tlpVariables.Controls.Add(this.PresionTuberiaRevestimiento, 3, 0);
            this.tlpVariables.Controls.Add(this.gravedadEspecificaGasInyeccion, 0, 6);
            this.tlpVariables.Controls.Add(this.PresionDisponible, 0, 4);
            this.tlpVariables.Controls.Add(this.PresionLineaDescarga, 0, 2);
            this.tlpVariables.Controls.Add(this.gastoGasInyeccion, 3, 4);
            this.tlpVariables.Controls.Add(this.TemperaturaSuperficie, 3, 2);
            this.tlpVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVariables.Location = new System.Drawing.Point(3, 3);
            this.tlpVariables.Name = "tlpVariables";
            this.tlpVariables.RowCount = 8;
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
            this.tlpVariables.Size = new System.Drawing.Size(620, 305);
            this.tlpVariables.TabIndex = 6;
            // 
            // PresionTuberiaProduccion
            // 
            this.PresionTuberiaProduccion.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.PresionTuberiaProduccion, 2);
            this.PresionTuberiaProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaProduccion.Location = new System.Drawing.Point(3, 0);
            this.PresionTuberiaProduccion.Name = "PresionTuberiaProduccion";
            this.PresionTuberiaProduccion.Size = new System.Drawing.Size(294, 20);
            this.PresionTuberiaProduccion.TabIndex = 0;
            this.PresionTuberiaProduccion.Text = "PresionTuberiaProduccion";
            // 
            // PresionTuberiaRevestimiento
            // 
            this.PresionTuberiaRevestimiento.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.PresionTuberiaRevestimiento, 2);
            this.PresionTuberiaRevestimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionTuberiaRevestimiento.Location = new System.Drawing.Point(323, 0);
            this.PresionTuberiaRevestimiento.Name = "PresionTuberiaRevestimiento";
            this.PresionTuberiaRevestimiento.Size = new System.Drawing.Size(294, 20);
            this.PresionTuberiaRevestimiento.TabIndex = 3;
            this.PresionTuberiaRevestimiento.Text = "PresionTuberiaRevestimiento";
            // 
            // gravedadEspecificaGasInyeccion
            // 
            this.gravedadEspecificaGasInyeccion.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.gravedadEspecificaGasInyeccion, 2);
            this.gravedadEspecificaGasInyeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gravedadEspecificaGasInyeccion.Location = new System.Drawing.Point(3, 120);
            this.gravedadEspecificaGasInyeccion.Name = "gravedadEspecificaGasInyeccion";
            this.gravedadEspecificaGasInyeccion.Size = new System.Drawing.Size(294, 20);
            this.gravedadEspecificaGasInyeccion.TabIndex = 18;
            this.gravedadEspecificaGasInyeccion.Text = "gravedadEspecificaGasInyeccion";
            // 
            // PresionDisponible
            // 
            this.PresionDisponible.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.PresionDisponible, 2);
            this.PresionDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionDisponible.Location = new System.Drawing.Point(3, 80);
            this.PresionDisponible.Name = "PresionDisponible";
            this.PresionDisponible.Size = new System.Drawing.Size(294, 20);
            this.PresionDisponible.TabIndex = 6;
            this.PresionDisponible.Text = "PresionDisponible";
            // 
            // PresionLineaDescarga
            // 
            this.PresionLineaDescarga.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.PresionLineaDescarga, 2);
            this.PresionLineaDescarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresionLineaDescarga.Location = new System.Drawing.Point(3, 40);
            this.PresionLineaDescarga.Name = "PresionLineaDescarga";
            this.PresionLineaDescarga.Size = new System.Drawing.Size(294, 20);
            this.PresionLineaDescarga.TabIndex = 12;
            this.PresionLineaDescarga.Text = "PresionLineaDescarga";
            // 
            // gastoGasInyeccion
            // 
            this.gastoGasInyeccion.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.gastoGasInyeccion, 2);
            this.gastoGasInyeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gastoGasInyeccion.Location = new System.Drawing.Point(323, 80);
            this.gastoGasInyeccion.Name = "gastoGasInyeccion";
            this.gastoGasInyeccion.Size = new System.Drawing.Size(294, 20);
            this.gastoGasInyeccion.TabIndex = 9;
            this.gastoGasInyeccion.Text = "gastoGasInyeccion";
            // 
            // TemperaturaSuperficie
            // 
            this.TemperaturaSuperficie.AutoSize = true;
            this.tlpVariables.SetColumnSpan(this.TemperaturaSuperficie, 2);
            this.TemperaturaSuperficie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemperaturaSuperficie.Location = new System.Drawing.Point(323, 40);
            this.TemperaturaSuperficie.Name = "TemperaturaSuperficie";
            this.TemperaturaSuperficie.Size = new System.Drawing.Size(294, 20);
            this.TemperaturaSuperficie.TabIndex = 15;
            this.TemperaturaSuperficie.Text = "TemperaturaSuperficie";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.DatosOperativos, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.DatosOperativosSends, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DatosOperativosComplete, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.DatosOperativosFails, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 314);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(620, 60);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // DatosOperativos
            // 
            this.DatosOperativos.AutoSize = true;
            this.DatosOperativos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosOperativos.Location = new System.Drawing.Point(313, 0);
            this.DatosOperativos.Name = "DatosOperativos";
            this.tableLayoutPanel3.SetRowSpan(this.DatosOperativos, 3);
            this.DatosOperativos.Size = new System.Drawing.Size(304, 60);
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
            this.DatosOperativosSends.Size = new System.Drawing.Size(304, 20);
            this.DatosOperativosSends.TabIndex = 0;
            this.DatosOperativosSends.Text = "DatosOperativosSends";
            this.DatosOperativosSends.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DatosOperativosComplete
            // 
            this.DatosOperativosComplete.AutoSize = true;
            this.DatosOperativosComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosOperativosComplete.Location = new System.Drawing.Point(3, 20);
            this.DatosOperativosComplete.Name = "DatosOperativosComplete";
            this.DatosOperativosComplete.Size = new System.Drawing.Size(304, 20);
            this.DatosOperativosComplete.TabIndex = 1;
            this.DatosOperativosComplete.Text = "DatosOperativosComplete";
            this.DatosOperativosComplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DatosOperativosFails
            // 
            this.DatosOperativosFails.AutoSize = true;
            this.DatosOperativosFails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosOperativosFails.Location = new System.Drawing.Point(3, 40);
            this.DatosOperativosFails.Name = "DatosOperativosFails";
            this.DatosOperativosFails.Size = new System.Drawing.Size(304, 20);
            this.DatosOperativosFails.TabIndex = 2;
            this.DatosOperativosFails.Text = "DatosOperativosFails";
            this.DatosOperativosFails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MonitoreoVirtual
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MonitoreoVirtual";
            this.Size = new System.Drawing.Size(672, 423);
            
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlpVariables.ResumeLayout(false);
            this.tlpVariables.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label DatosOperativosSends;
        private Label DatosOperativosComplete;
        private Label DatosOperativosFails;
        private Label DatosOperativos;
        private TableLayoutPanel tlpVariables;
        private Label PresionTuberiaProduccion;
        private Label PresionTuberiaRevestimiento;
        private Label gravedadEspecificaGasInyeccion;
        private Label PresionDisponible;
        private Label PresionLineaDescarga;
        private Label gastoGasInyeccion;
        private Label TemperaturaSuperficie;
    }
}