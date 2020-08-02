using Profesiones.Entidad;
using Profesiones.Interface;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class AsistenteDeObraTiempoCompleto : IAsistenteDeObra,IEquatable<AsistenteDeObraTiempoCompleto>
    {
        //Composición
        private readonly AsistenteDeObra asistenteDeObra = new AsistenteDeObra();
        public int Id { get { return asistenteDeObra.Id; } set { asistenteDeObra.Id = value; } }
        public AsistenteDeObra AsistenteDeObra { get; set; }

        public string ControlarMaterial()
        {
            return "me encargo de controlar todo el material durante el dia";
        }

        public string ControlarTiempos()
        {
            return "estoy a cargo de controlar varias veces el tiempo de obra";
        }

        public bool Equals([AllowNull] AsistenteDeObraTiempoCompleto other)
        {
            return this.Id == other.Id;
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
