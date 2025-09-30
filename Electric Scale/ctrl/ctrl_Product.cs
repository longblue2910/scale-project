using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Electric_Scale.info;
using Electric_Scale.cls;

namespace Electric_Scale.ctrl
{
    class ctrl_Product
    {
        private readonly info_Product infoPro = new info_Product();
        public DataTable GetAllProduct()
        {
            return infoPro.GetAllProduct();
        }

        /// <summary>
        /// Get product by ID
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        public DataTable GetProductByID(string ProductID)
        {
            return infoPro.GetProductByID(ProductID);
        }

        /// <summary>
        /// Get info of all products
        /// </summary>
        /// <returns></returns>
        public DataTable GetInfoProduct()
        {
            return infoPro.GetInfoProduct();
        }

        /// <summary>
        /// Return SQL string to insert data to product table
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public string SQLInsertProduct(cls_Product product)
        {
            return infoPro.SQLInsertProduct(product);
        }

        public string SQLEditProduct(string sProductID_Old,cls_Product product)
        { 
            return infoPro.SQLEditProduct(sProductID_Old, product);
        }

        public string SQLDeleteProductByID(string sProductID)
        {
            return infoPro.SQLDeleteProductByID(sProductID);
        }
    }
}
