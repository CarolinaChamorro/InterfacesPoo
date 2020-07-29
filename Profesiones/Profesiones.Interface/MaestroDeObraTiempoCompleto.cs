
namespace Profesiones.Interface
{
    public class MaestroDeObraTiempoCompleto : IMaestroDeObra
    {
        public string ControlarObra()
        {
            return "me encargo de verificar tareas durante el dia";
        }

        public string EjecutarObra()
        {
            return "me encargo definir los plazos de las tareas al día";
        }

        public string OrganizarObra()
        {
            return "me encargo verificar equipos de trabajo semanales";
        }

        public string PlanificarPuestos()
        {
            return "me encargo de asignar tareas diarias ";
        }
    }




}
