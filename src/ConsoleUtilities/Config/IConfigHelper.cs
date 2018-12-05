
namespace ConsoleUtilities.Config
{
	public interface IConfigHelper
	{
		string GetStringValue(string key);
		string GetStringValue(string key, string defaultValue);

		int GetIntegerValue(string key);
		int GetIntegerValue(string key, int defaultValue);

		double GetDoubleValue(string key);
		double GetDoubleValue(string key, double defaultValue);

		bool GetBooleanValue(string key);
		bool GetBooleanValue(string key, bool defaultValue);

		string GetConnectionString(string key);
	}
}
