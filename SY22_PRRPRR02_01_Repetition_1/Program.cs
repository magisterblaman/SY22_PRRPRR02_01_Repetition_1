using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_01_Repetition_1 {
	internal class Program {
		static void Main(string[] args) {
			Console.WriteLine("Hello world!");

			string namnetPåVariabeln = "Det här är en string";
			Console.WriteLine(namnetPåVariabeln);

			namnetPåVariabeln = "Jag är jättecool 123";
			Console.WriteLine(namnetPåVariabeln);

			string förnamn = "Hannes";
			string efternamn = "Blåman";

			string helaNamnet = förnamn + " " + efternamn;
			Console.WriteLine(helaNamnet);
		}
	}
}
