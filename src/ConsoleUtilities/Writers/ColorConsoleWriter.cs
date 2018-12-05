using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtilities.Writers
{
	public class ColorConsoleWriter : ConsoleWriter, IColorConsoleWriter
	{
		public void Header(string text, ConsoleColor textColor)
		{
			var currentColor = Console.ForegroundColor;
			Console.ForegroundColor = textColor;
			Header(text);
			Console.ForegroundColor = currentColor;
		}

		public void Separator(ConsoleColor textColor)
		{
			var currentColor = Console.ForegroundColor;
			Console.ForegroundColor = textColor;
			Separator();
			Console.ForegroundColor = currentColor;
		}

		public void Text(string text, ConsoleColor textColor)
		{
			var currentColor = Console.ForegroundColor;
			Console.ForegroundColor = textColor;
			Text(text);
			Console.ForegroundColor = currentColor;
		}

		public void TextLine(string text, ConsoleColor textColor)
		{
			var currentColor = Console.ForegroundColor;
			Console.ForegroundColor = textColor;
			TextLine(text);
			Console.ForegroundColor = currentColor;
		}
	}
}
