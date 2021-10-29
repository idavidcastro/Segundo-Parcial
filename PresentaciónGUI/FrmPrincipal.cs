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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnGestionEmpleado_Click(object sender, EventArgs e)
        {
            
            BtnRegistrar.Visible = true;
            BtnConsultar.Visible = true;
            Logo.Visible = false;

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrarEmpleado frmRegistrarEmpleado = new FrmRegistrarEmpleado();
            frmRegistrarEmpleado.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            BtnConsultar.Visible = false;
            BtnRegistrar.Visible = false;
            Logo.Visible = true;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultarEmpleado frmConsultarEmpleado = new FrmConsultarEmpleado();
            frmConsultarEmpleado.Show();
        }
    }
}
