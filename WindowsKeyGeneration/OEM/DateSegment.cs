namespace WindowsKeyGeneration {
	class DateSegment : FirstSegment {
		private string _dateString;

		public DateSegment(int min = 336, int max = 366) : base(min, max) { }

		public string DateString {
			get {
				_dateString = generateNumber(1995, 2003).ToString().Remove(0, 2);
				return ($"{FirstNumbers}{_dateString}"); 
			}
		}
	}
}
