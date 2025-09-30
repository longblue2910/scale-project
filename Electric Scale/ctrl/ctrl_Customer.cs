using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Electric_Scale.info;
using Electric_Scale.cls;

namespace Electric_Scale.ctrl
{
    class ctrl_Customer
    {
        private readonly info_Customer infoCus = new info_Customer();

        public DataTable GetAllCustomer()
        { 
            return infoCus.GetAllCustomer();
        }

        public DataTable GetCustomerByID(string sCustomerID)
        {
            return infoCus.GetCustomerByID(sCustomerID);        
        }

        /// <summary>
        /// Return info of all customers
        /// </summary>
        /// <returns></returns>
        public DataTable GetInfoCustomer()
        {
            return infoCus.GetInfoCustomer();
        }
        
        public string SQLInsertCustomer(cls_Customer customer)
        {
            return infoCus.SQLInsertCustomer(customer);    
        }

        public string SQLEditCustomer(string sCustomerID_Old, cls_Customer customer)
        {
            return infoCus.SQLEditCustomer(sCustomerID_Old, customer);
        }

        public string SQLDeleteCustomerByID(string sCustomerID)
        {
            return infoCus.SQLDeleteCustomerByID(sCustomerID);
        }
    }
}
