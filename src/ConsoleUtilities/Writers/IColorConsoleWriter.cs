using System;

namespace ConsoleUtilities.Writers
{
	public interface IColorConsoleWriter : IConsoleWriter
	{
		void Text(string text, ConsoleColor textColor);
		void TextLine(string text, ConsoleColor textColor);
		void Header(string text, ConsoleColor textColor);
		void Separator(ConsoleColor textColor);
	}
}
