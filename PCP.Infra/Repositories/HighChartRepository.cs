using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCP.Infra.Repositories
{
    public class HighChartRepository
    {
        public string StackedGroupBar(Object[] ChartValues, Object[] ChartValues1, Object[] ChartValues2, Object[] ChartValues3,string[] Categories, int ChartWidth, int ChartHeight, string TitleText, string TitleStyle, string SeriesName, string SeriesName1, string SeriesName2, string SeriesName3, string SeriesStyle, string Script, string ChartName, Number Rotation, int op, Color Cor1, Color Cor2,Color Cor3, Color Cor4, string resp)
        {

            //    Drilldown d = new Drilldown();

            Series Series1 = new Series
            {

                Name = SeriesName,
                Data = new DotNet.Highcharts.Helpers.Data
                (new object[] { ChartValues })
            };
            DotNet.Highcharts.Highcharts Chart = new DotNet.Highcharts.Highcharts(ChartName)
        .InitChart(new Chart
        {
            Width = ChartWidth,
            Height = ChartHeight,
            DefaultSeriesType = ChartTypes.Column


        })
        .SetTitle(new Title
        {

            Text = resp,
            Style = "fontSize: '12px', fontFamily: 'Times New Roman'"

        })

        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetTitle(new Title
        {

            Text = TitleText,
            Style = @"fontSize: '11px', fontFamily: 'Times New Roman'"

        })
        .SetYAxis(new YAxis
        {//mostra a soma do total acima das colunas 
            StackLabels = new YAxisStackLabels
            {
                Enabled = true,
                Style = @"fontSize: '9px', fontFamily: 'Times New Roman'"

            },
            //Max = 60, Min=0,Categories = Categories, Opposite = true 
        })
        .SetXAxis(new XAxis
        {
            Categories = Categories,
            Labels = new XAxisLabels { Rotation = Rotation, Style = SeriesStyle },
            GridLineWidth = 0

        })
        .SetSeries(new[]
        {
            new Series { Name = SeriesName, Data = new DotNet.Highcharts.Helpers.Data(ChartValues) , PlotOptionsBar = new PlotOptionsBar
                {
                   DataLabels = new PlotOptionsBarDataLabels
                   {

                       Enabled = true,
                       Rotation = 0,
                       Style = SeriesStyle
                   }, Color = Cor1

                },
                PlotOptionsSeries = new PlotOptionsSeries
                {
                    Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = Script  } },
                },
            },

            new Series { Name = SeriesName1, Data = new DotNet.Highcharts.Helpers.Data(ChartValues2)  , PlotOptionsBar = new PlotOptionsBar
                {
                   DataLabels = new PlotOptionsBarDataLabels
                   {
                       Enabled = true,
                        Rotation = 0,
                       Style = SeriesStyle

                   }, Color = Cor2
                },
                PlotOptionsSeries = new PlotOptionsSeries
                {
                    Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = Script  } },
                }
            } ,

            new Series { Name = SeriesName2, Data = new DotNet.Highcharts.Helpers.Data(ChartValues1)  , PlotOptionsBar = new PlotOptionsBar
                {
                   DataLabels = new PlotOptionsBarDataLabels
                   {
                       Enabled = true,
                       Rotation = 0,
                       Style = SeriesStyle

                   }, Color = Cor3
                },
                PlotOptionsSeries = new PlotOptionsSeries
                {
                    Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = Script  } },
                }
            } ,
            new Series { Name = SeriesName3, Data = new DotNet.Highcharts.Helpers.Data(ChartValues3)  , PlotOptionsBar = new PlotOptionsBar
                {
                   DataLabels = new PlotOptionsBarDataLabels
                   {
                       Enabled = true,
                       Rotation = 0,
                       Style = SeriesStyle

                   }, Color = Cor4
                },
                PlotOptionsSeries = new PlotOptionsSeries
                {
                    Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = Script  } },
                }
            } 
            //new Series { Type = ChartTypes.Line, Name = "Total", Data = new DotNet.Highcharts.Helpers.Data(ChartValues)  , PlotOptionsBar = new PlotOptionsBar
            //    {
            //       DataLabels = new PlotOptionsBarDataLabels
            //       {
            //           Enabled = true,
            //            Rotation = 0,
            //           Style = SeriesStyle,

            //       } ,
            //    Color = Cor2
            //    }
            //,
            //    PlotOptionsSeries = new PlotOptionsSeries
            //    {
            //        Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = Script  } },
            //    }
            //}
        })
        .SetPlotOptions(new PlotOptions
        {
            Column = new PlotOptionsColumn
            {
                Stacking = DotNet.Highcharts.Enums.Stackings.Normal,
                GroupPadding = 0.10
            }

         


        });
           

            return Chart.ToHtmlString();
        }

        public string StackedGroupBarOneSerie(Object[] ChartValues, Object[] ChartValues1, Object[] ChartValues2, string[] Categories, int ChartWidth, int ChartHeight, string TitleText, string TitleStyle, string SeriesName, string SeriesName1, string SeriesName2, string SeriesStyle, string Script, string ChartName, Number Rotation, int op, Color Cor1, Color Cor2, string resp)
        {

            Drilldown d = new Drilldown();

            Series Series1 = new Series
            {

                Name = SeriesName,
                Data = new DotNet.Highcharts.Helpers.Data
                (new object[] { ChartValues })
            };
            DotNet.Highcharts.Highcharts Chart = new DotNet.Highcharts.Highcharts(ChartName)
        .InitChart(new Chart
        {
            Width = ChartWidth,
            Height = ChartHeight,
            DefaultSeriesType = ChartTypes.Column


        })
        .SetTitle(new Title
        {

            Text = resp,
            Style = "fontSize: '12px', fontFamily: 'Times New Roman'"

        })
        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetTitle(new Title
        {

            Text = TitleText,
            Style = @"fontSize: '11px', fontFamily: 'Times New Roman'"

        })
        .SetYAxis(new YAxis
        {//mostra a soma do total acima das colunas 
            StackLabels = new YAxisStackLabels
            {
                Enabled = true,
                Style = @"fontSize: '9px', fontFamily: 'Times New Roman'"

            },
            //Max = 60, Min=0,Categories = Categories, Opposite = true 
        })
        .SetXAxis(new XAxis
        {
            Categories = Categories,
            Labels = new XAxisLabels { Rotation = Rotation, Style = SeriesStyle },
            GridLineWidth = 0

        })
        .SetSeries(new[]
        {
            new Series { Name = SeriesName, Data = new DotNet.Highcharts.Helpers.Data(ChartValues) , PlotOptionsBar = new PlotOptionsBar
                {
                   DataLabels = new PlotOptionsBarDataLabels
                   {

                       Enabled = true,
                       Rotation = 0,
                       Style = SeriesStyle
                   }, Color = Cor1

                },
                PlotOptionsSeries = new PlotOptionsSeries
                {
                    Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = Script  } },
                },
            },


        })
        .SetPlotOptions(new PlotOptions
        {
            Column = new PlotOptionsColumn
            {
                Stacking = DotNet.Highcharts.Enums.Stackings.Normal,
                GroupPadding = 0.10

            }

            //Bar = new PlotOptionsBar
            //{

            //}


        });
            //.SetTooltip(new Tooltip
            //{
            //    PointFormat = "{series.name}: <b>{point.y:.1f}",
            //    Animation = new Animation(true)
            //}
            //);

            return Chart.ToHtmlString();
        }

        public string HighChartBasicBarChart(Object[] chartValues, Object[] chartValues1, Object[] chartValues2, string[] categories, string titulo, string resp)
        {
            Series t1 = new Series
            {
                Name = resp,
                Data = new DotNet.Highcharts.Helpers.Data
                (new object[] { chartValues })
            };
            DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts(titulo)
        .InitChart(new Chart
        {
            Width = 600,
            Height = 400,
            DefaultSeriesType = DotNet.Highcharts.Enums.ChartTypes.Column
            // Style = "margin: '2 auto'"

        })
        .SetTitle(new Title
        {

            Text = resp,
            Style = "fontSize: '12px', fontFamily: 'Times New Roman'"

        })
         .SetCredits(new Credits
         {
             Enabled = false
         })
        .SetTitle(new Title
        {

            Text = resp,
            Style = "fontSize: '14px', fontFamily: 'Times New Roman'"

        })
        .SetXAxis(new XAxis
        {

            Categories = categories,
            Labels = new XAxisLabels { Rotation = -30 },
            GridLineWidth = 0
            // Title = new XAxisTitle { Text = "Perdas CTR" }

        })
        .SetYAxis(new YAxis
        {

            Min = 0,
            //Categories = chartValues,
            Title = new YAxisTitle { Text = "Ordens" },
            GridLineWidth = 0
        })
        .SetTooltip(new Tooltip
        {
            //PointFormat = "{series.name}: <b>{point.y:.1f}",
            Animation = new Animation(true)
        })
        .SetSeries(new[]
        {

            new  Series {  Name = "Ordens", Data = new DotNet.Highcharts.Helpers.Data(chartValues) , PlotOptionsSeries = new PlotOptionsSeries
                {
              //  Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function () {alert('Category: ' + this.category.substring(0,4) + ', value: ' + this.y + ' ' + this.series.name);}"  } },
              Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function (){  window.open('perdaDetalhe.aspx?p='+this.category.substring(0,4)+this.series.name, 'teste', 'scrollbars=1,height=750,width=1200');  }"  } },
                DataLabels = new PlotOptionsSeriesDataLabels
                   {

                       Enabled = true,
                       Style ="fontSize: '10px', fontFamily: 'Times New Roman', color: 'Black'",
                       Rotation =0

                   },
                }},
        });

            return chart.ToHtmlString();
        }

        public string HighChartBasicBarChartMultiSeries(Object[] chartValues, Object[] chartValues1, Object[] chartValues2, Object[] chartValues3, Object[] chartValues4, Object[] chartValues5, Object[] chartValues6, string[] categories, string titulo, string resp)
        {
            Series t1 = new Series
            {
                Name = "lotes",
                Data = new DotNet.Highcharts.Helpers.Data
                (new object[] { chartValues })
            };
            DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts(titulo)
        .InitChart(new Chart
        {
            Width = 720,
            Height = 600,
            DefaultSeriesType = DotNet.Highcharts.Enums.ChartTypes.Column
            // Style = "margin: '2 auto'"

        })
        .SetTitle(new Title
        {

            Text = resp,
            Style = "fontSize: '12px', fontFamily: 'Times New Roman'"

        })
         .SetCredits(new Credits
         {
             Enabled = false
         })
        .SetTitle(new Title
        {

            Text = "Qtd de ordens por ano",
            Style = "fontSize: '12px', fontFamily: 'Times New Roman'"

        })
        .SetYAxis(new YAxis
        {
            Title = new YAxisTitle { Text = "Total de ordens abertas por ano" },
            StackLabels = new YAxisStackLabels { Enabled = true, Style = @"fontWeight: 'bold', color: 'black'" }
        })
        .SetXAxis(new XAxis
        {

            Categories = categories,
            Labels = new XAxisLabels { Rotation = -30 },
            GridLineWidth = 0,
            Title = new XAxisTitle { Text = "" }

        })
        .SetYAxis(new YAxis
        {
            Title = new YAxisTitle { Text = "" },
            StackLabels = new YAxisStackLabels { Enabled = true, Style = @"fontWeight: 'bold', color: 'black'" }
        })
        .SetTooltip(new Tooltip
        {
            //PointFormat = "{series.name}: <b>{point.y:.1f}",
            Animation = new Animation(true)
        })
        .SetSeries(new[]
        {

            new  Series {  Name = "2014", Data = new DotNet.Highcharts.Helpers.Data(chartValues) , PlotOptionsSeries = new PlotOptionsSeries
                {
              //  Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function () {alert('Category: ' + this.category.substring(0,4) + ', value: ' + this.y + ' ' + this.series.name);}"  } },
              Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function (){  window.open('perdaDetalhe.aspx?p='+this.category.substring(0,4)+this.series.name, 'teste', 'scrollbars=1,height=750,width=1200');  }"  } },
                DataLabels = new PlotOptionsSeriesDataLabels
                   {

                       Enabled = true,
                       Style ="fontSize: '10px', fontFamily: 'Times New Roman', color: 'Black'",
                       Rotation =0

                   },
                }},
             new  Series {  Name = "2015", Data = new DotNet.Highcharts.Helpers.Data(chartValues1) , PlotOptionsSeries = new PlotOptionsSeries
                {
              //  Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function () {alert('Category: ' + this.category.substring(0,4) + ', value: ' + this.y + ' ' + this.series.name);}"  } },
              Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function (){  window.open('perdaDetalhe.aspx?p='+this.category.substring(0,4)+this.series.name, 'teste', 'scrollbars=1,height=750,width=1200');  }"  } },
                DataLabels = new PlotOptionsSeriesDataLabels
                   {

                       Enabled = true,
                       Style ="fontSize: '10px', fontFamily: 'Times New Roman', color: 'Black'",
                       Rotation =0

                   },
                }},
              new  Series {  Name = "2016", Data = new DotNet.Highcharts.Helpers.Data(chartValues2) , PlotOptionsSeries = new PlotOptionsSeries
                {
              //  Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function () {alert('Category: ' + this.category.substring(0,4) + ', value: ' + this.y + ' ' + this.series.name);}"  } },
              Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function (){  window.open('perdaDetalhe.aspx?p='+this.category.substring(0,4)+this.series.name, 'teste', 'scrollbars=1,height=750,width=1200');  }"  } },
                DataLabels = new PlotOptionsSeriesDataLabels
                   {

                       Enabled = true,
                       Style ="fontSize: '10px', fontFamily: 'Times New Roman', color: 'Black'",
                       Rotation =0

                   },
                }},
               new  Series {  Name = "2017", Data = new DotNet.Highcharts.Helpers.Data(chartValues3) , PlotOptionsSeries = new PlotOptionsSeries
                {
              //  Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function () {alert('Category: ' + this.category.substring(0,4) + ', value: ' + this.y + ' ' + this.series.name);}"  } },
              Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function (){  window.open('perdaDetalhe.aspx?p='+this.category.substring(0,4)+this.series.name, 'teste', 'scrollbars=1,height=750,width=1200');  }"  } },
                DataLabels = new PlotOptionsSeriesDataLabels
                   {

                       Enabled = true,
                       Style ="fontSize: '10px', fontFamily: 'Times New Roman', color: 'Black'",
                       Rotation =0

                   },
                }},
                new  Series {  Name = "2018", Data = new DotNet.Highcharts.Helpers.Data(chartValues4) , PlotOptionsSeries = new PlotOptionsSeries
                {
              //  Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function () {alert('Category: ' + this.category.substring(0,4) + ', value: ' + this.y + ' ' + this.series.name);}"  } },
              Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function (){  window.open('perdaDetalhe.aspx?p='+this.category.substring(0,4)+this.series.name, 'teste', 'scrollbars=1,height=750,width=1200');  }"  } },
                DataLabels = new PlotOptionsSeriesDataLabels
                   {

                       Enabled = true,
                       Style ="fontSize: '10px', fontFamily: 'Times New Roman', color: 'Black'",
                       Rotation =0

                   },
                }},
                 new  Series {  Name = "2019", Data = new DotNet.Highcharts.Helpers.Data(chartValues5) , PlotOptionsSeries = new PlotOptionsSeries
                {
              //  Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function () {alert('Category: ' + this.category.substring(0,4) + ', value: ' + this.y + ' ' + this.series.name);}"  } },
              Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function (){  window.open('perdaDetalhe.aspx?p='+this.category.substring(0,4)+this.series.name, 'teste', 'scrollbars=1,height=750,width=1200');  }"  } },
                DataLabels = new PlotOptionsSeriesDataLabels
                   {

                       Enabled = true,
                       Style ="fontSize: '10px', fontFamily: 'Times New Roman', color: 'Black'",
                       Rotation =0

                   },
                }}
        })
        .SetPlotOptions(new PlotOptions
        {
            Column = new PlotOptionsColumn
            {
                Stacking = DotNet.Highcharts.Enums.Stackings.Normal,
                GroupPadding = 0.10

            }

            //Bar = new PlotOptionsBar
            //{

            //}


        });

            return chart.ToHtmlString();
        }

        public string HighChartDualAxis(Object[] chartValues, Object[] chartValues1, Object[] chartValues2, Object[] chartValues3, string[] categories, string titulo, int min, int max, string resp)
        {
            Series t1 = new Series
            {
                Name = "lotes",
                Data = new DotNet.Highcharts.Helpers.Data
                (new object[] { chartValues })
            };
            DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts(titulo)
        .InitChart(new Chart
        {
            Width = 450,
            Height = 350,
            DefaultSeriesType = DotNet.Highcharts.Enums.ChartTypes.Column
            // Style = "margin: '2 auto'"

        })
        .SetTitle(new Title
        {

            Text = resp,
            Style = "fontSize: '12px', fontFamily: 'Times New Roman'"

        })
         .SetCredits(new Credits
         {
             Enabled = false
         })
        .SetTitle(new Title
        {

            Text = resp,
            Style = "fontSize: '14px', fontFamily: 'Times New Roman'"

        })
        .SetXAxis(new XAxis
        {

            Categories = categories,
            Labels = new XAxisLabels { Rotation = -30 },
            GridLineWidth = 0
            // Title = new XAxisTitle { Text = "Perdas CTR" }

        })
        .SetYAxis(new[]  {
                new YAxis
                {
                    Min= 1,
                    Max=1600,
                    GridLineColor = Color.White,
                    TickInterval=10,
                    Labels = new YAxisLabels
                    {
                        Formatter = "function() { return this.value; }",
                        Style = "color: '#89A54E'"
                    },
                    Title = new YAxisTitle
                    {
                        Text = "Dias",
                       // Style = "color: '#89A54E'"
                    }
                },new YAxis
                {
                    Min= min,
                    Max=max,
                    GridLineColor = Color.White,
                    TickInterval= max > 3000 ? 20 : 5,
                    Labels = new YAxisLabels
                    {
                        Formatter = "function() { return this.value; }",
                        Style = "color: '#4572A7'"
                    },
                    Title = new YAxisTitle
                    {
                        Text = "Qtd Ordens",
                      //  Style = "color: '#4572A7'"
                    },
                    Opposite = true
                }})
        .SetTooltip(new Tooltip
        {
            //PointFormat = "{series.name}: <b>{point.y:.1f}",
            Animation = new Animation(true)
        })
        .SetSeries(new[]
        {

            new  Series {  Name = "Media de Dias", Data = new DotNet.Highcharts.Helpers.Data(chartValues) , PlotOptionsSeries = new PlotOptionsSeries
                {
              //  Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function () {alert('Category: ' + this.category.substring(0,4) + ', value: ' + this.y + ' ' + this.series.name);}"  } },
              Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function (){  window.open('perdaDetalhe.aspx?p='+this.category.substring(0,4)+this.series.name, 'teste', 'scrollbars=1,height=750,width=1200');  }"  } },
                DataLabels = new PlotOptionsSeriesDataLabels
                   {

                       Enabled = true,
                       Style ="fontSize: '10px', fontFamily: 'Times New Roman', color: 'Black'",
                       Rotation =0

                   },
                }},
            new  Series { Type = ChartTypes.Line, Name = "Meta", Data = new DotNet.Highcharts.Helpers.Data(chartValues3) , PlotOptionsSeries = new PlotOptionsSeries
                {
              //  Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function () {alert('Category: ' + this.category.substring(0,4) + ', value: ' + this.y + ' ' + this.series.name);}"  } },
              Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function (){  window.open('perdaDetalhe.aspx?p='+this.category.substring(0,4)+this.series.name, 'teste', 'scrollbars=1,height=750,width=1200');  }"  } },
                DataLabels = new PlotOptionsSeriesDataLabels
                   {

                       Enabled = true,
                       Style ="fontSize: '10px', fontFamily: 'Times New Roman', color: 'black'",
                       Rotation =0

                   },
                }},
            new  Series { YAxis="1" , Type= ChartTypes.Line, Name = "Qtd Ordens", Data = new DotNet.Highcharts.Helpers.Data(chartValues2) , PlotOptionsSeries = new PlotOptionsSeries
                { 
              //  Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function () {alert('Category: ' + this.category.substring(0,4) + ', value: ' + this.y + ' ' + this.series.name);}"  } },
              Point = new PlotOptionsSeriesPoint { Events = new PlotOptionsSeriesPointEvents { Click = "function (){  window.open('perdaDetalhe.aspx?p='+this.category.substring(0,4)+this.series.name, 'teste', 'scrollbars=1,height=750,width=1200');  }"  } },
                DataLabels = new PlotOptionsSeriesDataLabels
                   {

                       Enabled = true,
                       Style ="fontSize: '10px', fontFamily: 'Times New Roman', color: 'Black'",
                       Rotation =0

                   },
                }},
        });

            return chart.ToHtmlString();
        }

        public string HighChartPie(string[,] chartValues, Object[] chartValues1, Object[] chartValues2, string[] categories, string titulo, string resp)
        {
            DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts(titulo)
      .InitChart(new Chart
      {
          Width = 450,
          Height = 300,
          DefaultSeriesType = DotNet.Highcharts.Enums.ChartTypes.Pie,
          Animation = new Animation(true)

      })
      .SetCredits(new Credits
      {
          Enabled = false
      })
      .SetTitle(new Title
      {

          Text = resp,
          Style = "fontSize: '14px', fontFamily: 'Times New Roman'"

      })
      .SetTooltip(new Tooltip
      {
          Enabled = true,
          Formatter = @"function() { return '<b>'+ this.series.name +'</b><br/>'+ this.x +': '+ this.y; }"
      })
      .SetPlotOptions(new PlotOptions
      {
          Pie = new PlotOptionsPie
          {
              SlicedOffset = 0,
              DataLabels = new PlotOptionsPieDataLabels { Enabled = true },
              Animation = new Animation(true),
          },

      })

      .SetSeries(new[]
      {
            new  Series { Name="", Data = new DotNet.Highcharts.Helpers.Data(chartValues) , PlotOptionsPie = new PlotOptionsPie
                {
                DataLabels = new PlotOptionsPieDataLabels
                   {
                       Enabled = true,
                       Style ="fontSize: '10px', fontFamily: 'Times New Roman', color: 'Black'",


                   },
                }},
      });


            return chart.ToHtmlString();
        }

        public string HighChartLineDual(string[] categories, Object[] chartValues, Object[] chartValues2, Object[] chartValues3, string serie1, string serie2,string serie3,string chartname, string title)
        {
           

            Series t1 = new Series
            {
                Name = serie1,
                Data = new DotNet.Highcharts.Helpers.Data
                (new object[] { chartValues })
            };

            Series t2 = new Series
            {
                Name = serie2,
                Data = new DotNet.Highcharts.Helpers.Data
                (new object[] { chartValues2 })
            };




            DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts(chartname)
        .InitChart(new Chart
        {
            Width = 600,
            Height = 300
           
        })
        .SetTitle(new Title
        {

            Text = title,

        })
        .SetXAxis(new XAxis
        {

            Categories = categories,
            Labels = new XAxisLabels { Rotation = -30 },
            GridLineWidth = 0
        })
        .SetYAxis(new YAxis
        {
            Title = new YAxisTitle { Text = "Disponibilidade Fisíca CTR" },
            GridLineWidth = 0
        })
        .SetSeries(new[]
        {

            new Series {  Name = serie1, Data = new DotNet.Highcharts.Helpers.Data(chartValues) , PlotOptionsLine = new PlotOptionsLine
                {
                   DataLabels = new PlotOptionsLineDataLabels
                   {
                       Enabled = true,
                       Style ="fontSize: '10px', fontFamily: 'Times New Roman', color: 'Black'"

                   },
                   LineWidth = 1.5,

                   Marker = new PlotOptionsLineMarker
                   {
                       LineWidth = 1
                   }


                }},
            new Series {  Name = serie2, Data = new DotNet.Highcharts.Helpers.Data(chartValues2), PlotOptionsLine = new PlotOptionsLine
            {
                LineWidth = 1.5,
                Marker = new PlotOptionsLineMarker
                {
                    Enabled = false
                }
            }

            },
            new Series { Type = ChartTypes.Column, Name = serie3, Data = new DotNet.Highcharts.Helpers.Data(chartValues3),
                PlotOptionsBar = new PlotOptionsBar
                {
                   DataLabels = new PlotOptionsBarDataLabels {Enabled = true , Style ="fontSize: '10px', fontFamily: 'Times New Roman', color: 'Black'"},
                   Tooltip = new PlotOptionsBarTooltip
                   {

                    HeaderFormat = "<p>meta: <b>1.53 </p>"
                   }

                }
                ,  },


        })
        .SetPlotOptions(new PlotOptions
        {

            //Line = new PlotOptionsLine
            //{
            //    DataLabels = new PlotOptionsLineDataLabels { Enabled = true }
            //}
        });

            return chart.ToHtmlString();
        }
    }
}
