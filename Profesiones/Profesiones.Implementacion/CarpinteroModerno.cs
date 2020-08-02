using Profesiones.Interface;
using Profesiones.Entidad;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class CarpinteroModerno : ICarpintero,IEquatable<CarpinteroModerno>
    {
        //Composición
        private readonly Carpintero carpintero = new Carpintero();
        public int Id { get { return carpintero.Id; } set { carpintero.Id = value; } }
        public Carpintero Carpintero { get; set; }
        public string Diseñar()
        {
            return "estoy diseñando con Autocad";
        }
        public string Medir()
        {
            return "estoy midiendo con láser";
        }
        public string Serruchar()
        {
            return "estoy serruchando con máquina";
        }
        public string Clavar()
        {
            return "estoy clavando con pistola de aire coomprimido";
        }
        public string Lijar()
        {
            return "estoy lijando con lijadora con absorción";
        }
        public string Lacar()
        {
            return "estoy lacando de secado instantáneo";
        }

        public bool Equals([AllowNull] CarpinteroModerno other)
        {
            return this.Id == other.Id;
        }
    }





}
