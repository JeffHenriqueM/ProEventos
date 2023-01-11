using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.api.model;

namespace ProEventos.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento (){
                     EventoId = 1,
                    Tema = "Como montar seu treino de peito",
                    Local = "Campo Grande",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImageUrl = "foto.png"
                },   
                 new Evento (){
                     EventoId = 2,
                    Tema = "Como montar seu treino de costa",
                    Local = "Campo Grande",
                    Lote = "2º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(3).ToString(),
                    ImageUrl = "foto1.png"
                }
        };
                
        
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        } 
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
    }
}
