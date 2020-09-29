using System;

namespace WindowsKeyGeneration {
	class FirstSegment {
		private Random rnd = new Random();
		private int _minNumber;
		private int _maxNumber;
		private int _firstNumbers;

		public FirstSegment(int min = 0, int max = 999) {
			_minNumber = min;
			_maxNumber = max;
		}

		public string FirstNumbers {
			get {
				generateNumber(_minNumber, _maxNumber);
				return _firstNumbers.ToString("000");
			}
		}

		protected int generateNumber(int min, int max) {
			return _firstNumbers = rnd.Next(min, max);
		}

	}
}
