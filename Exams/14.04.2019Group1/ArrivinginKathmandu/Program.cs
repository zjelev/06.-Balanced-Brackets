using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace ArrivinginKathmandu
{
	class Program
	{
		public static void Main(string[] args)
        {
		
			string lengthPattern = @"=(\d+)<<";

			string input = Console.ReadLine();

			while (input != "Last note")
			{
				Match lengthMatch = Regex.Match(input, lengthPattern);

				if (lengthMatch.Success)
				{
					string currentPattern = $@"^([A-Za-z0-9!@#$?]+)=\d+<<(.{{{lengthMatch.Groups[1].Value}}}$)";

					Match currentFullMatch = Regex.Match(input, currentPattern);

					if (currentFullMatch.Success)
					{
						string name = string
							.Join("", currentFullMatch
							.Groups[1]
							.Value
							.Where(x=>char.IsLetterOrDigit(x)));

						string coordinates = currentFullMatch.Groups[2].Value;

						Console.WriteLine($"Coordinates found! {name} -> {coordinates}");
					}
					else
					{
						Console.WriteLine("Nothing found!");
					}
				}
				else
				{
					Console.WriteLine("Nothing found!");
				}

				input = Console.ReadLine();
			}
		}
	}
}