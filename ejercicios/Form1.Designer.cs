namespace ejercicios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazadaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazadaCircularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazadaDobleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazadaDobleAnálisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaYListaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolBinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arlbolBinarioDeBusquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolBinarioDeBusqueda3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafoMatrizAdyacenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafoDijsktraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(340, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(140, 32);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaEnlazadaSimpleToolStripMenuItem,
            this.listaEnlazadaCircularToolStripMenuItem,
            this.listaEnlazadaDobleToolStripMenuItem,
            this.listaEnlazadaDobleAnálisisToolStripMenuItem,
            this.pilaToolStripMenuItem,
            this.pilaYListaSimpleToolStripMenuItem,
            this.colaToolStripMenuItem,
            this.arbolBinarioToolStripMenuItem,
            this.arlbolBinarioDeBusquedaToolStripMenuItem,
            this.arbolBinarioDeBusqueda3ToolStripMenuItem,
            this.grafoMatrizAdyacenciaToolStripMenuItem,
            this.grafoDijsktraToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(143, 32);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // listaEnlazadaSimpleToolStripMenuItem
            // 
            this.listaEnlazadaSimpleToolStripMenuItem.Name = "listaEnlazadaSimpleToolStripMenuItem";
            this.listaEnlazadaSimpleToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.listaEnlazadaSimpleToolStripMenuItem.Text = "Lista enlazada simple";
            this.listaEnlazadaSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazadaSimpleToolStripMenuItem_Click);
            // 
            // listaEnlazadaCircularToolStripMenuItem
            // 
            this.listaEnlazadaCircularToolStripMenuItem.Name = "listaEnlazadaCircularToolStripMenuItem";
            this.listaEnlazadaCircularToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.listaEnlazadaCircularToolStripMenuItem.Text = "Lista enlazada circular";
            this.listaEnlazadaCircularToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazadaCircularToolStripMenuItem_Click);
            // 
            // listaEnlazadaDobleToolStripMenuItem
            // 
            this.listaEnlazadaDobleToolStripMenuItem.Name = "listaEnlazadaDobleToolStripMenuItem";
            this.listaEnlazadaDobleToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.listaEnlazadaDobleToolStripMenuItem.Text = "Lista enlazada doble";
            this.listaEnlazadaDobleToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazadaDobleToolStripMenuItem_Click);
            // 
            // listaEnlazadaDobleAnálisisToolStripMenuItem
            // 
            this.listaEnlazadaDobleAnálisisToolStripMenuItem.Name = "listaEnlazadaDobleAnálisisToolStripMenuItem";
            this.listaEnlazadaDobleAnálisisToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.listaEnlazadaDobleAnálisisToolStripMenuItem.Text = "Lista enlazada doble análisis";
            this.listaEnlazadaDobleAnálisisToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazadaDobleAnálisisToolStripMenuItem_Click);
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.pilaToolStripMenuItem.Text = "Pila";
            this.pilaToolStripMenuItem.Click += new System.EventHandler(this.pilaToolStripMenuItem_Click);
            // 
            // pilaYListaSimpleToolStripMenuItem
            // 
            this.pilaYListaSimpleToolStripMenuItem.Name = "pilaYListaSimpleToolStripMenuItem";
            this.pilaYListaSimpleToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.pilaYListaSimpleToolStripMenuItem.Text = "Pila y Lista simple";
            this.pilaYListaSimpleToolStripMenuItem.Click += new System.EventHandler(this.pilaYListaSimpleToolStripMenuItem_Click);
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.colaToolStripMenuItem.Text = "Cola";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.colaToolStripMenuItem_Click);
            // 
            // arbolBinarioToolStripMenuItem
            // 
            this.arbolBinarioToolStripMenuItem.Name = "arbolBinarioToolStripMenuItem";
            this.arbolBinarioToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.arbolBinarioToolStripMenuItem.Text = "Arbol binario";
            this.arbolBinarioToolStripMenuItem.Click += new System.EventHandler(this.arbolBinarioToolStripMenuItem_Click);
            // 
            // arlbolBinarioDeBusquedaToolStripMenuItem
            // 
            this.arlbolBinarioDeBusquedaToolStripMenuItem.Name = "arlbolBinarioDeBusquedaToolStripMenuItem";
            this.arlbolBinarioDeBusquedaToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.arlbolBinarioDeBusquedaToolStripMenuItem.Text = "Arlbol binario de busqueda";
            this.arlbolBinarioDeBusquedaToolStripMenuItem.Click += new System.EventHandler(this.arlbolBinarioDeBusquedaToolStripMenuItem_Click);
            // 
            // arbolBinarioDeBusqueda3ToolStripMenuItem
            // 
            this.arbolBinarioDeBusqueda3ToolStripMenuItem.Name = "arbolBinarioDeBusqueda3ToolStripMenuItem";
            this.arbolBinarioDeBusqueda3ToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.arbolBinarioDeBusqueda3ToolStripMenuItem.Text = "Arbol binario de Busqueda 3";
            this.arbolBinarioDeBusqueda3ToolStripMenuItem.Click += new System.EventHandler(this.arbolBinarioDeBusqueda3ToolStripMenuItem_Click);
            // 
            // grafoMatrizAdyacenciaToolStripMenuItem
            // 
            this.grafoMatrizAdyacenciaToolStripMenuItem.Name = "grafoMatrizAdyacenciaToolStripMenuItem";
            this.grafoMatrizAdyacenciaToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.grafoMatrizAdyacenciaToolStripMenuItem.Text = "Grafo matriz adyacencia";
            this.grafoMatrizAdyacenciaToolStripMenuItem.Click += new System.EventHandler(this.grafoMatrizAdyacenciaToolStripMenuItem_Click);
            // 
            // grafoDijsktraToolStripMenuItem
            // 
            this.grafoDijsktraToolStripMenuItem.Name = "grafoDijsktraToolStripMenuItem";
            this.grafoDijsktraToolStripMenuItem.Size = new System.Drawing.Size(368, 32);
            this.grafoDijsktraToolStripMenuItem.Text = "Grafo Dijsktra";
            this.grafoDijsktraToolStripMenuItem.Click += new System.EventHandler(this.grafoDijsktraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 203);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaCircularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaDobleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaDobleAnálisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaYListaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolBinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arlbolBinarioDeBusquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolBinarioDeBusqueda3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafoMatrizAdyacenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafoDijsktraToolStripMenuItem;
    }
}

