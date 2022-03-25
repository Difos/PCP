using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;

namespace PCP.Infra.Helpers
{
    public class Html
    {
        public string HtmlDados(DataSet ds, string head, int op)
        {
            return returnDados(ds, head, op);
        }

        private static string returnDados(DataSet ds, string head, int op)
        {

            OleDbDataAdapter da;
            GridView gd = new GridView();

            int resp = 1;
            int count = 0, x = 1;
            object dummy = Type.Missing;
            int row, col, rowX = 0, colX = 0, calrow = 0, calcol = 0;

            string[,] array = new string[50000, 30];

            //table building
            string body = "", data = "", end = "", n = "";
            string join = "";

            gd.DataSource = ds.Tables[0];

            gd.DataBind();

            row = ds.Tables[0].Rows.Count;
            col = ds.Tables[0].Columns.Count;

            while (count < ds.Tables[0].Rows.Count)
            {
            top:

                if (colX > 0)
                {
                    join += "<td>" + HttpContext.Current.Server.HtmlDecode(gd.Rows[rowX].Cells[colX].Text) + "</td>";
                }


                if (colX == 0)
                {
                    n = gd.Rows[rowX].Cells[colX].Text;
                }


                if (op == 6)
                {
                    if (colX == 0 && int.Parse(gd.Rows[rowX].Cells[33].Text) > 1)
                    {
                        join += "<td class='cell2'><img src='./IMG/sad.png'/></td>";
                    }
                    else if (colX == 0 && int.Parse(gd.Rows[rowX].Cells[33].Text) <= 1)
                    {
                        join += "<td class='cell2'><img src='./IMG/sm.png'/></td>";
                    }
                    else
                    {

                    }

                }

                x++;
                colX++;


                if (op == 6)
                {
                    if (colX == 0 && int.Parse(gd.Rows[rowX].Cells[33].Text) > 1)
                    {
                        join += "<td class='cell2'><img src='./IMG/sad.png'/></td>";
                    }
                    else if (colX == 0 && int.Parse(gd.Rows[rowX].Cells[33].Text) == 1)
                    {
                        join += "<td class='cell2'><img src='./IMG/sm.png'/></td>";
                    }
                    else
                    {

                    }

                }
                if (colX % col == 0 && colX != 0)
                {

                    //if (string.Format("{0}", Session["PialTvUser"]) == "admin")
                    //{
                    switch (op)
                    {
                        case 1:
                            body += @"<tr>" +
                           join + "<td><button class='btn waves-effect edit' id='" + n + "'  type='button' name='Alterar' value='Alterar' onclick='clickHandler1(this)' class='btn-large' style='font-family: Arial, Helvetica, sans-serif; font-size: 8px;' width='70px' height='20px'>Alterar<i class='material-icons right'>edit</i></button></td>" +
                         "</tr>";
                            break;
                        case 2:
                            body += "<tr>" + join + "</tr>";
                            break;

                        case 3:
                            body += @"<tr>" +
                          join + "<td><button class='btn waves-effect edit' id='" + n + "'  type='button' name='Alterar' value='Alterar' onclick='clickHandler1(this)' class='btn-large' style='font-family: Arial, Helvetica, sans-serif; font-size: 8px;' width='70px' height='20px'>Alterar<i class='material-icons right'>edit</i></button></td>" +
                        "</tr>";
                            break;
                        case 4:
                            {
                                if (resp == 1)
                                {
                                    resp = 2;
                                    body += @"<tr>" +
                                    join + "<td><button class='btn waves-effect edit' id='" + n + "'  type='button' name='Alterar' value='Alterar' onclick='clickHandler1(this)' class='btn-large' style='font-family: Arial, Helvetica, sans-serif; font-size: 8px;' width='70px' height='20px'>Alterar<i class='material-icons right'>edit</i></button></td>" +
                                "</tr>";
                                }
                                else
                                {
                                    resp = 1;
                                    body += "<tr>" + join + "</tr>";
                                }

                                break;
                            }
                        case 5:
                            {
                                body += @"<tr>" +
                         join + "<td><button class='btn waves-effect edit' id='" + n + "'  type='button' name='Vizualizar' value='Vizualizar' onclick='clickHandler2(this)' class='btn-large' style='font-family: Arial, Helvetica, sans-serif; font-size: 8px;' width='70px' height='20px'>Vizualizar<i class='material-icons right'>search</i></button></td>" +
                       "</tr>";
                                break;
                            }
                        case 6:
                            {
                                body += "<tr>" + join + "</tr>";

                                break;
                            }

                    }

                    //}


                    join = "";
                }

                if (colX == col)
                {

                    x = 1;

                    colX = 0;

                    rowX++;

                    count++;


                    if (count == ds.Tables[0].Rows.Count)
                    {
                        goto prox;
                    }
                    else
                    {
                        goto top;
                    }


                }


            }

        prox:

            end = "</tbody></table>";

            head = head + body + end;

            return head;


        }
    }
}
