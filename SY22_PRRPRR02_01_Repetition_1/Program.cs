using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_01_Repetition_1 {
	internal class Program {
		static void Main(string[] args) {
			Console.WriteLine("Hur gammal är du?");
			string ageInput = Console.ReadLine();

			int age = int.Parse(ageInput);

			if (age >= 20) {
				Console.WriteLine("Välkommen in");
			} else if (age < 12) {
				Console.WriteLine("Välkommen in i målsmans sällskap");
			} else {
				Console.WriteLine("Hejdå");
			}
		}
	}
}
