using System;
using System.Collections;

namespace TS.Components
{
    ///
	[Serializable]
	public partial class WordBase
	{
		private System.Guid? _wordId;
		private string _word;
		private int? _isRemember;
		
		public WordBase()
		{
		}
		
		/// <summary>
        /// 根据参数决定是否初始化属性默认值
        /// </summary>
        /// <param name="isInitDefaultValue">一个bool值，表示是否初始化默认值</param>
		private WordBase(bool isInitDefaultValue)
		{
			if (isInitDefaultValue)
			{
				_isRemember = 0;
			}
		}
        			
		/// <summary>
        /// 
        /// </summary>		
		public System.Guid? WordId
		{
			get { return _wordId; }
			set { _wordId = value; }
		}
		
		/// <summary>
        /// 
        /// </summary>		
		public string Word
		{
			get { return _word; }
			set { _word = value; }
		}
		
		/// <summary>
        /// 
        /// </summary>		
		public int? IsRemember
		{
			get { return _isRemember; }
			set { _isRemember = value; }
		}
		
        
	}
}

