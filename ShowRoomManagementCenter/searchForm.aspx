<%@ Page Title="" Language="C#" MasterPageFile="~/ShowRoom.Master" AutoEventWireup="true" CodeBehind="searchForm.aspx.cs" Inherits="ShowRoomManagementCenter.searchForm" %>
<%@ Register Assembly="Infragistics4.Web.v12.1, Version=12.1.20121.2236, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" Namespace="Infragistics.Web.UI.GridControls" TagPrefix="ig" %>

<%@ Register Assembly="Infragistics4.Web.v12.1, Version=12.1.20121.2236, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" Namespace="Infragistics.Web.UI.ListControls" TagPrefix="ig" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
    <div class="jumbotron">
        <div class="container">


                   <br />
            <div class="row">
                      <div class="col-lg-6">
                   <div class="row">

                          <div class="col-lg-4">
                                                <asp:Label ID="lblCustomerCINC" runat="server" Text="Customer CNIC:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_CustomerCNIC" runat="server" Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>

                          </div>

                  </div>
            
                       <!-- Row  -->
                         <div class="row">
                         
                          <div class="col-lg-4">
                                <asp:Label ID="Label2" runat="server" Text="Customer Name:" ></asp:Label>


                          </div>
                          <div class="col-lg-4">
                             <asp:TextBox ID="TextBox_CustomerName" runat="server"  Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>


                          </div>
 
                       </div>
            
                       <!-- Row  -->
                         <div class="row">
                          
                          <div class="col-lg-4">
                                                <asp:Label ID="Label5" runat="server" Text="Father Name:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                 <asp:TextBox ID="TextBox_CustomerFName" runat="server"   Width="100%" BackColor="#FFCCCC" ></asp:TextBox><br />

                          </div>

                       </div>
            
                       <!-- Row  -->
                         <div class="row">
                          
                          <div class="col-lg-4">
                                                <asp:Label ID="Label6" runat="server" Text="Phone Number:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_PhoneNumber" runat="server"   BackColor="#FFCCCC" ></asp:TextBox><br />

                          </div>

                       </div>
                   </div>
                   <div class="col-lg-6">
                       <div class="row">
                         
                          <div class="col-lg-4">
                                                <asp:Label ID="Label1" runat="server" Text="Guarantor CNIC:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_GCNIC" runat="server" Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>

                          </div>
                          
                       </div>
            
                       <!-- Row  -->
                         <div class="row">
                          
                          <div class="col-lg-4">
                                <asp:Label ID="Label3" runat="server" Text="Guarantor Name:" ></asp:Label>


                          </div>
                          <div class="col-lg-4">
                             <asp:TextBox ID="TextBox_GName" runat="server"  Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>


                          </div>
                         
                       </div>
            
                       <!-- Row Guarantor -->
                         <div class="row">

                          <div class="col-lg-4">
                                                <asp:Label ID="Label4" runat="server" Text="G Father Name:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                 <asp:TextBox ID="TextBox_GFName" runat="server"   Width="100%" BackColor="#FFCCCC" ></asp:TextBox><br />

                          </div>
                         
                       </div>
            
                       <!-- Row  -->
                         <div class="row">
                          
                          <div class="col-lg-4">
                                                <asp:Label ID="Label7" runat="server" Text="G Phone Number:" ></asp:Label>

                          </div>
                          <div class="col-lg-4">
                                                <asp:TextBox ID="TextBox_GPhNo" runat="server"   BackColor="#FFCCCC" ></asp:TextBox><br />

                          </div>
                         
                       </div>
                          </div>
                </div>

            <!-- Row  -->
            <br />
            <br />

             <!-- Row Vehicle  -->

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
                     <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                

                          </div>
                          <div class="col-lg-7">
                                               
                              
                             <asp:RadioButtonList ID="radioButtonList" runat="server">
                                 <asp:ListItem Text="Exclusive" Value="OR" Selected="True"></asp:ListItem>
                                  <asp:ListItem Text="Inclusive" Value="AND" ></asp:ListItem>
                                
                             </asp:RadioButtonList>
                          </div>
                         
                       </div>
                       <!-- Row Applicant -->
        
                     <div class="row">
                          <div class="col-lg-3">

                          </div>
                          <div class="col-lg-2">
                                                
                              
                          </div>
                          <div class="col-lg-4">
                                               
                              <asp:Button ID="Btn_Search" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="Btn_Search_Click"  />
                              <asp:Button ID="Btn_Reset" runat="server" Text="Reset " CssClass="btn btn-warning" />
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
           
            <!-- /.row -->
        </div>

                   
    </div>
     <div class="row">
                <!-- Blog Entries Column col-md-8  -->
                <div class="col-lg-12">
                                        
                                     <ig:WebDataGrid ID="webDataGrid_Search" runat="server"  AutoGenerateColumns="False" Height="350px" DefaultColumnWidth="100">
                                            <Columns>
                                                <ig:TemplateDataField Key="Company" Width="80px">
                                                    <Header Text="Report" />
                                                        <ItemTemplate>
                                                        <asp:HyperLink ID="lnkName"  Text="View Details"  Target="_blank" NavigateUrl='<%# Eval("EngineNumber", "~/installmentsubmit.aspx?key={0}") %>' runat="server" />
                                                        </ItemTemplate>
                                                 </ig:TemplateDataField>

                         <ig:BoundDataField DataFieldName="CNIC" Key="CNIC" Width="100px">
                                <Header Text="Customer CNIC" >
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="Name" Key="Name"  Width="100px">
                                <Header Text="Customer Name">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="FatherName" Key="FatherName"  Width="100px">
                                <Header Text="Father Name">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="Address" Key="Address"  Width="100px">
                                <Header Text="Address">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="PhoneNumber" Key="PhoneNumber"  Width="100px">
                                <Header Text="Phone No">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="GCNIC" Key="GCNIC"  Width="100px">
                                <Header Text="GCNIC">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="GName" Key="GName">
                                <Header Text="GName">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="RegistrationNo" Key="RegistrationNo">
                                <Header Text="Regist. No.">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="AdvanceAmount" Key="AdvanceAmount">
                                <Header Text="Advance Amount">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="Price" Key="Price">
                                <Header Text="Price">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="EngineNumber" Key="EngineNumber">
                                <Header Text="Engine Number">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="ChasisNumber" Key="ChasisNumber">
                                <Header Text="Chasis Number">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="Model" Key="Model">
                                <Header Text="Model">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="CC" Key="CC">
                                <Header Text="CC">
                                </Header>
                            </ig:BoundDataField>
                            <ig:BoundDataField DataFieldName="TransactionDate" Key="TransactionDate">
                                <Header Text="Selling Date">
                                </Header>
                            </ig:BoundDataField>
                                            </Columns>
                        </ig:WebDataGrid>
                    </div>
                </div>
</asp:Content>