using ConsoleUtilities.Config;
using ConsoleUtilities.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtilitiesValidate
{
	public class ConfigHelperTest
	{
		ConsoleWriter _write = new ConsoleWriter();
		ConfigHelper _config = new ConfigHelper();

		public void Execute()
		{
			StringTest();
			IntegerTest();
			DoubleTest();
			BooleanTest();
		}

		#region String
		private void StringTest()
		{
			_write.Header("Begin: String Tests");

			string val = StringValue("goodstring");
			_write.TextLine($"Good Value    | Expect: 'wyatt'       | Actual: '{val}'");

			val = StringValue("emptystring");
			_write.TextLine($"Empty Value   | Expect: empty error   | Actual: {val}");

			val = StringValue("missingstring");
			_write.TextLine($"Missing Value | Expect: missing error | Actual: {val}");

			val = StringDefault("emptystring", "natalie");
			_write.TextLine($"Default Value | Expect: 'natalie'     | Actual: '{val}'");

			_write.Header("End: String Tests");
		}
		private string StringValue(string key)
		{
			try
			{
				return _config.GetStringValue(key);
			}
			catch(Exception e)
			{
				return e.Message;
			}
		}
		private string StringDefault(string key, string dfltval)
		{
			try
			{
				return _config.GetStringValue(key, dfltval);
			}
			catch (Exception e)
			{
				return e.Message;
			}
		}
		#endregion

		#region Integer
		private void IntegerTest()
		{
			_write.Header("Begin: Integer Tests");

			PerformIntTest("Good Value     | Expected: 42            | Actual: ", "goodint");
			PerformIntTest("Empty Value    | Expected: empty error   | Actual: ", "emptyint");
			PerformIntTest("Missing Value  | Expected: missing error | Actual: ", "missingint");
			PerformIntTest("Bad Value      | Expected: bad error     | Actual: ", "badint");
			PerformIntTest("Default Value  | Expected: 99            | Actual: ", "emptyint", 99);

			_write.Header("End: Integer Tests");
		}
		private int IntValue(string key)
		{
			int val = int.MinValue;

			try
			{
				val = _config.GetIntegerValue(key);
			}
			catch (Exception e)
			{
				_write.Text(e.Message);
			}

			return val;
		}
		private int IntValue(string key, int dfltval)
		{
			int val = -1;

			try
			{
				return _config.GetIntegerValue(key, dfltval);
			}
			catch (Exception e)
			{
				_write.Text(e.Message);
			}

			return val;
		}
		private void PerformIntTest(string setup, string key)
		{
			_write.Text(setup);
			int val = IntValue(key);
			if (val != int.MinValue) _write.Text(val.ToString());
			_write.Text("\r\n");
		}
		private void PerformIntTest(string setup, string key, int dfltValue)
		{
			_write.Text(setup);
			int val = IntValue(key, dfltValue);
			if (val != int.MinValue) _write.Text(val.ToString());
			_write.Text("\r\n");
		}
		#endregion

		#region Double
		private void DoubleTest()
		{
			_write.Header("Begin: Double Tests");

			PerformDoubleTest("Good Value     | Expected: 4.56          | Actual: ", "gooddouble");
			PerformDoubleTest("Empty Value    | Expected: empty error   | Actual: ", "emptydouble");
			PerformDoubleTest("Missing Value  | Expected: missing error | Actual: ", "missingdouble");
			PerformDoubleTest("Bad Value      | Expected: bad error     | Actual: ", "baddouble");
			PerformDoubleTest("Default Value  | Expected: 99.99         | Actual: ", "emptydouble", 99.99);
			PerformDoubleTest("Default Value  | Expected: 99.97         | Actual: ", "missingdouble", 99.97);

			_write.Header("End: Double Tests");
		}
		private double DoubleValue(string key)
		{
			double val = double.MinValue;

			try
			{
				val = _config.GetDoubleValue(key);
			}
			catch (Exception e)
			{
				_write.Text(e.Message);
			}

			return val;
		}
		private double DoubleValue(string key, double dfltValue)
		{
			double val = double.MinValue;

			try
			{
				val = _config.GetDoubleValue(key, dfltValue);
			}
			catch (Exception e)
			{
				_write.Text(e.Message);
			}

			return val;
		}
		private void PerformDoubleTest(string setup, string key)
		{
			_write.Text(setup);
			double val = DoubleValue(key);
			if (val != double.MinValue) _write.Text(val.ToString());
			_write.Text("\r\n");
		}
		private void PerformDoubleTest(string setup, string key, double dfltValue)
		{
			_write.Text(setup);
			double val = DoubleValue(key, dfltValue);
			if (val != double.MinValue) _write.Text(val.ToString());
			_write.Text("\r\n");
		}
		#endregion

		#region Boolean
		private void BooleanTest()
		{
			_write.Header("Begin: Boolean Tests");

			PerformBoolTest("True Value     | Expected: true          | Actual: ", "truebool");
			PerformBoolTest("False Value    | Expected: false         | Actual: ", "falsebool");
			PerformBoolTest("Empty Value    | Expected: empty error   | Actual: ", "emptybool");
			PerformBoolTest("Missing Value  | Expected: missing error | Actual: ", "missingbool");
			PerformBoolTest("Bad Value      | Expected: bad error     | Actual: ", "badbool");
			PerformBoolTest("Default True   | Expected: true          | Actual: ", "emptydouble", true);
			PerformBoolTest("Default False  | Expected: false         | Actual: ", "missingdouble", false);

			_write.Header("End: Boolean Tests");
		}
		private bool? BoolValue(string key)
		{
			bool? val = null;

			try
			{
				val = _config.GetBooleanValue(key);
			}
			catch (Exception e)
			{
				_write.Text(e.Message);
			}

			return val;
		}
		private bool? BoolValue(string key, bool dfltValue)
		{
			bool? val = null;

			try
			{
				val = _config.GetBooleanValue(key, dfltValue);
			}
			catch (Exception e)
			{
				_write.Text(e.Message);
			}

			return val;
		}
		private void PerformBoolTest(string setup, string key)
		{
			_write.Text(setup);
			bool? val = BoolValue(key);
			if (val.HasValue) _write.Text(val.ToString());
			_write.Text("\r\n");
		}
		private void PerformBoolTest(string setup, string key, bool dfltValue)
		{
			_write.Text(setup);
			bool? val = BoolValue(key, dfltValue);
			if (val.HasValue) _write.Text(val.ToString());
			_write.Text("\r\n");
		}
		#endregion
	}
}
