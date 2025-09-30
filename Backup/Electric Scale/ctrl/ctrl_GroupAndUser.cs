using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Electric_Scale.info;
using Electric_Scale.cls;

namespace Electric_Scale.ctrl
{
    class ctrl_GroupAndUser
    {
        private readonly info_GroupAndUser infoGaU = new info_GroupAndUser();

        /// <summary>
        /// Get all group
        /// </summary>
        /// <returns>List of groups</returns>
        public DataTable GetAllGroup()
        {
            return infoGaU.GetAllGroup();    
        }

        /// <summary>
        /// Get info group base on GroupID
        /// </summary>
        /// <param name="iGroupID"></param>
        /// <returns></returns>
        public DataTable GetInfoGroupByID(int iGroupID)
        {
            return infoGaU.GetInfoGroupByID(iGroupID);
        }

        /// <summary>
        /// Get list of groups is used
        /// </summary>
        /// <returns></returns>
        public DataTable GetInfoGroupAvailable()
        {
            return infoGaU.GetInfoGroupAvailable();
        }
        
        /// <summary>
        /// Get forms permission base on GroupID
        /// </summary>
        /// <param name="iGroupID"></param>
        /// <returns>List of form permission base on GroupID</returns>
        public DataTable GetFormPermissionByGroupID(int iGroupID)
        {
            return infoGaU.GetFormPermissionByGroupID(iGroupID);
        }

        /// <summary>
        /// Get List of form permission default
        /// </summary>
        /// <returns></returns>
        public DataTable GetFormPermissionDefault()
        {
            return infoGaU.GetFormPermissionDefault();
        }

        /// <summary>
        /// Get SQL string to delete UserGroup base on GroupID
        /// </summary>
        /// <param name="sGroupID"></param>
        /// <returns></returns>
        public string SQLDeleteUserGroupByID(int sGroupID)
        {
            return infoGaU.SQLDeleteUserGroupByID(sGroupID);
        }
    }
}
