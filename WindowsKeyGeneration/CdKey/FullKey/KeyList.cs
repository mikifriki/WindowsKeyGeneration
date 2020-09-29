using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsKeyGeneration {
	partial class FullCdKey {
		public List<string> keyList(int amount) {
			List<string> _keys = new List<string>();
			for (int i = 0; i < amount; i++) {
				_keys.Add(String.Format("{0}-{1}", CheckedNumber, keySegment()));
			}
			return  _keys;
		}
	}
}
