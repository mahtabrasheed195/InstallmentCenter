<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="ShowRoomManagementCenter.Search" %>
<%@ Register Assembly="Infragistics4.Web.v12.1, Version=12.1.20121.2236, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" Namespace="Infragistics.Web.UI.GridControls" TagPrefix="ig" %>

<%@ Register Assembly="Infragistics4.Web.v12.1, Version=12.1.20121.2236, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" Namespace="Infragistics.Web.UI.ListControls" TagPrefix="ig" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div style="width:80%;float:left;padding-left:10%;padding-right:10%; text-align:left">
    
                                           
                                       
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

                                       
                                 <div style="width:80%;float:left;padding-left:17%; text-align:left;">
                                    
                                                                        <br />
                                      <asp:Label ID="Label19" runat="server" Text="Customers:" ></asp:Label>
                             
                                     
                                     <br />
                                     <ig:WebDataGrid ID="webDataGrid_Search" runat="server" Width="100%" Height="350px">
                                            <Columns>
                                                <ig:TemplateDataField Key="Company" Width="80px">
                                                    <Header Text="Report" />
                                                        <ItemTemplate>
                                                        <asp:HyperLink ID="lnkName"  Text="View Details"  Target="_blank" NavigateUrl='<%# Eval("EngineNumber", "~/SubmitInstallment.aspx?key={0}") %>' runat="server" />
                                                        </ItemTemplate>
                                                 </ig:TemplateDataField>
                                            </Columns>
                                          <Behaviors>
                                             <ig:ColumnFixing>
                                             </ig:ColumnFixing>
                                             <ig:Selection>
                                             </ig:Selection>
                                             <ig:Sorting>
                                             </ig:Sorting>
                                             <ig:Filtering>
                                             </ig:Filtering>
                                             <ig:ColumnResizing>
                                             </ig:ColumnResizing>
                                             <ig:ColumnMoving>
                                             </ig:ColumnMoving>
                                             <ig:RowSelectors>
                                             </ig:RowSelectors>
                                         </Behaviors>
                                     </ig:WebDataGrid>
                                 </div>

        </div>
    </form>
</body>
</html>
