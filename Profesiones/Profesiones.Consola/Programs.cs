using Profesiones.Negocio;
using Profesiones.Implementacion;
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

            //Generada Id
            Random generador = new Random();
             
            Constructora miConstructora = new Constructora();
            //Carpinteros
            //CarpinteroModerno
            var carpModerno = new CarpinteroModerno { Id = generador.Next()};
            var carpinteroModerno = miConstructora.ContratarCarpintero(carpModerno);
            var modernoConstruye = miConstructora.ConstruirMesa();
            //Carpintero antigua/tradicional
            //poner id en  el console.writline
            var carpAntiguo = new CarpinteroAntiguo { Id = generador.Next() };
            var carpinteroTradicional = miConstructora.ContratarCarpintero(carpAntiguo);
            var tradicionalConstruye = miConstructora.ConstruirMesa();
            //Carpintero musical
            //poner id en  el console.writline
            var carpMusical = new CarpinteroMusical { Id = generador.Next() };
            var carpinteroMusical = miConstructora.ContratarCarpintero(carpMusical);
            var musicalConstruye = miConstructora.ConstruirMesa();
            //Arquitectos
            //Arquitecto Junior
            //poner id en  el console.writline
            var arquiJunior = new ArquitectoJunior { Id = generador.Next() };
            var arquitectoJunior = miConstructora.ContratarArquitecto(arquiJunior);
            var arquitectoJuniorProyecto = miConstructora.ManejarProyecto();
            //Arquitcto Master
            //poner id en  el console.writline
            var arquiMaster = new ArquitectoMaster { Id = generador.Next() };
            var arquitectoMaster = miConstructora.ContratarArquitecto(arquiMaster);
            var arquitectoMasterProyecto = miConstructora.ManejarProyecto();
            //Tecnicos
            //Tecnico Junior
            //poner id en  el console.writline
            var tecniJunior = new TecnicoJunior { Id = generador.Next() };
            var tecnicoJunior = miConstructora.ContratarTecnico(tecniJunior);
            var tecnicoJuniorProyecto = miConstructora.DarSoporte();
            //Tecnico Master
            //poner id en  el console.writline
            var tecniMaster = new TecnicoMaster { Id = generador.Next() };
            var tecnicoMaster = miConstructora.ContratarTecnico(tecniMaster);
            var tecnicoMasterProyecto = miConstructora.DarSoporte();
            //Maestro de obra
            //Maestro tiempo completo
            //poner id en  el console.writline
            var maestroCompleto = new MaestroDeObraTiempoCompleto { Id = generador.Next() };
            var maestroTiempoCompleto = miConstructora.ContratarMaestroDeObra(maestroCompleto);
            var maestroTiempoCompletoObra = miConstructora.DirigirObra();
            //Maestro medio tiempo
            //poner id en  el console.writline
            var maestroMedio = new MaestroDeObraMedioTiempo { Id = generador.Next() };
            var maestroMedioTiempo = miConstructora.ContratarMaestroDeObra(maestroMedio);
            var maestroMedioTiempoObra = miConstructora.DirigirObra();
            //Asistente de obra
            //Asitente tiempo completo
            //poner id en  el console.writline
            var asistCompleto = new AsistenteDeObraTiempoCompleto { Id = generador.Next() };
            var asistenteTiempoCompleto = miConstructora.ContratarAsistenteDeObra(asistCompleto);
            var asistenteTiempoCompletoObra = miConstructora.MonitorearObra();
            //Asistente de medio tiempo
            //poner id en  el console.writline
            var asisMedio = new AsistenteDeObraMedioTiempo { Id = generador.Next() };
            var asistenteMedioTiempo = miConstructora.ContratarAsistenteDeObra(asisMedio);
            var asistenteMedioTiempoObra = miConstructora.MonitorearObra();

            Console.WriteLine($"\tContrataciones en la empresa GroupSofware");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            //Carpinteros
            Console.WriteLine($"{carpModerno.Id} {carpinteroModerno} moderno");
            Console.WriteLine(modernoConstruye);
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"{carpAntiguo.Id} {carpinteroTradicional} tradicional");
            Console.WriteLine(tradicionalConstruye);
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"{carpMusical.Id} {carpinteroMusical} proactivo ");
            Console.WriteLine(musicalConstruye);
            //Arquitectos
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"{arquiMaster.Id} {arquitectoMaster} master");
            Console.WriteLine(arquitectoMasterProyecto);
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"{arquiJunior.Id} {arquitectoJunior} junior");
            Console.WriteLine(arquitectoJuniorProyecto);
            //Tecnicos
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"{tecniMaster.Id} {tecnicoMaster} master");
            Console.WriteLine(tecnicoMasterProyecto);
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"{tecniJunior.Id} {tecnicoJunior} junior");
            Console.WriteLine(tecnicoJuniorProyecto);
            //Maestros de obra
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"{maestroCompleto.Id} {maestroTiempoCompleto} a tiempo completo");
            Console.WriteLine(maestroTiempoCompletoObra);
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"{maestroMedio.Id} {maestroMedioTiempo} a medio tiempo");
            Console.WriteLine(maestroMedioTiempoObra);
            //Asistentes de obra
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"{asistCompleto.Id} {asistenteTiempoCompleto} a tiempo completo");
            Console.WriteLine(asistenteTiempoCompletoObra);
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"{asisMedio.Id} {asistenteMedioTiempo} a medio tiempo");
            Console.WriteLine(asistenteMedioTiempoObra);

            Console.ReadKey();
        }

    }
}
