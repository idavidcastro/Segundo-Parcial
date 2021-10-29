using Entidad;

using System;
using System.Collections.Generic;
using System.IO;

namespace Datos
{
    public class EmpleadoRepository
    {
        public string ruta = "Empleado.txt";

        public void Guardar(Empleado empleado)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{empleado.Identificacion};{empleado.Nombre};{empleado.SalarioBase};{empleado.Estado};");

            writer.Close();
            file.Close();
        }
        public List<Empleado> ConsultarPorEstado(string estado)
        {
            List<Empleado> empleados = new();
            using (StreamReader reader = new(ruta))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    
                    Empleado empleado = Mapear(linea);
                    if (empleado.Estado.Equals(estado))
                    {
                        empleados.Add(empleado);
                    }
                }
            }
            return empleados;
        }

        private static Empleado Mapear(string linea)
        {
            Empleado empleado= new(); 
            string[] dato = linea.Split(';');
            
            
            empleado.Identificacion = int.Parse(dato[0]);
            empleado.Nombre = dato[1];
            empleado.SalarioBase = decimal.Parse(dato[2]);
            empleado.Estado = dato[3];
            

            return empleado;
        }

        public List<Empleado> ConsultarPorAmbosEstados()
        {
            List<Empleado> empleados = new List<Empleado>();
            using (StreamReader reader = new(ruta))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Empleado empleado = Mapear(linea);

                    empleados.Add(empleado);
                }
            }
            return empleados;
        }
        
    }
}
