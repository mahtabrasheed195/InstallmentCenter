using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShowRoomManagementCenter
{
    public static class PrintHelper
    {
         public static ShowRoomManagementCenter.ShowRoomManagementEntities showroomEntity;

         static PrintHelper()
         {
             showroomEntity = new ShowRoomManagementCenter.ShowRoomManagementEntities(); 
         }

         public static bool addPrint(string enginenumber, int installmentNo)
         {
             try
             {
                 int vehicleid = ShowRoomHelper.getVehicleID(enginenumber);
                 int transactionid = ShowRoomHelper.getTransactionID(vehicleid);
                 string customerCNIC = ShowRoomHelper.getCustomerCNIC(transactionid);
                 Buyer customer = ShowRoomHelper.getCustomerInformationSingle(customerCNIC);
                 Installment installment = InstallmentManager.getInstallmentInformation(transactionid, installmentNo);
                 
                 PrintInstallment print = new PrintInstallment();
                 print.CustomerCNIC = customer.CNIC;
                 print.CustomerName = customer.Name;
                 print.EnginerNumber = enginenumber;
                 print.InstallmentAmountPayed=installment.PayedAmount;
                 print.InstallmentAmountPayable=installment.InstallmentAmount;
                 print.InstallmentNumber=installmentNo;
                 print.Price=InstallmentManager.getVehiclePrice(enginenumber);
                 print.TotalAmountPayedbyInstallment=InstallmentManager.getTotalPayedbyInstallments(enginenumber);
                 print.TotalAmountPayedTill= InstallmentManager.getTotalPayedAmount(enginenumber);
                 print.TotalRemainingAmount=InstallmentManager.getTotalRemainingAmount(enginenumber);
                 print.AdvanceAmount = InstallmentManager.getAdvancePayedAmount(enginenumber);

                 showroomEntity.PrintInstallments.Add(print);
                 showroomEntity.SaveChanges();

                 return true;
             }
             catch (Exception)
             {
                 return false;
             }
             
         }


         public static int getPrintID(string enginenumber, int installmentNo)
         {
             try
             {
                 var print = (from data in showroomEntity.PrintInstallments
                              where data.EnginerNumber == enginenumber && data.InstallmentNumber == installmentNo
                              select data.ID).First();

                 return print;
             }
             catch (Exception)
             {
                 return 0;
             }

         }

         public static PrintInstallment getPrint(int printID )
         {
             try
             {
                 var print=(from data in showroomEntity.PrintInstallments
                            where data.ID==printID
                            select data).First();

                 return print;
             }
             catch (Exception)
             {
                 return null;
             }

         }
    }
}