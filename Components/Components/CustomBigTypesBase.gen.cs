using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;

namespace TS.Components
{
    /// <summary>
    /// 业务处理类 CustomBigTypesBase
    /// </summary>
    public partial class CustomBigTypesBase
    {
        
        public static CustomBigType CreateInstance(bool isInitDefaultValue)
        {
            CustomBigType model = new CustomBigType();

            if (isInitDefaultValue)
            {
				model.CustomBigTypeId = Guid.NewGuid();
            }
            return model;
        }
    
        /// <summary>
        /// 获得所有数据
        /// </summary>
        /// <returns></returns>
        public static DataTable GetData()
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetCustomBigTypeData(null);
        }

        public static DataTable GetData(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetCustomBigTypeData(queryInfo);
        }
        
        public static List<CustomBigType> GetList(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetCustomBigTypeList(queryInfo);
        }
        
        public static object GetValue(string columnName, Guid customBigTypeId)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetValue("CustomBigType", columnName, "CustomBigTypeId", customBigTypeId, false );
        }
        
        public static CustomBigType GetModelById(Guid customBigTypeId)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetCustomBigTypeById(customBigTypeId);
        }
        
        public static CustomBigType GetModel(QueryInfo queryInfo)
        {
            List<CustomBigType> list = GetList(queryInfo);
            if (list == null || list.Count == 0)
                return null;
            else
                return list[0];
        }
        
        public static bool Update(CustomBigType customBigType)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.UpdateCustomBigType(customBigType);
        }

        public static bool Add(CustomBigType customBigType)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.CreateCustomBigType(customBigType);
        }
        
        public static bool Delete(Guid customBigType)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.DeleteCustomBigType(customBigType);
        }
        
        public static int Delete(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.DeleteCustomBigType(queryInfo);
        }
        
        
    }
}


	