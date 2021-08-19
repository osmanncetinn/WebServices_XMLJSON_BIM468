<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Covid.aspx.cs" Inherits="covid19.Covid" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>

    <table width="100%" border="1">
        <tr>
            <td width="150">
                <img src="logo.png" width="100" /></td>
            <td colspan="2" valign="bottom" align="right">
                <a href="">* Covid Nedir?</a>
                <a href="">* Ülke bazında veriler</a>
                <a href="">* Türkiye'de vakaların seyri</a>
                <a href="">* Covid Hastaneleri</a>


            </td>

        </tr>
        <tr>
            <td>
                <a href="">* Pandemi Nedir?</a>
                <br>
                <a href="">* Pandemi vakaları</a>
                <br>
                <a href="">* Alınacak önlemler</a>
                <br>
                <a href="">* Sağlıklı yaşam</a>



            </td>
            <td colspan="2">
                <form id="form1" runat="server">
                    <%--       <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
           <asp:GridView ID="gvColors" CssClass="table table-striped color-table" runat="server">
               <Columns>
                   <asp:BoundField />
               </Columns>
           </asp:GridView>
       </asp:Content>--%>

                    <asp:Panel ID="Panel2" runat="server">
                        <h3 align="center">Vaka bazında top 10 ülke</h3>
                        <asp:GridView ID="grid1" runat="server" AutoGenerateColumns="false" Width="100%" OnRowDataBound="grid1_RowDataBound" AlternatingRowStyle-BackColor="WhiteSmoke" HeaderStyle-BackColor="SkyBlue">
                            <Columns>
                                <asp:BoundField DataField="Name" HeaderText="Name" />
                                <asp:BoundField DataField="date" HeaderText="Tarih" />
                                <asp:BoundField DataField="confirmed" HeaderText="Covid Bulaşan" />
                                <asp:BoundField DataField="deaths" HeaderText="Ölen" />
                                <asp:BoundField DataField="recovered" HeaderText="Kurtarılan" />
                            </Columns>
                        </asp:GridView>
                    </asp:Panel>
                    <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center">
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Covid Verilerini Güncelle" OnClick="Button1_Click" BackColor="YellowGreen" />
                    </asp:Panel>
                 <%--   <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Center">
                        <asp:Chart runat="server" ID="covidChart" Height="154px" Width="783px">
                            <Series>
                                <asp:Series Name="Series1" XValueMember="0" YValueMembers="2" ChartType="Line"></asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                            </ChartAreas>
                        </asp:Chart>
                        <br />
                    </asp:Panel>--%>

                </form>
            </td>
        </tr>
        <tr>
            <td><a href="">İletişim</a>  </td>
            <td>
                <a href="">* Kişisel sağlık</a>
                <br />
                <a href="">* Toplum sağlığı</a>
                <br />
                <a href="">* Sağlıklı yaşam teknikleri</a>
                <br />

            </td>

            <td>
                <a href="">* Sağlık bakanlığı</a>
                <br />
                <a href="">* WHO</a>
                <br />
            </td>
        </tr>
    </table>


</body>
</html>
