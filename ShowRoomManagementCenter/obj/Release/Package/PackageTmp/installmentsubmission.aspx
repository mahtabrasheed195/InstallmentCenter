<%@ Page Title="" Language="C#" MasterPageFile="~/ShowRoom.Master" AutoEventWireup="true" CodeBehind="installmentsubmission.aspx.cs" Inherits="ShowRoomManagementCenter.installmentsubmission" %>

<%@ Register Assembly="Infragistics4.Web.v12.1, Version=12.1.20121.2236, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" Namespace="Infragistics.Web.UI.GridControls" TagPrefix="ig" %>
<%@ Register Assembly="Infragistics4.Web.v12.1, Version=12.1.20121.2236, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" Namespace="Infragistics.Web.UI.ListControls" TagPrefix="ig" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron">
        <div class="container">
            <div class="row">
                <!-- Blog Entries Column col-md-8  -->
                <div class="col-lg-12">
                  
                        <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
                                            
                             <div style="width:100%;float:left;padding-left:5%;padding-right:5%; text-align:left">
                       
      
                                <div style="width:80%;float:left;padding-left:1%; text-align:left;">

                                            <asp:Label ID="Label17" runat="server" Text="Select Engine Number:" ></asp:Label>
                                            <ig:WebDropDown ID="webDropDown_EngineNumber" runat="server" Width="200px" AutoPostBack="True" OnSelectionChanged="webDropDown_EngineNumber_SelectionChanged"></ig:WebDropDown>

                                            <asp:Label ID="lblPrice" runat="server" Text="" Font-Bold="true" Font-Size="X-Large"></asp:Label><br />
                                            <asp:Label ID="lblTotalRemainingAmount" runat="server" Text="" Font-Bold="true" Font-Size="X-Large"></asp:Label><br />
                                            &nbsp;<asp:Label ID="lblTotalPayedAmount" runat="server" Text="" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                            <br />
                                            <asp:Label ID="lblInstallmentNo" runat="server" Text="" Font-Bold="true" Font-Size="X-Large" ></asp:Label><br />
                                            <asp:Label ID="lblNextInstallmentAmount" runat="server" Text="" Font-Bold="true" Font-Size="X-Large"></asp:Label><br />
                                            
                                            <hr />
                                            <div style="width:35%;float:left;padding-left:4%;text-align:left ">
                                                <asp:Label ID="lblMerchName" runat="server" Text="Customer CNIC:" ></asp:Label>
                                                <br />
                                                <asp:Label ID="Label2" runat="server" Text="Customer Name:" ></asp:Label>
                                                <br />
                                                <asp:Label ID="Label5" runat="server" Text="Father Name:" ></asp:Label>
                                                <br />
                                                <asp:Label ID="Label6" runat="server" Text="Phone Number:" ></asp:Label>
                                                <br />
                                                <asp:Label ID="Label7" runat="server" Text="Address:" ></asp:Label>
                                                <br />
                                                <asp:Label ID="lblCreateStatusApplicant" runat="server" ForeColor="Red" ></asp:Label>
                                                <hr />
                                                 <br />
                                                <asp:Label ID="Label8" runat="server" Text="Guarantor CNIC:" ></asp:Label>
                                                <br />

                                                <asp:Label ID="Label3" runat="server" Text="Guarantor Name:" ></asp:Label>
                                                <br />
                                                 <asp:Label ID="Label4" runat="server" Text="Father Name:" ></asp:Label>
                                                <br />
                                                 <asp:Label ID="Label9" runat="server" Text="Phone Number:" ></asp:Label>
                                                <br />
                                                <asp:Label ID="Label1" runat="server" Text="Address:" ></asp:Label>
                                                <br />
                                                 <asp:Label ID="lblCreateStatusGuarantor" runat="server" ForeColor="Red" ></asp:Label>
                                                <br />
                                                <hr />
                                                 <asp:Label ID="Label10" runat="server" Text="Engine Number" ></asp:Label>
                                                <br />
                                                 <asp:Label ID="Label11" runat="server" Text="Chasis Number:" ></asp:Label>
                                                <br />
                                                 <asp:Label ID="Label12" runat="server" Text="Model:" ></asp:Label>
                                                <br />
                                                 <asp:Label ID="Label13" runat="server" Text="CC:" ></asp:Label>
                                                <br />
                                                <asp:Label ID="Label14" runat="server" Text="Price:" ></asp:Label>
                                                <br />
                                                <asp:Label ID="Label15" runat="server" Text="AdvanceAmount:" ></asp:Label>
                                                <br />
                                                <asp:Label ID="lblCreateStatusVehicle" runat="server" ForeColor="Red" ></asp:Label>
                                                <hr />
                                            </div>

                                            <div style="width:45%;float:left;padding-left:4%; text-align:left">
                                                <asp:TextBox ID="TextBox_CustomerCNIC" runat="server" Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>
                                                <br />
                                                <asp:TextBox ID="TextBox_CustomerName" runat="server"  Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>
                                                 <br />
                                                <asp:TextBox ID="TextBox_CustomerFName" runat="server"   Width="100%" BackColor="#FFCCCC" ></asp:TextBox><br />
                                                <asp:TextBox ID="TextBox_PhoneNumber" runat="server"   Width="75%" BackColor="#FFCCCC" ></asp:TextBox><br />
                                                <asp:TextBox ID="TextBox_Address" runat="server"    Width="100%" BackColor="#FFCCCC" ></asp:TextBox><br />
                                                <hr />
                                                <asp:TextBox ID="TextBox_GCNIC" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />
                         
                                                <asp:TextBox ID="TextBox_GName" runat="server"  Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />
                                                <asp:TextBox ID="TextBox_GFName" runat="server"   Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />
                                                <asp:TextBox ID="TextBox_GPhoneNumber" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />
                                                <asp:TextBox ID="TextBox_GAddress" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />
                                               
                                                <hr />
                                                <asp:TextBox ID="TextBox_EngineNumber" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />
                                                <asp:TextBox ID="TextBox_ChasisNumber" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />
                                                <asp:TextBox ID="TextBox_Model" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />
                                                <asp:TextBox ID="TextBox_CC" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />
                                                <asp:TextBox ID="TextBox_Price" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />
                                                <asp:TextBox ID="TextBox_AdvanceAmount" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />
                                              <br />    
                                                <div>
                                                        <asp:Button ID="Btn_SubmitInstallment" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="Btn_SubmitInstallment_Click" />
                                                        <asp:Button ID="Btn_Reset" runat="server" CssClass="btn btn-warning" Text="Reset" />
                                                        <br />
                                                    <br />  
                                                        <asp:Button ID="Btn_Print" runat="server" Text="Print Receipt" CssClass="btn btn-primary" OnClick="Btn_Print_Click" />
                                                     </div>
                                               
                                           </div>

                                        </div>
                                         <div style="width:100%;float:left;padding-left:5=1%; text-align:left;">
                                             <asp:Label ID="Label16" runat="server" Text="Installment Number :" ></asp:Label>
                                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                             <asp:TextBox ID="TextBox_Installments" runat="server" Width="10%" BackColor="#FFCCCC"  ></asp:TextBox>
                                                                                &nbsp;<asp:Button ID="Btn_InstallmentNumber" runat="server" Text="Load Installment Number" CssClass="btn btn-primary" OnClick="Btn_InstallmentNumber_Click" />
                                                                                <br />
                                              <asp:Label ID="Label19" runat="server" Text="Installment Amount:" ></asp:Label>
                                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                             <asp:TextBox ID="TextBox_InstallmentAmount" runat="server" Width="10%" BackColor="#FFCCCC"  ></asp:TextBox>
                                                                                <br />
                                             <br />
                                             <asp:CheckBox ID="CheckBox_Temp" Text="Temparory" runat="server" />
                                             <br />
                                             <ig:WebDataGrid ID="webDataGrid_Installments" runat="server" Width="100%" Height="350px">
                                             </ig:WebDataGrid>
                                         </div>
                             </div>
   
            </div>
          </div>
            <!-- /.row -->
        </div>
    </div>
</asp:Content>