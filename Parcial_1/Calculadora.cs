using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    internal class Calculadora
    {
       
        public void res(ref string valorNum1, ref string lblNum1, ref string lblResultado,ref string op, string neutro, ref bool lastEqual, ref bool isSet)
        {
            if (valorNum1 == "")
            {
                valorNum1 = lblResultado;
                lblNum1 = valorNum1 + " " + op;
                lblResultado = "";

            }
            else
            {
                if (lblResultado == "")
                {
                    lblResultado = neutro;
                }

                if (lastEqual)
                {
                    lblResultado = neutro;
                    lastEqual = false;
                }

                double n1 = Convert.ToDouble(valorNum1);
                double n2 = Convert.ToDouble(lblResultado);
                double result = 0;
                isSet = false;

                switch (op)
                {
                    case "+":
                        result = n1 + n2;
                        lblResultado = "";
                        break;
                    case "-":
                        result = n1 - n2;
                        lblResultado = "";
                        break;
                    case "*":
                        result = n1 * n2;
                        lblResultado = "";
                        break;
                    case "/":
                        if (n2 != 0)
                        {
                            result = n1 / n2;
                            lblResultado = "";
                        }
                        else
                        {
                            lblResultado = "Error";
                        }
                        break;
                    default:
                        lblResultado = "Error";
                        break;
                }

                valorNum1 = Convert.ToString(result);
                lblNum1 = valorNum1 + " " + op;
            }
        }

        public void resIgual(ref string valorNum1, ref string lblNum1, ref string lblResultado, ref string op, string neutro, ref bool isSet, ref string auxIgual, ref bool lastEqual)
        {
            if (valorNum1 == "")
            {
                valorNum1 = lblResultado;
                lblNum1 = valorNum1 + " " + op;
                lblResultado = "";

            }
            else
            {
                if (lblResultado == "")
                {
                    lblResultado = neutro;
                }

                if (!isSet)
                {
                    auxIgual = lblResultado;
                    isSet = true;
                }

                double n1 = Convert.ToDouble(valorNum1);
                double n2 = Convert.ToDouble(auxIgual);
                double resultado = 0;
                string auxNum = valorNum1;
                bool divCero = false;
                
                switch (op)
                {
                    case "+":
                        resultado = n1 + n2;
                        break;
                    case "-":
                        resultado = n1 - n2;
                        break;
                    case "*":
                        resultado = n1 * n2;
                        break;
                    case "/":
                        if (n2 != 0)
                        {
                            resultado = n1 / n2;
                        }
                        else
                        {
                            divCero = true;
                        }
                        break;
                    default:
                        divCero = true;
                        break;
                }

                lblResultado = Convert.ToString(resultado);
                valorNum1 = lblResultado;
                if (divCero)
                {
                    lblResultado = "Error";
                }
                lblNum1 = auxNum + " " + op + " " + auxIgual + " =";
                lastEqual = true;
            }
        }
    }

}
