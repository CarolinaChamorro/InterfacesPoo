
namespace Profesiones.Interface
{
    public class MaestroDeObraMedioTiempo : IMaestroDeObra
    {
        public string ControlarObra()
        {
            return "me encargo de verificar tareas durante mi jornada";
        }

        public string EjecutarObra()
        {
            return "me encargo definir los plazos de las tareas dentro de la jornada";
        }

        public string OrganizarObra()
        {
            return "me encargo verificar equipos de trabajo diarios";
        }

        public string PlanificarPuestos()
        {
            return "me encargo de asignar tareas por horas";
        }
    }




}
