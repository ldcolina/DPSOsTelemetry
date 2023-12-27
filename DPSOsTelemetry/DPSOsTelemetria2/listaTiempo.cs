using Languages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria2
{
    public partial class listaTiempo : Form
    {
        private static readonly ResourceManager SystemWell = new ResourceManager(typeof(SystemWell));

        private DataTable dt = new DataTable("Pozos");

        private List<lt> Last_Telemetria = new List<lt>();

        public listaTiempo()
        {
            InitializeComponent();
        }

        internal void Recargar(List<lt> _Telemetria)
        {
            if (JsonConvert.SerializeObject(Last_Telemetria) == JsonConvert.SerializeObject(_Telemetria))
                return;

            Last_Telemetria = _Telemetria.Copy();

            dt.Rows.Clear();

            foreach (lt _telemetria in _Telemetria.OrderBy(val => val.Name).OrderBy(val => val.Type))
            {
                DataRow dr = dt.NewRow();
                dr["Name"] = _telemetria.Name;
                dr["Type"] = SystemWell.GetString(_telemetria.Type);
                dr["Token"] = _telemetria.Token;
                dr["StartDate"] = _telemetria.Started.ToString("G");

                dr["ActionsDone"] = _telemetria.DatosOperativosSends + _telemetria.CartaDinagraficaSends;
                dr["ActionsClear"] = _telemetria.DatosOperativosComplete + _telemetria.CartaDinagraficaComplete;
                dr["ActionsFails"] = _telemetria.DatosOperativosFails + _telemetria.CartaDinagraficaFails;

                if (_telemetria.Range.DatosOperativos.TotalSeconds != 0)
                {
                    dr["Frequency_1a"] = _telemetria.Range.DatosOperativos.TotalSeconds;
                    dr["Frequency_1b"] = _telemetria.DOPromedio;
                    dr["Frequency_1c"] = _telemetria.DatosOperativosPromedio.TotalSeconds;
                    dr["Date2_1"] = _telemetria.DatosOperativosTime.AddSeconds(_telemetria.Range.DatosOperativos.TotalSeconds).ToString("G");
                }
                else
                {
                    dr["Frequency_1a"] = "-";
                    dr["Frequency_1b"] = "-";
                    dr["Frequency_1c"] = "-";
                    dr["Date2_1"] = "-";
                }

                if (_telemetria.Range.CartaDinagrafica.TotalSeconds != 0)
                {
                    dr["Frequency_2a"] = _telemetria.Range.CartaDinagrafica.TotalSeconds;
                    dr["Frequency_2b"] = _telemetria.CDPromedio;
                    dr["Frequency_2c"] = _telemetria.CartaDinagraficaPromedio.TotalSeconds;
                    dr["Date2_2"] = _telemetria.CartaDinagraficaTime.AddSeconds(_telemetria.Range.CartaDinagrafica.TotalSeconds).ToString("G");
                }
                else
                {
                    dr["Frequency_2a"] = "-";
                    dr["Frequency_2b"] = "-";
                    dr["Frequency_2c"] = "-";
                    dr["Date2_2"] = "-";
                }
                dt.Rows.Add(dr);
            }

            dataGridView1.DataSource = dt;

            #region Datos operativos

            if (_Telemetria.Max(val => val.Range.DatosOperativos).TotalSeconds != 0)
            {
                dataGridView1.Columns["Frequency_1a"].HeaderText = $"{Languages.listaTiempo.Frecuencia_1a} ({Siglas.Segundo})";
                dataGridView1.Columns["Frequency_1b"].HeaderText = $"{Languages.listaTiempo.Frecuencia_1b} ({Siglas.Segundo})";
                dataGridView1.Columns["Frequency_1c"].HeaderText = $"{Languages.listaTiempo.Frecuencia_1c} ({Siglas.Segundo})";

                dataGridView1.Columns["Date2_1"].HeaderText = Languages.listaTiempo.Fecha2_1;
            }
            else
            {
                dataGridView1.Columns["Frequency_1a"].Visible = false;
                dataGridView1.Columns["Frequency_1b"].Visible = false;
                dataGridView1.Columns["Frequency_1c"].Visible = false;

                dataGridView1.Columns["Date2_1"].Visible = false;
            }

            #endregion Datos operativos

            #region _Carta dinagráfica

            if (_Telemetria.Max(val => val.Range.CartaDinagrafica).TotalSeconds != 0)
            {
                dataGridView1.Columns["Frequency_2a"].HeaderText = $"{Languages.listaTiempo.Frecuencia_2a} ({Siglas.Segundo})";
                dataGridView1.Columns["Frequency_2b"].HeaderText = $"{Languages.listaTiempo.Frecuencia_2b} ({Siglas.Segundo})";
                dataGridView1.Columns["Frequency_2c"].HeaderText = $"{Languages.listaTiempo.Frecuencia_2c} ({Siglas.Segundo})";

                dataGridView1.Columns["Date2_2"].HeaderText = Languages.listaTiempo.Fecha2_2;
            }
            else
            {
                dataGridView1.Columns["Frequency_2a"].Visible = false;
                dataGridView1.Columns["Frequency_2b"].Visible = false;
                dataGridView1.Columns["Frequency_2c"].Visible = false;

                dataGridView1.Columns["Date2_2"].Visible = false;
            }

            #endregion _Carta dinagráfica

            Refrescar();
        }

        internal void Refrescar()
        {
            Text = DPSOsTelemetria.listaTiempo;

            dataGridView1.Columns["Name"].HeaderText = Languages.listaTiempo.Nombre;

            dataGridView1.Columns["Type"].HeaderText = Languages.listaTiempo.Tipo;

            dataGridView1.Columns["Token"].HeaderText = Languages.listaTiempo.Token;

            dataGridView1.Columns["StartDate"].HeaderText = Languages.listaTiempo.Fecha1;

            #region Datos operativos

            dataGridView1.Columns["Frequency_1a"].HeaderText = $"{Languages.listaTiempo.Frecuencia_1a} ({Siglas.Segundo})";
            dataGridView1.Columns["Frequency_1b"].HeaderText = $"{Languages.listaTiempo.Frecuencia_1b} ({Siglas.Segundo})";
            dataGridView1.Columns["Frequency_1c"].HeaderText = $"{Languages.listaTiempo.Frecuencia_1c} ({Siglas.Segundo})";

            dataGridView1.Columns["Date2_1"].HeaderText = Languages.listaTiempo.Fecha2_1;

            #endregion Datos operativos

            #region _Carta dinagráfica

            dataGridView1.Columns["Frequency_2a"].HeaderText = $"{Languages.listaTiempo.Frecuencia_2a} ({Siglas.Segundo})";
            dataGridView1.Columns["Frequency_2b"].HeaderText = $"{Languages.listaTiempo.Frecuencia_2b} ({Siglas.Segundo})";
            dataGridView1.Columns["Frequency_2c"].HeaderText = $"{Languages.listaTiempo.Frecuencia_2c} ({Siglas.Segundo})";

            dataGridView1.Columns["Date2_2"].HeaderText = Languages.listaTiempo.Fecha2_2;

            #endregion _Carta dinagráfica

            dataGridView1.Columns["ActionsDone"].HeaderText = Languages.listaTiempo.ActionsDone;

            dataGridView1.Columns["ActionsClear"].HeaderText = Languages.listaTiempo.ActionsClear;

            dataGridView1.Columns["ActionsFails"].HeaderText = Languages.listaTiempo.ActionsFails;

            foreach (DataRow dr in ((DataTable)dataGridView1.DataSource).Rows)
            {
                lt _telemetria = Last_Telemetria.Find(val => val.Token == dr["Token"].ToString());
                dr["Type"] = SystemWell.GetString(_telemetria.Type);
                dr["StartDate"] = _telemetria.Started.ToString("G");

                if (_telemetria.Range.DatosOperativos.TotalSeconds != 0)
                {
                    dr["Frequency_1a"] = _telemetria.Range.DatosOperativos.TotalSeconds;
                    dr["Frequency_1b"] = _telemetria.DOPromedio;
                    dr["Frequency_1c"] = _telemetria.DatosOperativosPromedio.TotalSeconds;
                    dr["Date2_1"] = _telemetria.DatosOperativosTime.AddSeconds(_telemetria.Range.DatosOperativos.TotalSeconds).ToString("G");
                }
                else
                {
                    dr["Frequency_1a"] = "-";
                    dr["Frequency_1b"] = "-";
                    dr["Frequency_1c"] = "-";
                    dr["Date2_1"] = "-";
                }

                if (_telemetria.Range.CartaDinagrafica.TotalSeconds != 0)
                {
                    dr["Frequency_2a"] = _telemetria.Range.CartaDinagrafica.TotalSeconds;
                    dr["Frequency_2b"] = _telemetria.CDPromedio;
                    dr["Frequency_2c"] = _telemetria.CartaDinagraficaPromedio.TotalSeconds;
                    dr["Date2_2"] = _telemetria.CartaDinagraficaTime.AddSeconds(_telemetria.Range.CartaDinagrafica.TotalSeconds).ToString("G");
                }
                else
                {
                    dr["Frequency_2a"] = "-";
                    dr["Frequency_2b"] = "-";
                    dr["Frequency_2c"] = "-";
                    dr["Date2_2"] = "-";
                }
            }

            try
            {
                string select = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                button1.Text = Languages.listaTiempo.Mostrar.Replace("{0}", !string.IsNullOrEmpty(select) ? select : "-");
            }
            catch
            {
                button1.Text = Languages.listaTiempo.Mostrar.Replace("{0}", "-");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();

            if (!string.IsNullOrEmpty(select))
                Main.Mostrar = select;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string select = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            button1.Text = Languages.listaTiempo.Mostrar.Replace("{0}", select);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button1_Click(null, null);
        }

        private void listaTiempo_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Size = MdiParent.ClientSize;
                Location = new Point(0, 0);
            }
        }

        private void listaTiempo_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Token", typeof(string));
            dt.Columns.Add("StartDate", typeof(string));
            dt.Columns.Add("Frequency_1a", typeof(string));
            dt.Columns.Add("Frequency_1b", typeof(string));
            dt.Columns.Add("Frequency_1c", typeof(string));
            dt.Columns.Add("Date2_1", typeof(string));
            dt.Columns.Add("Frequency_2a", typeof(string));
            dt.Columns.Add("Frequency_2b", typeof(string));
            dt.Columns.Add("Frequency_2c", typeof(string));
            dt.Columns.Add("Date2_2", typeof(string));
            dt.Columns.Add("ActionsDone", typeof(int));
            dt.Columns.Add("ActionsClear", typeof(int));
            dt.Columns.Add("ActionsFails", typeof(int));
        }
    }

    public class lt : ReferenciasI
    {
        #region DatosOperativos

        public int DatosOperativosSends { get; set; }

        public int DatosOperativosComplete { get; set; }

        public int DatosOperativosFails { get; set; }

        public double DOPromedio { get; set; }

        #endregion DatosOperativos

        #region DatosOperativos

        public int CartaDinagraficaSends { get; set; }

        public int CartaDinagraficaComplete { get; set; }

        public int CartaDinagraficaFails { get; set; }

        public double CDPromedio { get; set; }

        #endregion DatosOperativos
    }
}