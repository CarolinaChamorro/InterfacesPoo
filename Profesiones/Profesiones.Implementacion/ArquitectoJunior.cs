using Profesiones.Entidad;
using Profesiones.Interface;
using Profesiones.Negocio;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class ArquitectoJunior : IArquitecto,IEquatable<ArquitectoJunior>
    {
        //Composición
        private readonly Arquitecto arquitecto = new Arquitecto();
        public int Id { get { return arquitecto.Id; } set { arquitecto.Id = value; } }
        public Arquitecto Arquitecto { get; set; }

        public Proyecto Proyecto { get; set; }
        public Proyecto proyectoInterno = new Proyecto()
        {
            Nombre = "Proyecto SASS"
        };
        public Proyecto proyectoCuenca = new Proyecto()
        {
            Nombre = "UIO-Plan_Cuenta"
        };
        public Proyecto proyectoTrident = new Proyecto()
        {
            Nombre = "Plan-Trident"
        };
        public string AprobarProyecto()
        {
            return $"me encargo de aprobar el proyecto {proyectoTrident.Nombre}";
        }

        public string CambiarProyecto()
        {
            return $"estoy mejorando el proyecto {proyectoCuenca.Nombre}";
        }

        public string CrearProyecto()
        {
            return $"yo me encargo de crear el proyecto {proyectoInterno.Nombre}";
        }

        public string ValidarProyecto()
        {
            return $"yo me encargo de validar todo el proyecto {proyectoCuenca.Nombre}";
        }

        public string VerificarProyecto()
        {
            return $"estoy verificando errores en el proyecto {proyectoTrident.Nombre}";
        }

        public bool Equals([AllowNull] ArquitectoJunior other)
        {
            return this.Id==other.Id;
        }
    }




}
