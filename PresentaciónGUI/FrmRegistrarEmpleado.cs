using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaciónGUI
{
    public partial class FrmRegistrarEmpleado : Form
    {
        public FrmRegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            
            if (TxtIdentificacion.Text.Equals(""))
            {
                MessageBox.Show("Por favor digite la identificación");
            }else if (TxtNombre.Text.Equals("") )
            {
                MessageBox.Show("Por favor digite el nombre");
            }
            else if (TxtSalarioBase.Text.Equals(""))
            {
                MessageBox.Show("Por favor digite el salario base del empleado");
            }
            else if (CmbEstado.Text.Equals(""))
            {
                MessageBox.Show("Por favor escoja el estado del producto");
            }
            else
            {
                Registrar();
            }  
        }
        private void Registrar()
        {
            
            try
            {

                Empleado empleado = new(int.Parse(TxtIdentificacion.Text), TxtNombre.Text, decimal.Parse(TxtSalarioBase.Text), CmbEstado.Text);
                EmpleadoService empleadoService = new();
                string mensaje = empleadoService.Guardar(empleado);
                MessageBox.Show("Los datos se guardaron correctamente");

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al intentar guardar!");
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void Limpiar()
        {
            TxtIdentificacion.Text = "";
            TxtNombre.Text = "";
            TxtSalarioBase.Text = "";
            CmbEstado.Text = "";
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar <65 && e.KeyChar >90)|| (e.KeyChar <97 && e.KeyChar > 122))
            {
                MessageBox.Show("Solo se permiten letras en el campo de nombre");
                e.Handled = true;
                return;
            }
        }
    } 
}
