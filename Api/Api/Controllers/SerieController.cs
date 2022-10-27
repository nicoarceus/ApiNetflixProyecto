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
            this.Lista.Add(new Serie() { Id = 2, Genero = "Reality", Nombre = "El topo", Temporada = 1, FechaPublicacion = "10/10/2022", Director = "el señor de las sopaipillas", Capitulos = 10 });
            this.Lista.Add(new Serie() { Id = 3, Genero = "Reality", Nombre = "El topo", Temporada = 1, FechaPublicacion = "10/10/2022", Director = "el señor de las sopaipillas", Capitulos = 10 });
            this.Lista.Add(new Serie() { Id = 4, Genero = "Infatil", Nombre = "Gravity Falls", Temporada = 3, FechaPublicacion = "10/10/2015", Director = "La araña de rincón", Capitulos = 36 });
            this.Lista.Add(new Serie() { Id = 5, Genero = "Infatil", Nombre = "Gravity Falls", Temporada = 3, FechaPublicacion = "10/10/2015", Director = "La araña de rincón", Capitulos = 36 });
            this.Lista.Add(new Serie() { Id = 6, Genero = "Infatil", Nombre = "Gravity Falls", Temporada = 3, FechaPublicacion = "10/10/2015", Director = "La araña de rincón", Capitulos = 36 });
            this.Lista.Add(new Serie() { Id = 7, Genero = "Drama", Nombre = "The Walking Dead", Temporada = 10, FechaPublicacion = "10/10/2012", Director = "George Romero", Capitulos = 120 });
            this.Lista.Add(new Serie() { Id = 8, Genero = "Drama", Nombre = "The Walking Dead", Temporada = 10, FechaPublicacion = "10/10/2012", Director = "George Romero", Capitulos = 120 });
            this.Lista.Add(new Serie() { Id = 9, Genero = "Drama", Nombre = "The Walking Dead", Temporada = 10, FechaPublicacion = "10/10/2012", Director = "George Romero", Capitulos = 120 });
            this.Lista.Add(new Serie() { Id = 10, Genero = "K-Drama", Nombre = "Tribunal de menores", Temporada = 1, FechaPublicacion = "10/06/2022", Director = "Algun koreano famoso", Capitulos = 10 });
            this.Lista.Add(new Serie() { Id = 11, Genero = "K-Drama", Nombre = "Tribunal de menores", Temporada = 1, FechaPublicacion = "10/06/2022", Director = "Algun koreano famoso", Capitulos = 10 });
            this.Lista.Add(new Serie() { Id = 12, Genero = "K-Drama", Nombre = "Tribunal de menores", Temporada = 1, FechaPublicacion = "10/06/2022", Director = "Algun koreano famoso", Capitulos = 10 });
            this.Lista.Add(new Serie() { Id = 13, Genero = "K-Drama", Nombre = "Facultad de derecho", Temporada = 1, FechaPublicacion = "10/06/2021", Director = "Algun koreano nashee", Capitulos = 16 });
            this.Lista.Add(new Serie() { Id = 14, Genero = "K-Drama", Nombre = "Facultad de derecho", Temporada = 1, FechaPublicacion = "10/06/2021", Director = "Algun koreano nashee", Capitulos = 16 });
            this.Lista.Add(new Serie() { Id = 15, Genero = "K-Drama", Nombre = "Facultad de derecho", Temporada = 1, FechaPublicacion = "10/06/2021", Director = "Algun koreano nashee", Capitulos = 16 });
            this.Lista.Add(new Serie() { Id = 16, Genero = "Anime", Nombre = "Pokemon", Temporada = 16, FechaPublicacion = "13/07/2000", Director = "los señores de las pizzas", Capitulos = 1500 });
            this.Lista.Add(new Serie() { Id = 17, Genero = "Anime", Nombre = "Pokemon", Temporada = 16, FechaPublicacion = "13/07/2000", Director = "los señores de las pizzas", Capitulos = 1500 });
            this.Lista.Add(new Serie() { Id = 18, Genero = "Anime", Nombre = "Pokemon", Temporada = 16, FechaPublicacion = "13/07/2000", Director = "los señores de las pizzas", Capitulos = 1500 });
            this.Lista.Add(new Serie() { Id = 19, Genero = "Anime", Nombre = "One piece", Temporada = 20, FechaPublicacion = "13/07/1999", Director = "Miyazaki", Capitulos = 1030 });
            this.Lista.Add(new Serie() { Id = 20, Genero = "Anime", Nombre = "One piece", Temporada = 20, FechaPublicacion = "13/07/1999", Director = "Miyazaki", Capitulos = 1030 });
            this.Lista.Add(new Serie() { Id = 21, Genero = "Anime", Nombre = "One piece", Temporada = 20, FechaPublicacion = "13/07/1999", Director = "Miyazaki", Capitulos = 1030 });
        }

        [HttpGet]
        public IList<Serie> getDatos()
        {
            return Lista;

        }
        

      
    }
}
