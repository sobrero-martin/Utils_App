using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        #region calculadora
        private Calculadora calc = new Calculadora();

        #region keyEvents
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            switch (e.KeyCode)
            {
                case Keys.D0:
                    btResultado.Focus();
                    btCero.PerformClick();
                    break;
                case Keys.D1:
                    btResultado.Focus();
                    btUno.PerformClick();
                    break;
                case Keys.D2:
                    btResultado.Focus();
                    btDos.PerformClick();
                    break;
                case Keys.D3:
                    btResultado.Focus();
                    btTres.PerformClick();
                    break;
                case Keys.D4:
                    btResultado.Focus();
                    btCuatro.PerformClick();
                    break;
                case Keys.D5:
                    btResultado.Focus();
                    btCinco.PerformClick();
                    break;
                case Keys.D6:
                    btResultado.Focus();
                    btSeis.PerformClick();
                    break;
                case Keys.D7:
                    btResultado.Focus();
                    btSiete.PerformClick();
                    break;
                case Keys.D8:
                    btResultado.Focus();
                    btOcho.PerformClick();
                    break;
                case Keys.D9:
                    btResultado.Focus();
                    btNueve.PerformClick();
                    break;
                case Keys.Back:
                    btResultado.Focus();
                    btBorrarUno.PerformClick();
                    break;
                case Keys.Delete:
                    btResultado.Focus();
                    btBorrar.PerformClick();
                    break;
                case Keys.Oemcomma:
                    btResultado.Focus();
                    btComa.PerformClick();
                    break;
                case Keys.Oemplus:
                    btResultado.Focus();
                    btSuma.PerformClick();
                    break;
                case Keys.OemMinus:
                    btResultado.Focus();
                    btResta.PerformClick();
                    break;

            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 42)
            {
                btMultiplicacion.PerformClick();
            }
            if (e.KeyChar == 47)
            {
                btDivision.PerformClick();
            }
            if (e.KeyChar == 61)
            {
                btResultado.PerformClick();
            }

        }
        #endregion

        #region defVar
        string op = "";
        string valorNum1 = "", auxRes = "", auxNum1 = "", auxIgual = "";
        bool isSet = false, lastEqual = false;
        #endregion

        #region numeros

        private void btCero_Click(object sender, EventArgs e)
        {
            if (lastEqual)
            {
                lblResultado.Text = "";
                lblNum1.Text = "";
                valorNum1 = "";
                lastEqual = false;
            }
            lblResultado.Text = lblResultado.Text + "0";
        }

        private void btUno_Click(object sender, EventArgs e)
        {
            if (lastEqual)
            {
                lblResultado.Text = "";
                lblNum1.Text = "";
                valorNum1 = "";
                lastEqual = false;
            }
            lblResultado.Text = lblResultado.Text + "1";
        }

        private void btDos_Click(object sender, EventArgs e)
        {
            if (lastEqual)
            {
                lblResultado.Text = "";
                lblNum1.Text = "";
                valorNum1 = "";
                lastEqual = false;
            }
            lblResultado.Text = lblResultado.Text + "2";
        }

        private void btTres_Click(object sender, EventArgs e)
        {
            if (lastEqual)
            {
                lblResultado.Text = "";
                lblNum1.Text = "";
                valorNum1 = "";
                lastEqual = false;
            }
            lblResultado.Text = lblResultado.Text + "3";
        }

        private void btCuatro_Click(object sender, EventArgs e)
        {
            if (lastEqual)
            {
                lblResultado.Text = "";
                lblNum1.Text = "";
                valorNum1 = "";
                lastEqual = false;
            }
            lblResultado.Text = lblResultado.Text + "4";
        }

        private void btCinco_Click(object sender, EventArgs e)
        {
            if (lastEqual)
            {
                lblResultado.Text = "";
                lblNum1.Text = "";
                valorNum1 = "";
                lastEqual = false;
            }
            lblResultado.Text = lblResultado.Text + "5";
        }

        private void btSeis_Click(object sender, EventArgs e)
        {
            if (lastEqual)
            {
                lblResultado.Text = "";
                lblNum1.Text = "";
                valorNum1 = "";
                lastEqual = false;
            }
            lblResultado.Text = lblResultado.Text + "6";
        }

        private void btSiete_Click(object sender, EventArgs e)
        {
            if (lastEqual)
            {
                lblResultado.Text = "";
                lblNum1.Text = "";
                valorNum1 = "";
                lastEqual = false;
            }
            lblResultado.Text = lblResultado.Text + "7";
        }

        private void btOcho_Click(object sender, EventArgs e)
        {
            if (lastEqual)
            {
                lblResultado.Text = "";
                lblNum1.Text = "";
                valorNum1 = "";
                lastEqual = false;
            }
            lblResultado.Text = lblResultado.Text + "8";
        }

        private void btNueve_Click(object sender, EventArgs e)
        {
            if (lastEqual)
            {
                lblResultado.Text = "";
                lblNum1.Text = "";
                valorNum1 = "";
                lastEqual = false;
            }
            lblResultado.Text = lblResultado.Text + "9";
        }

        #endregion

        #region operadores
        private void btSuma_Click(object sender, EventArgs e)
        {
            op = "+";
            auxNum1 = lblNum1.Text;
            auxRes = lblResultado.Text;
            calc.res(ref valorNum1, ref auxNum1, ref auxRes, ref op, "0", ref lastEqual, ref isSet);
            lblNum1.Text = auxNum1;
            lblResultado.Text = auxRes;
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            op = "-";
            auxNum1 = lblNum1.Text;
            auxRes = lblResultado.Text;
            calc.res(ref valorNum1, ref auxNum1, ref auxRes, ref op, "0", ref lastEqual, ref isSet);
            lblNum1.Text = auxNum1;
            lblResultado.Text = auxRes;
        }

        private void btMultiplicacion_Click(object sender, EventArgs e)
        {
            op = "*";
            auxNum1 = lblNum1.Text;
            auxRes = lblResultado.Text;
            calc.res(ref valorNum1, ref auxNum1, ref auxRes, ref op, "1", ref lastEqual, ref isSet);
            lblNum1.Text = auxNum1;
            lblResultado.Text = auxRes;
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            op = "/";
            auxNum1 = lblNum1.Text;
            auxRes = lblResultado.Text;
            calc.res(ref valorNum1, ref auxNum1, ref auxRes, ref op, "1", ref lastEqual, ref isSet);
            lblNum1.Text = auxNum1;
            lblResultado.Text = auxRes;
        }


        #endregion

        #region restoBotones
        private void btBorrarUno_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length > 0)
            {
                lblResultado.Text = lblResultado.Text.Remove(lblResultado.Text.Length - 1, 1);
            }
            else
            {
                lblResultado.Text = "";
            }


        }

        private void btComa_Click(object sender, EventArgs e)
        {
            lblResultado.Text = lblResultado.Text + Convert.ToString(",");
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            lblNum1.Text = "";
            valorNum1 = "";
            lblResultado.Text = "";
            isSet = false;
        }

        private void btResultado_Click(object sender, EventArgs e)
        {

            string n = "0";

            if (op == "+" || op == "-")
            {
                n = "0";
            }
            else if (op == "*" || op == "/")
            {
                n = "1";
            }

            auxNum1 = lblNum1.Text;
            auxRes = lblResultado.Text;
            calc.resIgual(ref valorNum1, ref auxNum1, ref auxRes, ref op, n, ref isSet, ref auxIgual, ref lastEqual);
            lblNum1.Text = auxNum1;
            lblResultado.Text = auxRes;

        }

        #endregion

        #endregion
    }
}
