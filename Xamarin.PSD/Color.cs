using System;

namespace Xamarin.PSD
{
	public struct Color
	{
		public Color (byte r, byte g, byte b)
		{
			R = r;
			G = g;
			B = b;
		}
		
		public byte R { get; set;}
		public byte G { get; set;}
		public byte B { get; set;}
		
		/*public UIColor AsUIColor
		{
			get
			{
				float r = (float) R / (float) 255;
				float g = (float) G / (float) 255;
				float b = (float) B / (float) 255;
				return new UIColor(r, g, b, 1);
			}
			set
			{
				float r, g, b, a;
				value.GetRGBA(out r, out g, out b, out a);
				R = (byte) (r * 255);
				G = (byte) (g * 255);
				B = (byte) (b * 255);
			}
		}*/
	}
}

