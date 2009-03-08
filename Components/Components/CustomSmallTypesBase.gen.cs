using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;

namespace TS.Components
{
    /// <summary>
    /// 业务处理类 CustomSmallTypesBase
    /// </summary>
    public partial class CustomSmallTypesBase
    {
        
        public static CustomSmallType CreateInstance(bool isInitDefaultValue)
        {
            CustomSmallType model = new CustomSmallType();

            if (isInitDefaultValue)
            {
				model.CustomSmallTypeId = Guid.NewGuid();
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
            return dp.GetCustomSmallTypeData(null);
        }

        public static DataTable GetData(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetCustomSmallTypeData(queryInfo);
        }
        
        public static List<CustomSmallType> GetList(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetCustomSmallTypeList(queryInfo);
        }
        
        public static object GetValue(string columnName, Guid customSmallTypeId)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetValue("CustomSmallType", columnName, "CustomSmallTypeId", customSmallTypeId, false );
        }
        
        public static CustomSmallType GetModelById(Guid customSmallTypeId)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetCustomSmallTypeById(customSmallTypeId);
        }
        
        public static CustomSmallType GetModel(QueryInfo queryInfo)
        {
            List<CustomSmallType> list = GetList(queryInfo);
            if (list == null || list.Count == 0)
                return null;
            else
                return list[0];
        }
        
        public static bool Update(CustomSmallType customSmallType)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.UpdateCustomSmallType(customSmallType);
        }

        public static bool Add(CustomSmallType customSmallType)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.CreateCustomSmallType(customSmallType);
        }
        
        public static bool Delete(Guid customSmallType)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.DeleteCustomSmallType(customSmallType);
        }
        
        public static int Delete(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.DeleteCustomSmallType(queryInfo);
        }
        
        
    }
}


	