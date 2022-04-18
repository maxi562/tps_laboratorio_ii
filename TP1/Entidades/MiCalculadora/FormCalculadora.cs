﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        List<string> list = new List<string>();
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void CerrarFormulario_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void btn_LimpiarFormulario_Click(object sender, EventArgs e)
        {
            txt_OperandoUno.Clear();
            txt_OperandoDos.Clear();
            lst_Resultado.ClearSelected();
            cmb_Operar.SelectedIndex = 0;
        }

        private void btn_Operar_Click(object sender, EventArgs e)
        {
            double resultado = Entidades.Calculadora.Operar(txt_OperandoUno.Text, txt_OperandoDos.Text, char.Parse(cmb_Operar.Text));
            
            list.Add(resultado.ToString());
            lst_Resultado.DataSource = null;
            lst_Resultado.DataSource = list;
        }
    }
}
