<%@ Page Title="" Language="C#" MasterPageFile="~/ShowRoom.Master" AutoEventWireup="true" CodeBehind="AddInstallmentPlan.aspx.cs" Inherits="ShowRoomManagementCenter.AddInstallmentPlan" %>
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
                  <a class="navbar-brand" href="#">Sell MotorCycle</a>
                </div>
                <div class="collapse navbar-collapse" id="myNavbar">
                  <ul class="nav navbar-nav">
                    <li><a href="#">Applicant</a></li>
                    
                    <li> <a href="#">Guarantor</a></li>
                    <li><a href="#">Vehicle</a></li>
                    <li ><a href="#">Transaction</a></li>
                    <li class="active"><a href="#">Installments</a></li>
                  </ul>

                </div>
              </div>
            </nav>

        <div class="container">
        
                    <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-6">
                              <h3>Create Installment Plan</h3> 
                          </div>
                           <div class="col-lg-3">

                          </div>
                        
                    </div>
                   
            <br />

                       <!-- Row  -->
                      <div class="row">
                            
                          <div class="col-lg-3">
                               <asp:Label ID="Label3" runat="server" Text="Applicant CNIC:" CssClass="alert alert-info" ></asp:Label>
                          </div>
                          <div class="col-lg-3">
                                <asp:Label ID="lblApplicantCNIC" runat="server" Text=""  CssClass="alert alert-success" ></asp:Label>

                          </div>
                          <div class="col-lg-3">
                                <asp:Label ID="Label1" runat="server" Text="Guarantor CNIC:" CssClass="alert alert-info" ></asp:Label>                 
                          </div>
                          <div class="col-lg-3">
                               <asp:Label ID="lblGuarantorCNIC" runat="server" Text="" CssClass="alert alert-success" ></asp:Label> 
                          </div>
                                                    
                       </div>
            <br /> <br />
            <!-- Row  -->
                      <div class="row">
                          <div class="col-lg-3">
                               <asp:Label ID="Label2" runat="server" Text="Engine Number:" CssClass="alert alert-info" ></asp:Label>
                          </div>
                          <div class="col-lg-3">
                               <asp:Label ID="lblVehicleEngNo" runat="server" Text="" CssClass="alert alert-success" ></asp:Label>

                          </div>
                          <div class="col-lg-3">
                               <asp:Label ID="Label4" runat="server" Text="Transaction ID:" CssClass="alert alert-info" ></asp:Label>
                          </div>
                          <div class="col-lg-3">
                               <asp:Label ID="lblTransactionID" runat="server" Text="" CssClass="alert alert-success" ></asp:Label>

                          </div>
                      </div>

              <br /> <br />
            <!-- Row  -->
                      <div class="row">
                          <div class="col-lg-3">
                               <asp:Label ID="Label5" runat="server" Text="Total Price:" CssClass="alert alert-info" ></asp:Label>
                          </div>
                          <div class="col-lg-3">
                               <asp:Label ID="lblPrice" runat="server" Text="" CssClass="alert alert-success" ></asp:Label>

                          </div>
                          <div class="col-lg-3">
                               <asp:Label ID="Label7" runat="server" Text="Advance Amount:" CssClass="alert alert-info" ></asp:Label>
                          </div>
                          <div class="col-lg-3">
                               <asp:Label ID="lblAdvanceAmount" runat="server" Text="" CssClass="alert alert-success" ></asp:Label>

                          </div>
                      </div>
             <br />
 
    
                       <!-- Row  -->
            <div class="row">
                          <div class="col-lg-2">
                              <asp:Label ID="lblInstaAmount" runat="server" Text=""></asp:Label>
                          </div>
                          <div class="col-lg-10">  
                                    <asp:Button ID="Btn_AddInstallment" CssClass="btn btn-primary" runat="server" Text="Add Installment" OnClick="Btn_AddInstallment_Click" />
                           </div>
             </div> 
            <br />
               <asp:PlaceHolder ID="placeHolderInstallment" runat="server">
                                                   
               </asp:PlaceHolder>

                       <!-- Row Applicant -->            
                  <br />       
 
                    <div class="row">
                                 <div class="col-lg-12">  
                                      <ig:WebDataGrid ID="webDataGrid_Installments" runat="server" Width="100%" >
                                    </ig:WebDataGrid>
                                </div>
                  </div>
            <!-- Row  -->
            <br />
            <br />

                      <div class="row">
                            <div class="col-lg-4">
                                   <asp:Button ID="Btn_VerifyValues"  CssClass="btn btn-warning" runat="server" Text="Verify Installments" OnClick="Btn_VerifyValues_Click"/>
                            </div>
                            <div class="col-lg-4">
                                  <asp:Button ID="Btn_SaveInstallment"  CssClass="btn btn-primary" runat="server" Text="Save Installments" OnClick="Btn_SaveInstallment_Click" />
                            </div>
                             <div class="col-lg-4">
                                  <asp:Label ID="lblSaveInstallmentStatus" runat="server" Text=""></asp:Label>
                             </div>
                         </div>
             <div class="row">
                          <div class="col-lg-3">

                          </div>
                 <div class="col-lg-3">
                     <asp:Button ID="Btn_PrintPlan"  CssClass="btn btn-danger" runat="server" Text="Print Installments Plan"  OnClick="Btn_PrintPlan_Click"  />
                          </div>
            </div>
                         
            <br />
                       <!-- Row Applicant -->
                    <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                
                              
                          </div>
                          <div class="col-lg-4">
                              <asp:Label ID="lblSuccess" runat="server" Text=""  Visible="false" CssClass="alert-success"></asp:Label>                  
                               <asp:Label ID="lblStatus" runat="server" Text="" Visible="false" CssClass="alert-warning" ></asp:Label>  
                          </div>
                          <div class="col-lg-3">

                          </div>
                       </div>
                       <!-- Row Applicant -->
                                    <!-- Row Applicant -->

               <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-4">
                                                
                              
                          </div>
                          <div class="col-lg-4">
                              
                          </div>
                          <div class="col-lg-1">
                             <asp:Button ID="Btn_Next" runat="server" Text="Next" CssClass="btn btn-primary" ValidationGroup="AddApplicant" OnClick="Btn_Next_Click"  />

                          </div>
             </div>
                       <!-- Row Applicant -->
             
        </div>
    
    </div>
        
</asp:Content>
