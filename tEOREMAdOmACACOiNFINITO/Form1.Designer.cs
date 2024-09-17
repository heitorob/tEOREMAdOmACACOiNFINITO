using System.Windows.Forms;

namespace tEOREMAdOmACACOiNFINITO
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
            this.btnGERAR = new System.Windows.Forms.Button();
            this.trkNIVEL = new System.Windows.Forms.TrackBar();
            this.txtTEOREMA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkNIVEL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGERAR
            // 
            this.btnGERAR.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGERAR.Location = new System.Drawing.Point(143, 355);
            this.btnGERAR.Name = "btnGERAR";
            this.btnGERAR.Size = new System.Drawing.Size(203, 45);
            this.btnGERAR.TabIndex = 0;
            this.btnGERAR.Text = "GERAR";
            this.btnGERAR.UseVisualStyleBackColor = true;
            this.btnGERAR.Click += new System.EventHandler(this.btnGERAR_Click);
            // 
            // trkNIVEL
            // 
            this.trkNIVEL.Location = new System.Drawing.Point(455, 355);
            this.trkNIVEL.Minimum = 1;
            this.trkNIVEL.Name = "trkNIVEL";
            this.trkNIVEL.Size = new System.Drawing.Size(203, 45);
            this.trkNIVEL.TabIndex = 1;
            this.trkNIVEL.Value = 5;
            // 
            // txtTEOREMA
            // 
            this.txtTEOREMA.BackColor = System.Drawing.SystemColors.Window;
            this.txtTEOREMA.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTEOREMA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTEOREMA.Location = new System.Drawing.Point(143, 143);
            this.txtTEOREMA.Multiline = true;
            this.txtTEOREMA.Name = "txtTEOREMA";
            this.txtTEOREMA.Size = new System.Drawing.Size(515, 190);
            this.txtTEOREMA.TabIndex = 2;
            this.txtTEOREMA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTEOREMA_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teorema do Macaco Infinito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(676, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "O Jogo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("JetBrains Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(681, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F);
            this.label3.Location = new System.Drawing.Point(462, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nº de linhas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTEOREMA);
            this.Controls.Add(this.trkNIVEL);
            this.Controls.Add(this.btnGERAR);
            this.Name = "Form1";
            this.Text = "Teorema do Macaco Infinito: O Jogo";
            ((System.ComponentModel.ISupportInitialize)(this.trkNIVEL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGERAR;
        private System.Windows.Forms.TrackBar trkNIVEL;
        private System.Windows.Forms.TextBox txtTEOREMA;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}

