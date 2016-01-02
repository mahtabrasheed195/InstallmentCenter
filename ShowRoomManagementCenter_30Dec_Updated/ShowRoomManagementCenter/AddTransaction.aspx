<%@ Page Title="" Language="C#" MasterPageFile="~/ShowRoom.Master" AutoEventWireup="true" CodeBehind="AddTransaction.aspx.cs" Inherits="ShowRoomManagementCenter.AddTransaction" %>
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
                    <li class="active"><a href="#">Transaction</a></li>
                    <li><a href="#">Installments</a></li>
                  </ul>

                </div>
              </div>
            </nav>

        <div class="container">
        
                    <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-6">
                              <h3>Add Financial Information</h3> 
                          </div>
                           <div class="col-lg-3">

                          </div>
                        
                    </div>
                   
            <br />

                       <!-- Row  -->
                         <div class="row">
                            
                          <div class="col-lg-4">
                               <asp:Label ID="Label3" runat="server" Text="Applicant CNIC:" CssClass="alert alert-info" ></asp:Label>
                                <asp:Label ID="lblApplicantCNIC" runat="server" Text=""  CssClass="alert alert-success" ></asp:Label>
                          </div>
                          <div class="col-lg-4">
                                <asp:Label ID="Label1" runat="server" Text="Guarantor CNIC:" CssClass="alert alert-info" ></asp:Label>                 
                               <asp:Label ID="lblGuarantorCNIC" runat="server" Text="" CssClass="alert alert-success" ></asp:Label> 
                          </div>
                          <div class="col-lg-4">
                               <asp:Label ID="Label2" runat="server" Text="Engine Number:" CssClass="alert alert-info" ></asp:Label>
                               <asp:Label ID="lblVehicleEngNo" runat="server" Text="" CssClass="alert alert-success" ></asp:Label>
                          </div>
                          
                       </div>
             <br />
            <br />
                      <div class="row">
                          <div class="col-lg-3">

                          </div>
                         <div class="col-lg-2">
                                                 <asp:Label ID="Label11" runat="server" Text="Selling Price:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                      <asp:TextBox ID="TextBox_Price" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />
                              </div>
                          <div class="col-lg-3">
                              <asp:RequiredFieldValidator ID="reqFV_CNIC" runat="server" ControlToValidate="TextBox_Price" CssClass="alert-danger" ErrorMessage="*Selling Price is Required" ValidationGroup="AddApplicant"></asp:RequiredFieldValidator>
                          </div>
                       </div>
            <br />
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                           <div class="col-lg-2">
                                <asp:Label ID="Label12" runat="server" Text="Advance Amount:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                               <asp:TextBox ID="TextBox_AdvanceAmount" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />


                          </div>
                          <div class="col-lg-3">
                              <asp:RequiredFieldValidator ID="reqFV_GName" runat="server" ControlToValidate="TextBox_AdvanceAmount" CssClass="alert-danger" ErrorMessage="*Advance Amount is Required" ValidationGroup="AddApplicant"></asp:RequiredFieldValidator>
                          </div>
                       </div>
            <br />
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                 <asp:Label ID="Label13" runat="server" Text="Remarks:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_Remarks" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />

                          </div>
                          <div class="col-lg-3">
                              <%--<asp:RequiredFieldValidator ID="reqFV_GFName" runat="server"  ControlToValidate="TextBox_Model" CssClass="alert-danger" ErrorMessage="*Model is Required" ValidationGroup="AddApplicant"></asp:RequiredFieldValidator>--%>
                          </div>
                       </div>
            <br />
                       <!-- Row  -->

                       <!-- Row Applicant -->
        
                      
                         
 

            <!-- Row  -->
            <br />
            <br />
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                
                              
                          </div>
                          <div class="col-lg-4">
                                               
                              <asp:Button ID="Btn_AddTransaction" runat="server" Text="Add Transaction" CssClass="btn btn-primary"  ValidationGroup="AddApplicant" OnClick="Btn_AddTransaction_Click"    />
                              <asp:Button ID="Btn_Reset" runat="server" Text="Reset " CssClass="btn btn-warning"   />
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

