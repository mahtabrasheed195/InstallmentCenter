<%@ Page Title="" Language="C#" MasterPageFile="~/ShowRoom.Master" AutoEventWireup="true" CodeBehind="InstallmentSubmit.aspx.cs" Inherits="ShowRoomManagementCenter.InstallmentSubmit" %>
<%@ Register Assembly="Infragistics4.Web.v12.1, Version=12.1.20121.2236, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" Namespace="Infragistics.Web.UI.GridControls" TagPrefix="ig" %>

<%@ Register Assembly="Infragistics4.Web.v12.1, Version=12.1.20121.2236, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" Namespace="Infragistics.Web.UI.ListControls" TagPrefix="ig" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>  
    
    <div class="jumbotron">
        <div class="container">
            <div class="row">
                <div class="col-lg-2">
                                                <asp:Label ID="lblMerchName" runat="server" Text="Customer CNIC:" ></asp:Label>
                </div>
                <div class="col-lg-2">
                                                <asp:TextBox ID="TextBox_CustomerCNIC" runat="server" Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>

                </div>
                <div class="col-lg-2">
                                                <asp:Label ID="Label2" runat="server" Text="Customer Name:" ></asp:Label>

                </div>
                <div class="col-lg-2">
                                                <asp:TextBox ID="TextBox_CustomerName" runat="server"  Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>

                </div>
                <div class="col-lg-2">
                                                <asp:Label ID="Label5" runat="server" Text="Father Name:" ></asp:Label>

                </div>
                <div class="col-lg-2">
                                                <asp:TextBox ID="TextBox_CustomerFName" runat="server"   Width="100%" BackColor="#FFCCCC" ></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-2">
                                                <asp:Label ID="Label1" runat="server" Text="Phone Number:" ></asp:Label>
                </div>
                <div class="col-lg-2">

                                                <asp:TextBox ID="TextBox_PhoneNumber" runat="server"   Width="75%" BackColor="#FFCCCC" ></asp:TextBox><br />

                </div>
                <div class="col-lg-2">
                                              <asp:Label ID="Label9" runat="server" Text="Address:" ></asp:Label>
                </div>
                <div class="col-lg-6">
                                                <asp:TextBox ID="TextBox_Address" runat="server"    Width="100%" BackColor="#FFCCCC" ></asp:TextBox><br />

                </div>
                
            </div>
            <br />
            <div class="row">
                <div class="col-lg-2">
                                         
                     <asp:Label ID="Label3" runat="server" Text="Guarantor CNIC:" ></asp:Label>
                </div>
                <div class="col-lg-2">                                           
                         <asp:TextBox ID="TextBox_GCNIC" runat="server"    Width="100%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />


                </div>
                <div class="col-lg-2">
                                               <asp:Label ID="Label4" runat="server" Text="Guarantor Name:" ></asp:Label>


                </div>
                <div class="col-lg-2">
                                            <asp:TextBox ID="TextBox_GName" runat="server"  Width="100%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />

                </div>
                <div class="col-lg-2">
                                                 <asp:Label ID="Label6" runat="server" Text="Father Name:" ></asp:Label>

                </div>
                <div class="col-lg-2">
                                                <asp:TextBox ID="TextBox_GFName" runat="server"   Width="100%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />
                                               
                </div>
            </div>
            <div class="row">
                <div class="col-lg-2">
                                                <asp:Label ID="Label7" runat="server" Text="Phone Number:" ></asp:Label>
                </div>
                <div class="col-lg-2">

                                                <asp:TextBox ID="TextBox_GPhoneNumber" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />

                </div>
                <div class="col-lg-2">
                                              <asp:Label ID="Label8" runat="server" Text="Address:" ></asp:Label>
                </div>
                <div class="col-lg-6">
                                                <asp:TextBox ID="TextBox_GAddress" runat="server"    Width="100%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />

                </div>
                
            </div>
            <br />
                         <!-- Row Vehicle  -->
            <div class="row">
                <div class="col-lg-2">
                                         
                                                 <asp:Label ID="Label11" runat="server" Text="Engine Number:" ></asp:Label>
                </div>
                <div class="col-lg-2">                                           
                      <asp:TextBox ID="TextBox_EngineNumber" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />


                </div>
                <div class="col-lg-2">
                                <asp:Label ID="Label12" runat="server" Text="Chasis Number:" ></asp:Label>


                </div>
                <div class="col-lg-2">
                               <asp:TextBox ID="TextBox_ChasisNumber" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />

                </div>
                <div class="col-lg-2">
                                                 <asp:Label ID="Label13" runat="server" Text="Model:" ></asp:Label>

                </div>
                <div class="col-lg-2">
                                                <asp:TextBox ID="TextBox_Model" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />
                                               
                </div>
            </div>
                       
            <div class="row">
                <div class="col-lg-2">
                                         
                                                <asp:Label ID="Label27" runat="server" Text="CC:" ></asp:Label>
                </div>
                <div class="col-lg-2">                                           
                                  <asp:TextBox ID="TextBox_CC" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />


                </div>
                <div class="col-lg-2">
                                                <asp:Label ID="Label14" runat="server" Text="Registration Number:" ></asp:Label>


                </div>
                <div class="col-lg-2">
                                                <asp:TextBox ID="TextBox_RegistrationNo" runat="server"    Width="75%" MaxLength="100" BackColor="#CCFFCC" ></asp:TextBox><br />

                </div>
              
            </div>

            <br />
            
             <div class="row">
                 <div class="col-lg-1">
                </div>
                <div class="col-lg-2">
                                                <asp:Label ID="Label10" runat="server" Text="Price:" ></asp:Label>
                </div>
                <div class="col-lg-2">
                                                <asp:TextBox ID="TextBox_Price" runat="server" Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>

                </div>
            </div>
             
            <div class="row">
             <div class="col-lg-1">
                </div>
                     <div class="col-lg-2">
                                                <asp:Label ID="Label16" runat="server" Text="Total Payment" ></asp:Label>
                </div>
                <div class="col-lg-2">
                                                <asp:TextBox ID="TextBox_TotalPayment" runat="server" Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>

                </div>
            </div>
             <div class="row">
                  <div class="col-lg-1">
                </div>
                <div class="col-lg-2">
                                                <asp:Label ID="Label15" runat="server" Text="Remaining Amount:" ></asp:Label>

                </div>
                <div class="col-lg-2">
                                                <asp:TextBox ID="TextBox_RemainingAmount" runat="server"  Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>
                </div>
              </div>

            <div class="row">
                 <div class="col-lg-1">
                </div>
                <div class="col-lg-2">
                                               <asp:Label ID="Label17" runat="server" Text="Payed Installments" ></asp:Label>
                </div>
                <div class="col-lg-1">
                                                <asp:TextBox ID="TextBox_PayedInstallments" runat="server"  Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>

                </div>
            </div>
             <div class="row">
                  <div class="col-lg-1">
                </div>
                <div class="col-lg-2">
                                                <asp:Label ID="Label18" runat="server" Text="Remaining Installments" ></asp:Label>

                </div>
                <div class="col-lg-1">
                                                <asp:TextBox ID="TextBox_RemaingInstallments" runat="server"  Width="100%" BackColor="#FFCCCC"  ></asp:TextBox>

                </div>
           </div>
            
            <br />

             <div class="row">
                 <div class="col-lg-2">
                </div>
                 <div class="col-lg-3">
                     <asp:Label ID="lblInstallmentNumber" runat="server" Text="Installment Number"></asp:Label>
                 </div>
                 <div class="col-lg-3">
                    <asp:TextBox ID="TextBox_InstallmentNumber" runat="server"></asp:TextBox>
                 </div>
                 <div class="col-lg-3">
                      <asp:RequiredFieldValidator ID="rfv_InstallmentNumber" ControlToValidate="TextBox_InstallmentNumber" runat="server" ErrorMessage="*Installment Number" ForeColor="Red"></asp:RequiredFieldValidator>

                  </div>
                 
            </div>
             <div class="row">
                 <div class="col-lg-2">
                </div>
                 <div class="col-lg-3">
                     <asp:Label ID="lblInstallmentAmount" runat="server" Text="Installment Amount"></asp:Label>
                 </div>
                 <div class="col-lg-3">                    
                    <asp:TextBox ID="TextBox_InstallmentAmount" runat="server"></asp:TextBox>
                 </div>
                  <div class="col-lg-3">
                      <asp:RequiredFieldValidator ID="rfv_InstallmentAmount" ControlToValidate="TextBox_InstallmentAmount" runat="server" ErrorMessage="*Installment Amount" ForeColor="Red"></asp:RequiredFieldValidator>
                  </div>
                 
                 
            </div>

            <div class="row">
                <div class="col-lg-3">
                </div>
                 <div class="col-lg-4">
                     <asp:Button ID="Btn_SubmitInstallment" runat="server" Text="Submit Installment" CssClass="btn btn-primary" OnClick="Btn_SubmitInstallment_Click"  />
                </div> 
                <div class="col-lg-4">
                    <asp:Button ID="Btn_Print" runat="server" Text="Print Receipt" CssClass="btn btn-warning" Visible="false" OnClick="Btn_Print_Click" />
                </div>
            </div>

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

            <br />
             <div class="panel panel-primary">
                  <div class="panel-heading">Installments Record</div>

                  <div class="panel-body">
                      <div class="row">
                        <!-- Blog Entries Column col-md-8  -->
                        <div class="col-lg-12">
                                        
                                             <ig:WebDataGrid ID="webDataGrid_Installments" runat="server" Width="100%" Height="350px"  AutoGenerateColumns="false">
                                                    <Columns>
                                                        <ig:BoundDataField DataFieldName="Instal_No" Key="Instal_No">
                                                            <Header Text="Installment No">
                                                            </Header>
                                                        </ig:BoundDataField>
                                                        <ig:BoundDataField DataFieldName="Instal_Amount" Key="Instal_Amount">
                                                            <Header Text="Installment Amount">
                                                            </Header>
                                                        </ig:BoundDataField>
                                                        <ig:BoundDataField DataFieldName="PayedAmount" Key="PayedAmount">
                                                            <Header Text="Payed Amount">
                                                            </Header>
                                                        </ig:BoundDataField>
                                                        <ig:BoundDataField DataFieldName="DueDateEnd" Key="DueDateEnd">
                                                            <Header Text="Due Date">
                                                            </Header>
                                                        </ig:BoundDataField>
                                                        <ig:BoundDataField DataFieldName="PaymentDate" Key="PaymentDate">
                                                            <Header Text="Payment Date">
                                                            </Header>
                                                        </ig:BoundDataField>
                                                        <ig:BoundDataField DataFieldName="Late" Key="Late">
                                                            <Header Text="Is Late">
                                                            </Header>
                                                        </ig:BoundDataField>
                                                        <ig:BoundDataField DataFieldName="ReceivedBy" Key="ReceivedBy">
                                                            <Header Text="Received By">
                                                            </Header>
                                                        </ig:BoundDataField>
                                                    </Columns>

                                                    

                                             </ig:WebDataGrid>
                                
                            </div>
                        </div>
                  </div>
            </div>

        </div>
    </div>
</asp:Content>
