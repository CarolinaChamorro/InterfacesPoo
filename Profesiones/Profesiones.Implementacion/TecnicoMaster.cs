using Profesiones.Entidad;
using Profesiones.Interface;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
   public class TecnicoMaster : ITecnico,IEquatable<TecnicoMaster>
    {
        //Composicion
        private readonly Tecnico tecnico = new Tecnico();
        public int Id { get { return tecnico.Id; } set { tecnico.Id=value;} }
        public Tecnico Tecnico { get; set; }

        public string ControlarEquipos()
        {
            return "me encargo del funcionamiento y mantenimiento de los equipos";
        }

        public bool Equals([AllowNull] TecnicoMaster other)
        {
            return this.Id == other.Id;
        }

        public string MonitoriarEquipos()
        {
            return "me encargo de llevar un control del funcionamiento de los equipos";
        }

        public string PrepararEquipos()
        {
            return "me encargo de mantener funcionales todos los equipos";
        }

        public string SupervisarMaquinaria()
        {
            return "me encaro de cuidar el capacitar a los trabajadores para el uso de equipos";
        }
    }




}
