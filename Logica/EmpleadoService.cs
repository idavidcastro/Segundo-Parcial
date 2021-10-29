using Datos;
using Entidad;
using System;

namespace Logica
{
    public class EmpleadoService
    {
        EmpleadoRepository empleadoRepository;
        public EmpleadoService()
        {
            empleadoRepository = new EmpleadoRepository();
        }

        public string Guardar(Empleado empleado)
        {
            try
            {
                empleadoRepository.Guardar(empleado);
                return "Se guardaron los datos correctamente";
            }
            catch (Exception e)
            {
                return "ERROR!" + e.Message;
            }

        }
        
        
        public EmpleadoConsultaResponse ConsultarPorEstado(string estado)
        {
            try
            {
                return new EmpleadoConsultaResponse(empleadoRepository.ConsultarPorEstado(estado));
            }
            catch (Exception e)
            {
                return new EmpleadoConsultaResponse("ERROR!" + e.Message);
            }
        }
        public EmpleadoConsultaResponse ConsultarPorNombre(string nombre)
        {
            try
            {
                return new EmpleadoConsultaResponse(empleadoRepository.ConsultarPorEstado(nombre));
            }
            catch (Exception e)
            {
                return new EmpleadoConsultaResponse("ERROR!" + e.Message);
            }
        }
        public EmpleadoConsultaResponse ConsultarPorAmbosEstados()
        {
            try
            {
                return new EmpleadoConsultaResponse(empleadoRepository.ConsultarPorAmbosEstados());
            }
            catch (Exception e)
            {
                return new EmpleadoConsultaResponse("ERROR!" + e.Message);
            }
        }

        /*
        
        public ProductoConsultaResponse ConsultarPorEstado(string estado)
        {
            try
            {
                return new ProductoConsultaResponse(productoRepository.ConsultarPorEstado(estado));
            }
            catch (Exception e)
            {
                return new ProductoConsultaResponse("ERROR!" + e.Message);
            }
        }
        */
    }
}
