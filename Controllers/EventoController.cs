using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models; 
using ProEventos.API.Data;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
   
    private readonly DataContext _context;

    public EventoController(DataContext context)
    {
        _context = context; 
    }

    [HttpGet(Name = "GetEvento")]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;
    }

    [HttpGet("{id}")]
    public Evento GetById( int id)
    {
        return  _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
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
