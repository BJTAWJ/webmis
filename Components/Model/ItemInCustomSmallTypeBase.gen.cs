using System;
using System.Collections;

namespace TS.Components
{
    ///
	[Serializable]
	public partial class ItemInCustomSmallTypeBase
	{
		private System.Guid? _itemInCustomSmallTypeId;
		private System.Guid? _itemId;
		private System.Guid? _customSmallTypeId;
		
		public ItemInCustomSmallTypeBase()
		{
		}
		
		/// <summary>
        /// 根据参数决定是否初始化属性默认值
        /// </summary>
        /// <param name="isInitDefaultValue">一个bool值，表示是否初始化默认值</param>
		private ItemInCustomSmallTypeBase(bool isInitDefaultValue)
		{
			if (isInitDefaultValue)
			{
				_itemInCustomSmallTypeId = Guid.NewGuid();
			}
		}
        			
		/// <summary>
        /// 主键ID
        /// </summary>		
		public System.Guid? ItemInCustomSmallTypeId
		{
			get { return _itemInCustomSmallTypeId; }
			set { _itemInCustomSmallTypeId = value; }
		}
		
		/// <summary>
        /// 项目ID
        /// </summary>		
		public System.Guid? ItemId
		{
			get { return _itemId; }
			set { _itemId = value; }
		}
		
		/// <summary>
        /// 自定义小类
        /// </summary>		
		public System.Guid? CustomSmallTypeId
		{
			get { return _customSmallTypeId; }
			set { _customSmallTypeId = value; }
		}
		
        
	}
}

