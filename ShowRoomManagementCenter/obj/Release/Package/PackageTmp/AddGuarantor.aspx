<%@ Page Title="" Language="C#" MasterPageFile="~/ShowRoom.Master" AutoEventWireup="true" CodeBehind="AddGuarantor.aspx.cs" Inherits="ShowRoomManagementCenter.AddGuarantor" %>
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
                    
                    <li class="active"> <a href="#">Guarantor</a></li>
                    <li><a href="#">Vehicle</a></li>
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
                              <h3>Add Guarantor Information</h3> 
                          </div>
                           <div class="col-lg-3">

                          </div>
                        
                    </div>
                   
            <br />
                    <div class="row">
                          <div class="col-lg-3">
                              
                          </div>
                          <div class="col-lg-2">
                                    <asp:Label ID="Label17" runat="server" Text="Select Existing Guarantor CNIC:" ></asp:Label>

                          </div>
                           <div class="col-lg-4">
                                <ig:WebDropDown ID="webDropDown_GuarantorCNIC" runat="server" Width="200px" AutoPostBack="True" OnSelectionChanged="webDropDown_GuarantorCNIC_SelectionChanged" ></ig:WebDropDown>
                          </div>
                      </div>
          <br />

                      <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="lblGCINC" runat="server" Text="Guarantor CNIC:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_GCNIC" runat="server" Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>

                          </div>
                          <div class="col-lg-3">
                              <asp:RequiredFieldValidator ID="reqFV_CNIC" runat="server" ControlToValidate="TextBox_GCNIC" CssClass="alert-danger" ErrorMessage="*Guarantor CNIC is Required" ValidationGroup="AddApplicant"></asp:RequiredFieldValidator>
                          </div>
                       </div>
            <br />
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                <asp:Label ID="Label2" runat="server" Text="Guarantor Name:" ></asp:Label>


                          </div>
                          <div class="col-lg-4">
                             <asp:TextBox ID="TextBox_GName" runat="server"  Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>


                          </div>
                          <div class="col-lg-3">
                              <asp:RequiredFieldValidator ID="reqFV_GName" runat="server" ControlToValidate="TextBox_GName" CssClass="alert-danger" ErrorMessage="*Guarantor Name is Required" ValidationGroup="AddApplicant"></asp:RequiredFieldValidator>
                          </div>
                       </div>
            <br />
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="Label5" runat="server" Text="Guarantor Name:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                 <asp:TextBox ID="TextBox_GFName" runat="server"   Width="100%" BackColor="#FFCCCC" ></asp:TextBox><br />

                          </div>
                          <div class="col-lg-3">
                              <asp:RequiredFieldValidator ID="reqFV_GFName" runat="server"  ControlToValidate="TextBox_GFName" CssClass="alert-danger" ErrorMessage="*Guarantor Father Name is Required" ValidationGroup="AddApplicant"></asp:RequiredFieldValidator>
                          </div>
                       </div>
            <br />
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="Label6" runat="server" Text="Phone Number:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_GPhoneNumber" runat="server"   Width="75%" BackColor="#FFCCCC" ></asp:TextBox><br />

                          </div>
                          <div class="col-lg-3">
                              <asp:RequiredFieldValidator ID="reqFV_GPhNo" runat="server" ControlToValidate="TextBox_GPhoneNumber" CssClass="alert-danger" ErrorMessage="*Guarantor Phone Number is Required" ValidationGroup="AddApplicant"></asp:RequiredFieldValidator>
                          </div>
                       </div>
            <br />
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="Label8" runat="server" Text="Address:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_GAddress" runat="server"    Width="100%" BackColor="#FFCCCC" ></asp:TextBox><br />

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
                                               
                              <asp:Button ID="Btn_AddGuarantor" runat="server" Text="Add Guarantor" CssClass="btn btn-primary"  ValidationGroup="AddApplicant" OnClick="Btn_AddGuarantor_Click"  />
                              <asp:Button ID="Btn_Reset" runat="server" Text="Reset " CssClass="btn btn-warning" OnClick="Btn_Reset_Click"  />
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

