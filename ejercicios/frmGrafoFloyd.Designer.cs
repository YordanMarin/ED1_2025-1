namespace ejercicios
{
    partial class frmGrafoFloyd
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
            this.textCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVertices = new System.Windows.Forms.Button();
            this.textVertices = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMatrizCosto = new System.Windows.Forms.Button();
            this.textDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertarRaiz = new System.Windows.Forms.Button();
            this.textOrigen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnFloyd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCosto
            // 
            this.textCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCosto.Location = new System.Drawing.Point(129, 204);
            this.textCosto.Margin = new System.Windows.Forms.Padding(4);
            this.textCosto.Name = "textCosto";
            this.textCosto.Size = new System.Drawing.Size(95, 30);
            this.textCosto.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 74;
            this.label5.Text = "Costo:";
            // 
            // btnVertices
            // 
            this.btnVertices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVertices.Location = new System.Drawing.Point(421, 65);
            this.btnVertices.Margin = new System.Windows.Forms.Padding(4);
            this.btnVertices.Name = "btnVertices";
            this.btnVertices.Size = new System.Drawing.Size(189, 42);
            this.btnVertices.TabIndex = 71;
            this.btnVertices.Text = "Insertar";
            this.btnVertices.UseVisualStyleBackColor = true;
            this.btnVertices.Click += new System.EventHandler(this.btnVertices_Click);
            // 
            // textVertices
            // 
            this.textVertices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVertices.Location = new System.Drawing.Point(290, 69);
            this.textVertices.Margin = new System.Windows.Forms.Padding(4);
            this.textVertices.Name = "textVertices";
            this.textVertices.Size = new System.Drawing.Size(95, 30);
            this.textVertices.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "Nùmero de vertices:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(288, 181);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(691, 219);
            this.richTextBox1.TabIndex = 68;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(50, 296);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 329);
            this.listBox1.TabIndex = 67;
            // 
            // btnMatrizCosto
            // 
            this.btnMatrizCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatrizCosto.Location = new System.Drawing.Point(288, 120);
            this.btnMatrizCosto.Margin = new System.Windows.Forms.Padding(4);
            this.btnMatrizCosto.Name = "btnMatrizCosto";
            this.btnMatrizCosto.Size = new System.Drawing.Size(692, 52);
            this.btnMatrizCosto.TabIndex = 66;
            this.btnMatrizCosto.Text = "Matriz Costo";
            this.btnMatrizCosto.UseVisualStyleBackColor = true;
            this.btnMatrizCosto.Click += new System.EventHandler(this.btnMatrizCosto_Click);
            // 
            // textDestino
            // 
            this.textDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDestino.Location = new System.Drawing.Point(129, 165);
            this.textDestino.Margin = new System.Windows.Forms.Padding(4);
            this.textDestino.Name = "textDestino";
            this.textDestino.Size = new System.Drawing.Size(95, 30);
            this.textDestino.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 64;
            this.label3.Text = "Destino:";
            // 
            // btnInsertarRaiz
            // 
            this.btnInsertarRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRaiz.Location = new System.Drawing.Point(36, 243);
            this.btnInsertarRaiz.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertarRaiz.Name = "btnInsertarRaiz";
            this.btnInsertarRaiz.Size = new System.Drawing.Size(189, 42);
            this.btnInsertarRaiz.TabIndex = 63;
            this.btnInsertarRaiz.Text = "Insertar";
            this.btnInsertarRaiz.UseVisualStyleBackColor = true;
            this.btnInsertarRaiz.Click += new System.EventHandler(this.btnInsertarRaiz_Click);
            // 
            // textOrigen
            // 
            this.textOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOrigen.Location = new System.Drawing.Point(129, 125);
            this.textOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.textOrigen.Name = "textOrigen";
            this.textOrigen.Size = new System.Drawing.Size(95, 30);
            this.textOrigen.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Origen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 46);
            this.label1.TabIndex = 60;
            this.label1.Text = "GRAFO DIRIGIDO";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(288, 469);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(691, 242);
            this.richTextBox2.TabIndex = 77;
            this.richTextBox2.Text = "";
            // 
            // btnFloyd
            // 
            this.btnFloyd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloyd.Location = new System.Drawing.Point(288, 408);
            this.btnFloyd.Margin = new System.Windows.Forms.Padding(4);
            this.btnFloyd.Name = "btnFloyd";
            this.btnFloyd.Size = new System.Drawing.Size(692, 52);
            this.btnFloyd.TabIndex = 76;
            this.btnFloyd.Text = "Matriz Floyd-Warshall";
            this.btnFloyd.UseVisualStyleBackColor = true;
            this.btnFloyd.Click += new System.EventHandler(this.btnFloyd_Click);
            // 
            // frmGrafoFloyd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 744);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btnFloyd);
            this.Controls.Add(this.textCosto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVertices);
            this.Controls.Add(this.textVertices);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMatrizCosto);
            this.Controls.Add(this.textDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInsertarRaiz);
            this.Controls.Add(this.textOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGrafoFloyd";
            this.Text = "frmGrafoFloyd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVertices;
        private System.Windows.Forms.TextBox textVertices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMatrizCosto;
        private System.Windows.Forms.TextBox textDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertarRaiz;
        private System.Windows.Forms.TextBox textOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnFloyd;
    }
}