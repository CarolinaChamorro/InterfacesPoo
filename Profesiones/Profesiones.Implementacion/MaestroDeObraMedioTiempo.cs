using Profesiones.Entidad;
using Profesiones.Interface;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class MaestroDeObraMedioTiempo : IMaestroDeObra,IEquatable<MaestroDeObraMedioTiempo>
    {
        //Composicion
        private readonly MaestroDeObra maestroDeObra = new MaestroDeObra();
        public int Id { get { return maestroDeObra.Id; } set { maestroDeObra.Id = value; } }
        public MaestroDeObra MaestroDeObra { get; set; }
        public string ControlarObra()
        {
            return "me encargo de verificar tareas durante mi jornada";
        }

        public string EjecutarObra()
        {
            return "me encargo definir los plazos de las tareas dentro de la jornada";
        }

        public bool Equals([AllowNull] MaestroDeObraMedioTiempo other)
        {
            return this.Id == other.Id;
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
