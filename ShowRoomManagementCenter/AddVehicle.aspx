<%@ Page Title="" Language="C#" MasterPageFile="~/ShowRoom.Master" AutoEventWireup="true" CodeBehind="AddVehicle.aspx.cs" Inherits="ShowRoomManagementCenter.AddVehicle" %>
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
                    <li><a href="AddApplicant.aspx">Applicant</a></li>
                    
                    <li> <a href="AddGuarantor.aspx">Guarantor</a></li>
                    <li class="active"><a href="#">Vehicle</a></li>
                    <li><a href="#">Transaction</a></li>
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
                              <h3>Add MotorCycle Information</h3> <p><span class="glyphicons glyphicons-bicycle"></span></p>
                          </div>
                           <div class="col-lg-3">

                          </div>
                        
                    </div>
                   
            <br />

                      <div class="row">
                          <div class="col-lg-3">

                          </div>
                         <div class="col-lg-2">
                                                 <asp:Label ID="Label11" runat="server" Text="Engine Number:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                      <asp:TextBox ID="TextBox_EngineNumber" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />
                              </div>
                          <div class="col-lg-3">
                              <asp:RequiredFieldValidator ID="reqFV_CNIC" runat="server" ControlToValidate="TextBox_EngineNumber" CssClass="alert-danger" ErrorMessage="*Engine sNumber is Required" ValidationGroup="AddApplicant"></asp:RequiredFieldValidator>
                          </div>
                       </div>
            <br />
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                           <div class="col-lg-2">
                                <asp:Label ID="Label12" runat="server" Text="Chasis Number:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                               <asp:TextBox ID="TextBox_ChasisNumber" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />


                          </div>
                          <div class="col-lg-3">
                              <asp:RequiredFieldValidator ID="reqFV_GName" runat="server" ControlToValidate="TextBox_ChasisNumber" CssClass="alert-danger" ErrorMessage="*Chasis Number is Required" ValidationGroup="AddApplicant"></asp:RequiredFieldValidator>
                          </div>
                       </div>
            <br />
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                 <asp:Label ID="Label13" runat="server" Text="Model:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_Model" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />

                          </div>
                          <div class="col-lg-3">
                              <asp:RequiredFieldValidator ID="reqFV_GFName" runat="server"  ControlToValidate="TextBox_Model" CssClass="alert-danger" ErrorMessage="*Model is Required" ValidationGroup="AddApplicant"></asp:RequiredFieldValidator>
                          </div>
                       </div>
            <br />
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="Label27" runat="server" Text="CC:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                  <asp:TextBox ID="TextBox_CC" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />


                          </div>
                          <div class="col-lg-3">
                              <asp:RequiredFieldValidator ID="reqFV_GPhNo" runat="server" ControlToValidate="TextBox_CC" CssClass="alert-danger" ErrorMessage="*CC is Required" ValidationGroup="AddApplicant"></asp:RequiredFieldValidator>
                          </div>
                       </div>
            <br />
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="Label14" runat="server" Text="Registration Number:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_RegistrationNo" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />

                          </div>
                          <div class="col-lg-3">

                          </div>
                       </div>
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
                                               
                              <asp:Button ID="Btn_AddVehicle" runat="server" Text="Add MotorCycle" CssClass="btn btn-primary"  ValidationGroup="AddApplicant" OnClick="Btn_AddVehicle_Click"    />
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


