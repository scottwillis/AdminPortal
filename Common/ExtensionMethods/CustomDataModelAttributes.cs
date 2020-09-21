using System;

namespace Common {

	[AttributeUsage(AttributeTargets.Property)]
	public class MyCustomAttribute : Attribute {

		public string LookupKey;
		public string LookupKeySource = "Lookups.";
		public bool LookupOnCollection = true;
		public string GridViewDisplayMemberPath = "Code";
		public string DataFormDisplayMemberPath = "CodeAndName";
		public string SelectedValuePath;
		public string SelectedValue;
		public string SelectedItem;
		public bool Enum = false;
		public bool ProductConfig = false;
		public bool IsUserMaintainable = true;
		public bool OpenDropDownOnFocus = false;
		public bool IsComboBoxEditable = false;
		public bool IsFilteringEnabled = false;
		public string TextSearchMode = "StartsWith";
		public bool EnabledOnlyOnInsert = false;
		public AggregateType Aggregate = AggregateType.None;

		public string Width;
		public TextAlignment Alignment = TextAlignment.Left;
		public bool IsVisible = false;
		public bool IsReadOnly = false;
		public bool RedGreenDecimalStyle = false;
		public bool SameBasePriceStyle = false;
		public bool PriceLowerThanBaseStyle = false;
		public bool OrderStatusStyle = false;
		public bool QuoteStatusStyle = false;
		public bool BoldStyle = false;
		public bool ChildIndentStyle = false;
		public bool InEditStyle = false;
		public bool CatalogStructureBackgroundStyle = false;
		public bool MultiLineText = false;
		public bool IsUpper = false;
		public int MaxLength = 0;
		public bool AdsIgnore = false;
		public bool AdsReadOnly = false;
		public string AdsLookupProperty;
		public bool UpdateTriggerLostFocus = false;
		public bool DataFormAutoComplete = false;

		public string Mask;
		public string FormatString;
		public string MinValue = "";
		public string MaxValue = "";
		public char PlaceHolder = ' ';
		public bool IsClearButtonVisible = false;
		public MaskType Type = MaskType.Text;

	}

	public enum AggregateType {
		None = 0,
		Count,
		Sum,
		Average,
		AverageMargin,
		AverageCommission,
		SumCurrency
	}

	public enum MaskType {
		Text = 0,
		Numeric,
		Currency,
		DateTime
	}

	public enum TextAlignment {
		Left = 0,
		Right = 1,
		Center = 2,
		Justify = 3
	}

}
