using System;
using System.Collections;

namespace TS.Components
{
    ///
	[Serializable]
	public partial class CustomSmallTypeBase
	{
		private System.Guid? _customSmallTypeId;
		private System.Guid? _customBigTypeId;
		private string _customSmallTypeName;
		
		public CustomSmallTypeBase()
		{
		}
		
		/// <summary>
        /// 根据参数决定是否初始化属性默认值
        /// </summary>
        /// <param name="isInitDefaultValue">一个bool值，表示是否初始化默认值</param>
		private CustomSmallTypeBase(bool isInitDefaultValue)
		{
			if (isInitDefaultValue)
			{
				_customSmallTypeId = Guid.NewGuid();
			}
		}
        			
		/// <summary>
        /// 自定义小类ID
        /// </summary>		
		public System.Guid? CustomSmallTypeId
		{
			get { return _customSmallTypeId; }
			set { _customSmallTypeId = value; }
		}
		
		/// <summary>
        /// 父级大类ID
        /// </summary>		
		public System.Guid? CustomBigTypeId
		{
			get { return _customBigTypeId; }
			set { _customBigTypeId = value; }
		}
		
		/// <summary>
        /// 自定义小类名称
        /// </summary>		
		public string CustomSmallTypeName
		{
			get { return _customSmallTypeName; }
			set { _customSmallTypeName = value; }
		}
		
        
	}
}

