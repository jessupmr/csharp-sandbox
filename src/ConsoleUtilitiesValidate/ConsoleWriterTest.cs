using ConsoleUtilities.Writers;
using System;

namespace ConsoleUtilitiesValidate
{
	public class ConsoleWriterTest
	{

		public void Execute()
		{
			ConsoleWriter consoleWriter = new ConsoleWriter();
			ExecuteWriter(consoleWriter);

			ColorConsoleWriter colorWriter = new ColorConsoleWriter();
			ExecuteColorWriter(colorWriter);
		}

		private void ExecuteWriter(IConsoleWriter write)
		{
			write.Header("Begin: Execute Writer");
			write.EmptyLine();
			write.TextLine("this is a line.");
			write.Separator();
			write.Text("append ");
			write.Text("this ");
			write.Text("line");
			write.EmptyLine(3);
			write.Header("End: Execute Writer");
		}

		private void ExecuteColorWriter(IColorConsoleWriter write)
		{
			write.SetHeaderLine("++++++++++++++++++++++++++++++");
			write.SetSeparatorLine("<<<<<<<<<<---------->>>>>>>>>>");

			write.Header("Begin: Color Writer (Green)", ConsoleColor.Green);
			write.EmptyLine();
			write.TextLine("this is a red line.", ConsoleColor.Red);
			write.Separator(ConsoleColor.Yellow);
			write.Text("append ", ConsoleColor.Blue);
			write.Text("this ", ConsoleColor.Cyan);
			write.Text("line", ConsoleColor.Magenta);
			write.EmptyLine(2);
			write.Header("End: Execute Writer (Default)");
		}
	}
}
