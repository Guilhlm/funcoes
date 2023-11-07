namespace funçoes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbresultado = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.botaomais = new System.Windows.Forms.Button();
            this.botaomenos = new System.Windows.Forms.Button();
            this.botaodivisao = new System.Windows.Forms.Button();
            this.botaomulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(280, 68);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(18, 13);
            this.lbresultado.TabIndex = 0;
            this.lbresultado.Text = "R:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(31, 61);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(154, 61);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 2;
            // 
            // botaomais
            // 
            this.botaomais.Location = new System.Drawing.Point(32, 145);
            this.botaomais.Name = "botaomais";
            this.botaomais.Size = new System.Drawing.Size(83, 23);
            this.botaomais.TabIndex = 3;
            this.botaomais.Text = "+";
            this.botaomais.UseVisualStyleBackColor = true;
            this.botaomais.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaomenos
            // 
            this.botaomenos.Location = new System.Drawing.Point(31, 193);
            this.botaomenos.Name = "botaomenos";
            this.botaomenos.Size = new System.Drawing.Size(83, 23);
            this.botaomenos.TabIndex = 4;
            this.botaomenos.Text = "-";
            this.botaomenos.UseVisualStyleBackColor = true;
            this.botaomenos.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaodivisao
            // 
            this.botaodivisao.Location = new System.Drawing.Point(173, 145);
            this.botaodivisao.Name = "botaodivisao";
            this.botaodivisao.Size = new System.Drawing.Size(81, 23);
            this.botaodivisao.TabIndex = 5;
            this.botaodivisao.Text = "/";
            this.botaodivisao.UseVisualStyleBackColor = true;
            this.botaodivisao.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaomulti
            // 
            this.botaomulti.Location = new System.Drawing.Point(173, 193);
            this.botaomulti.Name = "botaomulti";
            this.botaomulti.Size = new System.Drawing.Size(81, 23);
            this.botaomulti.TabIndex = 6;
            this.botaomulti.Text = "x";
            this.botaomulti.UseVisualStyleBackColor = true;
            this.botaomulti.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaomulti);
            this.Controls.Add(this.botaodivisao);
            this.Controls.Add(this.botaomenos);
            this.Controls.Add(this.botaomais);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbresultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button botaomais;
        private System.Windows.Forms.Button botaomenos;
        private System.Windows.Forms.Button botaodivisao;
        private System.Windows.Forms.Button botaomulti;
    }
}

