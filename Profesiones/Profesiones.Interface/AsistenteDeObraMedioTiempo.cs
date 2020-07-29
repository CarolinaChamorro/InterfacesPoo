
namespace Profesiones.Interface
{
    public class AsistenteDeObraMedioTiempo : IAsistenteDeObra
    {
        public string ControlarMaterial()
        {
            return "me encargo de controlar todo el material en mi jornada ";
        }

        public string ControlarTiempos()
        {
            return "estoy a cargo de controlar tres veces el tiempo de obra";
        }

        public string InterpretarPlanos()
        {
            return "me encargo de interpretar los planos del dia";
        }

        public string RealizarMediciones()
        {
            return "estoy a cargo de verificar las mediciones dos veces a la semana";
        }
    }




}
