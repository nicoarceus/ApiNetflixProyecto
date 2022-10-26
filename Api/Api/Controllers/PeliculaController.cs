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
            this.Lista.Add(new Pelicula() { Id = 2, Genero = "Anime", Nombre = "Kung fu Panda", FechaPublicacion = "0291029", Director = "Jack Black", Duracion = 500 });
            this.Lista.Add(new Pelicula() { Id = 3, Genero = "Anime", Nombre = "Naruto", FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Duracion = 500 });
            this.Lista.Add(new Pelicula() { Id = 4, Genero = "Anime", Nombre = "Naruto", FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Duracion = 500 });
            this.Lista.Add(new Pelicula() { Id = 5, Genero = "Anime", Nombre = "Naruto", FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Duracion = 500 });
            this.Lista.Add(new Pelicula() { Id = 6, Genero = "Anime", Nombre = "Naruto", FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Duracion = 500 });
            this.Lista.Add(new Pelicula() { Id = 7, Genero = "Anime", Nombre = "Naruto", FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Duracion = 500 });
            this.Lista.Add(new Pelicula() { Id = 8, Genero = "Anime", Nombre = "Naruto", FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Duracion = 500 });
            this.Lista.Add(new Pelicula() { Id = 9, Genero = "Anime", Nombre = "Naruto", FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Duracion = 500 });
            this.Lista.Add(new Pelicula() { Id = 10, Genero = "Anime", Nombre = "Naruto", FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Duracion = 500 });
            this.Lista.Add(new Pelicula() { Id = 11, Genero = "Anime", Nombre = "Naruto", FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Duracion = 500 });
            this.Lista.Add(new Pelicula() { Id = 12, Genero = "Anime", Nombre = "Naruto", FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Duracion = 500 });
            this.Lista.Add(new Pelicula() { Id = 13, Genero = "Anime", Nombre = "Naruto", FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Duracion = 500 });
            this.Lista.Add(new Pelicula() { Id = 14, Genero = "Anime", Nombre = "Naruto", FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Duracion = 500 });

        }

        [HttpGet]
        public IList<Pelicula> getDatos()
        {
            return Lista;

        }
    }
}
