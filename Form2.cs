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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(lstItem.Items.IndexOf(txtItem.Text.Trim())>=0| txtItem.Text.Trim()==String.Empty)
            {
                MessageBox.Show("El elemento ya existe o es un a cadena en gray", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.SelectAll();//selecciona todo el texto de un textbox
            }
            else
            {
                //Si el elemento no existe ni es un elemento vacio,se le agrega la coleccion
                lstItem.Items.Add(txtItem.Text);
                txtItem.Text = String.Empty;
            }
            txtItem.Focus();//Enviar el cursor a la caja txtItem
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)//si pulsamos escape el formulario se cierra
            {
                this.Close();
            }
        }
    }
}
