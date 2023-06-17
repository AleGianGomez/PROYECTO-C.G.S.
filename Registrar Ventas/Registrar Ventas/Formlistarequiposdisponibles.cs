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
    public partial class Formlistarequiposdisponibles : Form
    {
        public Formlistarequiposdisponibles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNuevaVenta regresar = new FormNuevaVenta();
            regresar.Show();
            this.Hide();
        }
    }
}
