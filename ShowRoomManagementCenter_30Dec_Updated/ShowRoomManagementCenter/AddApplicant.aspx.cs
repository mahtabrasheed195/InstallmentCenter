using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowRoomManagementCenter
{
    public partial class AddApplicant : System.Web.UI.Page
    {


        protected bool isSuccess
        {
            get { return (bool)ViewState["isSuccess"]; }
            set { ViewState["isSuccess"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            lblSuccess.Visible = false;
            lblStatus.Visible = false;
            

            Btn_Next.Visible = false;

            if (!IsPostBack)
            {
                isSuccess = false;
                webDropDown_CustomerCNIC.DataSource = ShowRoomHelper.getCustomerCNICList();
                webDropDown_CustomerCNIC.DataBind();
            }
        }

        protected void Btn_AddApplicant_Click(object sender, EventArgs e)
        {
            addCustomer();
        }

        protected void Btn_Reset_Click(object sender, EventArgs e)
        {

        }

        private void addCustomer()
        {
            string cus_CNIC = TextBox_CustomerCNIC.Text;
            string cus_Name = TextBox_CustomerName.Text;
            string cus_FName = TextBox_CustomerFName.Text;
            string cus_PhoneNumber = TextBox_PhoneNumber.Text;
            string cus_Address = TextBox_Address.Text;

            if (!ShowRoomHelper.isCNICBlackListed(cus_CNIC))
            {
                if (!ShowRoomHelper.isApplicantExsit(cus_CNIC))
                {
                    if (ShowRoomHelper.addApplicant(cus_CNIC, cus_Name, cus_FName, cus_Address, cus_PhoneNumber))
                    {
                        lblSuccess.Text = "Applicant Added Successfully For Transaction";
                        lblSuccess.Visible = true;
                        isSuccess = true;
                        Btn_Next.Visible = true;
                        Session["s_ApplicantCNIC"] = cus_CNIC;
                    }
                    else
                    {
                        lblStatus.Text = "Applicant Not Added Successfully";
                        lblStatus.Visible = true;
                    }
                }
                else
                {
                    Session["s_ApplicantCNIC"] = cus_CNIC;
                    isSuccess = true;
                    Btn_Next.Visible = true;
                    lblSuccess.Text = "Existing Applicant Added Successfully For Transaction";
                    lblSuccess.Visible = true;
                }
            }
            else
            {
                lblStatus.Text = "This Applicant is Black Listed. Kindly check your record. You cannot sell motor cycle to black listed Customer";
                lblStatus.Visible = true;
            }

            
        }


        protected void Btn_Next_Click(object sender, EventArgs e)
        {
            if (isSuccess)
            {
                Response.Redirect("AddGuarantor.aspx");
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

                lblSuccess.Text = "Applicant Loaded Successfully";
                lblSuccess.Visible = true;
            }
            catch (Exception)
            {
                lblStatus.Text = "Applicant Not Loaded Successfully";
                lblStatus.Visible = true;
            }
        }
    }
}