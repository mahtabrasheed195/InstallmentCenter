<%@ Page Title="" Language="C#" MasterPageFile="~/ShowRoom.Master" AutoEventWireup="true" CodeBehind="sellmotorcycle.aspx.cs" Inherits="ShowRoomManagementCenter.sellmotorcycle" %>
<%@ Register Assembly="Infragistics4.Web.v12.1, Version=12.1.20121.2236, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" Namespace="Infragistics.Web.UI.GridControls" TagPrefix="ig" %>

<%@ Register Assembly="Infragistics4.Web.v12.1, Version=12.1.20121.2236, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" Namespace="Infragistics.Web.UI.ListControls" TagPrefix="ig" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
       
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>  
    <div class="jumbotron">
               

        <div class="container">


            <div class="row">
                <!-- Blog Entries Column col-md-8  -->

                <ul class="nav nav-pills">
                  <li class="active"><a data-toggle="pill" href="#home">Applicant</a></li>
                    <li><a data-toggle="pill" href="#menu1">Guarantor </a></li>
                  <li><a data-toggle="pill" href="#menu2">Vehicle</a></li>
                  
                </ul>

                <div class="tab-content">
                  <div id="home" class="tab-pane fade in active">
                    <h3>Applicant Information</h3>

                      <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="lblMerchName" runat="server" Text="Customer CNIC:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_CustomerCNIC" runat="server" Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>

                          </div>
                          <div class="col-lg-3">

                          </div>
                       </div>
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                <asp:Label ID="Label2" runat="server" Text="Customer Name:" ></asp:Label>


                          </div>
                          <div class="col-lg-4">
                             <asp:TextBox ID="TextBox_CustomerName" runat="server"  Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>


                          </div>
                          <div class="col-lg-3">

                          </div>
                       </div>
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="Label5" runat="server" Text="Father Name:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                 <asp:TextBox ID="TextBox_CustomerFName" runat="server"   Width="100%" BackColor="#FFCCCC" ></asp:TextBox><br />

                          </div>
                          <div class="col-lg-3">

                          </div>
                       </div>
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="Label6" runat="server" Text="Phone Number:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_PhoneNumber" runat="server"   Width="75%" BackColor="#FFCCCC" ></asp:TextBox><br />

                          </div>
                          <div class="col-lg-3">

                          </div>
                       </div>
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="Label8" runat="server" Text="Address:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_Address" runat="server"    Width="100%" BackColor="#FFCCCC" ></asp:TextBox><br />

                          </div>
                          <div class="col-lg-3">

                          </div>
                       </div>
                       <!-- Row Applicant -->

                   </div>
            
                
                  <div id="menu1" class="tab-pane fade  active">
                      <h3>Guarantor Information</h3>

                        <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="Label16" runat="server" Text="Guarantor CNIC:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                            <asp:TextBox ID="TextBox_GCNIC" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />

                          </div>
                          <div class="col-lg-3">

                          </div>
                       </div>
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                           <asp:Label ID="Label7" runat="server" Text="Guarantor Name:" ></asp:Label>
  


                          </div>
                          <div class="col-lg-4">
                                <asp:TextBox ID="TextBox_GName" runat="server"  Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />


                          </div>
                          <div class="col-lg-3">

                          </div>
                       </div>
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                 <asp:Label ID="Label4" runat="server" Text="Father Name:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_GFName" runat="server"   Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />

                          </div>
                          <div class="col-lg-3">

                          </div>
                       </div>
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                 <asp:Label ID="Label9" runat="server" Text="Phone Number:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_GPhoneNumber" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />

                          </div>
                          <div class="col-lg-3">

                          </div>
                       </div>
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="Label1" runat="server" Text="Address:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_GAddress" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />

                          </div>
                          <div class="col-lg-3">

                          </div>
                       </div>

                    
                  </div>

                  <div id="menu2" class="tab-pane fade  active">
                      <h3>Vehicle Information</h3>
                       
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

                          </div>
                       </div>
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

                          </div>
                       </div>
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

                          </div>
                       </div>
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

                          </div>
                       </div>
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="Label14" runat="server" Text="Price:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_Price" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />

                          </div>
                          <div class="col-lg-3">

                          </div>
                       </div>
                       <!-- Row  -->
                      <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="Label3" runat="server" Text="Advance Amount:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_AdvanceAmount" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />

                          </div>
                          <div class="col-lg-3">

                          </div>
                       </div>
                       <!-- Row  -->
                  
                  </div>
                
                  
                 
                </div>

                
               
            </div>
            <!-- /.row -->
             
            <div class="row">


                <div style="width:100%;float:left;padding-left:5%; text-align:left;">
                                            <h2>
                                                 <a href="#">Installment Creation Menu</a>
                                            </h2>

                                            <asp:Label ID="Label17" runat="server" Text="Select Customer CNIC:" ></asp:Label>
                                            <ig:WebDropDown ID="webDropDown_CustomerCNIC" runat="server" Width="200px" AutoPostBack="True" OnSelectionChanged="webDropDown_CustomerCNIC_SelectionChanged"></ig:WebDropDown>
                                         
                                            <asp:Label ID="Label18" runat="server" Text="Select Guarantor CNIC:" ></asp:Label>
                                            <ig:WebDropDown ID="webDropDown_GuarantorCNIC" runat="server" Width="200px" AutoPostBack="True" OnSelectionChanged="webDropDown_GuarantorCNIC_SelectionChanged" ></ig:WebDropDown>
                                            <hr />
                                            <div style="width:35%;float:left;padding-left:4%;text-align:left ">
                                             
                                                <asp:Label ID="lblCreateStatusApplicant" runat="server" ForeColor="Red" ></asp:Label>
                                                <hr />
                                                
                                                
                                     
                                               
                                                 <asp:Label ID="lblCreateStatusGuarantor" runat="server" ForeColor="Red" ></asp:Label>
                                               
                                                <br />
                                                <asp:Label ID="lblCreateStatusVehicle" runat="server" ForeColor="Red" ></asp:Label>
                                                <hr />
                                            </div>

                                            <div style="width:45%;float:left;padding-left:4%; text-align:left">
                                                
                                                <hr />
                                                
                                               
                                                   
                                                <div>
                                                        <asp:Button ID="Btn_Create" runat="server" Text="Create" CssClass="btn btn-primary" OnClick="Btn_Create_Click" />
                                                        <asp:Button ID="Btn_Reset" runat="server" CssClass="btn btn-warning" Text="Reset" />
                                                     </div>
                                                  <hr />
                                               
                                                
                                                    </div>
                                           
                                          

                                        </div>

            </div>
                      <div class="row">
                          <div class="col-lg-2">
                              <asp:Label ID="lblInstaAmount" runat="server" Text=""></asp:Label>
                          </div>
                                <div class="col-lg-10">  
                                    <asp:Button ID="Btn_AddInstallment" CssClass="btn btn-primary" runat="server" Text="Add Installment" OnClick="Btn_AddInstallment_Click" />
                                        </div>
                         </div> 
                       <div class="row">
                                                <asp:PlaceHolder ID="placeHolderInstallment" runat="server">
                                                    <%--<ig:WebDatePicker ID="WebDatePicker1" runat="server"></ig:WebDatePicker>--%>
                                                </asp:PlaceHolder>
                         </div>
                        <div class="row">
                            <div class="col-lg-4">
                                            <asp:Button ID="Btn_VerifyValues"  CssClass="btn btn-warning" runat="server" Text="Verify Installments" OnClick="Btn_VerifyValues_Click"/>
                            </div>
                            <div class="col-lg-4">
                                <asp:Button ID="Btn_SaveInstallment"  CssClass="btn btn-primary" runat="server" Text="Save Installments" OnClick="Btn_SaveInstallment_Click"/>
                            </div>
                             <div class="col-lg-4">
                                <asp:Label ID="lblSaveInstallmentStatus" runat="server" Text=""></asp:Label>
                             </div>
                         </div>
                 <div class="row">
                                 <div class="col-lg-12">  
                                      <ig:WebDataGrid ID="webDataGrid_Installments" runat="server" Width="100%" Height="350px">
                                    </ig:WebDataGrid>
                                     </div>
                  </div>

            <br />

          

        </div>
    </div>
</asp:Content>