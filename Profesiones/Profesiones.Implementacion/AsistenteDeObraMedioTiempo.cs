using Profesiones.Entidad;
using Profesiones.Interface;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class AsistenteDeObraMedioTiempo : IAsistenteDeObra,IEquatable<AsistenteDeObraMedioTiempo>
    {
        //Composición
        private readonly AsistenteDeObra asistenteDeObra = new AsistenteDeObra();
        public int Id { get { return asistenteDeObra.Id; } set { asistenteDeObra.Id = value; } }
        public AsistenteDeObra AsistenteDeObra { get; set; }
        public string ControlarMaterial()
        {
            return "me encargo de controlar todo el material en mi jornada ";
        }

        public string ControlarTiempos()
        {
            return "estoy a cargo de controlar tres veces el tiempo de obra";
        }

        public bool Equals([AllowNull] AsistenteDeObraMedioTiempo other)
        {
            return this.Id == other.Id;
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
