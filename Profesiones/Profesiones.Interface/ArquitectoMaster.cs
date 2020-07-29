
namespace Profesiones.Interface
{
    public class ArquitectoMaster : IArquitecto
    {
        public string AprobarProyecto()
        {
            return $"apruebo todos los proyectos {proyectoAgua}";
        }

        public string CambiarProyecto()
        {
            return $"estoy mejorando el proyecto {proyectoLuz.Nombre}";
        }

        public string CrearProyecto()
        {
            return $"yo me encargo de crear el nuevo proyecto {proyectoUrgente.Nombre}";
        }

        public string ValidarProyecto()
        {
            return $"yo me hago cargo de validar todo el proyecto {proyectoLuz.Nombre}";
        }

        public string VerificarProyecto()
        {
            return $"me encargo de corregir los errores en el proyecto {proyectoUrgente.Nombre}";
        }

        public Proyecto Proyecto { get; set; }
        public Proyecto proyectoAgua = new Proyecto()
        {
            Nombre = "Interagua"
        };
        public Proyecto proyectoLuz = new Proyecto()
        {
            Nombre = "UIO-Plan"
        };
        public Proyecto proyectoUrgente = new Proyecto()
        {
            Nombre = "Plan-Marriot"
        };
    }




}
