using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno
            _repoDueno = new RepositorioDueno(new Persistencia.AppContext());

        private static IRepositorioMascota
            _repoMascota =
                new RepositorioMascota(new Persistencia.AppContext());

        private static IRepositorioVeterinario
            _repoVeterinario =
                new RepositorioVeterinario(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Despues de agregar los metodos a consola abrir la terminal y escribir esto:
            //C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Consola> dotnet run
            // para que se guaden los cambios en la base de datos

            //AddDueno();
            //AddVeterinario();
            //AddMascota();
            //GetAllDuenos();
            //BuscarMascota(2);
            //listarMascotas();
        }

        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console
                .WriteLine(mascota.Nombre +
                "    " +
                mascota.Raza +
                "   " +
                mascota.Especie +
                "    " +
                mascota.Color);
        }

        private static void listarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota e in mascotas)
            {
                Console
                    .WriteLine(e.Nombre +
                    "    " +
                    e.Raza +
                    "   " +
                    e.Especie +
                    "    " +
                    e.Color);
            }
        }

        private static void AddDueno()
        {
            var dueno =
                new Dueno {
                    //Cedula = "1212",
                    Nombres = "pedro",
                    Apellidos = "Muy Valiente",
                    Direccion = "Bajo un puente",
                    Telefono = "1234567891",
                    Correo = "juansinmiedo@gmail.com"
                };
            _repoDueno.AddDueno (dueno);
        }

        private static void AddMascota()
        {
            var mascota =
                new Mascota {
                    Nombre = "hitachi",
                    Color = "negro",
                    Especie = "perro",
                    Raza = "pitbull"
                };
            _repoMascota.AddMascota (mascota);
        }

        private static void AddVeterinario()
        {
            var veterinario =
                new Veterinario {
                    Nombres = "jorge",
                    Apellidos = "super",
                    Direccion = "en la cima",
                    Telefono = "55555",
                    TarjetaProfesional = "no_tengo"
                };
            _repoVeterinario.AddVeterinario (veterinario);
        }
    }
}
