using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtilities.Converters
{
	public class NumericConvert : INumericConvert
	{
		#region Integer
		public int ToInt(string value)
		{
			int? returnValue = ToIntNullable(value);
			if (returnValue.HasValue)
				return returnValue.Value;
			else
				throw new Exception($"Cannot convert '{value}' to Integer.");
		}
		public int ToInt(string value, int defaultValue)
		{
			int? returnValue = ToIntNullable(value);
			return returnValue.HasValue ? returnValue.Value : defaultValue;
		}
		public int? ToIntNullable(string value)
		{
			if (int.TryParse(value, out var outValue))
				return outValue;
			else
				return null;
		}
		#endregion

		#region Double
		public double ToDouble(string value)
		{
			double? returnValue = ToDoubleNullable(value);
			if (returnValue.HasValue)
				return returnValue.Value;
			else
				throw new Exception($"Cannot convert '{value}' to Double.");
		}
		public double ToDouble(string value, double defaultValue)
		{
			double? returnValue = ToDoubleNullable(value);
			return returnValue.HasValue ? returnValue.Value : defaultValue;
		}
		public double? ToDoubleNullable(string value)
		{
			if (double.TryParse(value, out var outValue))
				return outValue;
			else
				return null;
		}
		#endregion

		#region Decimal
		public decimal ToDecimal(string value)
		{
			decimal? returnValue = ToDecimalNullable(value);
			if (returnValue.HasValue)
				return returnValue.Value;
			else
				throw new Exception($"Cannot convert '{value}' to Decimal.");
		}
		public decimal ToDecimal(string value, decimal defaultValue)
		{
			decimal? returnValue = ToDecimalNullable(value);
			return returnValue.HasValue ? returnValue.Value : defaultValue;
		}
		public decimal? ToDecimalNullable(string value)
		{
			if (decimal.TryParse(value, out var outValue))
				return outValue;
			else
				return null;
		}
		#endregion

		#region Float
		public float ToFloat(string value)
		{
			float? returnValue = ToFloatNullable(value);
			if (returnValue.HasValue)
				return returnValue.Value;
			else
				throw new Exception($"Cannot convert '{value}' to Float.");

		}
		public float ToFloat(string value, float defaultValue)
		{
			float? returnValue = ToFloatNullable(value);
			return returnValue.HasValue ? returnValue.Value : defaultValue;
		}
		public float? ToFloatNullable(string value)
		{
			if (float.TryParse(value, out var outValue))
				return outValue;
			else
				return null;
		}
		#endregion
	}
}
