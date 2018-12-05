using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtilities.Writers
{
	public interface IConsoleWriter
	{
		void SetHeaderLine(string headerLine);
		void SetSeparatorLine(string separatorLine);

		void Text(string text);
		void TextLine(string text);
		void EmptyLine(int numberOfLines = 1);
		void Header(string text);
		void Separator();
	}
}
