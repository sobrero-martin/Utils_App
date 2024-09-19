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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private Tarea tarea = new Tarea();

        #region txtFocus
     

        private void txtDescGotFocus(object sender, EventArgs e)
        {
            if (txtDesc.Text == "Ingrese una tarea")
            {
                txtDesc.Text = "";
            }
        }

        private void txtDescLostFocus(object sender, EventArgs e)
        {
            if (txtDesc.Text == "")
            {
                txtDesc.Text = "Ingrese una tarea";
            }
        }

        private void txtCodGotFocus(object sender, EventArgs e)
        {
            if (txtCod.Text == "Ingrese un código")
            {
                txtCod.Text = "";
            }
        }

        private void txtCodLostFocus(object sender, EventArgs e)
        {
            if (txtCod.Text == "")
            {
                txtCod.Text = "Ingrese un código";
            }
        }
        #endregion

        List<int> codigo = new List<int>();
        List<string> text = new List<string>();
        List<string> inicio = new List<string>();
        List<string> fin = new List<string>();
        int i = 0;

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == "" || txtDesc.Text == "Ingrese una tarea")
            {
                MessageBox.Show("Ingrese una tarea!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            else if (codigo.Count >= 10)
            {
                MessageBox.Show("Máximo de tareas alcanzado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            i++;
            codigo.Add(i);
            tarea.Crear(i, txtDesc.Text, dtpFin.Value);
            text.Add(tarea.AgregarDesc());
            inicio.Add(tarea.AgregarInicio());
            fin.Add(tarea.AgregarFin());

            lblTareas.Text = lblTareas.Text + "\r\n" + tarea.Escribir();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            lblTareas.Text = tarea.Borrar(ref codigo,ref text, Convert.ToInt32(txtCod.Text), lblTareas.Text, ref inicio, ref fin);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            lblTareas.Text = tarea.Editar(ref codigo, ref text, Convert.ToInt32(txtCod.Text), lblTareas.Text, txtDesc.Text, ref inicio, ref fin, dtpFin.Value);
        }
    }
}
