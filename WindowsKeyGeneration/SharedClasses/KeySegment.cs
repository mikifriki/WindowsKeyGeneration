using System.Linq;

namespace WindowsKeyGeneration {
	partial class FullCdKey {
		protected string keySegment(bool _fixedDigit = false) {
			bool _validKey = false;
			while (!_validKey) {
				generateIntArray();
				var _lastItem = _keySegment.Last();
				var _listSum = _keySegment.Sum();
				if (_lastItem != 0 && _lastItem <= 8 && _listSum % 7 == 0) {
					_validKey = true;
					_key = string.Join("", _keySegment);
				}
				else {
					generateIntArray();
				}
			}
			return _key;
		}
	}
}
