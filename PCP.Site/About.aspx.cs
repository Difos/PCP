using AutoMapper;
using PCP.Domain.Entities;
using PCP.Infra.Repositories;
using PCP.Site.AutoMapper;
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
        private readonly TrocasxSurgimentoVigenteRepository _trocas = new TrocasxSurgimentoVigenteRepository();
        private readonly IMapper _mapper;

        public About()
        {
            _mapper = AutoMapperConfig.Mapper;
        }
        protected void Page_Load(object sender, EventArgs e)
        {


            var trocas = _mapper.Map<List<TrocasxSurgimentoVigente>>(_trocas.GetTrocas());
            StringBuilder t = new StringBuilder();

            t.Append("<table>");
            t.Append("<tr><td>Dia</td><td>Trocas</td><td>Surgimento</td><td>Meta</td><tr>");

            foreach(var item in trocas)
            {
                t.Append(string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><tr>",item.Id,item.Troca,item.Surgimento,item.Meta));
            }

            t.Append("</table>");

            Teste.Text = t.ToString(); 
           
        }


    }

    
 


}