﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1
{
    internal class Tarea
    {
        public int Codigo {  get; set; }
        string Descripcion { get; set; }
        string FechaInicio { get; set; }
        string FechaFin {  get; set; }

        public void Crear (int cod, string desc, DateTime fechaFin)
        {
            Codigo = cod;
            Descripcion = desc;
            FechaInicio = DateTime.Now.ToString("dd/MM");
            FechaFin = fechaFin.ToString("dd/MM");
        }

        public string AgregarDesc()
        {
            return Descripcion;
        }

        public string AgregarInicio()
        {
            return FechaInicio;
        }

        public string AgregarFin()
        {
            return FechaFin;
        }

        public string Escribir()
        {
            return Codigo + " - " + Descripcion + " - " + FechaInicio + " - " + FechaFin;
        }
        public string Borrar(ref List<int> cod, ref List<string> text, int codigo, string backup, ref List<string> inicio, ref List<string> fin)
        {
            if (codigo > cod.Count)
            {
                MessageBox.Show("Tarea no existente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return backup;
            }
            cod.RemoveAt(cod.Find(x => x == codigo - 1));
            text.RemoveAt(codigo - 1);
            inicio.RemoveAt(codigo - 1);
            fin.RemoveAt(codigo - 1);

            string label = "";

            for (int i = 0; i < cod.Count; i++)
            {
                label = label + "\r\n" + (i+1).ToString() + " - " + text[i] + " - " + inicio[i] + " - " + fin[i];

            }

            return "Código / Tarea / Fecha de Creación / Fecha Límite" + label;
        }

        public string Editar(ref List<int> cod, ref List<string> text, int codigo, string backup, string newText, ref List<string> inicio, ref List<string> fin,DateTime newFin)
        {
            if (codigo > cod.Count)
            {
                MessageBox.Show("Tarea no existente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return backup;
            }

            text[codigo - 1] = newText;
            fin[codigo - 1] = newFin.ToString("dd/MM");

            string label = "";

            for (int i = 0; i < cod.Count; i++)
            {
                label = label + "\r\n" + (i + 1).ToString() + " - " + text[i] + " - " + inicio[i] + " - " + fin[i];
            }

            return "Código / Tarea / Fecha de Creación / Fecha Límite" + label;

        }
    }
}
