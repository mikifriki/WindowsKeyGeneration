using System.Collections.Generic;


namespace WindowsKeyGeneration {
	partial class FullCdKey : SiteSegment {
		private List<int> generateIntArray(int _amount = 7) {
			List<int> _intList = new List<int>(_amount);
			for (int i = 0; _amount > i; i++) {
				_intList.Add(generateNumber(0, 10));
			}
			return _keySegment = _intList; ;
		}
	}
}
