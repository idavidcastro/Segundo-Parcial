using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class EmpleadoConsultaResponse
    {
        
        public List<Empleado> Empleados { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public EmpleadoConsultaResponse(List<Empleado> empleado)
        {
            Empleados = empleado;
            Error = false;
        }
        public EmpleadoConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}
