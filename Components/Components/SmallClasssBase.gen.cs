using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;

namespace TS.Components
{
    /// <summary>
    /// 业务处理类 SmallClasssBase
    /// </summary>
    public partial class SmallClasssBase
    {
        
        public static SmallClass CreateInstance(bool isInitDefaultValue)
        {
            SmallClass model = new SmallClass();

            if (isInitDefaultValue)
            {
				model.SmallClassId = Guid.NewGuid();
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
            return dp.GetSmallClassData(null);
        }

        public static DataTable GetData(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetSmallClassData(queryInfo);
        }
        
        public static List<SmallClass> GetList(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetSmallClassList(queryInfo);
        }
        
        public static object GetValue(string columnName, Guid smallClassId)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetValue("SmallClass", columnName, "SmallClassId", smallClassId, false );
        }
        
        public static SmallClass GetModelById(Guid smallClassId)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetSmallClassById(smallClassId);
        }
        
        public static SmallClass GetModel(QueryInfo queryInfo)
        {
            List<SmallClass> list = GetList(queryInfo);
            if (list == null || list.Count == 0)
                return null;
            else
                return list[0];
        }
        
        public static bool Update(SmallClass smallClass)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.UpdateSmallClass(smallClass);
        }

        public static bool Add(SmallClass smallClass)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.CreateSmallClass(smallClass);
        }
        
        public static bool Delete(Guid smallClass)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.DeleteSmallClass(smallClass);
        }
        
        public static int Delete(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.DeleteSmallClass(queryInfo);
        }
        
        
    }
}


	