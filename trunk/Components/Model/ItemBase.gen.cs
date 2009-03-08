using System;
using System.Collections;

namespace TS.Components
{
    ///
	[Serializable]
	public partial class ItemBase
	{
		private System.Guid? _itemId;
		private System.Guid? _smallClassId;
		private int? _sortOrder;
		private string _englishText;
		private string _example;
		private string _chineseText;
		private string _remark;
		private string _mediaPath;
		private int? _itemType;
		private int? _selectedCount;
		private int? _selectSeed;
		private System.DateTime? _lastSelectedTime;
		private int? _isImport;
		private int? _isExclude;
		private int? _onceOKCount;
		
		public ItemBase()
		{
		}
		
		/// <summary>
        /// 根据参数决定是否初始化属性默认值
        /// </summary>
        /// <param name="isInitDefaultValue">一个bool值，表示是否初始化默认值</param>
		private ItemBase(bool isInitDefaultValue)
		{
			if (isInitDefaultValue)
			{
				_itemId = Guid.NewGuid();
				_selectedCount = 0;
				_selectSeed = 5;
				_isImport = 0;
				_isExclude = 0;
				_onceOKCount = 0;
			}
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
        /// 小类ID
        /// </summary>		
		public System.Guid? SmallClassId
		{
			get { return _smallClassId; }
			set { _smallClassId = value; }
		}
		
		/// <summary>
        /// 排序顺序
        /// </summary>		
		public int? SortOrder
		{
			get { return _sortOrder; }
			set { _sortOrder = value; }
		}
		
		/// <summary>
        /// 英语文本
        /// </summary>		
		public string EnglishText
		{
			get { return _englishText; }
			set { _englishText = value; }
		}
		
		/// <summary>
        /// 例句使用
        /// </summary>		
		public string Example
		{
			get { return _example; }
			set { _example = value; }
		}
		
		/// <summary>
        /// 中文文本
        /// </summary>		
		public string ChineseText
		{
			get { return _chineseText; }
			set { _chineseText = value; }
		}
		
		/// <summary>
        /// 备注讲解
        /// </summary>		
		public string Remark
		{
			get { return _remark; }
			set { _remark = value; }
		}
		
		/// <summary>
        /// 媒体路径
        /// </summary>		
		public string MediaPath
		{
			get { return _mediaPath; }
			set { _mediaPath = value; }
		}
		
		/// <summary>
        /// 项目类型
        /// </summary>		
		public int? ItemType
		{
			get { return _itemType; }
			set { _itemType = value; }
		}
		
		/// <summary>
        /// 选中次数
        /// </summary>		
		public int? SelectedCount
		{
			get { return _selectedCount; }
			set { _selectedCount = value; }
		}
		
		/// <summary>
        /// 选择种子
        /// </summary>		
		public int? SelectSeed
		{
			get { return _selectSeed; }
			set { _selectSeed = value; }
		}
		
		/// <summary>
        /// 最后一次选中时间
        /// </summary>		
		public System.DateTime? LastSelectedTime
		{
			get { return _lastSelectedTime; }
			set { _lastSelectedTime = value; }
		}
		
		/// <summary>
        /// 是否强化
        /// </summary>		
		public int? IsImport
		{
			get { return _isImport; }
			set { _isImport = value; }
		}
		
		/// <summary>
        /// 是否排除
        /// </summary>		
		public int? IsExclude
		{
			get { return _isExclude; }
			set { _isExclude = value; }
		}
		
		/// <summary>
        /// 一次正确通过次数
        /// </summary>		
		public int? OnceOKCount
		{
			get { return _onceOKCount; }
			set { _onceOKCount = value; }
		}
		
        
	}
}

