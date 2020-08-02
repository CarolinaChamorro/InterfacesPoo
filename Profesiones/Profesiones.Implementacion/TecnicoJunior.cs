using Profesiones.Entidad;
using Profesiones.Interface;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class TecnicoJunior : ITecnico,IEquatable<TecnicoJunior>
    {
        //Composicion
        private readonly Tecnico tecnico = new Tecnico();
        public int Id { get { return tecnico.Id; } set { tecnico.Id = value; } }
        public Tecnico Tecnico { get; set; }

        public string ControlarEquipos()
        {
            return "me encargo de hacer funcionar los equipos";
        }

        public bool Equals([AllowNull] TecnicoJunior other)
        {
            return this.Id == other.Id;
        }

        public string MonitoriarEquipos()
        {
            return "me encargo de monitoriar los equipos";
        }

        public string PrepararEquipos()
        {
            return "me encargo de comunicar las averias existentes en los equipos";
        }

        public string SupervisarMaquinaria()
        {
            return "me encaro de cuidar el los equipos";
        }
    }




}
