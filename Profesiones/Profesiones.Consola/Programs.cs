using Profesiones.Interface;
using System;

namespace Profesiones.Consola
{
    class Programs
    {
         static void Main(string[] args)
        {
            if (args == null)
            {
                Console.WriteLine("Bienvenido");
            }

            Constructora miConstructora = new Constructora();
            //Carpinteros
            var carpinteroModerno = miConstructora.ContratarCarpintero(new CarpinteroModerno());
            var modernoConstruye=miConstructora.ConstruirMesa();
            var carpinteroTradicional = miConstructora.ContratarCarpintero(new Carpintero());
            var tradicionalConstruye = miConstructora.ConstruirMesa();
            var carpinteroMusical = miConstructora.ContratarCarpintero(new CarpinteroMusical());
            var musicalConstruye = miConstructora.ConstruirMesa();
            //Arquitectos
            var arquitectoJunior = miConstructora.ContratarArquitecto(new ArquitectoJunior());
            var arquitectoJuniorProyecto = miConstructora.ManejarProyecto();
            var arquitectoMaster= miConstructora.ContratarArquitecto(new ArquitectoMaster());
            var arquitectoMasterProyecto = miConstructora.ManejarProyecto();
            //Tecnicos
            var tecnicoJunior = miConstructora.ContratarTecnico(new TecnicoJunior());
            var tecnicoJuniorProyecto = miConstructora.DarSoporte();
            var tecnicoMaster = miConstructora.ContratarTecnico(new TecnicoMaster());
            var tecnicoMasterProyecto = miConstructora.DarSoporte();
            //Maestro de obra
            var maestroTiempoCompleto = miConstructora.ContratarMaestroDeObra(new MaestroDeObraTiempoCompleto());
            var maestroTiempoCompletoObra = miConstructora.DirigirObra();
            var maestroMedioTiempo = miConstructora.ContratarMaestroDeObra(new MaestroDeObraMedioTiempo());
            var maestroMedioTiempoObra= miConstructora.DirigirObra();
            //Asistente de obra
            var asistenteTiempoCompleto = miConstructora.ContratarAsistenteDeObra(new AsistenteDeObraTiempoCompleto());
            var asistenteTiempoCompletoObra = miConstructora.MonitorearObra();
            var asistenteMedioTiempo = miConstructora.ContratarAsistenteDeObra(new AsistenteDeObraMedioTiempo());
            var asistenteMedioTiempoObra = miConstructora.MonitorearObra();

            Console.WriteLine($"\tContrataciones en la empresa GroupSofwatre");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            //Carpinteros
            Console.WriteLine(carpinteroModerno+" moderno");
            Console.WriteLine(modernoConstruye);
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine(carpinteroTradicional + " tradicional");
            Console.WriteLine(tradicionalConstruye);
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine(carpinteroMusical + " proactivo");
            Console.WriteLine(musicalConstruye);
            //Arquitectos
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine(arquitectoMaster + " master");
            Console.WriteLine(arquitectoMasterProyecto);
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine(arquitectoJunior + " junior");
            Console.WriteLine(arquitectoJuniorProyecto);
            //Tecnicos
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine(tecnicoMaster + " master");
            Console.WriteLine(tecnicoMasterProyecto);
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine(tecnicoJunior + " junior");
            Console.WriteLine(tecnicoJuniorProyecto);
            //Maestros de obra
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine(maestroTiempoCompleto + " a tiempo completo");
            Console.WriteLine(maestroTiempoCompletoObra);
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine(maestroMedioTiempo + " a medio tiempo");
            Console.WriteLine(maestroMedioTiempoObra);
            //Asistentes de obra
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine(asistenteTiempoCompleto+ " a tiempo completo");
            Console.WriteLine(asistenteTiempoCompletoObra);
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine(asistenteMedioTiempo + " a medio tiempo");
            Console.WriteLine(asistenteMedioTiempoObra);

            Console.ReadKey();
        }

    }
}
