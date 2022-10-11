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
        //Este contador lo usamos para usar la funcion de parpadeo
        int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        
        //En todos estos botones hasta que se diga otra cosa, le ponemos la pantalla para que este siempre
        //en blanco y no se ejecute la funcion de parpadeo
        //Otra cosa que tambien hace es pintar en la pantalla el boton que pulsamos o añadiendolo a lo que
        //ya teniamos en la pantalla
        private void bt1_Click(object sender, EventArgs e)
        {
            pantallaBlanco();

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
            pantallaBlanco();

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
            pantallaBlanco();

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
            pantallaBlanco();

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
            pantallaBlanco();

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
            pantallaBlanco();

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
            pantallaBlanco();

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
            pantallaBlanco();

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
            pantallaBlanco();

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
            pantallaBlanco();

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
            pantallaBlanco();

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
            pantallaBlanco();

            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = "-";
            } else
            {
                tBPantalla.Text = tBPantalla.Text + btMenos.Text;
            }
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            pantallaBlanco();

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
            pantallaBlanco();

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
            pantallaBlanco();

            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = "";
            } else
            {
                tBPantalla.Text = btRaiz.Text + tBPantalla.Text;
            }
        }

        private void btExponente_Click(object sender, EventArgs e)
        {
            pantallaBlanco();

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
            pantallaBlanco();

            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = "";
            } else
            {
                tBPantalla.Text = "1/" + tBPantalla.Text;
            }
        }

        private void btComa_Click(object sender, EventArgs e)
        {
            pantallaBlanco();

            if (tBPantalla.Text.Length == 0)
            {
                tBPantalla.Text = "0,";
            } else
            {
                tBPantalla.Text = tBPantalla.Text + ",";
            }
        }

        double numero1, numero2;
        double operacion = 0;

        private void btIgual_Click(object sender, EventArgs e)
        {
            pantallaBlanco();

            //En esta parte lo que hacemos es separar el texto que tenemos por pantalla y quedarnos
            //solo con los numeros, o como en el primer if si el numero empieza o queda en la pantalla
            //un numero negativo que tambien se guarde su signo
            //En el else if estamos guardando el numero con el que se hace la operacion en una raiz
            //cuadrada
            //En el else estamos guardando los numeros cuando estan separados por el split
            //cuando tienen algunos de los simbolos de abajo

            String pantalla = tBPantalla.Text;
            String[] numSeparados = pantalla.Split(new char[] {'+', '-', '*', '/', '√', '^'});
            char[] caracteres = tBPantalla.Text.ToCharArray();

            if (caracteres[0] == '-' && numSeparados[0] == "")
            {
                String numero = caracteres[0] + numSeparados[1];
                numero1 = double.Parse(numero);
                numero2 = double.Parse(numSeparados[2]);
            } else if (tBPantalla.Text.Contains("√") && numSeparados[0] == "")
            {
                numero1 = double.Parse(numSeparados[1]);
            } else 
            {
                numero1 = double.Parse(numSeparados[0]);
                numero2 = double.Parse(numSeparados[1]);
            }

            //En esta parte con los numeros anteriores segun el caso, sacamos por pantalla el resultado 
            //de la operacion

            if (tBPantalla.Text.Contains("+"))
            {
                operacion = numero1 + numero2;

                tBPantalla.Text = operacion.ToString();

            } else if (tBPantalla.Text.Contains("-"))
            {
                operacion = numero1 - numero2;

                tBPantalla.Text = operacion.ToString();

            } else if (tBPantalla.Text.Contains("*"))
            {
                operacion = numero1 * numero2;

                tBPantalla.Text = operacion.ToString();

            } else if (tBPantalla.Text.Contains("/"))
            {
                operacion = numero1 / numero2;

                tBPantalla.Text = operacion.ToString();

            } else if (tBPantalla.Text.Contains("^"))
            {
                operacion = Math.Pow(numero1, numero2);

                tBPantalla.Text = operacion.ToString();

            } else if (tBPantalla.Text.Contains("√")) 
            {
                operacion = Math.Sqrt(numero1);

                tBPantalla.Text = operacion.ToString();
            } else if (tBPantalla.Text.Contains("1/"))
            {
                operacion = numero1 / numero2;

                tBPantalla.Text = operacion.ToString();
            }
        }

        //Con esta funcion lo que estamos haciendo es que parpadee la pantalla con la ayuda del
        //contador y del cambio de color de la pantalla

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador % 2 == 0)
            {
                tBPantalla.BackColor = Color.PowderBlue;
            } else
            {
                tBPantalla.BackColor = Color.White;
            }
        }

        //En esta funcion lo que estamos haciendo es que el timer1 no se ejecute porque no esta 
        //activado, y que la pantalla se ponga de color blanca cuando se llame a esta funcion

        private void pantallaBlanco()
        {
            this.timer1.Enabled = false;
            this.tBPantalla.BackColor = Color.White;
        }

        //Aqui lo que hacemos es que cuando pulsemos el boton Borrar, la funcion timer1 se 
        //empieza a ejecutar porque esta activado y tambien la pantalla se borra

        private void btBorrar_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;

            tBPantalla.Clear();
        }
    }
}
