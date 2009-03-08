using System;
using System.Collections;

namespace TS.Components
{
    ///
	[Serializable]
	public partial class CustomBigTypeBase
	{
		private System.Guid? _customBigTypeId;
		private string _customBigTypeName;
		
		public CustomBigTypeBase()
		{
		}
		
		/// <summary>
        /// 根据参数决定是否初始化属性默认值
        /// </summary>
        /// <param name="isInitDefaultValue">一个bool值，表示是否初始化默认值</param>
		private CustomBigTypeBase(bool isInitDefaultValue)
		{
			if (isInitDefaultValue)
			{
				_customBigTypeId = Guid.NewGuid();
			}
		}
        			
		/// <summary>
        /// 自定义大类ID
        /// </summary>		
		public System.Guid? CustomBigTypeId
		{
			get { return _customBigTypeId; }
			set { _customBigTypeId = value; }
		}
		
		/// <summary>
        /// 自定义大类名称
        /// </summary>		
		public string CustomBigTypeName
		{
			get { return _customBigTypeName; }
			set { _customBigTypeName = value; }
		}
		
        
	}
}

