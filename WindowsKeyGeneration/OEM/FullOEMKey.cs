using System.Collections.Generic;

namespace WindowsKeyGeneration {
	class FullOEMKey : FullCdKey {

		DateSegment _dateGeneration = new DateSegment();
			public List<string> OEMList(int amount) {
				List<string> _keys = new List<string>();
				for (int i = 0; i < amount; i++) {
					_keys.Add(($"{_dateGeneration.DateString}-OEM-{keySegment(true)}-{generateNumber(0,99999).ToString("D6")}"));
				}
				return  _keys;
			}
		
	}
}
