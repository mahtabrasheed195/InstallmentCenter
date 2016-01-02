using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ShowRoomManagementCenter
{
    public partial class sellmotorcycle : System.Web.UI.Page
    {
        protected int NumberOfInstallments
        {
            get { return (int)ViewState["NumberOfInstallments"]; }
            set { ViewState["NumberOfInstallments"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            lblSaveInstallmentStatus.Text = "";
            if (!IsPostBack)
            {
                webDropDown_CustomerCNIC.DataSource = ShowRoomHelper.getCustomerCNICList();
                webDropDown_CustomerCNIC.DataBind();

                webDropDown_GuarantorCNIC.DataSource = ShowRoomHelper.getGuarantorCNICList();
                webDropDown_GuarantorCNIC.DataBind();
            }

            if (!Page.IsPostBack)
                //Initiate the counter of dynamically added controls
                this.NumberOfInstallments = 0;
            else
                //Controls must be repeatedly be created on postback
                this.createPostBackInstallments();
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
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol2 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol3 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol4 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol5 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol6 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol7 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol8 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol9 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol10 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            Label lblInstallmentNo = new Label();
            TextBox txtInstallmentNo = new TextBox();

            lblInstallmentNo.ID = "lblInstallmentNo_" + instNo.ToString();
            txtInstallmentNo.ID = "txtInstallmentNo_" + instNo.ToString();

            lblInstallmentNo.Text = "Install. No";
            txtInstallmentNo.Text = (NumberOfInstallments + 1).ToString();

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


            //Label lblInstallmentMonth = new Label();
            //TextBox txtInstallmentMonth = new TextBox();
            ////DropDownList ddlInstallmentMonth = new DropDownList();

            ////ddlInstallmentMonth.ID = "ddlInstallmentMonth_" + instNo.ToString();
            //lblInstallmentMonth.ID = "lblInstallmentMonth_" + instNo.ToString();
            //txtInstallmentMonth.ID = "txtInstallmentMonth_" + instNo.ToString();


            ////ddlInstallmentMonth.DataSource = getMonths();
            ////ddlInstallmentMonth.DataBind();
            ////ddlInstallmentMonth.SelectedIndex = 1;

            //lblInstallmentMonth.Text = "Month";

            //divCol5.Controls.Add(lblInstallmentMonth);
            //divCol6.Controls.Add(txtInstallmentMonth);



            //Label lblInstallmentYear = new Label();
            //TextBox txtInstallmentYear = new TextBox();
            ////DropDownList ddlInstallmentYear = new DropDownList();

            ////ddlInstallmentMonth.ID = "ddlInstallmentYear_" + instNo.ToString();
            //lblInstallmentYear.ID = "lblInstallmentYear_" + instNo.ToString();
            //txtInstallmentYear.ID = "txtInstallmentYear_" + instNo.ToString();

            ////ddlInstallmentYear.DataSource = getYears();
            ////ddlInstallmentYear.DataBind();
            ////ddlInstallmentYear.SelectedIndex = 1;

            //lblInstallmentYear.Text = "Year";

            //divCol7.Controls.Add(lblInstallmentYear);
            //divCol8.Controls.Add(txtInstallmentYear);



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
            //divRow.Controls.Add(divCol5);
            //divRow.Controls.Add(divCol6);
            //divRow.Controls.Add(divCol7);
            //divRow.Controls.Add(divCol8);
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
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol2 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol3 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol4 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol5 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol6 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol7 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol8 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol9 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            HtmlGenericControl divCol10 = new HtmlGenericControl();
            divCol1.Attributes["class"] = "col-md-1";
            divCol1.TagName = "div";

            Label lblInstallmentNo = new Label();
            TextBox txtInstallmentNo = new TextBox();

            lblInstallmentNo.ID = "lblInstallmentNo_" + NumberOfInstallments.ToString();
            txtInstallmentNo.ID = "txtInstallmentNo_" + NumberOfInstallments.ToString();

            lblInstallmentNo.Text = "Install. No";
            txtInstallmentNo.Text = (NumberOfInstallments + 1).ToString();

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


            //Label lblInstallmentMonth = new Label();
            //TextBox txtInstallmentMonth = new TextBox();
            ////DropDownList ddlInstallmentMonth = new DropDownList();

            ////ddlInstallmentMonth.ID = "ddlInstallmentMonth_" + instNo.ToString();
            //lblInstallmentMonth.ID = "lblInstallmentMonth_" + NumberOfInstallments.ToString();
            //txtInstallmentMonth.ID = "txtInstallmentMonth_" + NumberOfInstallments.ToString();


            ////ddlInstallmentMonth.DataSource = getMonths();
            ////ddlInstallmentMonth.DataBind();
            ////ddlInstallmentMonth.SelectedIndex = 1;

            //lblInstallmentMonth.Text = "Month";

            //divCol5.Controls.Add(lblInstallmentMonth);
            //divCol6.Controls.Add(txtInstallmentMonth);



            //Label lblInstallmentYear = new Label();
            //TextBox txtInstallmentYear = new TextBox();
            ////DropDownList ddlInstallmentYear = new DropDownList();

            ////ddlInstallmentMonth.ID = "ddlInstallmentYear_" + instNo.ToString();
            //lblInstallmentYear.ID = "lblInstallmentYear_" + NumberOfInstallments.ToString();
            //txtInstallmentYear.ID = "txtInstallmentYear_" + NumberOfInstallments.ToString();

            ////ddlInstallmentYear.DataSource = getYears();
            ////ddlInstallmentYear.DataBind();
            ////ddlInstallmentYear.SelectedIndex = 1;

            //lblInstallmentYear.Text = "Year";

            //divCol7.Controls.Add(lblInstallmentYear);
            //divCol8.Controls.Add(txtInstallmentYear);





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

                decimal tempSum=0;

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

          if(  ShowRoomHelper.addVehicle(engineno, chasisno,price, model, cc,"", "Vehicle Testing"))

              lblCreateStatusVehicle.Text = "Vehicle Added Successfully";
          else
              lblCreateStatusVehicle.Text = "Vehicle Not Added Successfully";
        }

        protected void Btn_Installments_Click(object sender, EventArgs e)
        {
            try
            {
                bool tempFlag = false;

                //if (CheckBox_Temp.Checked == true)
                //    tempFlag = true;
                //else
                //    tempFlag = false;


                string strPriceCharged = TextBox_Price.Text;
                string strAdvanceAmount = TextBox_AdvanceAmount.Text;
                //string noinstallments = TextBox_Installments.Text;
                //string installmentAmount = TextBox_InstallmentAmount.Text;

                string engineno = TextBox_EngineNumber.Text;
                int vehID = ShowRoomHelper.getVehicleID(engineno);
               
                double priceCharged = Convert.ToDouble(strPriceCharged);
                double advanceAmount = Convert.ToDouble(strAdvanceAmount);
                double netRemainingAmount = priceCharged - advanceAmount;

                int transactionID = ShowRoomHelper.getTransactionID(vehID);
               

                //if (!String.IsNullOrEmpty(noinstallments))
                //{
                //    if (ShowRoomHelper.generateInstallmentPlan(tempFlag, transactionID, netRemainingAmount.ToString(), noinstallments, DateTime.Now))
                //    {
                //        if (tempFlag)
                //        {
                //            webDataGrid_Installments.DataSource = ShowRoomHelper.getTemparoryInstallmentsTable (transactionID);
                //            webDataGrid_Installments.DataBind();
                //        }
                //        else
                //        {
                //            webDataGrid_Installments.DataSource = ShowRoomHelper.getInstallmentsTable(transactionID);
                //            webDataGrid_Installments.DataBind();
                //        }
                //    }
                //}
                //if (!String.IsNullOrEmpty(installmentAmount))
                //{
                //    if (ShowRoomHelper.generateInstallmentPlanbyInstallmentAmount(tempFlag, transactionID, netRemainingAmount.ToString(), installmentAmount, DateTime.Now))
                //    {
                //        if (tempFlag)
                //        {
                //            webDataGrid_Installments.DataSource = ShowRoomHelper.getTemparoryInstallmentsTable(transactionID);
                //            webDataGrid_Installments.DataBind();
                //        }
                //        else
                //        {
                //            webDataGrid_Installments.DataSource = ShowRoomHelper.getInstallmentsTable(transactionID);
                //            webDataGrid_Installments.DataBind();
                //        }
                //    }
                //}

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

        //protected void Btn_CustomInstallments_Click(object sender, EventArgs e)
        //{


        //}

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


                string engineno = TextBox_EngineNumber.Text;
                int vehID = ShowRoomHelper.getVehicleID(engineno);


                int localTransactionID = ShowRoomHelper.getTransactionID(vehID);

                if (true)
                {
                    if (saveInstallments(instaList, localTransactionID))
                    {
                        lblSaveInstallmentStatus.Text = "Sucessfully Saved";
                    }
                    else
                    {
                        lblSaveInstallmentStatus.Text = "Sucessfully Not Saved!!!!!!";
                    }
                }
                else
                {
                    lblSaveInstallmentStatus.Text = "Amount exceeded!!!!!!";
                }
            }
            catch (Exception)
            {
                
                throw;
            }


        }

        private bool saveInstallments(List<InstallmentDataObject> listInsta,int transId)
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

     }
    
}