using Profesiones.Interface;
using Profesiones.Entidad;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class CarpinteroAntiguo : ICarpintero, IEquatable<CarpinteroAntiguo>
    {
        //Composición
        private readonly Carpintero carpintero = new Carpintero();
        public int Id { get { return carpintero.Id; } set { carpintero.Id = value; } }
        public Carpintero Carpintero { get; set; }
        public string Diseñar()
        {
            return "estoy diseñando";
        }
        public string Medir()
        {
            return "estoy midiendo con metro";
        }
        public string Serruchar()
        {
            return "estoy serruchando";
        }
        public string Clavar()
        {
            return "estoy clavando";
        }
        public string Lijar()
        {
            return "estoy lijando";
        }
        public string Lacar()
        {
            return "estoy lacando";
        }

        public bool Equals([AllowNull] CarpinteroAntiguo other)
        {
            return this.Id == other.Id;
        }
    }





}
