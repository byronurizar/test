using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTelus.Models;
using static System.Net.Mime.MediaTypeNames;

namespace PruebaTelus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Prueba : ControllerBase
    {
        [HttpGet(Name = "all")]
        public IEnumerable<QuoteModel> Get()
        {
            QuoteModel quote = new QuoteModel();
            List<QuoteModel> list = quote.GetList();
            int contador = 1;
            foreach (QuoteModel item in list)
            {
                item.Id= contador;
                contador++;
            }
            return list.ToArray();
        }
        [HttpGet("byid/{id}")]
        public IEnumerable<QuoteModel> GetById(int id)
        {

            QuoteModel quote = new QuoteModel();
            List<QuoteModel> list = quote.GetList();
            int contador = 1;
            foreach (QuoteModel item in list)
            {
                item.Id = contador;
                contador++;
            }

            list = list.FindAll(i=>i.Id==id);
            return list.ToArray();
        }
        [HttpGet("author/{name}")]
        public IEnumerable<QuoteModel> AutorNmae(string name)
        {
            name = name.ToLower().Trim();
            QuoteModel quote = new QuoteModel();
            List<QuoteModel> list = quote.GetList();
            int contador = 1;
            foreach (QuoteModel item in list)
            {
                item.Id = contador;
                contador++;
            }

            list = list.FindAll(i => i.Author!=null && i.Author.ToLower().Trim().Contains(name));
            return list.ToArray();
        }
    }
  
}

