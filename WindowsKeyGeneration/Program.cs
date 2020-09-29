using System;

namespace WindowsKeyGeneration {
	class Program {
		static void Main() {
			FullCdKey _cdKey = new FullCdKey();
			FullOEMKey _OEMKey = new FullOEMKey();

			Console.WriteLine("Which key to generate? (CdKey, OEMKey)");
			string _keyType = Console.ReadLine();

			if (_keyType.ToLower() == "cdkey") {
				Console.WriteLine("CdKey: \n");
				Console.WriteLine("How many Keys to generate? \n");
				int _keyAmount = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("\n");
				Console.WriteLine(string.Join("\n", _cdKey.keyList(_keyAmount)));
			} else { 
				Console.WriteLine("OEMKey: \n");
				Console.WriteLine("How many Keys to generate? \n");
				int _OEMAmount = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("\n");
				Console.WriteLine(string.Join("\n", _OEMKey.OEMList(_OEMAmount)));
			}
		}
	}
}
