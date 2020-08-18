using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conceito_white
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            int c = 0;
            while (c < 10000)
            {
                c = c + 1;
                lblNumero.Text = Convert.ToString(c);
                lblNumero.Refresh();

                /* declaraçãop de variavel c, iniciada com 0.
                 * condicao: eqnauto c for menor que 10000 sera executada o laço
                 * incremento
                 * refresh é utliziado para que haja variacao dos numeros */

            }
        }
    }
}
