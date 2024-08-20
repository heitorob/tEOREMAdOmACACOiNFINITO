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
            ((System.ComponentModel.ISupportInitialize)(this.trkNIVEL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGERAR
            // 
            this.btnGERAR.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGERAR.Location = new System.Drawing.Point(143, 308);
            this.btnGERAR.Name = "btnGERAR";
            this.btnGERAR.Size = new System.Drawing.Size(203, 45);
            this.btnGERAR.TabIndex = 0;
            this.btnGERAR.Text = "GERAR";
            this.btnGERAR.UseVisualStyleBackColor = true;
            this.btnGERAR.Click += new System.EventHandler(this.btnGERAR_Click);
            // 
            // trkNIVEL
            // 
            this.trkNIVEL.Location = new System.Drawing.Point(455, 308);
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
            this.txtTEOREMA.Location = new System.Drawing.Point(143, 96);
            this.txtTEOREMA.Multiline = true;
            this.txtTEOREMA.Name = "txtTEOREMA";
            this.txtTEOREMA.Size = new System.Drawing.Size(515, 190);
            this.txtTEOREMA.TabIndex = 2;
            txtTEOREMA.KeyPress += new KeyPressEventHandler(txtTEOREMA_KeyPress);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTEOREMA);
            this.Controls.Add(this.trkNIVEL);
            this.Controls.Add(this.btnGERAR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trkNIVEL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGERAR;
        private System.Windows.Forms.TrackBar trkNIVEL;
        private System.Windows.Forms.TextBox txtTEOREMA;
    }
}

