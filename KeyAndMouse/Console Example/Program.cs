using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heptad.Dick.WinSystem.KeyboardMouse;

namespace Console_Example
{
	class Program
	{
		private static Dictionary<string, IKeyboardMouseEvents> MethodsSelector = new Dictionary<string, IKeyboardMouseEvents>()
		{
			{ "1.Global Event", Hook.GlobalEvents() },
			{ "2.App Event", Hook.AppEvents() },
		};

		private static Dictionary<string, Action<Action>> ActionSelector = new Dictionary<string, Action<Action>>()
		{
			{ "1.Detect single key", DetectSingleKey.Do },
			{ "2.Detect combination key", DetectCombinationKey.Do },
			{ "3.Detect sequence key", DetectSequenceKey.Do },
		};

		public static IKeyboardMouseEvents kmEvent { get; private set; }
		private static Action<Action> action { get; set; }

		static void Main(string[] args)
		{
			ConsoleMethods("Choose your events:", MethodsSelector, kmEvent);
			restart:
			ConsoleMethods("Enter what you want to test:", ActionSelector, action);
			if (action == null)
				goto restart;
			action(Application.Exit);
		}

		public static void ConsoleMethods<T>(string title, Dictionary<string, T> selector, T setObject)
		{
			restart:
			Console.WriteLine(title);
			Array.ForEach(selector.Keys.ToArray(), item => Console.WriteLine(item));
			char input = Console.ReadKey(true).KeyChar;
			setObject = selector
				.Where(s => s.Key.StartsWith(input.ToString()))
				.Select(s => s.Value)
				.FirstOrDefault();
			if (setObject == null)
				goto restart;
		}

		/// <summary>
		///		Program exit.
		/// </summary>
		/// <param name="quit"></param>
		private static void Exit(Action quit)
		{
			Environment.Exit(0);
		}
	}
}
