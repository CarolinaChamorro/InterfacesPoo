
namespace Profesiones.Interface
{
    public class AsistenteDeObraTiempoCompleto : IAsistenteDeObra
    {
        public string ControlarMaterial()
        {
            return "me encargo de controlar todo el material durante el dia";
        }

        public string ControlarTiempos()
        {
            return "estoy a cargo de controlar varias veces el tiempo de obra";
        }

        public string InterpretarPlanos()
        {
            return "me encargo de interpretar los planos a los trabajadores";
        }

        public string RealizarMediciones()
        {
            return "estoy a cargo de verificar las mediciones cada dia";
        }
    }




}
