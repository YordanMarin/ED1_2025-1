namespace ejercicios
{
    partial class frmArbolBinario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.btnInsertarRaiz = new System.Windows.Forms.Button();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertarRamas = new System.Windows.Forms.Button();
            this.radioIzquierda = new System.Windows.Forms.RadioButton();
            this.radioDerecha = new System.Windows.Forms.RadioButton();
            this.btnAltura = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnInsertarRaiz
            // 
            this.btnInsertarRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRaiz.Location = new System.Drawing.Point(43, 117);
            this.btnInsertarRaiz.Name = "btnInsertarRaiz";
            this.btnInsertarRaiz.Size = new System.Drawing.Size(118, 34);
            this.btnInsertarRaiz.TabIndex = 8;
            this.btnInsertarRaiz.Text = "Insertar Raíz";
            this.btnInsertarRaiz.UseVisualStyleBackColor = true;
            this.btnInsertarRaiz.Click += new System.EventHandler(this.btnInsertarRaiz_Click);
            // 
            // textNumero
            // 
            this.textNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumero.Location = new System.Drawing.Point(174, 63);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(163, 26);
            this.textNumero.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese número: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ÁRBOL BINARIO";
            // 
            // btnInsertarRamas
            // 
            this.btnInsertarRamas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRamas.Location = new System.Drawing.Point(43, 167);
            this.btnInsertarRamas.Name = "btnInsertarRamas";
            this.btnInsertarRamas.Size = new System.Drawing.Size(118, 34);
            this.btnInsertarRamas.TabIndex = 9;
            this.btnInsertarRamas.Text = "Insertar Ramas";
            this.btnInsertarRamas.UseVisualStyleBackColor = true;
            this.btnInsertarRamas.Click += new System.EventHandler(this.btnInsertarRamas_Click);
            // 
            // radioIzquierda
            // 
            this.radioIzquierda.AutoSize = true;
            this.radioIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIzquierda.Location = new System.Drawing.Point(72, 218);
            this.radioIzquierda.Name = "radioIzquierda";
            this.radioIzquierda.Size = new System.Drawing.Size(80, 20);
            this.radioIzquierda.TabIndex = 10;
            this.radioIzquierda.TabStop = true;
            this.radioIzquierda.Text = "Izquierda";
            this.radioIzquierda.UseVisualStyleBackColor = true;
            // 
            // radioDerecha
            // 
            this.radioDerecha.AutoSize = true;
            this.radioDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDerecha.Location = new System.Drawing.Point(72, 244);
            this.radioDerecha.Name = "radioDerecha";
            this.radioDerecha.Size = new System.Drawing.Size(77, 20);
            this.radioDerecha.TabIndex = 11;
            this.radioDerecha.TabStop = true;
            this.radioDerecha.Text = "Derecha";
            this.radioDerecha.UseVisualStyleBackColor = true;
            // 
            // btnAltura
            // 
            this.btnAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltura.Location = new System.Drawing.Point(43, 314);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(118, 34);
            this.btnAltura.TabIndex = 12;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(174, 117);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(163, 231);
            this.treeView1.TabIndex = 13;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 395);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.radioDerecha);
            this.Controls.Add(this.radioIzquierda);
            this.Controls.Add(this.btnInsertarRamas);
            this.Controls.Add(this.btnInsertarRaiz);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmArbolBinario";
            this.Text = "frmArbolBinario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarRaiz;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertarRamas;
        private System.Windows.Forms.RadioButton radioIzquierda;
        private System.Windows.Forms.RadioButton radioDerecha;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.TreeView treeView1;
    }
}