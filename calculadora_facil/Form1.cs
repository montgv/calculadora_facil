using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_facil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void bt1_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = bt1.Text;
            } else
            {
                tBPantalla.Text = tBPantalla.Text + bt1.Text;
            }
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = bt0.Text;
            } else
            {
                tBPantalla.Text = tBPantalla.Text + bt0.Text;
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = bt2.Text;
            } else
            {
                tBPantalla.Text = tBPantalla.Text + bt2.Text;
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = bt3.Text;
            } else
            {
                tBPantalla.Text = tBPantalla.Text + bt3.Text;
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = bt4.Text;
            } else
            {
                tBPantalla.Text = tBPantalla.Text + bt4.Text;
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = bt5.Text;
            } else
            {
                tBPantalla.Text = tBPantalla.Text + bt5.Text;
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = bt6.Text;
            } else
            {
                tBPantalla.Text = tBPantalla.Text + bt6.Text;
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = bt7.Text;
            } else
            {
                tBPantalla.Text = tBPantalla.Text + bt7.Text;
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = bt8.Text;
            } else
            {
                tBPantalla.Text = tBPantalla.Text + bt8.Text;
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = bt9.Text;
            } else
            {
                tBPantalla.Text = tBPantalla.Text + bt9.Text;
            }
        }

        private void btMas_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = "";
            } else
            {
                tBPantalla.Text = tBPantalla.Text + btMas.Text;
            }
        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = "";
            } else
            {
                tBPantalla.Text = tBPantalla.Text + btMenos.Text;
            }
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = "";
            } else
            {
                tBPantalla.Text = tBPantalla.Text + btMultiplicar.Text;
            }
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = "";
            } else
            {
                tBPantalla.Text = tBPantalla.Text + btDividir.Text;
            }
        }

        private void btRaiz_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = "";
            } else
            {
                tBPantalla.Text = tBPantalla.Text + btRaiz.Text;
            }
        }

        private void btExponente_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = "";
            } else
            {
                tBPantalla.Text = tBPantalla.Text + "^";
            }
        }

        private void btFraccion_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = "";
            } else
            {
                tBPantalla.Text = "1/" + tBPantalla.Text;
            }
        }

        int numero1, numero2;
        double operacion = 0;

        private void btIgual_Click(object sender, EventArgs e)
        {
            if (tBPantalla.Text.Contains("+"))
            {
                String pantalla = tBPantalla.Text;

                String[] numSeparados = pantalla.Split('+');

                numero1 = int.Parse(numSeparados[0]);
                numero2 = int.Parse(numSeparados[1]);

                operacion = numero1 + numero2;

                tBPantalla.Text = operacion.ToString();

            } else if (tBPantalla.Text.Contains("-"))
            {
                String pantalla = tBPantalla.Text;

                String[] numSeparados = pantalla.Split('-');

                numero1 = int.Parse(numSeparados[0]);
                numero2 = int.Parse(numSeparados[1]);

                operacion = numero1 - numero2;

                tBPantalla.Text = operacion.ToString();

            } else if (tBPantalla.Text.Contains("*"))
            {
                String pantalla = tBPantalla.Text;

                String[] numSeparados = pantalla.Split('*');

                numero1 = int.Parse(numSeparados[0]);
                numero2 = int.Parse(numSeparados[1]);

                operacion = numero1 * numero2;

                tBPantalla.Text = operacion.ToString();

            } else if (tBPantalla.Text.Contains("/"))
            {
                String pantalla = tBPantalla.Text;

                String[] numSeparados = pantalla.Split('/');

                numero1 = int.Parse(numSeparados[0]);
                numero2 = int.Parse(numSeparados[1]);

                operacion = numero1 / numero2;

                tBPantalla.Text = operacion.ToString();

            } else if (tBPantalla.Text.Contains("^"))
            {
                String pantalla = tBPantalla.Text;

                String[] numSeparados = pantalla.Split('^');

                numero1 = int.Parse(numSeparados[0]);
                numero2 = int.Parse(numSeparados[1]);

                operacion = Potencia(numero1, numero2);

                tBPantalla.Text = operacion.ToString();

            } else if (tBPantalla.Text.Contains("√")) 
            {
                String pantalla = tBPantalla.Text;

                String[] numSeparados = pantalla.Split('√');

                numero1 = int.Parse(numSeparados[0]);

                operacion = Math.Sqrt(numero1);

                tBPantalla.Text = operacion.ToString();
            } else if (tBPantalla.Text.Contains("1/"))
            {
                String pantalla = tBPantalla.Text;

                String[] numSeparados = pantalla.Split('/');

                numero1 = int.Parse(numSeparados[1]);

                operacion = 1 / numero1;

                tBPantalla.Text = operacion.ToString();
            }
        }

        private static double Potencia(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            } else
            {
                return x * Potencia(x, y - 1);
            }
        }

        

        private void btBorrar_Click(object sender, EventArgs e)
        {
            tBPantalla.Clear();
        }
    }
}
