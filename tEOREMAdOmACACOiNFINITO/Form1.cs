using System;
using System.Windows.Forms;

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
            // Determina o nível de duração do jogo.
            // Cada nível corresponde a uma linha; cada linha corresponde a 50 caracteres.
            // O primeiro caractere de todos é substituido pela seta "➤".
            int nivel = (trkNIVEL.Value * 50) - 1;

            // Gera o texto do tamanho do nível.
            string texto = Generatetexto(nivel);

            // Adiciona a seta no começo do texto gerado e o mostra ao usuário.
            txtTEOREMA.Text = "➤" + texto;
        }

        static string Generatetexto(int nivel)
        {
            // Estabelece os caracteres possíveis de serem gerados.
            const string chars = "ABCDEFGHIJLMNOPQRSTUVXZ";

            Random random = new Random();

            // Cria a variável que armazenará o texto gerado.
            // O parâmetro "nivel" determina o tamanho do texto.
            char[] stringChars = new char[nivel];

            // Preenche cada índice de "stringChars" com caracteres aleatórios.
            for (int i = 0; i < nivel; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            // Transforma "stringChars" em um único texto e retorna.
            return new string(stringChars);
        }

        private void txtTEOREMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Impede o usuário de digitar algo indevido no texto gerado.

            // Testa se a tecla pressionada é um "caracter de controle".
            // Os caracteres de controle podem ser: Backspace, Tab, Enter,
            //   Esc ou as setas de navegação.
            if (!char.IsControl(e.KeyChar))
            {
                // Se a tecla pressionada não for um caracter de controle,
                //  impede a ação de ser realizada.
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mostra uma caixa de mensagem com as regras do jogo.
            // Fiquei com preguiça de fazer um sistema melhor, então vai isso mesmo.
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
