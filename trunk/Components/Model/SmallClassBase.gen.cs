using System;
using System.Collections;

namespace TS.Components
{
    ///
	[Serializable]
	public partial class SmallClassBase
	{
		private System.Guid? _smallClassId;
		private System.Guid? _bigClassId;
		private string _smallClassName;
		
		public SmallClassBase()
		{
		}
		
		/// <summary>
        /// 根据参数决定是否初始化属性默认值
        /// </summary>
        /// <param name="isInitDefaultValue">一个bool值，表示是否初始化默认值</param>
		private SmallClassBase(bool isInitDefaultValue)
		{
			if (isInitDefaultValue)
			{
				_smallClassId = Guid.NewGuid();
			}
		}
        			
		/// <summary>
        /// 小类ID
        /// </summary>		
		public System.Guid? SmallClassId
		{
			get { return _smallClassId; }
			set { _smallClassId = value; }
		}
		
		/// <summary>
        /// 大类ID
        /// </summary>		
		public System.Guid? BigClassId
		{
			get { return _bigClassId; }
			set { _bigClassId = value; }
		}
		
		/// <summary>
        /// 小类名称
        /// </summary>		
		public string SmallClassName
		{
			get { return _smallClassName; }
			set { _smallClassName = value; }
		}
		
        
	}
}

