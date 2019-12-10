using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoListas
{
    public partial class TareaLista : Form
    {
        private List<Clases.producto> listaproducto = new List<Clases.producto>();
        public TareaLista()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Clases.producto productos = new Clases.producto();
            productos.codigo = this.txtcodigo.Text;
            productos.nombre = this.txtnombre.Text;
            productos.precio = double.Parse(this.txtprecio.Text);
            productos.fecha = DateTime.Parse(this.txtfecha.Text);
            productos.unidad = int.Parse(this.txtunidad.Text);

            listaproducto.Add(productos);

            ////mostar los estudiantes en el listview

            ListViewItem produ = new ListViewItem(productos.codigo);
            listproducto.Items.Add(produ);
            produ.SubItems.Add(productos.nombre);
            produ.SubItems.Add(productos.precio.ToString());
            produ.SubItems.Add(productos.fecha.ToString());
            produ.SubItems.Add(productos.unidad.ToString());
        }
    }
}
