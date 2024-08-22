using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tEOREMAdOmACACOiNFINITO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGERAR_Click(object sender, EventArgs e)
        {
            int nivel = trkNIVEL.Value * 50;

            string texto = Generatetexto(nivel);

            txtTEOREMA.Text = texto;
        }

        static string Generatetexto(int nivel)
        {
            const string chars = "ABCDEFGHIJLMNOPQRSTUVXZ";

            Random random = new Random();

            char[] stringChars = new char[nivel];

            for (int i = 0; i < nivel; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(stringChars);
        }

        private void txtTEOREMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblAJUDA_MouseEnter(object sender, EventArgs e)
        {
            lblAJUDA.Text = "xxxxxxxx\r\nxxxxxxxx\r\nxxxxxxxx\r\nxxxxxxxx.";
        }

        private void lblAJUDA_MouseLeave(object sender, EventArgs e)
        {
            lblAJUDA.Text = "?";
        }
    }
}
