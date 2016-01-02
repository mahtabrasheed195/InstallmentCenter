<%@ Page Title="" Language="C#" MasterPageFile="~/ShowRoom.Master" AutoEventWireup="true" CodeBehind="BlackListCustomer.aspx.cs" Inherits="ShowRoomManagementCenter.BlackListCustomer" %>
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
 
                   <a class="navbar-brand" href="#">&nbsp Black Listing</a>

                
              </div>
            </nav>
        <div class="container">
        
                    <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-6">
                               <h3>Customer Black List Menu</h3>
                          </div>
                           <div class="col-lg-3">

                          </div>
                        
                                         
                    </div>
                  
            <br />

                      <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="lblCustomerCINC" runat="server" Text="Customer CNIC:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_CustomerCNIC" runat="server" Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>

                          </div>
                          <div class="col-lg-3">
                              <asp:RequiredFieldValidator ID="reqFV_CNIC" runat="server" ControlToValidate="TextBox_CustomerCNIC" CssClass="alert-danger" ErrorMessage="*Customer CNIC is Required" ValidationGroup="AddApplicant"></asp:RequiredFieldValidator>
                          </div>
                       </div>
            <br />
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                <asp:Label ID="Label2" runat="server" Text="Black List Reason:" ></asp:Label>


                          </div>
                          <div class="col-lg-4">
                             <asp:TextBox ID="TextBox_Reason" runat="server"  Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>


                          </div>
                          <div class="col-lg-3">
                              <asp:RequiredFieldValidator ID="reqFV_CName" runat="server" ControlToValidate="TextBox_Reason" CssClass="alert-danger" ErrorMessage="*Reason is Required" ValidationGroup="AddApplicant"></asp:RequiredFieldValidator>
                          </div>
                       </div>
            <br />
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                <asp:Label ID="Label5" runat="server" Text="Remarks:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                 <asp:TextBox ID="TextBox_Remarks" runat="server"   Width="100%" BackColor="#FFCCCC" ></asp:TextBox><br />

                          </div>
                          <div class="col-lg-3">
                              <asp:RequiredFieldValidator ID="reqFV_CFName" runat="server"  ControlToValidate="TextBox_Remarks" CssClass="alert-danger" ErrorMessage="*Customer Father Name is Required" ValidationGroup="AddApplicant"></asp:RequiredFieldValidator>
                          </div>
                       </div>
            <br />
                       <!-- Row  -->
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                               

                          </div>
                          <div class="col-lg-4">
                                                <asp:RadioButtonList ID="radioButtonList" runat="server">
                                                    <asp:ListItem Text="Customer" Value="cus" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Text="Guarantor" Value="gua" ></asp:ListItem>
                                
                                                 </asp:RadioButtonList>

                          </div>
                          <div class="col-lg-3">
                              
                          </div>
                       </div>
     

            <!-- Row  -->
            <br />
            <br />
                         <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                
                              
                          </div>
                          <div class="col-lg-4">
                                               
                              <asp:Button ID="Btn_AddBlackList" runat="server" Text="Black List" CssClass="btn btn-danger"  ValidationGroup="AddApplicant" OnClick="Btn_AddBlackList_Click"  />
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
            <div class="row">
                <!-- Blog Entries Column col-md-8  -->
                <div class="col-lg-12">
                    <ig:WebDataGrid ID="webDataGrid_BlackListedUsers" runat="server"  AutoGenerateColumns="False" Height="350px" DefaultColumnWidth="185" >
                        <Columns>
                            <ig:BoundDataField DataFieldName="CNIC" Key="CNIC">
                                <Header Text="CNIC">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="Reason" Key="Reason">
                                <Header Text="Reason">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="Remarks" Key="Remarks">
                                <Header Text="Remarks">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="BlackListAs" Key="BlackListAs">
                                <Header Text="BlackListAs">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="BlackListedBy" Key="BlackListedBy">
                                <Header Text="BlackListedBy">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="BlackListDate" Key="BlackListDate">
                                <Header Text="BlackListDate">
                                </Header>
                            </ig:BoundDataField>

                        </Columns>
                                     
                     </ig:WebDataGrid>
                   
              </div>
                       </div>
             
        </div>
    
    </div>
        
</asp:Content>

