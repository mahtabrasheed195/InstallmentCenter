using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowRoomManagementCenter
{
    public partial class AddGuarantor : System.Web.UI.Page
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
            Btn_Next2.Visible = false;

            if (!IsPostBack)
            {
                isSuccess = false;
                webDropDown_GuarantorCNIC.DataSource = ShowRoomHelper.getGuarantorCNICList();
                webDropDown_GuarantorCNIC.DataBind();
            }
        }

        protected void Btn_AddGuarantor_Click(object sender, EventArgs e)
        {
            addGuarantor();
        }

        private void addGuarantor()
        {
            string grntr_CNIC = TextBox_GCNIC.Text;
            string grntr_Name = TextBox_GName.Text;
            string grntr_FName = TextBox_GFName.Text;
            string grntr_PhoneNumber = TextBox_GPhoneNumber.Text;
            string grntr_Address = TextBox_GAddress.Text;
            if (!ShowRoomHelper.isGuarantorExsit(grntr_CNIC))
            {
                if (ShowRoomHelper.addGuarantor(grntr_CNIC, grntr_Name, grntr_FName, grntr_Address, grntr_PhoneNumber, "Testing Phase"))
                {
                    lblSuccess.Text = "Guarantor Added Successfully For Transaction";
                    lblSuccess.Visible = true;
                    isSuccess = true;
                    Btn_Next.Visible = true;
                    Btn_Next2.Visible = true;
                    Session["s_GuarantorCNIC"] = grntr_CNIC;
                }
                else
                {
                    lblStatus.Text = "Guarantor Not Added Successfully";
                    lblStatus.Visible = true;
                }
            }
            else 
            {
                Session["s_GuarantorCNIC"] = grntr_CNIC;
                isSuccess = true;
                Btn_Next.Visible = true;
                Btn_Next2.Visible = true;
                lblSuccess.Text = "Existing Guarantor Added Successfully For Transaction";
                lblSuccess.Visible = true;
            }
        }

        protected void Btn_Reset_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_Next_Click(object sender, EventArgs e)
        {
            if (isSuccess)
            {
                Response.Redirect("AddVehicle.aspx");
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

        private void fillGuarantor(List<Guarantor> buyerList)
        {
            try
            {
                TextBox_GCNIC.Text = buyerList[0].CNIC;
                TextBox_GName.Text = buyerList[0].Name;
                TextBox_GFName.Text = buyerList[0].FatherName;
                TextBox_GPhoneNumber.Text = buyerList[0].PhoneNumber;
                TextBox_GAddress.Text = buyerList[0].Address;

                lblSuccess.Text = "Guarantor Loaded Successfully";
                lblSuccess.Visible = true;
            }
            catch (Exception)
            {
                lblStatus.Text = "Guarantor Not Loaded Successfully";
                lblStatus.Visible = true;
            }
        }
    }
}