using Profesiones.Interface;
using Profesiones.Entidad;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class CarpinteroMusical : ICarpintero, IEquatable<CarpinteroMusical>
    {
        //Composición
        private readonly Carpintero carpintero = new Carpintero();
        public int Id { get { return carpintero.Id; } set { carpintero.Id = value; } }
        public Carpintero Carpintero { get; set; }
        public string Clavar()
        {
            return "estoy clavando escuchando Pop";
        }

        public string Diseñar()
        {
            return "estoy diseñando y bailando";
        }

        public bool Equals([AllowNull] CarpinteroMusical other)
        {
            return this.Id == other.Id;
        }

        public string Lacar()
        {
            return "estoy lacando y cantando ";
        }

        public string Lijar()
        {
            return "estoy lijando y silbando";
        }

        public string Medir()
        {
            return "estoy midiendo y tratareando";
        }

        public string Serruchar()
        {
            return "estoy serruchando y moviendome";
        }
    }
}
