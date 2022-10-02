using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L9_DBDLL_29187
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_sumar_Click(object sender, EventArgs e)
        {
            int primer_numero, segundo_numero, resultado;
            /*validamos que sea un número y no una letra*/
           
            if ( !int.TryParse(txt_numero2.Text, out int num) )
            {
                MessageBox.Show("Debe ingresar un número");
            }
            else
            {
                if ( !int.TryParse(txt_numero1.Text, out int num2) ) 
                 {
                    MessageBox.Show("Debe ingresar números no letras");
                }
                else
                {
                    primer_numero = Convert.ToInt32(txt_numero1.Text);
                    segundo_numero = Convert.ToInt32(txt_numero2.Text);

                    resultado = primer_numero + segundo_numero;

                    lbl_resultado.Text = resultado.ToString();
                }
                    
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_numero1.Clear();
            txt_numero2.Clear();
            lbl_resultado.Text=""; 
        }

        private void txt_numero2_TextChanged(object sender, EventArgs e)
        {
           
           
        }


        private void lbl_numero1_Click(object sender, EventArgs e)
        {

        }

        private void txt_numero1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
