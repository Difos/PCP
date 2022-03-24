using AutoMapper;
using PCP.Domain.Entities;
using PCP.Infra.Repositories;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PCP.Site.Controllers
{
    public class DisponibilidadeController : Controller
    {
        private readonly DisponibilidadeRepository _disponibilidade = new DisponibilidadeRepository();
        private readonly IMapper _mapper;

        public DisponibilidadeController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // GET: Disponibilidade
        public ActionResult Index()
        {
            var disponbilidade = _mapper.Map<List<TrocasxSurgimentoVigente>>(_disponibilidade.GetAllDf());
            return View(disponbilidade);
        }

        
    }
}