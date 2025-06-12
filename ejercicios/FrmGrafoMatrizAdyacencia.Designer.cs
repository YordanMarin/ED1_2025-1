namespace ejercicios
{
    partial class FrmGrafoMatrizAdyacencia
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
            this.textOrigen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAmplitud = new System.Windows.Forms.Button();
            this.btnProfundidad = new System.Windows.Forms.Button();
            this.textAmplitud = new System.Windows.Forms.TextBox();
            this.textProfundidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInsertarRaiz
            // 
            this.btnInsertarRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRaiz.Location = new System.Drawing.Point(47, 156);
            this.btnInsertarRaiz.Name = "btnInsertarRaiz";
            this.btnInsertarRaiz.Size = new System.Drawing.Size(142, 34);
            this.btnInsertarRaiz.TabIndex = 38;
            this.btnInsertarRaiz.Text = "Insertar";
            this.btnInsertarRaiz.UseVisualStyleBackColor = true;
            this.btnInsertarRaiz.Click += new System.EventHandler(this.btnInsertarRaiz_Click);
            // 
            // textOrigen
            // 
            this.textOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOrigen.Location = new System.Drawing.Point(117, 72);
            this.textOrigen.Name = "textOrigen";
            this.textOrigen.Size = new System.Drawing.Size(72, 26);
            this.textOrigen.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Origen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 35;
            this.label1.Text = "GRAFO DIRIGIDO";
            // 
            // textDestino
            // 
            this.textDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDestino.Location = new System.Drawing.Point(117, 113);
            this.textDestino.Name = "textDestino";
            this.textDestino.Size = new System.Drawing.Size(72, 26);
            this.textDestino.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Destino:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(236, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(519, 42);
            this.button1.TabIndex = 41;
            this.button1.Text = "Matriz Adyacencia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(58, 211);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 284);
            this.listBox1.TabIndex = 42;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(236, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(519, 250);
            this.richTextBox1.TabIndex = 43;
            this.richTextBox1.Text = "";
            // 
            // btnAmplitud
            // 
            this.btnAmplitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmplitud.Location = new System.Drawing.Point(236, 395);
            this.btnAmplitud.Name = "btnAmplitud";
            this.btnAmplitud.Size = new System.Drawing.Size(142, 34);
            this.btnAmplitud.TabIndex = 44;
            this.btnAmplitud.Text = "Amplitud";
            this.btnAmplitud.UseVisualStyleBackColor = true;
            this.btnAmplitud.Click += new System.EventHandler(this.btnAmplitud_Click);
            // 
            // btnProfundidad
            // 
            this.btnProfundidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfundidad.Location = new System.Drawing.Point(236, 437);
            this.btnProfundidad.Name = "btnProfundidad";
            this.btnProfundidad.Size = new System.Drawing.Size(142, 34);
            this.btnProfundidad.TabIndex = 45;
            this.btnProfundidad.Text = "Profundidad";
            this.btnProfundidad.UseVisualStyleBackColor = true;
            this.btnProfundidad.Click += new System.EventHandler(this.btnProfundidad_Click);
            // 
            // textAmplitud
            // 
            this.textAmplitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAmplitud.Location = new System.Drawing.Point(402, 399);
            this.textAmplitud.Name = "textAmplitud";
            this.textAmplitud.Size = new System.Drawing.Size(353, 26);
            this.textAmplitud.TabIndex = 46;
            // 
            // textProfundidad
            // 
            this.textProfundidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProfundidad.Location = new System.Drawing.Point(402, 442);
            this.textProfundidad.Name = "textProfundidad";
            this.textProfundidad.Size = new System.Drawing.Size(353, 26);
            this.textProfundidad.TabIndex = 47;
            // 
            // FrmGrafoMatrizAdyacencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 540);
            this.Controls.Add(this.textProfundidad);
            this.Controls.Add(this.textAmplitud);
            this.Controls.Add(this.btnProfundidad);
            this.Controls.Add(this.btnAmplitud);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInsertarRaiz);
            this.Controls.Add(this.textOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGrafoMatrizAdyacencia";
            this.Text = "FrmGrafoMatrizAdyacencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarRaiz;
        private System.Windows.Forms.TextBox textOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAmplitud;
        private System.Windows.Forms.Button btnProfundidad;
        private System.Windows.Forms.TextBox textAmplitud;
        private System.Windows.Forms.TextBox textProfundidad;
    }
}