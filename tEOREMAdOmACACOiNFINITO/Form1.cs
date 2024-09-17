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
            int nivel = (trkNIVEL.Value * 50) - 1;

            string texto = Generatetexto(nivel);

            txtTEOREMA.Text = "➤" + texto;
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CONFIGURAÇÕES DO JOGO\n" +
                "- Aperte GERAR para invocar uma seleção de letras aleatória.\n" +
                "- Ajuste o número de linhas geradas usando a Barra de Ajuste.\n\n" +
                "REGRAS E OBJETIVOS\n" +
                "- Selecione na caixa de texto onde a seta ➤ está indicando.\n" +
                "- Use a tecla DELETE para apagar as letras à frente.\n" +
                "- Use a tecla -> caso queira manter uma letra.\n" +
                "- Use a tecla ENTER quando tiver terminado uma palavra.\n" +
                "- Tente formar o máximo de palavras possíveis.",
                "AJUDA", MessageBoxButtons.OK);
        }
    }
}
