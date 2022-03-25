using AutoMapper;
using PCP.Domain.Entities;
using PCP.Infra.Repositories;
using PCP.Site.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PCP.Site
{
    public partial class About : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

         
            //Trocas t = new Trocas();

            //t.teste();



            //var disponbilidade = Mapper.Map<IEnumerable<Disponibilidade_FisicaDto>>(_disponibilidade.dados());
        }
    }

    public class Trocas
    {
        private readonly TrocasxSurgimentoVigenteRepository _trocas = new TrocasxSurgimentoVigenteRepository();
        private readonly IMapper _mapper;
        public Trocas(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void teste()
        {
            //var config1 = new MapperConfiguration(cfg =>
            //   cfg.CreateMap<Disponibilidade_Fisica, Disponibilidade_FisicaDto>());

            //var config2 = new MapperConfiguration(cfg =>
            //   cfg.CreateMap<TrocasxSurgimentoVigente, TrocasxSurgimentoVigenteDto>());

            //var mapper = config2.CreateMapper();

            var disp = _mapper.Map<List<TrocasxSurgimentoVigente>>(_trocas.GetTrocas());
            GridView GridView1 = new GridView();

            GridView1.DataSource = disp;

            foreach (var linha in disp)
            {
                var x = linha.Troca;
            }
        }
    }


}