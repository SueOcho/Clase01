using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyWinc_Sem01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Bienvenid@ .. " + txtUsuario.Text,"Mensaje");
            //Muestra un mensaje ,primer parametro el texto, segundo el nombre de la cajita

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar.PerformClick();//llama al evento btnAceptar 
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Estas seguro de cerrar", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                //cancelamos el cierre
                e.Cancel = true;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
