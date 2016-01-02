<%@ Page Title="" Language="C#" MasterPageFile="~/ShowRoom.Master" AutoEventWireup="true" CodeBehind="MonthlyRecovery.aspx.cs" Inherits="ShowRoomManagementCenter.MonthlyRecovery" %>
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
                               <h3>Monthly Installment Recovery</h3>
                          </div>
                           <div class="col-lg-3">

                          </div>
                        
                                         
                    </div>
                  
            <br />

                       <!-- Row Applicant -->
                    <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                
                              <asp:Label ID="Label1" runat="server" Text="Select Recovery Month:"></asp:Label>
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
                        <ig:WebDataGrid ID="webDataGrid_MonthRecovery" runat="server"  AutoGenerateColumns="False"  DefaultColumnWidth="170px" >
                            <Columns>
                                <ig:BoundDataField DataFieldName="CNIC" Key="CNIC">
                                    <Header Text="CNIC">
                                    </Header>
                                </ig:BoundDataField>
                                <ig:BoundDataField DataFieldName="Name" Key="Name">
                                    <Header Text="Name">
                                    </Header>
                                </ig:BoundDataField>
                                
                               
                                <ig:BoundDataField DataFieldName="EngineNumber" Key="EngineNumber">
                                    <Header Text="Engine No">
                                    </Header>
                                </ig:BoundDataField>

                               <ig:BoundDataField DataFieldName="PayedAmount" Key="PayedAmount">
                                    <Header Text="Payed Amount">
                                    </Header>
                                </ig:BoundDataField>
                                <ig:BoundDataField DataFieldName="InstallmentAmount" Key="InstallmentAmount">
                                    <Header Text="Due Amount">
                                    </Header>
                                </ig:BoundDataField>

                                <ig:BoundDataField DataFieldName="PaymentDate" Key="PaymentDate">
                                    <Header Text="PaymentDate">
                                    </Header>
                                </ig:BoundDataField>

                                <ig:BoundDataField DataFieldName="ReceivedBy" Key="ReceivedBy">
                                    <Header Text="ReceivedBy">
                                    </Header>
                                </ig:BoundDataField>
                               
                            </Columns>
                        
                                     
                         </ig:WebDataGrid>
                   
                       
                   
                  </div>
           </div>
             
        </div>
    
    </div>
        
</asp:Content>

