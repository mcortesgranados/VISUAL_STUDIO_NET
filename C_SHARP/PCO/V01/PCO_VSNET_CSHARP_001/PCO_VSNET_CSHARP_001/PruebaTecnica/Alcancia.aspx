<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alcancia.aspx.cs" Inherits="PCO_VSNET_CSHARP_001.PruebaTecnica.WebForm1" %>

<%@ Import Namespace="PCO_VSNET_CSHARP_001.PruebaTecnica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="PruebaTecnica.css" rel="stylesheet" type="text/css">
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            border: 1px solid #999999;
            height: 20px;
        }
        .auto-style2 {
            height: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
          <table width="100%" border="0" cellspacing="1" cellpadding="1">
            <tr>
              <td class="texto3">PRUEBA TECNICA - ALCANCIA </td>
            </tr>
            <tr>
              <td><table width="100%" border="0" cellspacing="1" cellpadding="1">
                <tr>
                  <td class="texto2">SECCION 1 - AGREGAR DENOMINACION </td>
                  <td class="texto2">SECCION 2 - LISTADO DE DENOMINACIONES </td>
                </tr>
                <tr>
                  <td class="texto1"><table width="100%" border="0" cellspacing="1" cellpadding="1">
                    <tr>
                      <td class="texto4">Denominacion : </td>
                      <td class="texto1">
                          <asp:TextBox ID="TextBox_DENOMINACION" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                      <td colspan="2">
                          <asp:Button ID="Button_AGREGAR_DENOMINACION" runat="server" OnClick="Button_AGREGAR_DENOMINACION_Click" Text="Agregar Denominación" />
                        </td>
                    </tr>
                  </table></td>
                  <td class="texto1"><table width="100%" border="0" cellspacing="1" cellpadding="1">
                      <%
                          Alcancia alcancia = (Alcancia)Session["alcancia"];
                          if (alcancia != null)
                          {
                                  foreach(Denominacion denominacion in alcancia.l_denominaciones)
                                  {
                       %>
                    <tr>
                      <td class="texto1"><%Response.Write(denominacion.getNombreDenominacion()); %></td>
                    </tr>
                      <% 
                                }
                          }
                       %>
                  </table></td>
                </tr>
              </table></td>
            </tr>
            <tr>
              <td class="texto2">SECCION 2 - AGREGAR MONEDAS </td>
            </tr>
            <tr>
              <td class="texto1"><table width="100%" border="0" cellspacing="1" cellpadding="1">
                <tr>
                  <td class="texto2">SECCION 3 - AGREGAR MONEDA </td>
                  <td class="texto2">SECCION 4 - LISTADO DE MONEDAS Y SUS RESPECTIVAS DENOMINACIONES </td>
                </tr>
                <tr>
                  <td class="texto1"><table width="100%" border="0" cellspacing="1" cellpadding="1">

                    <tr>
                      <td class="texto4">Denominacion</td>
                      <td class="texto1">
                          <asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Inline">
                              <ContentTemplate>
                                  <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                  </asp:DropDownList>
                              </ContentTemplate>
                          </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                      <td colspan="2" class="auto-style2">
                          <asp:Button ID="Button_AGREGAR_MONEDA" runat="server" Text="Agregar Moneda" />
                        </td>
                    </tr>
                    <tr>
                      <td colspan="2">&nbsp;</td>
                    </tr>
                  </table></td>
                  <td class="texto1"><table width="100%" border="0" cellspacing="1" cellpadding="1">
                    <tr>
                      <td class="auto-style1">moNEDA1</td>
                    </tr>
                    <tr>
                      <td class="texto1">MONEDA2</td>
                    </tr>
                  </table></td>
                </tr>
              </table></td>
            </tr>
          </table>
        </div>
    </form>
</body>
</html>
