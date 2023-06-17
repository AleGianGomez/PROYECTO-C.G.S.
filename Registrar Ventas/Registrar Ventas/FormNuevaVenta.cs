using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registrar_Ventas
{
    public partial class FormNuevaVenta : Form
    {
        public FormNuevaVenta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formlistarequiposdisponibles equipos = new Formlistarequiposdisponibles();
            equipos.Show();
            this.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCliente clientes = new FormCliente();   
            clientes.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
