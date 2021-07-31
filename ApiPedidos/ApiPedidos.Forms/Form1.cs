using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiPedidos.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'modelDB.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.modelDB.Producto);
            // TODO: esta línea de código carga datos en la tabla 'modelDB.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.modelDB.Cliente);

        }
    }
}
