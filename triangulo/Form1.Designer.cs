namespace triangulo
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
            this.btnCalcula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tx1 = new System.Windows.Forms.TextBox();
            this.tx2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(103, 350);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(100, 23);
            this.btnCalcula.TabIndex = 0;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lado 1";
            // 
            // tx1
            // 
            this.tx1.Location = new System.Drawing.Point(103, 134);
            this.tx1.Name = "tx1";
            this.tx1.Size = new System.Drawing.Size(100, 20);
            this.tx1.TabIndex = 2;
            // 
            // tx2
            // 
            this.tx2.Location = new System.Drawing.Point(103, 207);
            this.tx2.Name = "tx2";
            this.tx2.Size = new System.Drawing.Size(100, 20);
            this.tx2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lado 2";
            // 
            // tx3
            // 
            this.tx3.Location = new System.Drawing.Point(103, 285);
            this.tx3.Name = "tx3";
            this.tx3.Size = new System.Drawing.Size(100, 20);
            this.tx3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lado 2";
            // 
            // txResult
            // 
            this.txResult.Enabled = false;
            this.txResult.Location = new System.Drawing.Point(103, 403);
            this.txResult.Name = "txResult";
            this.txResult.ReadOnly = true;
            this.txResult.Size = new System.Drawing.Size(100, 20);
            this.txResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.txResult);
            this.Controls.Add(this.tx3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcula);
            this.Name = "Form1";
            this.Text = "Calcula triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx1;
        private System.Windows.Forms.TextBox tx2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txResult;
    }
}

