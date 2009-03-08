using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TS.Components
{

    public abstract partial class CommonDataProvider
    {

        #region Populate
        

        public BigClass PopulateBigClassFromIDataReader(IDataReader dr)
        {
            BigClass model = null;
        
            if (dr != null)
            {
                model = new BigClass();
                
                if (dr["BigClassId"] is System.DBNull)
                    model.BigClassId = null;
                else
                    model.BigClassId = (Guid)dr["BigClassId"];
                    
                model.BigClassName = dr["BigClassName"].ToString();
            }	
            return model;	
        }
        

        public CustomBigType PopulateCustomBigTypeFromIDataReader(IDataReader dr)
        {
            CustomBigType model = null;
        
            if (dr != null)
            {
                model = new CustomBigType();
                
                if (dr["CustomBigTypeId"] is System.DBNull)
                    model.CustomBigTypeId = null;
                else
                    model.CustomBigTypeId = (Guid)dr["CustomBigTypeId"];
                    
                model.CustomBigTypeName = dr["CustomBigTypeName"].ToString();
            }	
            return model;	
        }
        

        public CustomSmallType PopulateCustomSmallTypeFromIDataReader(IDataReader dr)
        {
            CustomSmallType model = null;
        
            if (dr != null)
            {
                model = new CustomSmallType();
                
                if (dr["CustomSmallTypeId"] is System.DBNull)
                    model.CustomSmallTypeId = null;
                else
                    model.CustomSmallTypeId = (Guid)dr["CustomSmallTypeId"];
                    
                if (dr["CustomBigTypeId"] is System.DBNull)
                    model.CustomBigTypeId = null;
                else
                    model.CustomBigTypeId = (Guid)dr["CustomBigTypeId"];
                    
                model.CustomSmallTypeName = dr["CustomSmallTypeName"].ToString();
            }	
            return model;	
        }
        

        public Item PopulateItemFromIDataReader(IDataReader dr)
        {
            Item model = null;
        
            if (dr != null)
            {
                model = new Item();
                
                if (dr["ItemId"] is System.DBNull)
                    model.ItemId = null;
                else
                    model.ItemId = (Guid)dr["ItemId"];
                    
                if (dr["SmallClassId"] is System.DBNull)
                    model.SmallClassId = null;
                else
                    model.SmallClassId = (Guid)dr["SmallClassId"];
                    
                if (dr["SortOrder"] is System.DBNull)
                    model.SortOrder = null;
                else
                    model.SortOrder = (Int32)dr["SortOrder"];
                    
                model.EnglishText = dr["EnglishText"].ToString();
                model.Example = dr["Example"].ToString();
                model.ChineseText = dr["ChineseText"].ToString();
                model.Remark = dr["Remark"].ToString();
                model.MediaPath = dr["MediaPath"].ToString();
                if (dr["ItemType"] is System.DBNull)
                    model.ItemType = null;
                else
                    model.ItemType = (Int32)dr["ItemType"];
                    
                if (dr["SelectedCount"] is System.DBNull)
                    model.SelectedCount = null;
                else
                    model.SelectedCount = (Int32)dr["SelectedCount"];
                    
                if (dr["SelectSeed"] is System.DBNull)
                    model.SelectSeed = null;
                else
                    model.SelectSeed = (Int32)dr["SelectSeed"];
                    
                if (dr["LastSelectedTime"] is System.DBNull)
                    model.LastSelectedTime = null;
                else
                    model.LastSelectedTime = (DateTime)dr["LastSelectedTime"];
                    
                if (dr["IsImport"] is System.DBNull)
                    model.IsImport = null;
                else
                    model.IsImport = (Int32)dr["IsImport"];
                    
                if (dr["IsExclude"] is System.DBNull)
                    model.IsExclude = null;
                else
                    model.IsExclude = (Int32)dr["IsExclude"];
                    
                if (dr["OnceOKCount"] is System.DBNull)
                    model.OnceOKCount = null;
                else
                    model.OnceOKCount = (Int32)dr["OnceOKCount"];
                    
            }	
            return model;	
        }
        

        public ItemInCustomSmallType PopulateItemInCustomSmallTypeFromIDataReader(IDataReader dr)
        {
            ItemInCustomSmallType model = null;
        
            if (dr != null)
            {
                model = new ItemInCustomSmallType();
                
                if (dr["ItemInCustomSmallTypeId"] is System.DBNull)
                    model.ItemInCustomSmallTypeId = null;
                else
                    model.ItemInCustomSmallTypeId = (Guid)dr["ItemInCustomSmallTypeId"];
                    
                if (dr["ItemId"] is System.DBNull)
                    model.ItemId = null;
                else
                    model.ItemId = (Guid)dr["ItemId"];
                    
                if (dr["CustomSmallTypeId"] is System.DBNull)
                    model.CustomSmallTypeId = null;
                else
                    model.CustomSmallTypeId = (Guid)dr["CustomSmallTypeId"];
                    
            }	
            return model;	
        }
        

        public SmallClass PopulateSmallClassFromIDataReader(IDataReader dr)
        {
            SmallClass model = null;
        
            if (dr != null)
            {
                model = new SmallClass();
                
                if (dr["SmallClassId"] is System.DBNull)
                    model.SmallClassId = null;
                else
                    model.SmallClassId = (Guid)dr["SmallClassId"];
                    
                if (dr["BigClassId"] is System.DBNull)
                    model.BigClassId = null;
                else
                    model.BigClassId = (Guid)dr["BigClassId"];
                    
                model.SmallClassName = dr["SmallClassName"].ToString();
            }	
            return model;	
        }
        

        public Word PopulateWordFromIDataReader(IDataReader dr)
        {
            Word model = null;
        
            if (dr != null)
            {
                model = new Word();
                
                if (dr["WordId"] is System.DBNull)
                    model.WordId = null;
                else
                    model.WordId = (Guid)dr["WordId"];
                    
                model.Word = dr["Word"].ToString();
                if (dr["IsRemember"] is System.DBNull)
                    model.IsRemember = null;
                else
                    model.IsRemember = (Int32)dr["IsRemember"];
                    
            }	
            return model;	
        }
        
        
        #endregion
        


        #region About BigClass
		
		public abstract BigClass GetBigClassById(Guid bigClassId);
		
        public abstract DataTable GetBigClassData(QueryInfo queryInfo);
        
		public abstract List<BigClass> GetBigClassList(QueryInfo queryInfo);
        
		public abstract bool CreateBigClass(BigClass bigClass);
		
		public abstract bool UpdateBigClass(BigClass bigClass);
		
		public abstract bool DeleteBigClass(Guid bigClassId);
		
        public abstract int DeleteBigClass(QueryInfo queryInfo);
        
		
		#endregion
        
        
	

        #region About CustomBigType
		
		public abstract CustomBigType GetCustomBigTypeById(Guid customBigTypeId);
		
        public abstract DataTable GetCustomBigTypeData(QueryInfo queryInfo);
        
		public abstract List<CustomBigType> GetCustomBigTypeList(QueryInfo queryInfo);
        
		public abstract bool CreateCustomBigType(CustomBigType customBigType);
		
		public abstract bool UpdateCustomBigType(CustomBigType customBigType);
		
		public abstract bool DeleteCustomBigType(Guid customBigTypeId);
		
        public abstract int DeleteCustomBigType(QueryInfo queryInfo);
        
		
		#endregion
        
        
	

        #region About CustomSmallType
		
		public abstract CustomSmallType GetCustomSmallTypeById(Guid customSmallTypeId);
		
        public abstract DataTable GetCustomSmallTypeData(QueryInfo queryInfo);
        
		public abstract List<CustomSmallType> GetCustomSmallTypeList(QueryInfo queryInfo);
        
		public abstract bool CreateCustomSmallType(CustomSmallType customSmallType);
		
		public abstract bool UpdateCustomSmallType(CustomSmallType customSmallType);
		
		public abstract bool DeleteCustomSmallType(Guid customSmallTypeId);
		
        public abstract int DeleteCustomSmallType(QueryInfo queryInfo);
        
		
		#endregion
        
        
	

        #region About Item
		
		public abstract Item GetItemById(Guid itemId);
		
        public abstract DataTable GetItemData(QueryInfo queryInfo);
        
		public abstract List<Item> GetItemList(QueryInfo queryInfo);
        
		public abstract bool CreateItem(Item item);
		
		public abstract bool UpdateItem(Item item);
		
		public abstract bool DeleteItem(Guid itemId);
		
        public abstract int DeleteItem(QueryInfo queryInfo);
        
		
		#endregion
        
        
	

        #region About ItemInCustomSmallType
		
		public abstract ItemInCustomSmallType GetItemInCustomSmallTypeById(Guid itemInCustomSmallTypeId);
		
        public abstract DataTable GetItemInCustomSmallTypeData(QueryInfo queryInfo);
        
		public abstract List<ItemInCustomSmallType> GetItemInCustomSmallTypeList(QueryInfo queryInfo);
        
		public abstract bool CreateItemInCustomSmallType(ItemInCustomSmallType itemInCustomSmallType);
		
		public abstract bool UpdateItemInCustomSmallType(ItemInCustomSmallType itemInCustomSmallType);
		
		public abstract bool DeleteItemInCustomSmallType(Guid itemInCustomSmallTypeId);
		
        public abstract int DeleteItemInCustomSmallType(QueryInfo queryInfo);
        
		
		#endregion
        
        
	

        #region About SmallClass
		
		public abstract SmallClass GetSmallClassById(Guid smallClassId);
		
        public abstract DataTable GetSmallClassData(QueryInfo queryInfo);
        
		public abstract List<SmallClass> GetSmallClassList(QueryInfo queryInfo);
        
		public abstract bool CreateSmallClass(SmallClass smallClass);
		
		public abstract bool UpdateSmallClass(SmallClass smallClass);
		
		public abstract bool DeleteSmallClass(Guid smallClassId);
		
        public abstract int DeleteSmallClass(QueryInfo queryInfo);
        
		
		#endregion
        
        
	

        #region About Word
		
		public abstract Word GetWordById(Guid wordId);
		
        public abstract DataTable GetWordData(QueryInfo queryInfo);
        
		public abstract List<Word> GetWordList(QueryInfo queryInfo);
        
		public abstract bool CreateWord(Word word);
		
		public abstract bool UpdateWord(Word word);
		
		public abstract bool DeleteWord(Guid wordId);
		
        public abstract int DeleteWord(QueryInfo queryInfo);
        
		
		#endregion
        
        
	        
    }

}