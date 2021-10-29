using System;

namespace Entidad
{
    public class Empleado
    {
        public Empleado()
        {

        }
        public Empleado(int identificacion, string nombre, decimal salarioBase, string estado)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            SalarioBase = salarioBase;
            Estado = estado;
        }

        public int Identificacion { get; set; }
        public string  Nombre { get; set; }
        public decimal SalarioBase { get; set; }
        public string Estado { get; set; }
    }
}
