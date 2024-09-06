
using System.Windows.Forms;

namespace DPSOsTelemetria
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.Abrir_Eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.GuardarArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.Ventanas = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.Cascade = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.TileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.TileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MinimizedAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.listaTiempo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Config = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Ventanas,
            this.Ayuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.Ventanas;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(977, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuevo,
            this.Abrir_Eliminar,
            this.toolStripSeparator,
            this.GuardarArchivo,
            this.toolStripSeparator1,
            this.Salir});
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(73, 24);
            this.Archivo.Text = "&Archivo";
            // 
            // Nuevo
            // 
            this.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Nuevo.Size = new System.Drawing.Size(195, 26);
            this.Nuevo.Text = "&Nuevo";
            this.Nuevo.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // Abrir_Eliminar
            // 
            this.Abrir_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abrir_Eliminar.Name = "Abrir_Eliminar";
            this.Abrir_Eliminar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Abrir_Eliminar.Size = new System.Drawing.Size(195, 26);
            this.Abrir_Eliminar.Text = "&Abrir";
            this.Abrir_Eliminar.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(192, 6);
            // 
            // GuardarArchivo
            // 
            this.GuardarArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarArchivo.Name = "GuardarArchivo";
            this.GuardarArchivo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.GuardarArchivo.Size = new System.Drawing.Size(195, 26);
            this.GuardarArchivo.Text = "&Guardar";
            this.GuardarArchivo.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // Salir
            // 
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(195, 26);
            this.Salir.Text = "&Salir";
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Ventanas
            // 
            this.Ventanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArrangeIcons,
            this.Cascade,
            this.CloseAll,
            this.TileHorizontal,
            this.TileVertical,
            this.MinimizedAll});
            this.Ventanas.Name = "Ventanas";
            this.Ventanas.Size = new System.Drawing.Size(82, 24);
            this.Ventanas.Text = "&Ventanas";
            // 
            // ArrangeIcons
            // 
            this.ArrangeIcons.Name = "ArrangeIcons";
            this.ArrangeIcons.Size = new System.Drawing.Size(186, 26);
            this.ArrangeIcons.Text = "ArrangeIcons";
            this.ArrangeIcons.Click += new System.EventHandler(this.ArrangeIcons_Click);
            // 
            // Cascade
            // 
            this.Cascade.Name = "Cascade";
            this.Cascade.Size = new System.Drawing.Size(186, 26);
            this.Cascade.Text = "Cascade";
            this.Cascade.Click += new System.EventHandler(this.Cascade_Click);
            // 
            // CloseAll
            // 
            this.CloseAll.Name = "CloseAll";
            this.CloseAll.Size = new System.Drawing.Size(186, 26);
            this.CloseAll.Text = "CloseAll";
            this.CloseAll.Click += new System.EventHandler(this.CloseAll_Click);
            // 
            // TileHorizontal
            // 
            this.TileHorizontal.Name = "TileHorizontal";
            this.TileHorizontal.Size = new System.Drawing.Size(186, 26);
            this.TileHorizontal.Text = "TileHorizontal";
            this.TileHorizontal.Click += new System.EventHandler(this.TileHorizontal_Click);
            // 
            // TileVertical
            // 
            this.TileVertical.Name = "TileVertical";
            this.TileVertical.Size = new System.Drawing.Size(186, 26);
            this.TileVertical.Text = "TileVertical";
            this.TileVertical.Click += new System.EventHandler(this.TileVertical_Click);
            // 
            // MinimizedAll
            // 
            this.MinimizedAll.Name = "MinimizedAll";
            this.MinimizedAll.Size = new System.Drawing.Size(186, 26);
            this.MinimizedAll.Text = "MinimizedAll";
            this.MinimizedAll.Click += new System.EventHandler(this.MinimizedAll_Click);
            // 
            // Ayuda
            // 
            this.Ayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaTiempo,
            this.toolStripSeparator5,
            this.Config});
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(65, 24);
            this.Ayuda.Text = "Ay&uda";
            // 
            // listaTiempo
            // 
            this.listaTiempo.Name = "listaTiempo";
            this.listaTiempo.Size = new System.Drawing.Size(171, 26);
            this.listaTiempo.Text = "List_Tiempo";
            this.listaTiempo.Click += new System.EventHandler(this.listaTiempo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(168, 6);
            // 
            // Config
            // 
            this.Config.Name = "Config";
            this.Config.Size = new System.Drawing.Size(171, 26);
            this.Config.Text = "&Acerca de...";
            this.Config.Click += new System.EventHandler(this.Config_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(977, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(806, 20);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 412);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 26);
            this.panel2.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 438);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DPSOsTelemetria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Archivo;
        private ToolStripMenuItem Nuevo;
        private ToolStripMenuItem Abrir_Eliminar;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem GuardarArchivo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem Salir;
        private ToolStripMenuItem Ayuda;
        private ToolStripMenuItem Ventanas;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem Config;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel panel2;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Timer timer1;
        private ToolStripMenuItem listaTiempo;
        private ToolStripMenuItem Cascade;
        private ToolStripMenuItem ArrangeIcons;
        private ToolStripMenuItem CloseAll;
        private ToolStripMenuItem TileHorizontal;
        private ToolStripMenuItem TileVertical;
        private ToolStripMenuItem MinimizedAll;
    }
}