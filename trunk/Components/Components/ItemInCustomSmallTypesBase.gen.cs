using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;

namespace TS.Components
{
    /// <summary>
    /// 业务处理类 ItemInCustomSmallTypesBase
    /// </summary>
    public partial class ItemInCustomSmallTypesBase
    {
        
        public static ItemInCustomSmallType CreateInstance(bool isInitDefaultValue)
        {
            ItemInCustomSmallType model = new ItemInCustomSmallType();

            if (isInitDefaultValue)
            {
				model.ItemInCustomSmallTypeId = Guid.NewGuid();
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
            return dp.GetItemInCustomSmallTypeData(null);
        }

        public static DataTable GetData(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetItemInCustomSmallTypeData(queryInfo);
        }
        
        public static List<ItemInCustomSmallType> GetList(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetItemInCustomSmallTypeList(queryInfo);
        }
        
        public static object GetValue(string columnName, Guid itemInCustomSmallTypeId)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetValue("ItemInCustomSmallType", columnName, "ItemInCustomSmallTypeId", itemInCustomSmallTypeId, false );
        }
        
        public static ItemInCustomSmallType GetModelById(Guid itemInCustomSmallTypeId)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetItemInCustomSmallTypeById(itemInCustomSmallTypeId);
        }
        
        public static ItemInCustomSmallType GetModel(QueryInfo queryInfo)
        {
            List<ItemInCustomSmallType> list = GetList(queryInfo);
            if (list == null || list.Count == 0)
                return null;
            else
                return list[0];
        }
        
        public static bool Update(ItemInCustomSmallType itemInCustomSmallType)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.UpdateItemInCustomSmallType(itemInCustomSmallType);
        }

        public static bool Add(ItemInCustomSmallType itemInCustomSmallType)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.CreateItemInCustomSmallType(itemInCustomSmallType);
        }
        
        public static bool Delete(Guid itemInCustomSmallType)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.DeleteItemInCustomSmallType(itemInCustomSmallType);
        }
        
        public static int Delete(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.DeleteItemInCustomSmallType(queryInfo);
        }
        
        
    }
}


	