using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;

namespace TS.Components
{
    /// <summary>
    /// 业务处理类 WordsBase
    /// </summary>
    public partial class WordsBase
    {
        
        public static Word CreateInstance(bool isInitDefaultValue)
        {
            Word model = new Word();

            if (isInitDefaultValue)
            {
				model.IsRemember = 0;
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
            return dp.GetWordData(null);
        }

        public static DataTable GetData(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetWordData(queryInfo);
        }
        
        public static List<Word> GetList(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetWordList(queryInfo);
        }
        
        public static object GetValue(string columnName, Guid wordId)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetValue("Word", columnName, "WordId", wordId, false );
        }
        
        public static Word GetModelById(Guid wordId)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.GetWordById(wordId);
        }
        
        public static Word GetModel(QueryInfo queryInfo)
        {
            List<Word> list = GetList(queryInfo);
            if (list == null || list.Count == 0)
                return null;
            else
                return list[0];
        }
        
        public static bool Update(Word word)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.UpdateWord(word);
        }

        public static bool Add(Word word)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.CreateWord(word);
        }
        
        public static bool Delete(Guid word)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.DeleteWord(word);
        }
        
        public static int Delete(QueryInfo queryInfo)
        {
            CommonDataProvider dp = CommonDataProvider.Instance();
            return dp.DeleteWord(queryInfo);
        }
        
        
    }
}


	