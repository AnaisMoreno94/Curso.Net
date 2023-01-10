using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            Producto sprite = new Producto() 
            {
                Nombre = "Sprite",
                Descripcion= "Gaseosa sabor limon",
                PrecioCosto=100,
                Margen=0.3,
                IVA = 0.21,
                Proveedor= "Coca-Cola",
                Categoria="Bebida",
                SubCategoria="Gaseosa"
            };

            MessageBox.Show ("Producto Creado: "+sprite.Nombre+", Categoria: " +sprite.Categoria+", SubCategoria: "+sprite.SubCategoria+", Proveedor: "+sprite.Proveedor+", Precio de costo: "+sprite.PrecioCosto+", Margen de ganancia: "+(sprite.Margen*100)+"%, IVA: "+(sprite.IVA * 100)+"%, Precio Bruto: "+ Convert.ToDouble(sprite.PrecioBruto)+", Precio Venta: "+ Convert.ToDouble(sprite.PrecioVenta));




        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            ClienteIndividuo Juan = new ClienteIndividuo() 
            {
                Nombre = "Juan Pablo",
                Apellido = "Perez",
                CUIT ="21-97035564-0",
                Email= "juanpablo@hotmail.com",
                Telefono = "11-56985467",
                Direccion = "Av. Santa Fe, 954"
            };

            MessageBox.Show("Cliente Creado: " + Juan.Nombre + " " + Juan.Apellido + ", CUIT: "+Juan.CUIT+", E-mail: "+Juan.Email+", Telefono: "+Juan.Telefono+", Direccion:"+Juan.Direccion );


        }
    }
}
