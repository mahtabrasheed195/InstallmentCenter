using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowRoomManagementCenter
{
    public partial class InstallmentSubmit : System.Web.UI.Page
    {
        string passedEngNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSuccess.Visible = false;
            lblStatus.Visible = false;
            Btn_Print.Visible = false;
            if (Request.QueryString["key"] != null)
            {
                passedEngNo = Request.QueryString["key"];
                populateInformation(passedEngNo);
            }
        }

        protected void Btn_SubmitInstallment_Click(object sender, EventArgs e)
        {
            try
            {
                string installmentAmount = TextBox_InstallmentAmount.Text;

                string strInstallNo = TextBox_InstallmentNumber.Text;
                int installNo = Convert.ToInt16(strInstallNo);

                if (InstallmentManager.submitInstallmentbyEngineNo(passedEngNo, installNo, installmentAmount, DateTime.Now))
                {

                    PrintHelper.addPrint(passedEngNo, installNo);
                    int printID = PrintHelper.getPrintID(passedEngNo, installNo);

                    Session["printID"] = printID;

                    lblSuccess.Visible = true;
                    lblSuccess.Text = "Installment Submitted Successfully";
                    Btn_Print.Visible = true;

                    populateInformation(passedEngNo);
                }
                else
                {
                    lblStatus.Visible = true;
                    lblStatus.Text = "Installment Not Submitted Successfully";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void populateInformation(string enginenumber)
        {
            try
            {
                int vehid = ShowRoomHelper.getVehicleID(enginenumber);
                int tranid = ShowRoomHelper.getTransactionID(vehid);
                string cusCNIC = ShowRoomHelper.getCustomerCNIC(tranid);
                string guarantorCNIC = ShowRoomHelper.getGuarantorCNIC(tranid);

                List<Buyer> custList = ShowRoomHelper.getCustomerInformation(cusCNIC);
                List<Guarantor> guarantorList = ShowRoomHelper.getGuarantorInformation(guarantorCNIC);
                fillCustomer(custList);
                fillGuarantor(guarantorList);

                fillVehicle(enginenumber);

                TextBox_InstallmentNumber.Text = InstallmentManager.getInstallmentNo(enginenumber).ToString();
                TextBox_InstallmentAmount.Text = InstallmentManager.getNextIntallmentAmount(enginenumber).ToString();


                TextBox_TotalPayment.Text = InstallmentManager.getTotalPayedAmount(enginenumber).ToString();
                TextBox_RemainingAmount.Text = InstallmentManager.getTotalRemainingAmount(enginenumber).ToString();
               
                TextBox_Price.Text = InstallmentManager.getVehiclePrice(enginenumber).ToString();
                webDataGrid_Installments.DataSource = InstallmentManager.getInstallmentsStatusTable(enginenumber);
                webDataGrid_Installments.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void fillVehicle(string engno)
        {
            List<Vehicle> vehList = ShowRoomHelper.getVehicleTable(engno);
            TextBox_EngineNumber.Text = vehList[0].EngineNumber;
            TextBox_ChasisNumber.Text = vehList[0].ChasisNumber;
            TextBox_Model.Text = vehList[0].Model;
            TextBox_CC.Text = vehList[0].CC;

        }
        private void fillCustomer(List<Buyer> buyerList)
        {
            try
            {
                TextBox_CustomerCNIC.Text = buyerList[0].CNIC;
                TextBox_CustomerName.Text = buyerList[0].Name;
                TextBox_CustomerFName.Text = buyerList[0].FatherName;
                TextBox_PhoneNumber.Text = buyerList[0].PhoneNumber;
                TextBox_Address.Text = buyerList[0].Address;

               
            }
            catch (Exception)
            {
                

            }
        }

        private void fillGuarantor(List<Guarantor> buyerList)
        {
            try
            {
                TextBox_GCNIC.Text = buyerList[0].CNIC;
                TextBox_GName.Text = buyerList[0].Name;
                TextBox_GFName.Text = buyerList[0].FatherName;
                TextBox_GPhoneNumber.Text = buyerList[0].PhoneNumber;
                TextBox_GAddress.Text = buyerList[0].Address;

                
            }
            catch (Exception)
            {
                

            }
        }

        protected void Btn_Print_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstallmentReceipt.aspx");
        }
    }
}