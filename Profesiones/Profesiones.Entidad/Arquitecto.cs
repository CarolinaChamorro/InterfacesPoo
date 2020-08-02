using System;
using System.Collections.Generic;
using System.Text;

namespace Profesiones.Entidad
{
    public class Arquitecto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<string> MaterialesDeArquitecto { get; set; }
    }
}
