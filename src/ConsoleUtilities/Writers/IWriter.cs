using System;

namespace ConsoleUtilities.Writers
{
	public interface IWriter
	{
		void SetHeaderLine(string line);
		void SetSeparatorLine(string line);
		void SetTextColor(ConsoleColor textColor);

		void Append(string text);
		void Append(string text, ConsoleColor textColor);

		void Line(string text);
		void Line(string text, ConsoleColor textColor);

		void EmptyLine();
		void EmptyLine(int numberOfLines);

		void Separator();
		void Separator(ConsoleColor textColor);

		void Header(string text);
		void Header(string text, ConsoleColor textColor);
	}
}
