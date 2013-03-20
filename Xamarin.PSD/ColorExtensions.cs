using System;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using System.Runtime.InteropServices;

namespace Xamarin.PSD
{
	[StructLayout(LayoutKind.Explicit, Size=4)]
	public struct Color {
		[FieldOffset(0)]
		public byte A;

		[FieldOffset(1)]
		public byte R;

		[FieldOffset(2)]
		public byte G;

		[FieldOffset(3)]
		public byte B;

		public Color(byte a, byte r, byte g, byte b) {
			A = a;
			R = r;
			G = g;
			B = b;
		}

		public static Color FromArgb(int r, int g, int b) {
			return new Color(0, (byte)r, (byte)g, (byte)b);
		}

		public override string ToString ()
		{
			return string.Format ("({0}, {1}, {2}, {3})", A, R, G, B);
		}
	}
}

