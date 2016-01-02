using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowRoomManagementCenter
{
    public partial class SaleForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                webDropDown_CustomerCNIC.DataSource = ShowRoomHelper.getCustomerCNICList();
                webDropDown_CustomerCNIC.DataBind();

                webDropDown_GuarantorCNIC.DataSource = ShowRoomHelper.getGuarantorCNICList();
                webDropDown_GuarantorCNIC.DataBind();
            }

        }

        protected void Btn_Create_Click(object sender, EventArgs e)
        {
            string cus_CNIC = TextBox_CustomerCNIC.Text;
            string grntr_CNIC = TextBox_GCNIC.Text;
            string engineno = TextBox_EngineNumber.Text;
            string price = TextBox_Price.Text;
            string advance = TextBox_AdvanceAmount.Text;
          
            if(!ShowRoomHelper.isApplicantExsit(cus_CNIC))
                addCustomer();
            else
                lblCreateStatusApplicant.Text = "Applicant Already Exsit";
            if(!ShowRoomHelper.isGuarantorExsit(grntr_CNIC))
                addGuarantor();
            else
                lblCreateStatusGuarantor.Text = "Guarantor Already Exsit";
            if (!ShowRoomHelper.isVehicleExsit(engineno))
                addVehicle();
            else
                lblCreateStatusVehicle.Text = "Vehicle Already Exsit";

            
            int vehID = ShowRoomHelper.getVehicleID(engineno);

           if( ShowRoomHelper.addTransaction(vehID, cus_CNIC, grntr_CNIC, price,advance, "Auto Generated"))

                lblCreateStatusVehicle.Text =lblCreateStatusVehicle.Text + "----------Transaction Added";
        }

        private void addCustomer()
        {
            string cus_CNIC = TextBox_CustomerCNIC.Text;
            string cus_Name = TextBox_CustomerName.Text;
            string cus_FName = TextBox_CustomerFName.Text;
            string cus_PhoneNumber = TextBox_PhoneNumber.Text;
            string cus_Address = TextBox_Address.Text;

            if (ShowRoomHelper.addApplicant(cus_CNIC, cus_Name, cus_FName, cus_Address, cus_PhoneNumber))
                lblCreateStatusApplicant.Text = "Applicant Added Successfully";
            else
                lblCreateStatusApplicant.Text = "Applicant Not Added Successfully";
        }

        private void addGuarantor()
        {
            string grntr_CNIC = TextBox_GCNIC.Text;
            string grntr_Name = TextBox_GName.Text;
            string grntr_FName = TextBox_GFName.Text;
            string grntr_PhoneNumber = TextBox_GPhoneNumber.Text;
            string grntr_Address = TextBox_GAddress.Text;

         if(   ShowRoomHelper.addGuarantor(grntr_CNIC, grntr_Name, grntr_FName, grntr_Address, grntr_PhoneNumber, "Testing Phase"))
             lblCreateStatusGuarantor.Text = "Guarantor Added Successfully";
         else
             lblCreateStatusGuarantor.Text = "Guarantor Not Added Successfully";

        }

        private void addVehicle()
        {
            string engineno = TextBox_EngineNumber.Text;
            string chasisno = TextBox_ChasisNumber.Text;
            string model = TextBox_Model.Text;
            string cc = TextBox_CC.Text;
            string price = TextBox_Price.Text;
            //string installments = TextBox_Installments.Text;

          if(  ShowRoomHelper.addVehicle(engineno, chasisno,price, model, cc, "Vehicle Testing"))

              lblCreateStatusVehicle.Text = "Vehicle Added Successfully";
          else
              lblCreateStatusVehicle.Text = "Vehicle Not Added Successfully";
        }

        protected void Btn_Installments_Click(object sender, EventArgs e)
        {
            try
            {
                bool tempFlag = false;

                if (CheckBox_Temp.Checked == true)
                    tempFlag = true;
                else
                    tempFlag = false;


                string strPriceCharged = TextBox_Price.Text;
                string strAdvanceAmount = TextBox_AdvanceAmount.Text;
                string noinstallments = TextBox_Installments.Text;
                string installmentAmount = TextBox_InstallmentAmount.Text;

                string engineno = TextBox_EngineNumber.Text;
                int vehID = ShowRoomHelper.getVehicleID(engineno);
               
                double priceCharged = Convert.ToDouble(strPriceCharged);
                double advanceAmount = Convert.ToDouble(strAdvanceAmount);
                double netRemainingAmount = priceCharged - advanceAmount;

                int transactionID = ShowRoomHelper.getTransactionID(vehID);
               

                if (!String.IsNullOrEmpty(noinstallments))
                {
                    if (ShowRoomHelper.generateInstallmentPlan(tempFlag, transactionID, netRemainingAmount.ToString(), noinstallments, DateTime.Now))
                    {
                        if (tempFlag)
                        {
                            webDataGrid_Installments.DataSource = ShowRoomHelper.getTemparoryInstallmentsTable (transactionID);
                            webDataGrid_Installments.DataBind();
                        }
                        else
                        {
                            webDataGrid_Installments.DataSource = ShowRoomHelper.getInstallmentsTable(transactionID);
                            webDataGrid_Installments.DataBind();
                        }
                    }
                }
                if (!String.IsNullOrEmpty(installmentAmount))
                {
                    if (ShowRoomHelper.generateInstallmentPlanbyInstallmentAmount(tempFlag, transactionID, netRemainingAmount.ToString(), installmentAmount, DateTime.Now))
                    {
                        if (tempFlag)
                        {
                            webDataGrid_Installments.DataSource = ShowRoomHelper.getTemparoryInstallmentsTable(transactionID);
                            webDataGrid_Installments.DataBind();
                        }
                        else
                        {
                            webDataGrid_Installments.DataSource = ShowRoomHelper.getInstallmentsTable(transactionID);
                            webDataGrid_Installments.DataBind();
                        }
                    }
                }

            }
            catch (Exception)
            {

                lblCreateStatusVehicle.Text = "Some Error Occured in Application";
            }

        }

        protected void webDropDown_CustomerCNIC_SelectionChanged(object sender, Infragistics.Web.UI.ListControls.DropDownSelectionChangedEventArgs e)
        {
            try
            {
                string cnic = webDropDown_CustomerCNIC.SelectedItem.ToString();

                fillCustomer(ShowRoomHelper.getCustomerInformation(cnic));
            }
            catch (Exception)
            {
                
                
            }
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

        protected void webDropDown_GuarantorCNIC_SelectionChanged(object sender, Infragistics.Web.UI.ListControls.DropDownSelectionChangedEventArgs e)
        {
            try
            {
                string cnic = webDropDown_GuarantorCNIC.SelectedItem.ToString();

                fillGuarantor(ShowRoomHelper.getGuarantorInformation(cnic));
            }
            catch (Exception)
            {

              
            }
        }

    }
}