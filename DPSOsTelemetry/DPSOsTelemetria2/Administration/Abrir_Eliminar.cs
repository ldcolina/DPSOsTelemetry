﻿using Languages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using Telemetria;

namespace DPSOsTelemetria.Administration
{
    public partial class Abrir_Eliminar : Form
    {
        public string ID;

        internal readonly string DataBase;

        private static readonly ResourceManager SystemWell = new ResourceManager(typeof(SystemWell));

        public Abrir_Eliminar()
        {
            InitializeComponent();
            DataBase = Main.Carpeta;
        }

        #region Buscar pozo

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<ReferenciasII> ControlPozos = new List<ReferenciasII>();
            Directory.GetFiles(DataBase).ToList().ForEach(val =>
            {
                ReferenciasII ReferenciasII = JsonConvert.DeserializeObject<ReferenciasII>(File.ReadAllText(val));
                ReferenciasII.ID = val;
                ReferenciasII.Date = File.GetLastWriteTime(val);
                if (!string.IsNullOrEmpty(ReferenciasII.Token))
                    ControlPozos.Add(ReferenciasII);
            });
            foreach (ReferenciasII cp in ControlPozos)
                cp.Type = SystemWell.GetString(cp.Type);
            ControlPozos = ControlPozos.OrderByDescending(val => val.Date).ToList();

            dataGridView1.DataSource = !(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
                ? ControlPozos.Where(val => val.Name.ToLower().Contains(textBox1.Text.ToLower()) || val.Token.ToLower().Contains(textBox1.Text.ToLower()) || val.Type.ToLower().Contains(textBox1.Text.ToLower())).ToDataTable()
                : ControlPozos.ToDataTable();

            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Name"].HeaderText = Languages.Administration.Nombre;
            dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Token"].HeaderText = Languages.Administration.Token;
            dataGridView1.Columns["Token"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Type"].HeaderText = Languages.Administration.Tipo;
            dataGridView1.Columns["Type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Date"].HeaderText = Languages.Administration.Utc_Modify;
            dataGridView1.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["MetodoQGI"].Visible = false;
            dataGridView1.Columns["Unidades"].Visible = false;
            dataGridView1.Columns["Range"].Visible = false;
        }

        #endregion Buscar pozo

        #region Eliminar

        private void button3_Click(object sender, EventArgs e)
        {
            string select = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            ReferenciasII Well = JsonConvert.DeserializeObject<ReferenciasII>(File.ReadAllText(select));
            Well.ID = select;

            Main.Eliminar = Well;

            textBox1_TextChanged(textBox1, null);
        }

        #endregion Eliminar

        #region Abrir

        private void button2_Click(object sender, EventArgs e)
        {
            string select = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            ReferenciasII Well = JsonConvert.DeserializeObject<ReferenciasII>(File.ReadAllText(select));
            Well.ID = select;

            Main.Abrir = Well;
            Close();
        }

        #endregion Abrir

        #region Modificar

        private void button1_Click(object sender, EventArgs e)
        {
            string select = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            ReferenciasII Well = JsonConvert.DeserializeObject<ReferenciasII>(File.ReadAllText(select));
            Well.ID = select;

            Main.Modificar = Well;
            Close();
        }

        #endregion Modificar

        private void Abrir_Eliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Abrir_Eliminar_Load(object sender, EventArgs e)
        {
            Text = Languages.DPSOsTelemetria.Abrir_Eliminar;
            label1.Text = Languages.Administration.Buscar;
            button1.Text = Languages.Administration.Modificar;
            button2.Text = Languages.Administration.Abrir;
            button3.Text = Languages.Administration.Eliminar;
            textBox1_TextChanged(null, null);
        }
    }
}