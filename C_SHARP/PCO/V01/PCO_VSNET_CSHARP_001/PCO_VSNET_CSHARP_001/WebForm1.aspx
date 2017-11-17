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
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        </p>
        <asp:Substitution ID="Substitution1" runat="server" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:BulletedList ID="BulletedList1" runat="server" OnClick="BulletedList1_Click">
        </asp:BulletedList>
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="2" Width="1163px">
            <StartNavigationTemplate>
                <asp:Button ID="StartNextButton" runat="server" CommandName="MoveNext" Text="Next" />
            </StartNavigationTemplate>
            <WizardSteps>
                <asp:WizardStep runat="server" title="Step 1">
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Step 2">
                    <asp:Image ID="Image1" runat="server" />
                </asp:WizardStep>
                <asp:WizardStep runat="server">
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                    <asp:CheckBox ID="CheckBox2" runat="server" />
                </asp:WizardStep>
                <asp:WizardStep runat="server">
                </asp:WizardStep>
                <asp:WizardStep runat="server">
                </asp:WizardStep>
                <asp:WizardStep runat="server">
                </asp:WizardStep>
                <asp:WizardStep runat="server">
                </asp:WizardStep>
                <asp:WizardStep runat="server">
                </asp:WizardStep>
                <asp:WizardStep runat="server">
                </asp:WizardStep>
                <asp:WizardStep runat="server">
                </asp:WizardStep>
                <asp:WizardStep runat="server">
                </asp:WizardStep>
                <asp:WizardStep runat="server">
                </asp:WizardStep>
                <asp:WizardStep runat="server">
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    </form>
</body>
</html>
