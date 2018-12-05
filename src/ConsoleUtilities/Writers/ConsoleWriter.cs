using System;

namespace ConsoleUtilities.Writers
{
	public class ConsoleWriter : IConsoleWriter
	{
		protected string _headerLine = "--------------------------------";
		protected string _separatorLine = "---------- ----------- ----------";
		private const int MIN_LINES_TO_ADD = 1;
		private const int MAX_LINES_TO_ADD = 10;

		#region Setters
		public void SetHeaderLine(string headerLine)
		{
			_headerLine = headerLine;
		}

		public void SetSeparatorLine(string separatorLine)
		{
			_separatorLine = separatorLine;
		}
		#endregion

		public void Text(string text)
		{
			Print(text);
		}

		public void TextLine(string text)
		{
			PrintLine(text);
		}

		public void EmptyLine(int numberOfLines = 1)
		{
			if (numberOfLines >= MIN_LINES_TO_ADD && numberOfLines <= MAX_LINES_TO_ADD)
			{
				for (int i = 0; i < numberOfLines; i++)
					PrintLine("");
			}
		}

		public void Header(string text)
		{
			PrintLine(_headerLine);
			PrintLine(text);
			PrintLine(_headerLine);
		}

		public void Separator()
		{
			PrintLine(_separatorLine);
		}

		#region Protected Methods
		protected void Print(string text)
		{
			Console.Write(text);
		}

		protected void PrintLine(string text)
		{
			Console.WriteLine(text);
		}
		#endregion
	}
}
