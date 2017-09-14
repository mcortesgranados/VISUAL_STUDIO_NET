<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PCO_VSNET_CSHARP_001.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="100%" border="1" cellspacing="1" cellpadding="1">
            <%

                var miListado = (List<string>)Session["var"];

                foreach (String a in miListado)
                { 
            %>
          
            <tr>
              <td>Test1</td>
              <td><% Response.Write(a);%></td>
            </tr>
            <%
             }   
             %>
          </table>
        </div>
    </form>
</body>
</html>
