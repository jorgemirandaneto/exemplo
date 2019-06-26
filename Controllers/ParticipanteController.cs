using System.Collections.Generic;
using System.Linq;
using exemplo.Context;
using exemplo.Models;
using Microsoft.AspNetCore.Mvc;

namespace exemplo.Controllers {
    [Produces ("application/json")]
    [Route ("api/Participantes")]
    public class ParticipanteController : ControllerBase {
        readonly private Contexto contexto;

        public ParticipanteController (Contexto _contexto) {
            this.contexto = _contexto;
        }
        [HttpGet]
        public IEnumerable<Participante> get () { 
            return this.contexto.Participantes.ToList();
        }
    }
}