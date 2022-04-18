using System;
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
            this.Close();            
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
            
            list.Add(txt_OperandoUno.Text + " " + char.Parse(cmb_Operar.Text) + " " + 
                txt_OperandoDos.Text + " " + " = " + resultado.ToString());
            lst_Resultado.DataSource = null;
            lst_Resultado.DataSource = list;
        }

        private void btn_ConvertiraBinario_Click(object sender, EventArgs e)
        {
            double resultado = Entidades.Calculadora.Operar(txt_OperandoUno.Text, txt_OperandoDos.Text, char.Parse(cmb_Operar.Text));
            string binario = Entidades.Operando.DecimalBinario(Convert.ToString(resultado));
            list.Add(txt_OperandoUno.Text + " " + char.Parse(cmb_Operar.Text) + " " +
                txt_OperandoDos.Text + " " + " = " + binario);
            lst_Resultado.DataSource = null;
            lst_Resultado.DataSource = list;
        }

        private void btn_ConvertiraDecimal_Click(object sender, EventArgs e)
        {
            string Operando1 = Entidades.Operando.BinarioDecimal(txt_OperandoUno.Text);
            string Operando2 = Entidades.Operando.BinarioDecimal(txt_OperandoDos.Text);

            double resultado = Entidades.Calculadora.Operar(Operando1, Operando2, char.Parse(cmb_Operar.Text));

            list.Add(txt_OperandoUno.Text + " " + char.Parse(cmb_Operar.Text) + " " +
                txt_OperandoDos.Text + " " + " = " + resultado.ToString());
            lst_Resultado.DataSource = null;
            lst_Resultado.DataSource = list;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro desea cerrar el programa?",
               "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
