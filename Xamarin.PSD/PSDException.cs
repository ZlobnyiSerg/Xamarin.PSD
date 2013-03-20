using System;

namespace Xamarin.PSD
{
	public class PSDException : ApplicationException
	{
		public PSDException () :base() {}
		public PSDException(string message) : base(message) {}
		public PSDException(string message, Exception innerException) : base(message, innerException) {}
	}
}

