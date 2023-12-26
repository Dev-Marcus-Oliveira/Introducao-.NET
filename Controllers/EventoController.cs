using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models; 

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    public IEnumerable<Evento> _evento = new Evento[] {
            new Evento(){
                EventoId = 1,
                Tema = "Angular e .NET 6",
                Local = "São Paulo",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
            },
            new Evento(){
                EventoId = 2,
                Tema = "Angular v13 - v15",
                Local = "São Paulo",
                Lote = "2º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto1.png"
            }
        };
    

    public EventoController()
    {
        
    }

    [HttpGet(Name = "GetEvento")]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById( int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost(Name = "PostEvento")]
    public string Post()
    {
        return "exemplo de post";
    }

    [HttpPut("{id}")]
    public string Put( int id)
    {
        return $"exemplo de Put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete( int id)
    {
        return $"exemplo de Delete com id = {id}";
    }

    
}
