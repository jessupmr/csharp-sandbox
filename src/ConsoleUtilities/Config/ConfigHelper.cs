using System;
using System.Configuration;

namespace ConsoleUtilities.Config
{
	public class ConfigHelper : IConfigHelper
	{
		#region String
		public string GetStringValue(string key)
		{
			string value = ConfigurationManager.AppSettings.Get(key);

			if (value == null)
				throw new ConfigurationErrorsException($"The key '{key}' was not found.");

			if (string.IsNullOrWhiteSpace(value))
				throw new ConfigurationErrorsException($"The key '{key}' value was empty.");

			return value;
		}

		public string GetStringValue(string key, string defaultValue)
		{
			string value = ConfigurationManager.AppSettings.Get(key);

			if (string.IsNullOrWhiteSpace(value))
				value = defaultValue;

			return value;
		}
		#endregion

		#region Boolean
		public bool GetBooleanValue(string key)
		{
			string strValue = GetStringValue(key);
			if (Boolean.TryParse(strValue, out var value))
				return value;

			throw new FormatException($"Could not convert key value pair '{key}':'{strValue}' to Boolean.");
		}

		public bool GetBooleanValue(string key, bool defaultValue)
		{
			if (Boolean.TryParse(GetStringValue(key, string.Empty), out var value))
				return value;

			return defaultValue;
		}
		#endregion

		#region Double
		public double GetDoubleValue(string key)
		{
			string strValue = GetStringValue(key);
			if (Double.TryParse(strValue, out var value))
				return value;

			throw new FormatException($"Could not convert key value pair '{key}':'{strValue}' to Double.");
		}

		public double GetDoubleValue(string key, double defaultValue)
		{
			if (Double.TryParse(GetStringValue(key, string.Empty), out var value))
				return value;

			return defaultValue;
		}
		#endregion

		#region Integer
		public int GetIntegerValue(string key)
		{
			string strValue = GetStringValue(key);
			if (int.TryParse(strValue, out var value))
				return value;

			throw new FormatException($"Could not convert key value pair '{key}':'{strValue}' to Integer.");
		}

		public int GetIntegerValue(string key, int defaultValue)
		{
			if (int.TryParse(GetStringValue(key, string.Empty), out var value))
				return value;

			return defaultValue;
		}
		#endregion

		#region Connection String
		public string GetConnectionString(string key)
		{
			return ConfigurationManager.ConnectionStrings[key].ConnectionString;
		}
		#endregion
	}
}
