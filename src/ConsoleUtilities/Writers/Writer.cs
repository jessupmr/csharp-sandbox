using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtilities.Writers
{
	public class Writer : IWriter
	{
		#region Constructors
		public Writer() : this("--------------------------------", "---------- ---------- ----------") { }

		public Writer(string HeaderLine, string SeparatorLine)
		{
			this.HeaderLine = HeaderLine;
			this.SeparatorLine = SeparatorLine;
		}
		#endregion

		#region Properties
		public string HeaderLine { get; set; }
		public string SeparatorLine { get; set; }

		public void Character(string character)
		{
			throw new NotImplementedException();
		}

		public void EmptyLine()
		{
			throw new NotImplementedException();
		}

		public void Header(string text)
		{
			throw new NotImplementedException();
		}

		public void Line(string text)
		{
			throw new NotImplementedException();
		}

		public void Separator()
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
