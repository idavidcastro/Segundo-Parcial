using Datos;
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
    public partial class FrmConsultarEmpleado : Form
    {
        public FrmConsultarEmpleado()
        {
            InitializeComponent();
        }

        private void FrmConsultarEmpleado_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnConsultarEstado_Click(object sender, EventArgs e)
        {

            EmpleadoConsultaResponse respuesta;
            EmpleadoService empleadoService = new();

            if (CmbConsultaEstado.Text.Equals("Activo"))
            {
                respuesta = empleadoService.ConsultarPorEstado(CmbConsultaEstado.Text);
            }
            else if (CmbConsultaEstado.Text.Equals("Inactivo"))
            {
                respuesta = empleadoService.ConsultarPorEstado(CmbConsultaEstado.Text);
            }
            else
            {
                respuesta = empleadoService.ConsultarPorAmbosEstados();
            }

            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                dgtEmpleados.DataSource = respuesta.Empleados;
            }
            
            
        }

        private void BtnConsultarNombre_Click(object sender, EventArgs e)
        {
            
        }
    }
}
