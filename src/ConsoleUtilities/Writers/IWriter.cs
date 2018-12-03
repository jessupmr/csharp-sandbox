using System;

namespace ConsoleUtilities.Writers
{
	public interface IWriter
	{
		string HeaderLine { get; set; }
		string SeparatorLine { get; set; }

		void Character(string character);
		void Line(string text);
		void EmptyLine();
		void Separator();
		void Header(string text);
	}
}
