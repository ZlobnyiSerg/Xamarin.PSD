using System;
using MonoTouch.CoreGraphics;
using MonoTouch.UIKit;

namespace Xamarin.PSD
{
	public class ImageConverter
	{
		public static UIImage BufferToImage (Color[] buffer, int width, int height)
		{
			byte[] bytes = new byte[buffer.Length * 4];
			int j = 0;
			for (int i=0; i<buffer.Length; i++, j+= 4) {
				bytes[j+0] = buffer[i].R;
				bytes[j+1] = buffer[i].G;
				bytes[j+2] = buffer[i].B;
				bytes[j+3] = 255;
			}
			CGDataProvider dataProvider = new CGDataProvider(bytes, 0, bytes.Length);
			CGImage image = new CGImage(
				width, 
				height, 
				8, 
				32, 
				4 * width, 
				CGColorSpace.CreateDeviceRGB(), 
				CGBitmapFlags.ByteOrderDefault | CGBitmapFlags.Last, 
				dataProvider, 
				null, 
				false, 
				CGColorRenderingIntent.Default
			);
			return new UIImage(image);
		}
	}
}

