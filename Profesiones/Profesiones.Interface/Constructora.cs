namespace Profesiones.Interface
{
    public class Constructora
    {
        public ICarpintero Carpintero { get; set; }
        public IArquitecto Arquitecto { get; set; }
        public ITecnico Tecnico { get; set; }
        public IMaestroDeObra Maestro { get; set; }
        public IAsistenteDeObra Asistente { get; set; }
        
        //Carpinteros
        public string ContratarCarpintero(ICarpintero carpintero)
        {
            Carpintero = carpintero;
            return "Contraté un carpintero";
        }
        public string ConstruirMesa()
        {
            return $"Para construir una mesa yo {Carpintero.Diseñar()}, {Carpintero.Medir()}" +
                $", {Carpintero.Serruchar()}, {Carpintero.Clavar()}, {Carpintero.Lijar()}," +
                $"luego {Carpintero.Lacar()} y termino mi trabajo";
        }
        //Arquitectos
        public string ContratarArquitecto(IArquitecto arquitecto)
        {
            Arquitecto=arquitecto;
            return "Contraté un arquitecto";
        }
        public string ManejarProyecto()
        {
            return $"En mi trabajo {Arquitecto.CrearProyecto()},también {Arquitecto.CambiarProyecto()}" +
                $",cada semana {Arquitecto.VerificarProyecto()}, {Arquitecto.ValidarProyecto()},también {Arquitecto.AprobarProyecto()}," +
                $"luego {Carpintero.Lacar()} y termino mi trabajo";
        }

        //Tecnicos
        public string ContratarTecnico(ITecnico tecnico)
        {
            Tecnico = tecnico;
            return "Contraté un técnico";
        }
        public string DarSoporte()
        {
            return $"En mi trabajo yo {Tecnico.PrepararEquipos()}, {Tecnico.ControlarEquipos()}" +
                $", {Tecnico.MonitoriarEquipos()},y {Tecnico.SupervisarMaquinaria()}";
        }
        //Maestros de obra
        public string ContratarMaestroDeObra(IMaestroDeObra maestroDeObra)
        {
            Maestro=maestroDeObra;
            return "Contraté un maestro de obra";
        }
        public string DirigirObra()
        {
            return $"En mi trabajo yo {Maestro.OrganizarObra()}, {Maestro.PlanificarPuestos()}" +
                $", {Maestro.EjecutarObra()},y {Maestro.ControlarObra()}";
        }
        //Asistentes de obra
        public string ContratarAsistenteDeObra(IAsistenteDeObra asistenteDeObra)
        {
            Asistente=asistenteDeObra;
            return "Contraté un asistente de obra";
        }
        public string MonitorearObra()
        {
            return $"En mi trabajo yo {Asistente.InterpretarPlanos()}, {Asistente.RealizarMediciones()}" +
                $", {Asistente.ControlarMaterial()},y {Asistente.ControlarTiempos()}";
        }


        //Carpinteros de manera individual
        public string ContratarCarpintero()
        {
            Carpintero = new Carpintero();
            return "Contraté un carpintero";
        }
        public string ContratarCarpinteroModerno()
        {
            Carpintero = new CarpinteroModerno();
            return "Contraté un carpintero moderno";
        }
        public string ContratarOtroCarpintero()
        {
            Carpintero = new CarpinteroMusical();
            return "Contraté un carpintero musical";
        }

    }
}
