using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ShowRoomManagementCenter
{
    public partial class AddInstallmentPlan : System.Web.UI.Page
    {
        private string ApplicantCNIC = "";
        private string GuarantorCNIC = "";
        private string EngineNo = "";
        private int TransactionID = -1;
        private string TotalPrice = "";
        private string AdvanceAmount = "";

        private bool isSuccess = false;
        private bool addTrans = true;

        private bool saveFlag = false;

        protected void Page_Load(object sender, EventArgs e)
        {
           // Btn_PrintPlan.Visible = false;

            if (Session["s_ApplicantCNIC"] != null)
            {
                lblApplicantCNIC.Text = Session["s_ApplicantCNIC"].ToString();
                ApplicantCNIC = Session["s_ApplicantCNIC"].ToString();
            }
            else
            {
                Response.Redirect("AddApplicant.aspx");
                addTrans = false;
            }

            if (Session["s_GuarantorCNIC"] != null)
            {
                lblGuarantorCNIC.Text = Session["s_GuarantorCNIC"].ToString();
                GuarantorCNIC = Session["s_GuarantorCNIC"].ToString();
            }
            else
            {
                Response.Redirect("AddGuarantor.aspx");
                addTrans = false;
            }

            if (Session["s_EngineNo"] != null)
            {
                lblVehicleEngNo.Text = Session["s_EngineNo"].ToString();
                EngineNo = Session["s_EngineNo"].ToString();
            }
            else
            {
                Response.Redirect("AddVehicle.aspx");
                addTrans = false;
            }

            if (Session["s_TransID"] != null)
            {
                lblTransactionID.Text = Session["s_TransID"].ToString();
                TransactionID = Convert.ToInt16( Session["s_TransID"]);

                if (Session["s_Price"] != null && Session["s_AdvanceAmount"] != null)
                {
                    lblPrice.Text = Session["s_Price"].ToString();
                    lblAdvanceAmount.Text = Session["s_AdvanceAmount"].ToString(); 
                }
            }
            else
            {
                Response.Redirect("AddTransaction.aspx");
                addTrans = false;
            }

            if (!Page.IsPostBack)
                //Initiate the counter of dynamically added controls
                this.NumberOfInstallments = 0;
            else
                //Controls must be repeatedly be created on postback
                this.createPostBackInstallments();
        }

        protected int NumberOfInstallments
        {
            get { return (int)ViewState["NumberOfInstallments"]; }
            set { ViewState["NumberOfInstallments"] = value; }
        }

        private void createPostBackInstallments()
        {
            int count = this.NumberOfInstallments;

            for (int i = 0; i < count; i++)
            {
                createInstallmentElements(i);
            }
        }

        private void createInstallmentElements(int instNo)
        {
            HtmlGenericControl divRow = new HtmlGenericControl();
            divRow.Attributes["class"] = "row";
            divRow.TagName = "div";

            HtmlGenericControl divCol1 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-lg-2";
            divCol1.TagName = "div";

            HtmlGenericControl divCol2 = new HtmlGenericControl();
            divCol2.Attributes["class"] = "col-lg-2";
            divCol2.TagName = "div";

            HtmlGenericControl divCol3 = new HtmlGenericControl();
            divCol3.Attributes["class"] = "col-lg-1";
            divCol3.TagName = "div";

            HtmlGenericControl divCol4 = new HtmlGenericControl();
            divCol4.Attributes["class"] = "col-lg-3";
            divCol4.TagName = "div";


            HtmlGenericControl divCol9 = new HtmlGenericControl();
            divCol9.Attributes["class"] = "col-lg-1";
            divCol9.TagName = "div";

            HtmlGenericControl divCol10 = new HtmlGenericControl();
            divCol10.Attributes["class"] = "col-lg-3";
            divCol10.TagName = "div";

            Label lblInstallmentNo = new Label();
            TextBox txtInstallmentNo = new TextBox();

            lblInstallmentNo.ID = "lblInstallmentNo_" + instNo.ToString();
            txtInstallmentNo.ID = "txtInstallmentNo_" + instNo.ToString();

            lblInstallmentNo.Text = "Install. No";
            txtInstallmentNo.Text = (instNo + 1).ToString();
            txtInstallmentNo.ReadOnly = true;

            divCol1.Controls.Add(lblInstallmentNo);
            divCol2.Controls.Add(txtInstallmentNo);

            Label lblInstallmentAmount = new Label();
            TextBox txtInstallmentAmount = new TextBox();
            RequiredFieldValidator rfvAmount = new RequiredFieldValidator();
            rfvAmount.ID = "rfvAmount_" + instNo.ToString();
            rfvAmount.ControlToValidate = "txtInstallmentAmount_" + instNo.ToString();
            rfvAmount.ErrorMessage = "Please Enter Amount";
            //rfvAmount.CssClass = "";


            RangeValidator rangeAmount = new RangeValidator();
            rangeAmount.ID = "rangeAmount_" + instNo.ToString();
            rangeAmount.ControlToValidate = "txtInstallmentAmount_" + instNo.ToString();
            rangeAmount.ErrorMessage = "Amount Not Correct";
            rangeAmount.Type = ValidationDataType.Currency;
            rangeAmount.MaximumValue = "1000000";
            rangeAmount.MinimumValue = "0";


            lblInstallmentAmount.ID = "lblInstallmentAmount_" + instNo.ToString();
            txtInstallmentAmount.ID = "txtInstallmentAmount_" + instNo.ToString();

            lblInstallmentAmount.Text = "Installment Amount";

            divCol3.Controls.Add(lblInstallmentAmount);
            divCol4.Controls.Add(txtInstallmentAmount);
            divCol4.Controls.Add(rfvAmount);
            divCol4.Controls.Add(rangeAmount);




            Label lblInstallmentDueDate = new Label();
            TextBox txtInstallmentDueDate = new TextBox();

            RangeValidator rangeDueDate = new RangeValidator();
            rangeDueDate.ID = "rangeDueDate_" + instNo.ToString();
            rangeDueDate.ControlToValidate = "DTPInstallmentDueDate_" + instNo.ToString();
            rangeDueDate.ErrorMessage = "Due Date Required";
            rangeDueDate.Type = ValidationDataType.Date;
            rangeDueDate.MaximumValue = "9999/12/28";
            rangeDueDate.MinimumValue = "1000/12/28";


            RequiredFieldValidator rfqValidator = new RequiredFieldValidator();

            rfqValidator.ID = "rfqValidator_" + instNo.ToString();
            rfqValidator.ErrorMessage = "Please enter the due date";
            rfqValidator.ControlToValidate = "DTPInstallmentDueDate_" + instNo.ToString();


            Infragistics.Web.UI.EditorControls.WebDatePicker dtpick = new Infragistics.Web.UI.EditorControls.WebDatePicker();

            dtpick.ID = "DTPInstallmentDueDate_" + instNo.ToString();
            lblInstallmentDueDate.ID = "lblInstallmentDueDate_" + instNo.ToString();
            txtInstallmentDueDate.ID = "txtInstallmentDueDate_" + instNo.ToString();

            lblInstallmentDueDate.Text = "Due Date";

            divCol9.Controls.Add(lblInstallmentDueDate);
            divCol10.Controls.Add(dtpick);
            divCol10.Controls.Add(rfqValidator);

            divRow.Controls.Add(divCol1);
            divRow.Controls.Add(divCol2);
            divRow.Controls.Add(divCol3);
            divRow.Controls.Add(divCol4);

            divRow.Controls.Add(divCol9);
            divRow.Controls.Add(divCol10);

            placeHolderInstallment.Controls.Add(divRow);

        }

        private void createInstallmentElements()
        {
            HtmlGenericControl divRow = new HtmlGenericControl();
            divRow.Attributes["class"] = "row";
            divRow.TagName = "div";

            HtmlGenericControl divCol1 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-lg-2";
            divCol1.TagName = "div";

            HtmlGenericControl divCol2 = new HtmlGenericControl();
            divCol2.Attributes["class"] = "col-lg-2";
            divCol2.TagName = "div";

            HtmlGenericControl divCol3 = new HtmlGenericControl();
            divCol3.Attributes["class"] = "col-lg-1";
            divCol3.TagName = "div";

            HtmlGenericControl divCol4 = new HtmlGenericControl();
            divCol4.Attributes["class"] = "col-lg-3";
            divCol4.TagName = "div";


            HtmlGenericControl divCol9 = new HtmlGenericControl();
            divCol9.Attributes["class"] = "col-lg-1";
            divCol9.TagName = "div";

            HtmlGenericControl divCol10 = new HtmlGenericControl();
            divCol10.Attributes["class"] = "col-lg-3";
            divCol10.TagName = "div";

            Label lblInstallmentNo = new Label();
            TextBox txtInstallmentNo = new TextBox();

            lblInstallmentNo.ID = "lblInstallmentNo_" + NumberOfInstallments.ToString();
            txtInstallmentNo.ID = "txtInstallmentNo_" + NumberOfInstallments.ToString();

            lblInstallmentNo.Text = "Install. No";
            txtInstallmentNo.Text = (NumberOfInstallments + 1).ToString();
            txtInstallmentNo.ReadOnly = true;

            divCol1.Controls.Add(lblInstallmentNo);
            divCol2.Controls.Add(txtInstallmentNo);

            Label lblInstallmentAmount = new Label();
            TextBox txtInstallmentAmount = new TextBox();

            RequiredFieldValidator rfvAmount = new RequiredFieldValidator();
            rfvAmount.ID = "rfvAmount_" + NumberOfInstallments.ToString();
            rfvAmount.ControlToValidate = "txtInstallmentAmount_" + NumberOfInstallments.ToString();
            rfvAmount.ErrorMessage = "Please Enter Amount";

            RangeValidator rangeAmount = new RangeValidator();
            rangeAmount.ID = "rangeAmount_" + NumberOfInstallments.ToString();
            rangeAmount.ControlToValidate = "txtInstallmentAmount_" + NumberOfInstallments.ToString();
            rangeAmount.ErrorMessage = "Amount Not Correct";
            rangeAmount.Type = ValidationDataType.Currency;
            rangeAmount.MaximumValue = "1000000";
            rangeAmount.MinimumValue = "0";


            lblInstallmentAmount.ID = "lblInstallmentAmount_" + NumberOfInstallments.ToString();
            txtInstallmentAmount.ID = "txtInstallmentAmount_" + NumberOfInstallments.ToString();

            lblInstallmentAmount.Text = "Installment Amount";

            divCol3.Controls.Add(lblInstallmentAmount);
            divCol4.Controls.Add(txtInstallmentAmount);
            divCol4.Controls.Add(rfvAmount);
            divCol4.Controls.Add(rangeAmount);

            Label lblInstallmentDueDate = new Label();
            TextBox txtInstallmentDueDate = new TextBox();

            RangeValidator rangeDueDate = new RangeValidator();
            rangeDueDate.ID = "rangeDueDate_" + NumberOfInstallments.ToString();
            rangeDueDate.ControlToValidate = "DTPInstallmentDueDate_" + NumberOfInstallments.ToString();
            rangeDueDate.ErrorMessage = "Due Date Required";
            rangeDueDate.Type = ValidationDataType.Date;
            rangeDueDate.MaximumValue = "9999/12/28";
            rangeDueDate.MinimumValue = "1000/12/28";


            RequiredFieldValidator rfqValidator = new RequiredFieldValidator();

            rfqValidator.ID = "rfqValidator_" + NumberOfInstallments.ToString();
            rfqValidator.ErrorMessage = "Please enter the due date";
            rfqValidator.ControlToValidate = "DTPInstallmentDueDate_" + NumberOfInstallments.ToString();

            Infragistics.Web.UI.EditorControls.WebDatePicker dtpick = new Infragistics.Web.UI.EditorControls.WebDatePicker();
            dtpick.ID = "DTPInstallmentDueDate_" + NumberOfInstallments.ToString();

            lblInstallmentDueDate.ID = "lblInstallmentDueDate_" + NumberOfInstallments.ToString();
            txtInstallmentDueDate.ID = "txtInstallmentDueDate_" + NumberOfInstallments.ToString();

            lblInstallmentDueDate.Text = "Due Date";

            divCol9.Controls.Add(lblInstallmentDueDate);
            divCol10.Controls.Add(dtpick);
            divCol10.Controls.Add(rfqValidator);

            divRow.Controls.Add(divCol1);
            divRow.Controls.Add(divCol2);
            divRow.Controls.Add(divCol3);
            divRow.Controls.Add(divCol4);
            //divRow.Controls.Add(divCol5);
            //divRow.Controls.Add(divCol6);
            //divRow.Controls.Add(divCol7);
            //divRow.Controls.Add(divCol8);
            divRow.Controls.Add(divCol9);
            divRow.Controls.Add(divCol10);

            placeHolderInstallment.Controls.Add(divRow);

            NumberOfInstallments++;

        }

        private List<InstallmentDataObject> getInstallmentList()
        {
            List<InstallmentDataObject> listInst = new List<InstallmentDataObject>();

            int count = this.NumberOfInstallments;

            for (int i = 0; i < count; i++)
            {
                listInst.Add(getInstallmentValue(i));
            }

            return listInst;
        }

        private decimal getTotalInstallmentAmount()
        {
            try
            {
                List<InstallmentDataObject> listInsta = getInstallmentList();

                decimal tempSum = 0;

                foreach (var item in listInsta)
                {
                    tempSum += item.InstallmentAmount;
                }


                return tempSum;
            }
            catch (Exception)
            {

                return 1;
            }
        }

        private InstallmentDataObject getInstallmentValue(int number)
        {
            string instNoValID = "ctl00$ContentPlaceHolder1$txtInstallmentNo_" + number;
            string instAmountValID = "ctl00$ContentPlaceHolder1$txtInstallmentAmount_" + number;
            string instMonthValID = "ctl00$ContentPlaceHolder1$txtInstallmentMonth_" + number;
            string instYearValID = "ctl00$ContentPlaceHolder1$txtInstallmentYear_" + number;
            string instDueDateValID = "ctl00$ContentPlaceHolder1$DTPInstallmentDueDate_" + number;


            //string instNoValID = "ContentPlaceHolder1_txtInstallmentNo_" + number;
            //string instAmountValID = "ContentPlaceHolder1_txtInstallmentAmount_" + number;
            //string instMonthValID = "ContentPlaceHolder1_ddlInstallmentMonth_" + number;
            //string instYearValID = "ContentPlaceHolder1_ddlInstallmentYear_" + number;
            //string instDueDateValID = "ContentPlaceHolder1_DTPInstallmentDueDate_" + number;


            TextBox txtinstNo = (TextBox)Page.FindControl(instNoValID);
            TextBox txtinstAmount = (TextBox)Page.FindControl(instAmountValID);
            //TextBox ddlinstMonth = (TextBox)Page.FindControl(instMonthValID);
            //DropDownList ddlinstYear = (DropDownList)Page.FindControl(instYearValID);

            //TextBox ddlinstMonth = (TextBox)Page.FindControl(instMonthValID);
            //TextBox ddlinstYear = (TextBox)Page.FindControl(instYearValID);
            Infragistics.Web.UI.EditorControls.WebDatePicker DTPinstDueDate = (Infragistics.Web.UI.EditorControls.WebDatePicker)Page.FindControl(instDueDateValID);

            string instNoValStr = txtinstNo.Text;
            int instNoInt = Int16.Parse(instNoValStr);

            string instAmountValStr = txtinstAmount.Text;
            Decimal instAmountDecimalVal = Decimal.Parse(instAmountValStr);

            //string instMonthValStr = ddlinstMonth.Text;//ddlinstMonth.SelectedItem.ToString();
            //string instYearValStr = ddlinstYear.Text;//ddlinstYear.SelectedItem.ToString();
            DateTime instDueDateDTVal = (DateTime)DTPinstDueDate.Value;

            InstallmentDataObject installmentObj = new InstallmentDataObject();

            installmentObj.InstallmentNo = instNoInt;
            installmentObj.InstallmentAmount = instAmountDecimalVal;
            installmentObj.Month = instDueDateDTVal.Month.ToString();
            installmentObj.Year = instDueDateDTVal.Year.ToString();
            installmentObj.DueDate = instDueDateDTVal;

            return installmentObj;


        }

        private bool saveInstallments(List<InstallmentDataObject> listInsta, int transId)
        {
            try
            {
                foreach (var item in listInsta)
                {
                    int instaNo = item.InstallmentNo;
                    decimal instaAmount = item.InstallmentAmount;
                    string instaMonth = item.Month;
                    string instaYear = item.Year;
                    DateTime instaDueDate = item.DueDate;

                    if (!ShowRoomHelper.createInstallment(transId, instaAmount, instaNo, instaDueDate, instaDueDate, DateTime.Now, instaMonth, instaYear))
                    {
                        return false;
                    }

                }

                return true;
            }
            catch (Exception Exp)
            {

                return false;
            }
        }

        protected void Btn_AddInstallment_Click(object sender, EventArgs e)
        {
            createInstallmentElements();
        }

        protected void Btn_VerifyValues_Click(object sender, EventArgs e)
        {
            lblInstaAmount.Text = getTotalInstallmentAmount().ToString();
            webDataGrid_Installments.DataSource = getInstallmentList();
            webDataGrid_Installments.DataBind();
        }

        protected void Btn_SaveInstallment_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstallmentDataObject> instaList = getInstallmentList();


               
                int vehID = ShowRoomHelper.getVehicleID(EngineNo);


                if (addTrans)
                {
                    if (saveInstallments(instaList, TransactionID))
                    {
                        lblSuccess.Text = "Installments Added Successfully";
                        lblSuccess.Visible = true;
                        saveFlag = true;
                        //Btn_PrintPlan.Visible = true;
                    }
                    else
                    {
                        lblStatus.Text = "Transaction Not Added Successfully";
                        lblStatus.Visible = true;
                    }
                }
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void Btn_Next_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddInstallmentPlan.aspx");
        }

        protected void Btn_PrintPlan_Click(object sender, EventArgs e)
        {

          
                Response.Redirect("InstallmentPlanPrint.aspx?key="+TransactionID);
            

        }
    }
}