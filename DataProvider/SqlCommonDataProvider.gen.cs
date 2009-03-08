

using System;
using System.Collections.Generic;
using System.Text;
using TS.Components;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using Maticsoft.DBUtility;

namespace TS.DataProvider
{
    public partial class SqlCommonDataProvider : CommonDataProvider
    {


        #region About BigClass

		public override DataTable GetBigClassData( QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * ");
            strSql.Append(" From BigClass ");
			strSql.Append(" Where 1=1 ");



            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);
            if (sqi != null)
            {
                strSql.Append(" " + sqi.WhereClause);

                if (!Globals.IsNullorEmpty(sqi.OrderClause))
                    strSql.Append(" Order By " + sqi.OrderClause);

                list.AddRange(sqi.Parameters);
            }


            DataSet ds;

            try
            {
                ds = DbHelperSQL.Query(strSql.ToString(),list.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return ds.Tables[0];
        }

        public override List<BigClass> GetBigClassList( QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * ");
            strSql.Append(" From BigClass ");
			strSql.Append(" Where 1=1 ");



            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);
            if (sqi != null)
            {
                strSql.Append(" " + sqi.WhereClause);

                if (!Globals.IsNullorEmpty(sqi.OrderClause))
                    strSql.Append(" Order By " + sqi.OrderClause);

                list.AddRange(sqi.Parameters);
            }

            List<BigClass> listBigClass = new List<BigClass>();

            SqlDataReader dr;

            try
            {
                dr = DbHelperSQL.ExecuteReader(strSql.ToString(),list.ToArray());
                while (dr.Read())
                {
                    listBigClass.Add(PopulateBigClassFromIDataReader(dr));
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            
            return listBigClass;			
        }
        
		public override BigClass GetBigClassById(Guid bigClassId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" From BigClass Where BigClassId = @bigClassId");

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter p = new SqlParameter("@bigClassId", SqlDbType.UniqueIdentifier,16);
            p.Value = bigClassId;
            parameters.Add(p);



            BigClass bigClass = null;

            SqlDataReader dr;
            try
            {
                dr = DbHelperSQL.ExecuteReader(strSql.ToString(),parameters.ToArray());
                if (dr.Read())
                {
                    bigClass = PopulateBigClassFromIDataReader(dr);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return bigClass;

        }

        

        public override bool CreateBigClass(BigClass bigClass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Insert Into BigClass(");
            strSql.Append("BigClassId,BigClassName");
            strSql.Append(") Values (");
            strSql.Append("@BigClassId,@BigClassName");
			strSql.Append(")");

            SqlParameter[] parameters = {
				new SqlParameter("@BigClassId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@BigClassName", SqlDbType.NVarChar)
			};
            parameters[0].Value = bigClass.BigClassId;
            parameters[1].Value = bigClass.BigClassName;

            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

		public override bool UpdateBigClass(BigClass bigClass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Update BigClass Set ");
            strSql.Append(@"BigClassName = @BigClassName");
			strSql.Append(" Where BigClassId = @BigClassId");

            SqlParameter[] paramArray = {
				new SqlParameter("@BigClassId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@BigClassName", SqlDbType.NVarChar)
			};
            paramArray[0].Value = bigClass.BigClassId;
            paramArray[1].Value = bigClass.BigClassName;

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.AddRange(paramArray);


            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

		public override bool DeleteBigClass(Guid bigClassId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From BigClass  ");
            strSql.Append(" Where BigClassId = @BigClassId");

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter p = new SqlParameter("@BigClassId", SqlDbType.UniqueIdentifier,16);
            p.Value = bigClassId;
            parameters.Add(p);


            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

        public override int DeleteBigClass(QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            int rows;

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From BigClass Where 1=2 ");

            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);

            if (sqi == null)
            {
                rows = 0;
            }
            else
            {
                if (!Globals.IsNullorEmpty(sqi.WhereClause))
                {
                    string strWhere = " Or ( 1=1 " + sqi.WhereClause + ")";
                    strSql.Append(strWhere);
                }

                list.AddRange(sqi.Parameters);

                try
                {
                    rows = DbHelperSQL.ExecuteSql(strSql.ToString(), list.ToArray());
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return rows;
        }

		#endregion




        #region About CustomBigType

		public override DataTable GetCustomBigTypeData( QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * ");
            strSql.Append(" From CustomBigType ");
			strSql.Append(" Where 1=1 ");



            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);
            if (sqi != null)
            {
                strSql.Append(" " + sqi.WhereClause);

                if (!Globals.IsNullorEmpty(sqi.OrderClause))
                    strSql.Append(" Order By " + sqi.OrderClause);

                list.AddRange(sqi.Parameters);
            }


            DataSet ds;

            try
            {
                ds = DbHelperSQL.Query(strSql.ToString(),list.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return ds.Tables[0];
        }

        public override List<CustomBigType> GetCustomBigTypeList( QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * ");
            strSql.Append(" From CustomBigType ");
			strSql.Append(" Where 1=1 ");



            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);
            if (sqi != null)
            {
                strSql.Append(" " + sqi.WhereClause);

                if (!Globals.IsNullorEmpty(sqi.OrderClause))
                    strSql.Append(" Order By " + sqi.OrderClause);

                list.AddRange(sqi.Parameters);
            }

            List<CustomBigType> listCustomBigType = new List<CustomBigType>();

            SqlDataReader dr;

            try
            {
                dr = DbHelperSQL.ExecuteReader(strSql.ToString(),list.ToArray());
                while (dr.Read())
                {
                    listCustomBigType.Add(PopulateCustomBigTypeFromIDataReader(dr));
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            
            return listCustomBigType;			
        }
        
		public override CustomBigType GetCustomBigTypeById(Guid customBigTypeId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" From CustomBigType Where CustomBigTypeId = @customBigTypeId");

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter p = new SqlParameter("@customBigTypeId", SqlDbType.UniqueIdentifier,16);
            p.Value = customBigTypeId;
            parameters.Add(p);



            CustomBigType customBigType = null;

            SqlDataReader dr;
            try
            {
                dr = DbHelperSQL.ExecuteReader(strSql.ToString(),parameters.ToArray());
                if (dr.Read())
                {
                    customBigType = PopulateCustomBigTypeFromIDataReader(dr);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return customBigType;

        }

        

        public override bool CreateCustomBigType(CustomBigType customBigType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Insert Into CustomBigType(");
            strSql.Append("CustomBigTypeId,CustomBigTypeName");
            strSql.Append(") Values (");
            strSql.Append("@CustomBigTypeId,@CustomBigTypeName");
			strSql.Append(")");

            SqlParameter[] parameters = {
				new SqlParameter("@CustomBigTypeId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@CustomBigTypeName", SqlDbType.NVarChar)
			};
            parameters[0].Value = customBigType.CustomBigTypeId;
            parameters[1].Value = customBigType.CustomBigTypeName;

            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

		public override bool UpdateCustomBigType(CustomBigType customBigType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Update CustomBigType Set ");
            strSql.Append(@"CustomBigTypeName = @CustomBigTypeName");
			strSql.Append(" Where CustomBigTypeId = @CustomBigTypeId");

            SqlParameter[] paramArray = {
				new SqlParameter("@CustomBigTypeId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@CustomBigTypeName", SqlDbType.NVarChar)
			};
            paramArray[0].Value = customBigType.CustomBigTypeId;
            paramArray[1].Value = customBigType.CustomBigTypeName;

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.AddRange(paramArray);


            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

		public override bool DeleteCustomBigType(Guid customBigTypeId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From CustomBigType  ");
            strSql.Append(" Where CustomBigTypeId = @CustomBigTypeId");

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter p = new SqlParameter("@CustomBigTypeId", SqlDbType.UniqueIdentifier,16);
            p.Value = customBigTypeId;
            parameters.Add(p);


            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

        public override int DeleteCustomBigType(QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            int rows;

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From CustomBigType Where 1=2 ");

            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);

            if (sqi == null)
            {
                rows = 0;
            }
            else
            {
                if (!Globals.IsNullorEmpty(sqi.WhereClause))
                {
                    string strWhere = " Or ( 1=1 " + sqi.WhereClause + ")";
                    strSql.Append(strWhere);
                }

                list.AddRange(sqi.Parameters);

                try
                {
                    rows = DbHelperSQL.ExecuteSql(strSql.ToString(), list.ToArray());
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return rows;
        }

		#endregion




        #region About CustomSmallType

		public override DataTable GetCustomSmallTypeData( QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * ");
            strSql.Append(" From CustomSmallType ");
			strSql.Append(" Where 1=1 ");



            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);
            if (sqi != null)
            {
                strSql.Append(" " + sqi.WhereClause);

                if (!Globals.IsNullorEmpty(sqi.OrderClause))
                    strSql.Append(" Order By " + sqi.OrderClause);

                list.AddRange(sqi.Parameters);
            }


            DataSet ds;

            try
            {
                ds = DbHelperSQL.Query(strSql.ToString(),list.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return ds.Tables[0];
        }

        public override List<CustomSmallType> GetCustomSmallTypeList( QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * ");
            strSql.Append(" From CustomSmallType ");
			strSql.Append(" Where 1=1 ");



            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);
            if (sqi != null)
            {
                strSql.Append(" " + sqi.WhereClause);

                if (!Globals.IsNullorEmpty(sqi.OrderClause))
                    strSql.Append(" Order By " + sqi.OrderClause);

                list.AddRange(sqi.Parameters);
            }

            List<CustomSmallType> listCustomSmallType = new List<CustomSmallType>();

            SqlDataReader dr;

            try
            {
                dr = DbHelperSQL.ExecuteReader(strSql.ToString(),list.ToArray());
                while (dr.Read())
                {
                    listCustomSmallType.Add(PopulateCustomSmallTypeFromIDataReader(dr));
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            
            return listCustomSmallType;			
        }
        
		public override CustomSmallType GetCustomSmallTypeById(Guid customSmallTypeId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" From CustomSmallType Where CustomSmallTypeId = @customSmallTypeId");

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter p = new SqlParameter("@customSmallTypeId", SqlDbType.UniqueIdentifier,16);
            p.Value = customSmallTypeId;
            parameters.Add(p);



            CustomSmallType customSmallType = null;

            SqlDataReader dr;
            try
            {
                dr = DbHelperSQL.ExecuteReader(strSql.ToString(),parameters.ToArray());
                if (dr.Read())
                {
                    customSmallType = PopulateCustomSmallTypeFromIDataReader(dr);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return customSmallType;

        }

        

        public override bool CreateCustomSmallType(CustomSmallType customSmallType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Insert Into CustomSmallType(");
            strSql.Append("CustomSmallTypeId,CustomBigTypeId,CustomSmallTypeName");
            strSql.Append(") Values (");
            strSql.Append("@CustomSmallTypeId,@CustomBigTypeId,@CustomSmallTypeName");
			strSql.Append(")");

            SqlParameter[] parameters = {
				new SqlParameter("@CustomSmallTypeId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@CustomBigTypeId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@CustomSmallTypeName", SqlDbType.NVarChar)
			};
            parameters[0].Value = customSmallType.CustomSmallTypeId;
            parameters[1].Value = customSmallType.CustomBigTypeId;
            parameters[2].Value = customSmallType.CustomSmallTypeName;

            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

		public override bool UpdateCustomSmallType(CustomSmallType customSmallType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Update CustomSmallType Set ");
            strSql.Append(@"CustomBigTypeId = @CustomBigTypeId,
                            CustomSmallTypeName = @CustomSmallTypeName");
			strSql.Append(" Where CustomSmallTypeId = @CustomSmallTypeId");

            SqlParameter[] paramArray = {
				new SqlParameter("@CustomSmallTypeId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@CustomBigTypeId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@CustomSmallTypeName", SqlDbType.NVarChar)
			};
            paramArray[0].Value = customSmallType.CustomSmallTypeId;
            paramArray[1].Value = customSmallType.CustomBigTypeId;
            paramArray[2].Value = customSmallType.CustomSmallTypeName;

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.AddRange(paramArray);


            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

		public override bool DeleteCustomSmallType(Guid customSmallTypeId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From CustomSmallType  ");
            strSql.Append(" Where CustomSmallTypeId = @CustomSmallTypeId");

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter p = new SqlParameter("@CustomSmallTypeId", SqlDbType.UniqueIdentifier,16);
            p.Value = customSmallTypeId;
            parameters.Add(p);


            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

        public override int DeleteCustomSmallType(QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            int rows;

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From CustomSmallType Where 1=2 ");

            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);

            if (sqi == null)
            {
                rows = 0;
            }
            else
            {
                if (!Globals.IsNullorEmpty(sqi.WhereClause))
                {
                    string strWhere = " Or ( 1=1 " + sqi.WhereClause + ")";
                    strSql.Append(strWhere);
                }

                list.AddRange(sqi.Parameters);

                try
                {
                    rows = DbHelperSQL.ExecuteSql(strSql.ToString(), list.ToArray());
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return rows;
        }

		#endregion




        #region About Item

		public override DataTable GetItemData( QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * ");
            strSql.Append(" From Item ");
			strSql.Append(" Where 1=1 ");



            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);
            if (sqi != null)
            {
                strSql.Append(" " + sqi.WhereClause);

                if (!Globals.IsNullorEmpty(sqi.OrderClause))
                    strSql.Append(" Order By " + sqi.OrderClause);

                list.AddRange(sqi.Parameters);
            }


            DataSet ds;

            try
            {
                ds = DbHelperSQL.Query(strSql.ToString(),list.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return ds.Tables[0];
        }

        public override List<Item> GetItemList( QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * ");
            strSql.Append(" From Item ");
			strSql.Append(" Where 1=1 ");



            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);
            if (sqi != null)
            {
                strSql.Append(" " + sqi.WhereClause);

                if (!Globals.IsNullorEmpty(sqi.OrderClause))
                    strSql.Append(" Order By " + sqi.OrderClause);

                list.AddRange(sqi.Parameters);
            }

            List<Item> listItem = new List<Item>();

            SqlDataReader dr;

            try
            {
                dr = DbHelperSQL.ExecuteReader(strSql.ToString(),list.ToArray());
                while (dr.Read())
                {
                    listItem.Add(PopulateItemFromIDataReader(dr));
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            
            return listItem;			
        }
        
		public override Item GetItemById(Guid itemId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" From Item Where ItemId = @itemId");

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter p = new SqlParameter("@itemId", SqlDbType.UniqueIdentifier,16);
            p.Value = itemId;
            parameters.Add(p);



            Item item = null;

            SqlDataReader dr;
            try
            {
                dr = DbHelperSQL.ExecuteReader(strSql.ToString(),parameters.ToArray());
                if (dr.Read())
                {
                    item = PopulateItemFromIDataReader(dr);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return item;

        }

        

        public override bool CreateItem(Item item)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Insert Into Item(");
            strSql.Append("ItemId,SmallClassId,SortOrder,EnglishText,Example,ChineseText,Remark,MediaPath,ItemType,SelectedCount,SelectSeed,LastSelectedTime,IsImport,IsExclude,OnceOKCount");
            strSql.Append(") Values (");
            strSql.Append("@ItemId,@SmallClassId,@SortOrder,@EnglishText,@Example,@ChineseText,@Remark,@MediaPath,@ItemType,@SelectedCount,@SelectSeed,@LastSelectedTime,@IsImport,@IsExclude,@OnceOKCount");
			strSql.Append(")");

            SqlParameter[] parameters = {
				new SqlParameter("@ItemId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@SmallClassId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@SortOrder", SqlDbType.Int),
                new SqlParameter("@EnglishText", SqlDbType.NVarChar),
                new SqlParameter("@Example", SqlDbType.NVarChar),
                new SqlParameter("@ChineseText", SqlDbType.NVarChar),
                new SqlParameter("@Remark", SqlDbType.NText),
                new SqlParameter("@MediaPath", SqlDbType.NVarChar),
                new SqlParameter("@ItemType", SqlDbType.Int),
                new SqlParameter("@SelectedCount", SqlDbType.Int),
                new SqlParameter("@SelectSeed", SqlDbType.Int),
                new SqlParameter("@LastSelectedTime", SqlDbType.DateTime),
                new SqlParameter("@IsImport", SqlDbType.Int),
                new SqlParameter("@IsExclude", SqlDbType.Int),
                new SqlParameter("@OnceOKCount", SqlDbType.Int)
			};
            parameters[0].Value = item.ItemId;
            parameters[1].Value = item.SmallClassId;
            parameters[2].Value = item.SortOrder;
            parameters[3].Value = item.EnglishText;
            parameters[4].Value = item.Example;
            parameters[5].Value = item.ChineseText;
            parameters[6].Value = item.Remark;
            parameters[7].Value = item.MediaPath;
            parameters[8].Value = item.ItemType;
            parameters[9].Value = item.SelectedCount;
            parameters[10].Value = item.SelectSeed;
            parameters[11].Value = item.LastSelectedTime;
            parameters[12].Value = item.IsImport;
            parameters[13].Value = item.IsExclude;
            parameters[14].Value = item.OnceOKCount;

            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

		public override bool UpdateItem(Item item)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Update Item Set ");
            strSql.Append(@"SmallClassId = @SmallClassId,
                            SortOrder = @SortOrder,
                            EnglishText = @EnglishText,
                            Example = @Example,
                            ChineseText = @ChineseText,
                            Remark = @Remark,
                            MediaPath = @MediaPath,
                            ItemType = @ItemType,
                            SelectedCount = @SelectedCount,
                            SelectSeed = @SelectSeed,
                            LastSelectedTime = @LastSelectedTime,
                            IsImport = @IsImport,
                            IsExclude = @IsExclude,
                            OnceOKCount = @OnceOKCount");
			strSql.Append(" Where ItemId = @ItemId");

            SqlParameter[] paramArray = {
				new SqlParameter("@ItemId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@SmallClassId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@SortOrder", SqlDbType.Int),
                new SqlParameter("@EnglishText", SqlDbType.NVarChar),
                new SqlParameter("@Example", SqlDbType.NVarChar),
                new SqlParameter("@ChineseText", SqlDbType.NVarChar),
                new SqlParameter("@Remark", SqlDbType.NText),
                new SqlParameter("@MediaPath", SqlDbType.NVarChar),
                new SqlParameter("@ItemType", SqlDbType.Int),
                new SqlParameter("@SelectedCount", SqlDbType.Int),
                new SqlParameter("@SelectSeed", SqlDbType.Int),
                new SqlParameter("@LastSelectedTime", SqlDbType.DateTime),
                new SqlParameter("@IsImport", SqlDbType.Int),
                new SqlParameter("@IsExclude", SqlDbType.Int),
                new SqlParameter("@OnceOKCount", SqlDbType.Int)
			};
            paramArray[0].Value = item.ItemId;
            paramArray[1].Value = item.SmallClassId;
            paramArray[2].Value = item.SortOrder;
            paramArray[3].Value = item.EnglishText;
            paramArray[4].Value = item.Example;
            paramArray[5].Value = item.ChineseText;
            paramArray[6].Value = item.Remark;
            paramArray[7].Value = item.MediaPath;
            paramArray[8].Value = item.ItemType;
            paramArray[9].Value = item.SelectedCount;
            paramArray[10].Value = item.SelectSeed;
            paramArray[11].Value = item.LastSelectedTime;
            paramArray[12].Value = item.IsImport;
            paramArray[13].Value = item.IsExclude;
            paramArray[14].Value = item.OnceOKCount;

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.AddRange(paramArray);


            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

		public override bool DeleteItem(Guid itemId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From Item  ");
            strSql.Append(" Where ItemId = @ItemId");

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter p = new SqlParameter("@ItemId", SqlDbType.UniqueIdentifier,16);
            p.Value = itemId;
            parameters.Add(p);


            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

        public override int DeleteItem(QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            int rows;

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From Item Where 1=2 ");

            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);

            if (sqi == null)
            {
                rows = 0;
            }
            else
            {
                if (!Globals.IsNullorEmpty(sqi.WhereClause))
                {
                    string strWhere = " Or ( 1=1 " + sqi.WhereClause + ")";
                    strSql.Append(strWhere);
                }

                list.AddRange(sqi.Parameters);

                try
                {
                    rows = DbHelperSQL.ExecuteSql(strSql.ToString(), list.ToArray());
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return rows;
        }

		#endregion




        #region About ItemInCustomSmallType

		public override DataTable GetItemInCustomSmallTypeData( QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * ");
            strSql.Append(" From ItemInCustomSmallType ");
			strSql.Append(" Where 1=1 ");



            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);
            if (sqi != null)
            {
                strSql.Append(" " + sqi.WhereClause);

                if (!Globals.IsNullorEmpty(sqi.OrderClause))
                    strSql.Append(" Order By " + sqi.OrderClause);

                list.AddRange(sqi.Parameters);
            }


            DataSet ds;

            try
            {
                ds = DbHelperSQL.Query(strSql.ToString(),list.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return ds.Tables[0];
        }

        public override List<ItemInCustomSmallType> GetItemInCustomSmallTypeList( QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * ");
            strSql.Append(" From ItemInCustomSmallType ");
			strSql.Append(" Where 1=1 ");



            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);
            if (sqi != null)
            {
                strSql.Append(" " + sqi.WhereClause);

                if (!Globals.IsNullorEmpty(sqi.OrderClause))
                    strSql.Append(" Order By " + sqi.OrderClause);

                list.AddRange(sqi.Parameters);
            }

            List<ItemInCustomSmallType> listItemInCustomSmallType = new List<ItemInCustomSmallType>();

            SqlDataReader dr;

            try
            {
                dr = DbHelperSQL.ExecuteReader(strSql.ToString(),list.ToArray());
                while (dr.Read())
                {
                    listItemInCustomSmallType.Add(PopulateItemInCustomSmallTypeFromIDataReader(dr));
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            
            return listItemInCustomSmallType;			
        }
        
		public override ItemInCustomSmallType GetItemInCustomSmallTypeById(Guid itemInCustomSmallTypeId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" From ItemInCustomSmallType Where ItemInCustomSmallTypeId = @itemInCustomSmallTypeId");

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter p = new SqlParameter("@itemInCustomSmallTypeId", SqlDbType.UniqueIdentifier,16);
            p.Value = itemInCustomSmallTypeId;
            parameters.Add(p);



            ItemInCustomSmallType itemInCustomSmallType = null;

            SqlDataReader dr;
            try
            {
                dr = DbHelperSQL.ExecuteReader(strSql.ToString(),parameters.ToArray());
                if (dr.Read())
                {
                    itemInCustomSmallType = PopulateItemInCustomSmallTypeFromIDataReader(dr);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return itemInCustomSmallType;

        }

        

        public override bool CreateItemInCustomSmallType(ItemInCustomSmallType itemInCustomSmallType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Insert Into ItemInCustomSmallType(");
            strSql.Append("ItemInCustomSmallTypeId,ItemId,CustomSmallTypeId");
            strSql.Append(") Values (");
            strSql.Append("@ItemInCustomSmallTypeId,@ItemId,@CustomSmallTypeId");
			strSql.Append(")");

            SqlParameter[] parameters = {
				new SqlParameter("@ItemInCustomSmallTypeId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@ItemId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@CustomSmallTypeId", SqlDbType.UniqueIdentifier)
			};
            parameters[0].Value = itemInCustomSmallType.ItemInCustomSmallTypeId;
            parameters[1].Value = itemInCustomSmallType.ItemId;
            parameters[2].Value = itemInCustomSmallType.CustomSmallTypeId;

            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

		public override bool UpdateItemInCustomSmallType(ItemInCustomSmallType itemInCustomSmallType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Update ItemInCustomSmallType Set ");
            strSql.Append(@"ItemId = @ItemId,
                            CustomSmallTypeId = @CustomSmallTypeId");
			strSql.Append(" Where ItemInCustomSmallTypeId = @ItemInCustomSmallTypeId");

            SqlParameter[] paramArray = {
				new SqlParameter("@ItemInCustomSmallTypeId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@ItemId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@CustomSmallTypeId", SqlDbType.UniqueIdentifier)
			};
            paramArray[0].Value = itemInCustomSmallType.ItemInCustomSmallTypeId;
            paramArray[1].Value = itemInCustomSmallType.ItemId;
            paramArray[2].Value = itemInCustomSmallType.CustomSmallTypeId;

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.AddRange(paramArray);


            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

		public override bool DeleteItemInCustomSmallType(Guid itemInCustomSmallTypeId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From ItemInCustomSmallType  ");
            strSql.Append(" Where ItemInCustomSmallTypeId = @ItemInCustomSmallTypeId");

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter p = new SqlParameter("@ItemInCustomSmallTypeId", SqlDbType.UniqueIdentifier,16);
            p.Value = itemInCustomSmallTypeId;
            parameters.Add(p);


            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

        public override int DeleteItemInCustomSmallType(QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            int rows;

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From ItemInCustomSmallType Where 1=2 ");

            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);

            if (sqi == null)
            {
                rows = 0;
            }
            else
            {
                if (!Globals.IsNullorEmpty(sqi.WhereClause))
                {
                    string strWhere = " Or ( 1=1 " + sqi.WhereClause + ")";
                    strSql.Append(strWhere);
                }

                list.AddRange(sqi.Parameters);

                try
                {
                    rows = DbHelperSQL.ExecuteSql(strSql.ToString(), list.ToArray());
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return rows;
        }

		#endregion




        #region About SmallClass

		public override DataTable GetSmallClassData( QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * ");
            strSql.Append(" From SmallClass ");
			strSql.Append(" Where 1=1 ");



            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);
            if (sqi != null)
            {
                strSql.Append(" " + sqi.WhereClause);

                if (!Globals.IsNullorEmpty(sqi.OrderClause))
                    strSql.Append(" Order By " + sqi.OrderClause);

                list.AddRange(sqi.Parameters);
            }


            DataSet ds;

            try
            {
                ds = DbHelperSQL.Query(strSql.ToString(),list.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return ds.Tables[0];
        }

        public override List<SmallClass> GetSmallClassList( QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * ");
            strSql.Append(" From SmallClass ");
			strSql.Append(" Where 1=1 ");



            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);
            if (sqi != null)
            {
                strSql.Append(" " + sqi.WhereClause);

                if (!Globals.IsNullorEmpty(sqi.OrderClause))
                    strSql.Append(" Order By " + sqi.OrderClause);

                list.AddRange(sqi.Parameters);
            }

            List<SmallClass> listSmallClass = new List<SmallClass>();

            SqlDataReader dr;

            try
            {
                dr = DbHelperSQL.ExecuteReader(strSql.ToString(),list.ToArray());
                while (dr.Read())
                {
                    listSmallClass.Add(PopulateSmallClassFromIDataReader(dr));
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            
            return listSmallClass;			
        }
        
		public override SmallClass GetSmallClassById(Guid smallClassId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" From SmallClass Where SmallClassId = @smallClassId");

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter p = new SqlParameter("@smallClassId", SqlDbType.UniqueIdentifier,16);
            p.Value = smallClassId;
            parameters.Add(p);



            SmallClass smallClass = null;

            SqlDataReader dr;
            try
            {
                dr = DbHelperSQL.ExecuteReader(strSql.ToString(),parameters.ToArray());
                if (dr.Read())
                {
                    smallClass = PopulateSmallClassFromIDataReader(dr);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return smallClass;

        }

        

        public override bool CreateSmallClass(SmallClass smallClass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Insert Into SmallClass(");
            strSql.Append("SmallClassId,BigClassId,SmallClassName");
            strSql.Append(") Values (");
            strSql.Append("@SmallClassId,@BigClassId,@SmallClassName");
			strSql.Append(")");

            SqlParameter[] parameters = {
				new SqlParameter("@SmallClassId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@BigClassId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@SmallClassName", SqlDbType.NVarChar)
			};
            parameters[0].Value = smallClass.SmallClassId;
            parameters[1].Value = smallClass.BigClassId;
            parameters[2].Value = smallClass.SmallClassName;

            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

		public override bool UpdateSmallClass(SmallClass smallClass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Update SmallClass Set ");
            strSql.Append(@"BigClassId = @BigClassId,
                            SmallClassName = @SmallClassName");
			strSql.Append(" Where SmallClassId = @SmallClassId");

            SqlParameter[] paramArray = {
				new SqlParameter("@SmallClassId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@BigClassId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@SmallClassName", SqlDbType.NVarChar)
			};
            paramArray[0].Value = smallClass.SmallClassId;
            paramArray[1].Value = smallClass.BigClassId;
            paramArray[2].Value = smallClass.SmallClassName;

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.AddRange(paramArray);


            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

		public override bool DeleteSmallClass(Guid smallClassId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From SmallClass  ");
            strSql.Append(" Where SmallClassId = @SmallClassId");

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter p = new SqlParameter("@SmallClassId", SqlDbType.UniqueIdentifier,16);
            p.Value = smallClassId;
            parameters.Add(p);


            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

        public override int DeleteSmallClass(QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            int rows;

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From SmallClass Where 1=2 ");

            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);

            if (sqi == null)
            {
                rows = 0;
            }
            else
            {
                if (!Globals.IsNullorEmpty(sqi.WhereClause))
                {
                    string strWhere = " Or ( 1=1 " + sqi.WhereClause + ")";
                    strSql.Append(strWhere);
                }

                list.AddRange(sqi.Parameters);

                try
                {
                    rows = DbHelperSQL.ExecuteSql(strSql.ToString(), list.ToArray());
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return rows;
        }

		#endregion




        #region About Word

		public override DataTable GetWordData( QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * ");
            strSql.Append(" From Word ");
			strSql.Append(" Where 1=1 ");



            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);
            if (sqi != null)
            {
                strSql.Append(" " + sqi.WhereClause);

                if (!Globals.IsNullorEmpty(sqi.OrderClause))
                    strSql.Append(" Order By " + sqi.OrderClause);

                list.AddRange(sqi.Parameters);
            }


            DataSet ds;

            try
            {
                ds = DbHelperSQL.Query(strSql.ToString(),list.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return ds.Tables[0];
        }

        public override List<Word> GetWordList( QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * ");
            strSql.Append(" From Word ");
			strSql.Append(" Where 1=1 ");



            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);
            if (sqi != null)
            {
                strSql.Append(" " + sqi.WhereClause);

                if (!Globals.IsNullorEmpty(sqi.OrderClause))
                    strSql.Append(" Order By " + sqi.OrderClause);

                list.AddRange(sqi.Parameters);
            }

            List<Word> listWord = new List<Word>();

            SqlDataReader dr;

            try
            {
                dr = DbHelperSQL.ExecuteReader(strSql.ToString(),list.ToArray());
                while (dr.Read())
                {
                    listWord.Add(PopulateWordFromIDataReader(dr));
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            
            return listWord;			
        }
        
		public override Word GetWordById(Guid wordId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" From Word Where WordId = @wordId");

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter p = new SqlParameter("@wordId", SqlDbType.UniqueIdentifier,16);
            p.Value = wordId;
            parameters.Add(p);



            Word word = null;

            SqlDataReader dr;
            try
            {
                dr = DbHelperSQL.ExecuteReader(strSql.ToString(),parameters.ToArray());
                if (dr.Read())
                {
                    word = PopulateWordFromIDataReader(dr);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return word;

        }

        

        public override bool CreateWord(Word word)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Insert Into Word(");
            strSql.Append("WordId,Word,IsRemember");
            strSql.Append(") Values (");
            strSql.Append("@WordId,@Word,@IsRemember");
			strSql.Append(")");

            SqlParameter[] parameters = {
				new SqlParameter("@WordId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@Word", SqlDbType.NVarChar),
                new SqlParameter("@IsRemember", SqlDbType.Int)
			};
            parameters[0].Value = word.WordId;
            parameters[1].Value = word.Word;
            parameters[2].Value = word.IsRemember;

            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

		public override bool UpdateWord(Word word)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Update Word Set ");
            strSql.Append(@"Word = @Word,
                            IsRemember = @IsRemember");
			strSql.Append(" Where WordId = @WordId");

            SqlParameter[] paramArray = {
				new SqlParameter("@WordId", SqlDbType.UniqueIdentifier),
                new SqlParameter("@Word", SqlDbType.NVarChar),
                new SqlParameter("@IsRemember", SqlDbType.Int)
			};
            paramArray[0].Value = word.WordId;
            paramArray[1].Value = word.Word;
            paramArray[2].Value = word.IsRemember;

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.AddRange(paramArray);


            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

		public override bool DeleteWord(Guid wordId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From Word  ");
            strSql.Append(" Where WordId = @WordId");

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter p = new SqlParameter("@WordId", SqlDbType.UniqueIdentifier,16);
            p.Value = wordId;
            parameters.Add(p);


            int rows;

            try
            {
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters.ToArray());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return (rows > 0);
        }

        public override int DeleteWord(QueryInfo queryInfo)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            int rows;

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From Word Where 1=2 ");

            SqlQueryInfo sqi = sqlHelper.ParseQueryInfo(queryInfo);

            if (sqi == null)
            {
                rows = 0;
            }
            else
            {
                if (!Globals.IsNullorEmpty(sqi.WhereClause))
                {
                    string strWhere = " Or ( 1=1 " + sqi.WhereClause + ")";
                    strSql.Append(strWhere);
                }

                list.AddRange(sqi.Parameters);

                try
                {
                    rows = DbHelperSQL.ExecuteSql(strSql.ToString(), list.ToArray());
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return rows;
        }

		#endregion



	}
	
}
