using System;
using System.Collections;

namespace TS.Components
{
    ///
	[Serializable]
	public partial class BigClassBase
	{
		private System.Guid? _bigClassId;
		private string _bigClassName;
		
		public BigClassBase()
		{
		}
		
		/// <summary>
        /// 根据参数决定是否初始化属性默认值
        /// </summary>
        /// <param name="isInitDefaultValue">一个bool值，表示是否初始化默认值</param>
		private BigClassBase(bool isInitDefaultValue)
		{
			if (isInitDefaultValue)
			{
				_bigClassId = Guid.NewGuid();
			}
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
        /// 大类名称
        /// </summary>		
		public string BigClassName
		{
			get { return _bigClassName; }
			set { _bigClassName = value; }
		}
		
        
	}
}

