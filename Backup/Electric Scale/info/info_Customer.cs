using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Electric_Scale.cls;
using Electric_Scale.func;

namespace Electric_Scale.info
{
    class info_Customer
    {
        public DataTable GetAllCustomer()
        {
            string sSQL = "";
            sSQL += "Exec sp_GetAllCustomer ";
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }

        public DataTable GetCustomerByID(string sCustomerID)
        {
            string sSQL = "";
            sSQL += "Exec sp_GetCustomerByID ";
            sSQL += cls_GlobalUtil.SQLString(sCustomerID);
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }

        public DataTable GetInfoCustomer()
        {
            string sSQL = "";
            sSQL += "Exec sp_GetInfoCustomer ";
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }

        public string SQLInsertCustomer(cls_Customer customer)
        {
            string sSQL = "";
            sSQL += "Exec sp_InsertCustomer ";
            sSQL += cls_GlobalUtil.SQLString(customer.CustomerID) + cls_GlobalUtil.COMMA;
            sSQL += "N";
            sSQL += cls_GlobalUtil.SQLString(customer.CustomerName) + cls_GlobalUtil.COMMA;
            sSQL += "N";
            sSQL += cls_GlobalUtil.SQLString(customer.Address) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(customer.Email) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(customer.Phone) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(customer.Fax) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(customer.Disabled);

            return sSQL;
        }

        public string SQLEditCustomer(string sCustomerID_Old, cls_Customer customer)
        {
            string sSQL = "";
            sSQL += "Exec sp_EditCustomer ";
            sSQL += cls_GlobalUtil.SQLString(sCustomerID_Old) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(customer.CustomerID) + cls_GlobalUtil.COMMA;
            sSQL += "N";
            sSQL += cls_GlobalUtil.SQLString(customer.CustomerName) + cls_GlobalUtil.COMMA;
            sSQL += "N";
            sSQL += cls_GlobalUtil.SQLString(customer.Address) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(customer.Email) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(customer.Phone) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(customer.Fax) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(customer.Disabled);

            return sSQL;
        }

        public string SQLDeleteCustomerByID(string sCustomerID)
        {
            string sSQL = "";
            sSQL += "Exec sp_DeleteCustomerByID ";
            sSQL += cls_GlobalUtil.SQLString(sCustomerID);

            return sSQL;
        }
    }
}
