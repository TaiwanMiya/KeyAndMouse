using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Example
{
	class DetectSingleKey
	{
		public static void Do(Action action)
		{
			Console.WriteLine("Press ESC to exit");
			Program.kmEvent.KeyPress += (sender, e) =>
			{
				action();
			};
		}
	}
}
