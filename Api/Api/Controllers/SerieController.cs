using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerieController : ControllerBase
    {
        IList<Serie> Lista = new List<Serie>(); 

        public SerieController()
        {
            this.Lista.Add(new Serie() { Id = 1, Genero = "Anime", Nombre = "Naruto", Temporada = 3 ,FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500});
            this.Lista.Add(new Serie() { Id = 2, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 3, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 4, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 5, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 6, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 7, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 8, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 9, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 10, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 11, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 12, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 13, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });

            this.Lista.Add(new Serie() { Id = 14, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 15, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 16, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 17, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 18, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 19, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 20, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
            this.Lista.Add(new Serie() { Id = 21, Genero = "Anime", Nombre = "Naruto", Temporada = 3, FechaPublicacion = "0291029", Director = "el señor de las sopaipillas", Capitulos = 500 });
        }

        [HttpGet]
        public IList<Serie> getDatos()
        {
            return Lista;

        }
    }
}
