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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            subForm(new Form3());
        }

        private Form formActivo = null;
        private void subForm(Form subForm)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = subForm;
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            panelSub.Controls.Add(subForm);
            subForm.Show();       
        }
 
        private void btInicio_Click(object sender, EventArgs e)
        {
            subForm(new Form3());
        }

        private void btCalculadora_Click(object sender, EventArgs e)
        {
            subForm(new Form2());
        }

        private void btTareas_Click(object sender, EventArgs e)
        {
            subForm(new Form4());
        }
    }
}
