using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular()
        {
            try
            {
            string nota = textBoxNota.Text;
            string nome = textBoxNome.Text;

            string abrev = $"O(a) aluno(a) {nome} tirou {nota} e foi";

                if (Convert.ToInt64(nota) >= 60)
                {
                    MessageBox.Show($"{abrev} APROVADO.");
                }
                else
                {
                    MessageBox.Show($"{abrev} REPROVADO.");
                }

            }

            catch
            {
                MessageBox.Show("Digite um valor válido");
                return;
            }
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
