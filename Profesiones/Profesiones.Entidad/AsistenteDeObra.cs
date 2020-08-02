using System.Collections.Generic;

namespace Profesiones.Entidad
{
    public class AsistenteDeObra
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<string> MaterialesDeObraParaAsistente { get; set; }
    }
}
