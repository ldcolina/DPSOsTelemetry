using Newtonsoft.Json;
using System.Data;
using System.Resources;
using Telemetria;

namespace DPSOsTelemetria
{
    public partial class listaTiempo : Form
    {
        private DataTable dt = new("Pozos");
        private static readonly ResourceManager SystemWell = new(typeof(Languages.SystemWell));
        private List<ReferenciasI> Last_Telemetria = new();

        public listaTiempo()
        {
            InitializeComponent();

            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Token", typeof(string));
            dt.Columns.Add("Date1", typeof(string));
            dt.Columns.Add("Frequency_1", typeof(string));
            dt.Columns.Add("Date2_1", typeof(string));
            dt.Columns.Add("Frequency_2", typeof(string));
            dt.Columns.Add("Date2_2", typeof(string));
            dt.Columns.Add("ActionsDone", typeof(int));
            dt.Columns.Add("ActionsClear", typeof(int));
            dt.Columns.Add("ActionsFails", typeof(int));

            dataGridView1.DataSource = dt;
            Refrescar();
        }

        private void listaTiempo_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = this.MdiParent.ClientSize;
                this.Location = new Point(0, 0);
            }
        }

        internal void Refrescar()
        {
            Text = Languages.DPSOsTelemetria.listaTiempo;

            dataGridView1.Columns["Name"].HeaderText = Languages.listaTiempo.Nombre;
            dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns["Type"].HeaderText = Languages.listaTiempo.Tipo;
            dataGridView1.Columns["Type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns["Token"].HeaderText = Languages.listaTiempo.Token;
            dataGridView1.Columns["Token"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (DataRow dr in ((DataTable)dataGridView1.DataSource).Rows)
            {
                ReferenciasI _telemetria = Last_Telemetria.Find(val => val.Token == dr["Token"].ToString());
                dr["Type"] = SystemWell.GetString(_telemetria.Type);

                dr["Date1"] = _telemetria.Started.ToString("G");
                if (_telemetria.Range.DatosOperativos.TotalMilliseconds != 0)
                {
                    double miliseg = _telemetria.Range.DatosOperativos.TotalMilliseconds * _telemetria.DatosOperativosSends;
                    dr["Frequency_1"] = _telemetria.Range.DatosOperativos.TotalSeconds;
                    dr["Date2_1"] = _telemetria.Started.AddMilliseconds(miliseg).ToString("G");
                }
                else
                {
                    dr["Frequency_1"] = "-";
                    dr["Date2_1"] = "-";
                }

                if (_telemetria.Range.CartaDinagrafica.TotalMilliseconds != 0)
                {
                    double miliseg = _telemetria.Range.CartaDinagrafica.TotalMilliseconds * _telemetria.CartaDinagraficaSends;
                    dr["Frequency_2"] = _telemetria.Range.CartaDinagrafica.TotalSeconds;
                    dr["Date2_2"] = _telemetria.Started.AddMilliseconds(miliseg).ToString("G");
                }
                else
                {
                    dr["Frequency_2"] = "-";
                    dr["Date2_2"] = "-";
                }
            }

            dataGridView1.Columns["Date1"].HeaderText = Languages.listaTiempo.Fecha1;
            dataGridView1.Columns["Date1"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns["Frequency_1"].HeaderText = $"{Languages.listaTiempo.Frecuencia_1} ({Languages.Siglas.Segundo})";
            dataGridView1.Columns["Frequency_1"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Date2_1"].HeaderText = Languages.listaTiempo.Fecha2_1;
            dataGridView1.Columns["Date2_1"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns["Frequency_2"].HeaderText = $"{Languages.listaTiempo.Frecuencia_2} ({Languages.Siglas.Segundo})";
            dataGridView1.Columns["Frequency_2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Date2_2"].HeaderText = Languages.listaTiempo.Fecha2_2;
            dataGridView1.Columns["Date2_2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns["ActionsDone"].HeaderText = Languages.listaTiempo.ActionsDone;
            dataGridView1.Columns["ActionsDone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns["ActionsClear"].HeaderText = Languages.listaTiempo.ActionsClear;
            dataGridView1.Columns["ActionsClear"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns["ActionsFails"].HeaderText = Languages.listaTiempo.ActionsFails;
            dataGridView1.Columns["ActionsFails"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        internal void Recargar(List<ReferenciasI> _Telemetria)
        {
            if (JsonConvert.SerializeObject(Last_Telemetria) == JsonConvert.SerializeObject(_Telemetria))
                return;

            Last_Telemetria = _Telemetria.Copy();

            dt.Rows.Clear();

            foreach (ReferenciasI _telemetria in _Telemetria.OrderBy(val => val.Name).OrderBy(val => val.Type))
            {
                DataRow dr = dt.NewRow();
                dr["Name"] = _telemetria.Name;
                dr["Type"] = SystemWell.GetString(_telemetria.Type);
                dr["Token"] = _telemetria.Token;

                dr["ActionsDone"] = _telemetria.DatosOperativosSends + _telemetria.CartaDinagraficaSends;
                dr["ActionsClear"] = _telemetria.DatosOperativosComplete + _telemetria.CartaDinagraficaComplete;
                dr["ActionsFails"] = _telemetria.DatosOperativosFails + _telemetria.CartaDinagraficaFails;

                dr["Date1"] = _telemetria.Started.ToString("G");
                if (_telemetria.Range.DatosOperativos.TotalMilliseconds != 0)
                {
                    double miliseg = _telemetria.Range.DatosOperativos.TotalMilliseconds * _telemetria.DatosOperativosSends;
                    dr["Frequency_1"] = _telemetria.Range.DatosOperativos.TotalSeconds;
                    dr["Date2_1"] = _telemetria.Started.AddMilliseconds(miliseg).ToString("G");
                }
                else
                {
                    dr["Frequency_1"] = "-";
                    dr["Date2_1"] = "-";
                }

                if (_telemetria.Range.CartaDinagrafica.TotalMilliseconds != 0)
                {
                    double miliseg = _telemetria.Range.CartaDinagrafica.TotalMilliseconds * _telemetria.CartaDinagraficaSends;
                    dr["Frequency_2"] = _telemetria.Range.CartaDinagrafica.TotalSeconds;
                    dr["Date2_2"] = _telemetria.Started.AddMilliseconds(miliseg).ToString("G");
                }
                else
                {
                    dr["Frequency_2"] = "-";
                    dr["Date2_2"] = "-";
                }
                dt.Rows.Add(dr);
            }

            dataGridView1.DataSource = dt;
        }
    }
}