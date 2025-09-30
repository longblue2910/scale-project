using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Electric_Scale.func;
using Electric_Scale.cls;


namespace Electric_Scale.info
{
    class info_Product
    {
        public DataTable GetAllProduct()
        {
            string sSQL = "";
            sSQL += "Exec sp_GetAllProduct ";
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }

        public DataTable GetProductByID(string ProductID)
        {
            string sSQL = "";
            sSQL += "Exec sp_GetProductByID ";
            sSQL += cls_GlobalUtil.SQLString(ProductID);
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }

        public DataTable GetInfoProduct()
        {
            string sSQL = "";
            sSQL += "Exec sp_GetInfoProduct ";
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }

        public string SQLInsertProduct(cls_Product product)
        {
            string sSQL = "";
            sSQL += "Exec sp_InsertProduct ";
            sSQL += cls_GlobalUtil.SQLString(product.ProductID) + cls_GlobalUtil.COMMA;
            sSQL += "N"; 
            sSQL += cls_GlobalUtil.SQLString(product.ProductName) + cls_GlobalUtil.COMMA;
            sSQL += "N"; 
            sSQL += cls_GlobalUtil.SQLString(product.Description) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(product.Disabled);

            return sSQL;            
        }

        public string SQLEditProduct(string sProductID_Old, cls_Product product)
        {
            string sSQL = "";
            sSQL += "Exec sp_EditProduct ";
            sSQL += cls_GlobalUtil.SQLString(sProductID_Old) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(product.ProductID) + cls_GlobalUtil.COMMA;
            sSQL += "N"; 
            sSQL += cls_GlobalUtil.SQLString(product.ProductName) + cls_GlobalUtil.COMMA;
            sSQL += "N"; 
            sSQL += cls_GlobalUtil.SQLString(product.Description) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(product.Disabled);

            return sSQL;
        }

        public string SQLDeleteProductByID(string sProductID)
        {
            string sSQL = "";
            sSQL += "Exec sp_DeleteProductByID ";
            sSQL += cls_GlobalUtil.SQLString(sProductID);            

            return sSQL;
        }
    }
}
