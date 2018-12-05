using ConsoleUtilities.Writers;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtilitiesValidate
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleWriter consoleWriter = new ConsoleWriter();

			//DoConsoleWriter();
			DoConfigHelper();


			consoleWriter.EmptyLine();
			consoleWriter.TextLine("Press <enter> to quit.");
			Console.ReadLine();
		}

		static void DoConsoleWriter()
		{
			ConsoleWriterTest test = new ConsoleWriterTest();
			test.Execute();
		}

		static void DoConfigHelper()
		{
			ConfigHelperTest test = new ConfigHelperTest();
			test.Execute();
		}
	}
}
