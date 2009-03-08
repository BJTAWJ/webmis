using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;

namespace TS.Components
{
    /// <summary>
    /// 业务处理类 ItemsBase
    /// </summary>
    public partial class ItemsBase
    {
        
        public static Item CreateInstance(bool isInitDefaultValue)
        {
            Item model = new Item();

            if (isInitDefaultValue)
            {
				model.ItemId = Guid.NewGuid();
				model.SelectedCount = 0;
				model.SelectSeed = 5;
				model.IsImport = 0;
				model.IsExclude = 0;
				model.OnceOKCount = 0;
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
            return dp.GetItemData(null);
        }

        public static DataTable GetData(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetItemData(queryInfo);
        }
        
        public static List<Item> GetList(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetItemList(queryInfo);
        }
        
        public static object GetValue(string columnName, Guid itemId)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetValue("Item", columnName, "ItemId", itemId, false );
        }
        
        public static Item GetModelById(Guid itemId)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetItemById(itemId);
        }
        
        public static Item GetModel(QueryInfo queryInfo)
        {
            List<Item> list = GetList(queryInfo);
            if (list == null || list.Count == 0)
                return null;
            else
                return list[0];
        }
        
        public static bool Update(Item item)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.UpdateItem(item);
        }

        public static bool Add(Item item)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.CreateItem(item);
        }
        
        public static bool Delete(Guid item)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.DeleteItem(item);
        }
        
        public static int Delete(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.DeleteItem(queryInfo);
        }
        
        
    }
}


	