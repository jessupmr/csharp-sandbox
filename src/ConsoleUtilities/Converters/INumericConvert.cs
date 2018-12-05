using System;

namespace ConsoleUtilities.Converters
{
	public interface INumericConvert
	{
		int ToInt(string value);
		int ToInt(string value, int defaultValue);
		int? ToIntNullable(string value);

		double ToDouble(string value);
		double ToDouble(string value, double defaultValue);
		double? ToDoubleNullable(string value);

		decimal ToDecimal(string value);
		decimal ToDecimal(string value, decimal defaultValue);
		decimal? ToDecimalNullable(string value);

		float ToFloat(string value);
		float ToFloat(string value, float defaultValue);
		float? ToFloatNullable(string value);
	}
}
