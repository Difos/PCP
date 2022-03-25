using AutoMapper;
using PCP.Domain.Entities;
using PCP.Infra.Helpers;
using PCP.Infra.Repositories;
using PCP.Site.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PCP.Site
{
    public partial class DashRodeiros : System.Web.UI.Page
    {
        public string tab1;
        public string tab2;
        public string tab3;
        public string tab4;
        public string tab5;
        public string tab6;

        public string data;

        HighChartRepository _chart = new HighChartRepository();
        DisponibilidadeRepository _disp = new DisponibilidadeRepository();
        TrocasxSurgimentoVigenteRepository _trocas = new TrocasxSurgimentoVigenteRepository();
        Html _html = new Html();
        

        IMapper _mapper;

        public DashRodeiros()
        {
            _mapper = AutoMapperConfig.Mapper;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //loadChartDf();
            loadTrocasxSurgimento();
            loadTrocasTurno();
            
        }

        public void loadTrocasxSurgimento()
        {
            var idf = _mapper.Map<List<TrocasxSurgimentoVigente>>(_trocas.GetTrocas());
            int count = 0;

            Object[] chartValues = new Object[31];
            Object[] chartValues2 = new Object[31];
            Object[] chartValues3 = new Object[31];

            string[] x = new string[31];

            foreach (var obj in idf)
            {
                x[count] = string.Format("{0}", obj.Id);
                chartValues[count] = string.Format("{0}", obj.Troca);
                chartValues3[count] = string.Format("{0}", obj.Surgimento);
                chartValues2[count] = string.Format("{0}", obj.Meta);

                count++;

            }

            Literal1.Text = _chart.HighChartLineDual(x, chartValues, chartValues2, chartValues3, "Troca", "Meta", "Surgimento","Surgimento","Troca de rodeiros x Surgimento de Alarmes");
        }

        public void loadTrocasTurno()
        {
            var idf = _mapper.Map<List<TrocaRodeirosTurno>>(_trocas.GetTrocasTurno());
            int count = 0;

            Object[] chartValues = new Object[idf.Count];
            Object[] chartValues2 = new Object[idf.Count];
            Object[] chartValues3 = new Object[idf.Count];
            Object[] chartValues4 = new Object[idf.Count];

            string[] x = new string[idf.Count];

            foreach (var obj in idf)
            {
                x[count] = string.Format("{0}", obj.Data).Substring(0,2);
                chartValues[count] = string.Format("{0}", obj.A);
                chartValues3[count] = string.Format("{0}", obj.B);
                chartValues2[count] = string.Format("{0}", obj.C);
                chartValues4[count] = string.Format("{0}", obj.D);

                count++;

            }

            Literal2.Text = _chart.StackedGroupBar(chartValues, chartValues2, chartValues3, chartValues4, x, 600, 300, "Trocas por Turno", "fontSize: '9px', fontFamily: 'Times New Roman'", "A", "B", "C", "D","fontSize: '9px', fontFamily: 'Times New Roman'", "function (){   }", "TrocasTurno", -30, 1, System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.DarkSeaGreen, System.Drawing.Color.MediumOrchid, "");
        }
        public void loadChartDf()
        {
            var idf = _mapper.Map<List<indisponibilidadectr>>(_disp.GetAllDf());
            int count = 0; 

            Object[] chartValues = new Object[32];
            Object[] chartValues2 = new Object[32];
            Object[] chartValues3 = new Object[32];

            string[] x = new string[32];

            foreach (var obj in idf)
            {
                x[count] = string.Format("{0}", obj.Id);
                chartValues[count] = string.Format("{0}", obj.Idf);
                chartValues2[count] = string.Format("{0}", obj.Meta);
                chartValues3[count] = string.Format("{0}", obj.Acum);

                count++;

            }

            Idf.Text = _chart.HighChartLineDual(x, chartValues, chartValues2, chartValues3, "df", "meta", "idf","Acumulado", "Indisponibilidade (%) de Vagões no CTR Mês");
        }

        public void loadTrocasDetails(string data)
        {
            var result = _mapper.Map<List<ResultAllTrocas>>(_trocas.GetTrocasDetail(data));
           
            TrocaTurno.Text = _html.HtmlDados(result.ConvertToDataSet("Dados"), @"<table class='bordered striped centered highlight responsive-table'><tr>
            <td class='teal lighten-2'>Linha</td>
            <td class='teal lighten-2'>00h</td>
            <td class='teal lighten-2'>01h</td>
            <td class='teal lighten-2'>02h</td>
            <td class='teal lighten-2'>03h</td>
            <td class='teal lighten-2'>04h</td>
            <td class='teal lighten-2'>05h</td>
            <td class='teal lighten-2'>06h</td>
            <td class='teal lighten-2'>07h</td>
            <td class='teal lighten-2'>08h</td>
            <td class='teal lighten-2'>09h</td>
            <td class='teal lighten-2'>10h</td>
            <td class='teal lighten-2'>11h</td>
            <td class='teal lighten-2'>12h</td>
            <td class='teal lighten-2'>13h</td>
            <td class='teal lighten-2'>14h</td>
            <td class='teal lighten-2'>15h</td>
            <td class='teal lighten-2'>16h</td>
            <td class='teal lighten-2'>17h</td>
            <td class='teal lighten-2'>18h</td>
            <td class='teal lighten-2'>19h</td>
            <td class='teal lighten-2'>20h</td>
            <td class='teal lighten-2'>21h</td>
            <td class='teal lighten-2'>22h</td>
            <td class='teal lighten-2'>23h</td>
            <td class='teal lighten-2'>Total</td></tr>", 2);

        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {

            loadTrocasDetails(Request["calendar"]);
        }
    }
}