using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Dynamic;

namespace ShowRoomManagementCenter
{
    public static class SearchHelper
    {
        public static ShowRoomManagementCenter.ShowRoomManagementEntities showroomEntity;

        static SearchHelper()
        {
            showroomEntity = new ShowRoomManagementCenter.ShowRoomManagementEntities();
        }


        //public static List<Buyer> searchByCustomerCNIC(string CNIC)
        //{
        //    try
        //    {
        //        var customerinfo = (from data in showroomEntity.Buyers
        //                            where data.CNIC == CNIC
        //                            select data);

        //        return customerinfo.ToList();
        //    }
        //    catch (Exception)
        //    {

        //        return null;
        //    }
        //}

        public static List<SearchObject> searchByCustomerCNIC(string CNIC)
        {
            try
            {
                var SearchResult = (from cus in showroomEntity.Buyers
                                    join  trans in showroomEntity.Transactions
                                    on cus.CNIC equals trans.BuyerCNIC
                                    join veh in showroomEntity.Vehicles on trans.VehicleID equals veh.Id
                                    where cus.CNIC==CNIC
                                    select new SearchObject 
                                    {
                                        Name = cus.Name,
                                        FatherName=cus.FatherName,
                                        CNIC=cus.CNIC,
                                        PhoneNumber=cus.PhoneNumber,
                                        Address=cus.Address,
                                        CreationDate=cus.CreationDate,
                                        EngineNumber=veh.EngineNumber,
                                        ChasisNumber=veh.ChasisNumber,
                                        Model=veh.Model,
                                        CC=veh.CC,
                                        Price=trans.Price.Value,
                                        AdvanceAmount=trans.AdvanceAmount.Value,
                                        TransactionDate=trans.TransactionDate,
                                        GuarantorCNIC=trans.GuarantorCNIC
                                    }
                                    );

                return SearchResult.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static List<SearchObject> searchByEngineNumber(string enginenumber)
        {
            try
            {
                var SearchResult = (from trans in showroomEntity.Transactions  
                                    join cus in showroomEntity.Buyers
                                    on trans.BuyerCNIC equals cus.CNIC 
                                    join veh in showroomEntity.Vehicles on trans.VehicleID equals veh.Id
                                    where veh.EngineNumber == enginenumber
                                    select new SearchObject
                                    {
                                        Name = cus.Name,
                                        FatherName = cus.FatherName,
                                        CNIC = cus.CNIC,
                                        PhoneNumber = cus.PhoneNumber,
                                        Address = cus.Address,
                                        CreationDate = cus.CreationDate,
                                        EngineNumber = veh.EngineNumber,
                                        ChasisNumber = veh.ChasisNumber,
                                        Model = veh.Model,
                                        CC = veh.CC,
                                        Price = trans.Price.Value,
                                        AdvanceAmount = trans.AdvanceAmount.Value,
                                        TransactionDate = trans.TransactionDate,
                                        GuarantorCNIC = trans.GuarantorCNIC
                                    }
                                    );

                return SearchResult.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static List<SearchObject> searchByChasisNumber(string chasisnumber)
        {
            try
            {
                var SearchResult = (from trans in showroomEntity.Transactions
                                    join cus in showroomEntity.Buyers
                                    on trans.BuyerCNIC equals cus.CNIC 
                                    join veh in showroomEntity.Vehicles on trans.VehicleID equals veh.Id
                                    where veh.ChasisNumber == chasisnumber
                                    select new SearchObject
                                    {
                                        Name = cus.Name,
                                        FatherName = cus.FatherName,
                                        CNIC = cus.CNIC,
                                        PhoneNumber = cus.PhoneNumber,
                                        Address = cus.Address,
                                        CreationDate = cus.CreationDate,
                                        EngineNumber = veh.EngineNumber,
                                        ChasisNumber = veh.ChasisNumber,
                                        Model = veh.Model,
                                        CC = veh.CC,
                                        Price = trans.Price.Value,
                                        AdvanceAmount = trans.AdvanceAmount.Value,
                                        TransactionDate = trans.TransactionDate,
                                        GuarantorCNIC = trans.GuarantorCNIC
                                    }
                                    );

                return SearchResult.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static List<v_SearchOverAll_Showroom> searchByCusCNIC(string CNIC)
        {
            try
            {
                var SearchResult = (from search in showroomEntity.v_SearchOverAll_Showroom
                                    where search.BuyerCNIC==CNIC
                                    select search
                                    );

                return SearchResult.ToList<v_SearchOverAll_Showroom>();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static List<v_SearchOverAll_Showroom> searchDynamically(string whereclause,List<string> list)
        {
            try
            {
                var SearchResult = showroomEntity.v_SearchOverAll_Showroom
                                     .Where(whereclause, list[0], list[1], list[2], list[3], list[4], list[5], list[6], list[7], list[8], list[9], list[10], list[11], list[12]);

                return SearchResult.ToList<v_SearchOverAll_Showroom>();
            }
            catch (Exception Exp)
            {

                return null;
            }
        }
    }
}