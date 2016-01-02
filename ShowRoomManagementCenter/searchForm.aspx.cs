using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowRoomManagementCenter
{
    public partial class searchForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
        }
        
        protected void Btn_Search_Click(object sender, EventArgs e)
        {
            string cus_CNIC = TextBox_CustomerCNIC.Text;
            string cus_Name = TextBox_CustomerName.Text;
            string cus_FName = TextBox_CustomerFName.Text;
            string cus_PhNo = TextBox_PhoneNumber.Text;

            string guarantor_CNIC = TextBox_GCNIC.Text;
            string guarantor_Name = TextBox_GName.Text;
            string guarantor_FName = TextBox_GFName.Text;
            string guarantor_PhNo = TextBox_GPhNo.Text;

            string engineNo = TextBox_EngineNumber.Text;
            string chasisNo = TextBox_ChasisNumber.Text;
            string model = TextBox_Model.Text;
            string cc = TextBox_CC.Text;
            string registrationNo = TextBox_RegistrationNo.Text;

            string queryWhereClauseAnd = "";
            string queryWhereClauseOr = "";
            string andStr = " and ";
            string orStr = " or ";

            List<string> listtokens = new List<string>();
            List<string> listcolumns = new List<string>();


            #region Get Criteria Filter 
            //Applicant Filters
            if (!String.IsNullOrWhiteSpace(cus_CNIC))
            {
                queryWhereClauseOr += "CNIC=" + cus_CNIC+ orStr;
                listtokens.Add(cus_CNIC);
                listcolumns.Add("CNIC");
            }
            if (!String.IsNullOrWhiteSpace(cus_Name))
            {
                queryWhereClauseOr += "Name='" + cus_Name + "'" + orStr;
                listtokens.Add(cus_Name);
                listcolumns.Add("Name");
            }

            if (!String.IsNullOrWhiteSpace(cus_FName))
            {
                queryWhereClauseOr += "FatherName='" + cus_FName + "'" + orStr;
                listtokens.Add(cus_FName);
                listcolumns.Add("FatherName");
            }
            if (!String.IsNullOrWhiteSpace(cus_PhNo))
            {
                queryWhereClauseOr += "PhoneNumber='" + cus_PhNo + "'" + orStr;
                listtokens.Add(cus_PhNo);
                listcolumns.Add("PhoneNumber");
            }

            //Guarantor Filters
            if (!String.IsNullOrWhiteSpace(guarantor_CNIC))
            {
                queryWhereClauseOr += "GCNIC='" + guarantor_CNIC + "'" + orStr;
                listtokens.Add(guarantor_CNIC);
                listcolumns.Add("GCNIC");
            }
            if (!String.IsNullOrWhiteSpace(guarantor_Name))
            {
                queryWhereClauseOr += "GName='" + guarantor_Name + "'" + orStr;
                listtokens.Add(guarantor_Name);
                listcolumns.Add("GName");
            }
            if (!String.IsNullOrWhiteSpace(guarantor_FName))
            {
                queryWhereClauseOr += "GFatherName='" + guarantor_FName + "'" + orStr;
                listtokens.Add(guarantor_FName);
                listcolumns.Add("GFatherName");
            }
            if (!String.IsNullOrWhiteSpace(guarantor_PhNo))
            {
                queryWhereClauseOr += "GPhoneNumber='" + guarantor_PhNo + "'" + orStr;
                listtokens.Add(guarantor_PhNo);
                listcolumns.Add("GPhoneNumber");
            }
            //Vehicle Filters
            if (!String.IsNullOrWhiteSpace(engineNo))
            {
                queryWhereClauseOr += "EngineNumber='" + engineNo + "'" + orStr;
                listtokens.Add(engineNo);
                listcolumns.Add("EngineNumber");
            }
            if (!String.IsNullOrWhiteSpace(chasisNo))
            {
                queryWhereClauseOr += "ChasisNumber='" + chasisNo + "'" + orStr;
                listtokens.Add(chasisNo);
                listcolumns.Add("ChasisNumber");
            } 
            if (!String.IsNullOrWhiteSpace(model))
            {
                queryWhereClauseOr += "Model='" + model + "'" + orStr;
                listtokens.Add(model);
                listcolumns.Add("Model");
            } 
            if (!String.IsNullOrWhiteSpace(cc))
            {
                queryWhereClauseOr += "CC='" + cc + "'" + orStr;
                listtokens.Add(cc);
                listcolumns.Add("CC");
            }
            if (!String.IsNullOrWhiteSpace(registrationNo))
            {
                queryWhereClauseOr += "RegistrationNo=" + registrationNo;
                listtokens.Add(registrationNo);
                listcolumns.Add("RegistrationNo");
                    
            }
            #endregion

            string optr=" OR ";

            for (int i = 0; i < radioButtonList.Items.Count; i++)
            {
                if(radioButtonList.Items[i].Selected)
                {
                   optr= " "+ radioButtonList.Items[i].Value + " ";
                }
            }

            string query = "";
            string condition1 = ".Contains(@";
            string condition2 =  ")";
            string operatorSearch = " OR "; //    OR/AND
            //foreach (var item in listtokens)
            //{
            //    query += item + condition;
            //}


            for (int i = 0; i < listcolumns.Count; i++)
            {
                if (!(listcolumns.Count - 1 == i))
                {
                    query += listcolumns[i] + condition1 + i + condition2 + optr;
                }
                else
                {
                    query += listcolumns[i] + condition1 + i + condition2;
                }
            }

            for (int i = listtokens.Count; i < 13; i++)
            {
                listtokens.Add("");
            }
                //webDataGrid_Search.DataSource=   SearchHelper.searchByCusCNIC(cus_CNIC);
                //webDataGrid_Search.DataBind();


                webDataGrid_Search.DataSource = SearchHelper.searchDynamically(query, listtokens);
                webDataGrid_Search.DataBind();
        }

      
    }
}