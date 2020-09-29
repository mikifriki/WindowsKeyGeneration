using System;
using System.Linq;

namespace WindowsKeyGeneration {
	class SiteSegment : FirstSegment {
		private string[] _excludedNumbers = new string[] { "333", "444", "555", "666", "777", "888", "999" };
		private string _checkedNumber;

		protected string CheckedNumber {
			get {
				do {
					_checkedNumber = FirstNumbers;
				} while (_excludedNumbers.Contains(_checkedNumber));
				return _checkedNumber;
			}
		}
	}
}
