using System.Collections.Generic;

namespace Lab1
{
	public static class DataProvider
	{
		public static IEnumerable<ColumnMetadata> GetColumnsMetadata()
		{
			yield return new ColumnMetadata
			{
				OrderNumber = 1,
				HeadText = "Название фирмы",
			};
			yield return new ColumnMetadata
			{
				OrderNumber = 2,
				HeadText = "Янв",
			};
			yield return new ColumnMetadata
			{
				OrderNumber = 3,
				HeadText = "Февр",
			};
			yield return new ColumnMetadata
			{
				OrderNumber = 4,
				HeadText = "Март",
			};
			yield return new ColumnMetadata
			{
				OrderNumber = 4,
				HeadText = "Апрель",
			};
			yield return new ColumnMetadata
			{
				OrderNumber = 5,
				HeadText = "Май",
			};
			yield return new ColumnMetadata
			{
				OrderNumber = 6,
				HeadText = "Июнь",
			};
			yield return new ColumnMetadata
			{
				OrderNumber = 7,
				HeadText = "Всего за полугодие",
				Readonly = true
			};
			yield return new ColumnMetadata
			{
				OrderNumber = 8,
				HeadText = "Среднее кол-во за 1 месяц",
				Readonly = true
			};
		}
	}

	public class ColumnMetadata
	{
		public int OrderNumber { get; set; }
		public string HeadText { get; set; }
		public bool Readonly { get; set; }
	}
}
