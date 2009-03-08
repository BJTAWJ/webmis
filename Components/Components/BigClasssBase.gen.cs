using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;

namespace TS.Components
{
    /// <summary>
    /// 业务处理类 BigClasssBase
    /// </summary>
    public partial class BigClasssBase
    {
        
        public static BigClass CreateInstance(bool isInitDefaultValue)
        {
            BigClass model = new BigClass();

            if (isInitDefaultValue)
            {
				model.BigClassId = Guid.NewGuid();
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
            return dp.GetBigClassData(null);
        }

        public static DataTable GetData(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetBigClassData(queryInfo);
        }
        
        public static List<BigClass> GetList(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetBigClassList(queryInfo);
        }
        
        public static object GetValue(string columnName, Guid bigClassId)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetValue("BigClass", columnName, "BigClassId", bigClassId, false );
        }
        
        public static BigClass GetModelById(Guid bigClassId)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetBigClassById(bigClassId);
        }
        
        public static BigClass GetModel(QueryInfo queryInfo)
        {
            List<BigClass> list = GetList(queryInfo);
            if (list == null || list.Count == 0)
                return null;
            else
                return list[0];
        }
        
        public static bool Update(BigClass bigClass)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.UpdateBigClass(bigClass);
        }

        public static bool Add(BigClass bigClass)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.CreateBigClass(bigClass);
        }
        
        public static bool Delete(Guid bigClass)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.DeleteBigClass(bigClass);
        }
        
        public static int Delete(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.DeleteBigClass(queryInfo);
        }
        
        
    }
}


	