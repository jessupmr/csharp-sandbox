using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtilities.Writers
{
	public class Writer : IWriter
	{
		private int _minEmptyLines = 1;
		private int _maxEmptyLines = 10;
		private string _headerLine = "--------------------------------";
		private string _separatorLine = "---------- ---------- ----------";
		private ConsoleColor _textColor = ConsoleColor.Gray;

		#region Constructors
		public Writer() { }
		#endregion

		#region Setters
		public void SetHeaderLine(string line)
		{
			_headerLine = line;
		}
		public void SetSeparatorLine(string line)
		{
			_separatorLine = line;
		}
		public void SetTextColor(ConsoleColor textColor)
		{
			_textColor = textColor;
		}
		#endregion

		#region Append
		public void Append(string text)
		{
			Append(text, _textColor);
		}
		public void Append(string text, ConsoleColor textColor)
		{
			Print(text, textColor);
		}
		#endregion

		#region Empty Line
		public void EmptyLine()
		{
			Console.WriteLine("");
		}
		public void EmptyLine(int numberOfLines)
		{
			if (numberOfLines < _minEmptyLines || numberOfLines > _maxEmptyLines)
				return;

			for (int i = 0; i < numberOfLines; i++)
			{
				EmptyLine();
			}
		}
		#endregion

		#region Header
		public void Header(string text)
		{
			Header(text, _textColor);
		}
		public void Header(string text, ConsoleColor textColor)
		{
			PrintLine(_headerLine, textColor);
			PrintLine(text, textColor);
			PrintLine(_headerLine, textColor);
		}
		#endregion

		#region Line
		public void Line(string text)
		{
			Line(text, _textColor);
		}
		public void Line(string text, ConsoleColor textColor)
		{
			PrintLine(text, textColor);
		}
		#endregion

		#region Separator
		public void Separator()
		{
			Separator(_textColor);
		}
		public void Separator(ConsoleColor textColor)
		{
			PrintLine(_separatorLine, textColor);
		}
		#endregion

		#region Private Methods
		private void Print(string text, ConsoleColor textColor)
		{
			var currentColor = Console.ForegroundColor;
			Console.ForegroundColor = textColor;
			Console.Write(text);
			Console.ForegroundColor = currentColor;
		}
		private void PrintLine(string text, ConsoleColor textColor)
		{
			var currentColor = Console.ForegroundColor;
			Console.ForegroundColor = textColor;
			Console.WriteLine(text);
			Console.ForegroundColor = currentColor;
		}
		#endregion
	}
}
