<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DashRodeiros.aspx.cs" Inherits="PCP.Site.DashRodeiros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript" src="Scripts/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="./materialize/materialize.js"></script>
    <link href="materialize/css/materialize.css" rel="stylesheet" type="text/css" />
    <link href="materialize/css/materialize.min.css" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.8/css/materialize.min.css">

    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>

    <!-- Compiled and minified JavaScript -->
    <script src="./Scripts/jquery-1.9.0.min.js" type="text/javascript"></script>
    <script src="./Scripts/Highcharts-4.0.1/js/highcharts.js" type="text/javascript"></script>
    <link href="Content/bootstrap.min.css" rel="Stylesheet" media="screen" />

    <script src="./Scripts/jquery-1.9.0.min.js" type="text/javascript"></script>
    <script src="./Scripts/Highcharts-4.0.1/js/highcharts.js" type="text/javascript"></script>

    <script src="./Scripts/jquery-1.9.0.min.js" type="text/javascript"></script>
    <script src="./Scripts/Highcharts-4.0.1/js/highcharts.js" type="text/javascript"></script>
    <link href="Content/bootstrap.min.css" rel="Stylesheet" media="screen" />

    <script type="text/javascript" src="Scripts/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="./materialize/materialize.js"></script>
    <link href="materialize/css/materialize.css" rel="stylesheet" type="text/css" />
    <link href="materialize/css/materialize.min.css" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <!-- Compiled and minified CSS -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.8/css/materialize.min.css">

    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>

    <!-- Compiled and minified JavaScript -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.8/js/materialize.min.js"></script>
    <br />
    <div class="card-tabs">
        <ul class="tabs tabs-fixed-width tabs-transparent blue darken-1or">
            <li class="tab"><a class="<%=tab1 %>" href="#test4">Saúde da Frota</a></li>
            <li class="tab"><a class="<%=tab2 %>" href="#test2">Troca de Rodeiros</a></li>
            <li class="tab"><a class="<%=tab3 %>" href="#test6">Perfil de Perdas</a></li>
            <li class="tab"><a class="<%=tab4 %>" href="#test7">IDF</a></li>
            <li class="tab"><a class="<%=tab5 %>" href="#test8">Alarmes</a></li>
        </ul>
    </div>
    <br />

    <div class="jumbotron">
        <div id="test4" class="active" style="display: block;">

            <fieldset class="z-depth-1" style="background-color: white; width: 98%; margin-left: 12px; margin-right: 12px;">
                <legend class="blue-text" style="font-size: 30px;"><i class="material-icons" style="font-size: 30px">equalizer</i>Saúde da Frota</legend>
                <div class="row">
                    <div class="col s6">
                        <asp:Literal ID="Literal8" runat="server"></asp:Literal>
                    </div>
                    <div class="col s6">
                        <asp:Literal ID="Literal9" runat="server"></asp:Literal>
                    </div>
                </div>

                <div class="row">
                    <div class="col s6">
                        <asp:Literal ID="Literal11" runat="server"></asp:Literal>
                    </div>
                    <div class="col s6">
                        <asp:Literal ID="Literal12" runat="server"></asp:Literal>
                    </div>
                </div>

            </fieldset>
        </div>
        <div id="test2" class="active" style="display: block;">

            <fieldset class="z-depth-1" style="background-color: white; width: 98%; margin-left: 12px; margin-right: 12px;">
                <legend class="blue-text" style="font-size: 30px;"><i class="material-icons" style="font-size: 30px">equalizer</i>Troca de Rodeiros</legend>
                <div class="row">
                    <div class="col s6">
                        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                    </div>
                    <div class="col s6">
                        <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                    </div>
                </div>
                <div class="row">
                    <div class="col s1">
                        De:
                        <input type="text" name="calendar" id="calendar" value="<%=data %>" />
                    </div>
                    <div class="col s4">
                        <asp:Button ID="btnPesquisar" CssClass="btn-success green" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click" />
                    </div>
                </div>
                <div class="row">
                    <div class="col s12">
                        <asp:Literal ID="TrocaTurno" runat="server"></asp:Literal>
                    </div>
                </div>

                <div class="row">
                    <div class="col s6">
                        <asp:Literal ID="Literal3" runat="server"></asp:Literal>
                    </div>
                    <div class="col s6">
                        <asp:Literal ID="Literal4" runat="server"></asp:Literal>
                    </div>
                </div>

            </fieldset>
        </div>


        <div id="test7" class="active" style="display: block;">

            <fieldset class="z-depth-1" style="background-color: white; width: 98%; margin-left: 12px; margin-right: 12px;">
                <legend class="blue-text" style="font-size: 30px;"><i class="material-icons" style="font-size: 30px">equalizer</i>Indisponibilidade Fisíca</legend>
                <div class="row">
                    <div class="col s6">
                        <asp:Literal ID="Idf" runat="server"></asp:Literal>
                    </div>
                    <div class="col s6">
                        <asp:Literal ID="Literal6" runat="server"></asp:Literal>
                    </div>
                </div>

                <div class="row">
                    <div class="col s6">
                        <asp:Literal ID="Literal7" runat="server"></asp:Literal>
                    </div>
                    <div class="col s6">
                        <asp:Literal ID="Literal10" runat="server"></asp:Literal>
                    </div>
                </div>

            </fieldset>
        </div>
    </div>

    <meta http-equiv="Content-Type" content="
            text/html; charset=UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <link rel="stylesheet" type="text/css" href="./codebase/dhtmlxcalendar.css" />
    <script src="./codebase/dhtmlxcalendar1.js"></script>


    <script src="./codebase/dhtmlxcalendar2.js"></script>
    <script type="text/javascript">
        var myCalendar;
        function doOnLoad() {
            myCalendar = new dhtmlXCalendarObject(["calendar", "calendar2", "calendar3", "calendar4"]);
        }

        doOnLoad();

    </script>

</asp:Content>
