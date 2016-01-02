using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowRoomManagementCenter
{
    public partial class SubmitInstallment : System.Web.UI.Page
    {
        string passedEngNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["key"] != null)
            {
                passedEngNo = Request.QueryString["key"];
                populateInformation(passedEngNo);
            }

            if(!IsPostBack)
            webDropDown_EngineNumber.DataSource = ShowRoomHelper.getEngineNumberList();
           
        }

        protected void webDropDown_EngineNumber_SelectionChanged(object sender, Infragistics.Web.UI.ListControls.DropDownSelectionChangedEventArgs e)
        {
            string enginenumber=webDropDown_EngineNumber.SelectedItem.ToString();
            populateInformation(enginenumber);
           
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

                TextBox_Installments.Text =  InstallmentManager.getInstallmentNo(enginenumber).ToString();
                TextBox_InstallmentAmount.Text =  InstallmentManager.getNextIntallmentAmount(enginenumber).ToString();

                lblInstallmentNo.Text = "Installment No. : " + InstallmentManager.getInstallmentNo(enginenumber).ToString();
                lblNextInstallmentAmount.Text = "Next Installment Amount: " + InstallmentManager.getNextIntallmentAmount(enginenumber).ToString();

                lblTotalPayedAmount.Text =  "Total Payed Amount: " + InstallmentManager.getTotalPayedAmount(enginenumber).ToString();
                lblTotalRemainingAmount.Text = "Total Remaining Amount: " + InstallmentManager.getTotalRemainingAmount(enginenumber).ToString();
                lblPrice.Text = "Total Price : " + InstallmentManager.getVehiclePrice(enginenumber).ToString();

                webDataGrid_Installments.DataSource = InstallmentManager.getInstallmentsStatusTable(enginenumber);
                webDataGrid_Installments.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void Btn_SubmitInstallment_Click(object sender, EventArgs e)
        {
            try
            {
                string installmentAmount = TextBox_InstallmentAmount.Text;
                string enginenumber = webDropDown_EngineNumber.SelectedItem.ToString();
                string strInstallNo = TextBox_Installments.Text;
                int installNo = Convert.ToInt16(strInstallNo);

                InstallmentManager.submitInstallmentbyEngineNo(enginenumber, installNo, installmentAmount, DateTime.Now);

                PrintHelper.addPrint(enginenumber, installNo);
                int printID=PrintHelper.getPrintID(enginenumber, installNo);

                Session["printID"] = printID;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void fillVehicle(string engno)
        {
           List<Vehicle> vehList= ShowRoomHelper.getVehicleTable(engno);
           TextBox_EngineNumber.Text = vehList[0].EngineNumber;
           TextBox_ChasisNumber.Text = vehList[0].ChasisNumber;
           TextBox_Model.Text = vehList[0].Model;
           TextBox_CC.Text = vehList[0].CC;
            
        }

        protected void Btn_InstallmentNumber_Click(object sender, EventArgs e)
        {
            string enginenumber = webDropDown_EngineNumber.SelectedItem.ToString();
            TextBox_Installments.Text = InstallmentManager.getInstallmentNo(enginenumber).ToString();
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

                lblCreateStatusApplicant.Text = "Applicant Loaded Successfully";
            }
            catch (Exception)
            {
                lblCreateStatusApplicant.Text = "Applicant Not Loaded Successfully";

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

                lblCreateStatusGuarantor.Text = "Guarantor Loaded Successfully";
            }
            catch (Exception)
            {
                lblCreateStatusGuarantor.Text = "Guarantor Not Loaded Successfully";

            }
        }

        protected void Btn_Print_Click(object sender, EventArgs e)
        {
            int printID =Convert.ToInt16( Session["printID"]);
            Response.Redirect("InstallmentReceipt.aspx");
        }

    }
}