<%@ Page Title="" Language="C#" MasterPageFile="~/ShowRoom.Master" AutoEventWireup="true" CodeBehind="MonthlyDueInstallment.aspx.cs" Inherits="ShowRoomManagementCenter.MonthlyDueInstallment" %>
<%@ Register Assembly="Infragistics4.Web.v12.1, Version=12.1.20121.2236, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" Namespace="Infragistics.Web.UI.NavigationControls" TagPrefix="ig" %>
<%@ Register Assembly="Infragistics4.Web.v12.1, Version=12.1.20121.2236, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" Namespace="Infragistics.Web.UI.GridControls" TagPrefix="ig" %>

<%@ Register Assembly="Infragistics4.Web.v12.1, Version=12.1.20121.2236, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" Namespace="Infragistics.Web.UI.ListControls" TagPrefix="ig" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>  
    
    <div class="jumbotron">

            <nav class="navbar navbar-default">
              <div class="container-fluid">
                <div class="navbar-header">
                  <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>                        
                  </button>
 
                   <a class="navbar-brand" href="#">&nbsp Monthly Recovery</a>

                
              </div>
            </nav>
        <div class="container">
        
                    <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-6">
                               <h3>Pending Recovery</h3>
                          </div>
                           <div class="col-lg-3">

                          </div>
                        
                                         
                    </div>
                  
            <br />

                       <!-- Row Applicant -->
                    <div class="row">
                          <div class="col-lg-2">

                          </div>
                          <div class="col-lg-3">
                                                
                              <asp:Label ID="Label1" runat="server" Text="Select Pending Recovery Month:"></asp:Label>
                          </div>
                          <div class="col-lg-4">
                                              
                              <ig:WebDropDown ID="webDDL_Months" runat="server" Width="200px" AutoPostBack="True" OnSelectionChanged="webDDL_Months_SelectionChanged"></ig:WebDropDown>
                          </div>
                          <div class="col-lg-3">
                              <asp:Label ID="lblSuccess" runat="server" Text=""  Visible="false" CssClass="alert-success"></asp:Label>  
                          </div>
                       </div>
             <div class="row">
                           <div class="col-lg-2">
                                <asp:Label ID="Label2" runat="server" Font-Bold="true" Font-Size="Large" Text="Total Recovery :"></asp:Label>
                          </div>
                          <div class="col-lg-3">
                                <asp:Label ID="lblTotalRecovery" runat="server" Font-Bold="true" Font-Size="Large" Text=""></asp:Label>
                          </div>
                          
             </div>
            <br />
                       <!-- Row Applicant -->
            <div class="row">
                <!-- Blog Entries Column col-md-8  -->
                    <div class="col-lg-12">
                        <ig:WebDataGrid ID="webDataGrid_MonthlyDueInstallments" runat="server"  AutoGenerateColumns="False"  DefaultColumnWidth="100px" >
                            <Columns>
                                
                                <ig:BoundDataField DataFieldName="BuyerCNIC" Key="BuyerCNIC">
                                    <Header Text="BuyerCNIC">
                                    </Header>
                                </ig:BoundDataField>
                                <ig:BoundDataField DataFieldName="Name" Key="Name">
                                    <Header Text="Name">
                                    </Header>
                                </ig:BoundDataField>
                                <ig:BoundDataField DataFieldName="GuarantorCNIC" Key="GuarantorCNIC">
                                    <Header Text="GuarantorCNIC">
                                    </Header>
                                </ig:BoundDataField>
                                 <ig:BoundDataField DataFieldName="EngineNumber" Key="EngineNumber">
                                    <Header Text="Engine No">
                                    </Header>
                                </ig:BoundDataField>
                                <ig:BoundDataField DataFieldName="ChasisNumber" Key="ChasisNumber">
                                    <Header Text="Chasis No">
                                    </Header>
                                </ig:BoundDataField>
                                <ig:BoundDataField DataFieldName="Model" Key="Model">
                                    <Header Text="Model">
                                    </Header>
                                </ig:BoundDataField>

                                <ig:BoundDataField DataFieldName="InstallmentNumber" Key="InstallmentNumber">
                                    <Header Text="Insta. No">
                                    </Header>
                                </ig:BoundDataField>
                                <ig:BoundDataField DataFieldName="InstallmentAmount" Key="InstallmentAmount">
                                    <Header Text="Insta. Amount">
                                    </Header>
                                </ig:BoundDataField>
                                <ig:BoundDataField DataFieldName="Month" Key="Month">
                                    <Header Text="Month">
                                    </Header>
                                </ig:BoundDataField>
                                
                                <ig:BoundDataField DataFieldName="DueDateEnd" Key="DueDateEnd">
                                    <Header Text="Due Date">
                                    </Header>
                                </ig:BoundDataField>
                               <ig:BoundDataField DataFieldName="TransactionDate" Key="TransactionDate">
                                    <Header Text="Sell Date">
                                    </Header>
                                </ig:BoundDataField>
                                  
                                        <ig:TemplateDataField Key="Company" Width="80px">
                                                    <Header Text="View Detail" />
                                                        <ItemTemplate>
                                                        <asp:HyperLink ID="lnkName"  Text="View Details"  Target="_blank" NavigateUrl='<%# Eval("EngineNumber", "~/installmentsubmit.aspx?key={0}") %>' runat="server" />
                                                        </ItemTemplate>
                                                 </ig:TemplateDataField>
                            </Columns>
                         </ig:WebDataGrid>
                       
                   
                  </div>
           </div>
             
        </div>
    
    </div>
        
</asp:Content>

 
