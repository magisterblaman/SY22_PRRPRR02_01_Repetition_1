using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_01_Repetition_1 {
	internal class Program {
		static void Main(string[] args) {
			Console.WriteLine("Skriv ditt personnummer:");
			string personnummer = Console.ReadLine();

			if (personnummer == "188603240000") {
				Console.WriteLine("Du är världens äldsta person, grattis");
			} else {
				Console.WriteLine("Synd");
			}
		}
	}
}
