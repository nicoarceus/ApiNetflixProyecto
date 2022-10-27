using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        IList<Pelicula> Lista = new List<Pelicula>();

        public PeliculaController()
        {
            this.Lista.Add(new Pelicula() { Id = 1, Genero = "Anime", Nombre = "Naruto",  FechaPublicacion = "0291029", Director = "el señor de las sopaipillas",Duracion = 150 });
            this.Lista.Add(new Pelicula() { Id = 2, Genero = "Animada/infantil", Nombre = "Kung fu Panda", FechaPublicacion = "0291029", Director = "Jack Black", Duracion = 90 });
            this.Lista.Add(new Pelicula() { Id = 3, Genero = "Deportes/drama", Nombre = "Juego de honor", FechaPublicacion = "12/07/2005", Director = "Thomas Carter", Duracion = 136 });
            this.Lista.Add(new Pelicula() { Id = 4, Genero = "Comedia", Nombre = "Ted 2", FechaPublicacion = "12/07/2015", Director = "Seth MacFarlane", Duracion = 115 });
            this.Lista.Add(new Pelicula() { Id = 5, Genero = "Anime", Nombre = "Naruto", FechaPublicacion = "0291029", Director = "Sasuke kun", Duracion = 95 });
            this.Lista.Add(new Pelicula() { Id = 6, Genero = "Anime", Nombre = "Naruto", FechaPublicacion = "0291029", Director = "Sasuke kun", Duracion = 91 });
            this.Lista.Add(new Pelicula() { Id = 7, Genero = "Terror", Nombre = "Alien 2", FechaPublicacion = "12/04/2003", Director = "James Cameron", Duracion = 95 });
            this.Lista.Add(new Pelicula() { Id = 8, Genero = "Terror", Nombre = "Alien 2", FechaPublicacion = "12/04/2003", Director = "James Cameron", Duracion = 95 });
            this.Lista.Add(new Pelicula() { Id = 9, Genero = "Terror", Nombre = "Alien 2", FechaPublicacion = "12/04/2003", Director = "James Cameron", Duracion = 95 });
            this.Lista.Add(new Pelicula() { Id = 10, Genero = "Anime", Nombre = "Mi vecino totoro", FechaPublicacion = "2004", Director = "Studio Gibli", Duracion = 90 });
            this.Lista.Add(new Pelicula() { Id = 11, Genero = "Anime", Nombre = "Mi vecino totoro", FechaPublicacion = "2004", Director = "Studio Gibli", Duracion = 90 });
            this.Lista.Add(new Pelicula() { Id = 12, Genero = "Anime", Nombre = "La princesa Mononoke", FechaPublicacion = "2004", Director = "Studio Gibli", Duracion = 97 });
            this.Lista.Add(new Pelicula() { Id = 13, Genero = "Anime", Nombre = "La princesa Mononoke", FechaPublicacion = "2004", Director = "Studio Gibli", Duracion = 97 });
            this.Lista.Add(new Pelicula() { Id = 14, Genero = "Anime", Nombre = "La princesa Mononoke", FechaPublicacion = "2004", Director = "Studio Gibli", Duracion = 97 });

        }

        [HttpGet]
        public IList<Pelicula> getDatos()
        {
            return Lista;

        }
    }
}
