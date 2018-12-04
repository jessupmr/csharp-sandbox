using ConsoleUtilities.Writers;
using System;
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
			Writer consoleWriter = new Writer();
			ExecuteWriter(consoleWriter);
			ExecuteColorWriter(consoleWriter);

			consoleWriter.EmptyLine();
			consoleWriter.Line("Press <enter> to quit.");
			Console.ReadLine();
		}

		static void ExecuteWriter(IWriter write)
		{
			write.Header("Begin: Execute Writer");
			write.EmptyLine();
			write.Line("this is a line.");
			write.Separator();
			write.Append("append ");
			write.Append("this ");
			write.Append("line");
			write.EmptyLine(3);
			write.Header("End: Execute Writer");
		}

		static void ExecuteColorWriter(IWriter write)
		{
			write.SetHeaderLine("++++++++++++++++++++++++++++++");
			write.SetSeparatorLine("<<<<<<<<<<---------->>>>>>>>>>");
			write.SetTextColor(ConsoleColor.White);

			write.Header("Begin: Color Writer (Green)", ConsoleColor.Green);
			write.EmptyLine();
			write.Line("this is a red line.", ConsoleColor.Red);
			write.Separator(ConsoleColor.Yellow);
			write.Append("append ", ConsoleColor.Blue);
			write.Append("this ", ConsoleColor.Cyan);
			write.Append("line", ConsoleColor.Magenta);
			write.EmptyLine(2);
			write.Header("End: Execute Writer (Default)");
		}

	}
}
