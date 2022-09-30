using EmpleadosCRUD.Datos;
using EmpleadosCRUD.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe llenar el  campo");
            }
            else
            {
                try
                {
                    Emplea et = new Emplea();
                    et.Nombre = txtNombre.Text.Trim();
                    et.Apellidos = txtApellido.Text.Trim();
                    et.Correo = txtCorreo.Text.Trim();
                    et.FechaIngreso = txtIngreso.Value.Year+"-"+ txtIngreso.Value.Month + "-" + txtIngreso.Value.Day;

                    if (Empleado.guardar(et))
                    {
                        MessageBox.Show("Empleado gurdado");
                    }
                    else
                    {
                        MessageBox.Show("Empleado no guardado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe llenar el  campo");
            }
            else
            {
                Empleado em = Consultar(txtNombre.Text.Trim());
                if (em == null)
                {
                    MessageBox.Show("No hay registro de ese empleado" + txtNombre.Text);

                }
                else
                {
                    txtNombre.Text = 
                }
            }
        }
    }
}
