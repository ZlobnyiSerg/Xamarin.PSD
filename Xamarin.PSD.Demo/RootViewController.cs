using System;
using MonoTouch.UIKit;
using System.Diagnostics;

namespace Xamarin.PSD.Demo
{
	public class RootViewController : UIViewController
	{
		public RootViewController ()
		{
		}

		public override void LoadView ()
		{
			base.LoadView ();
			UIImageView test = new UIImageView();
			Stopwatch sw = new Stopwatch();
			sw.Start ();
			CPSD psd = new CPSD("Demo1.psd");
			sw.Stop ();
			Console.WriteLine(" ========= PSD LOAD TIME: {0} =========", sw.Elapsed);
			Console.WriteLine("{0}x{1}", psd.GetWidth(), psd.GetHeight());
			Console.WriteLine("First pixels: {0};{1};{2}", psd.Buffer[0], psd.Buffer[1], psd.Buffer[2]);
			sw.Restart();
			test.Image = ImageConverter.BufferToImage(psd.Buffer, psd.GetWidth(), psd.GetHeight());
			sw.Stop ();
			Console.WriteLine(" ========= CONVERT TIME: {0} =========", sw.Elapsed);
			test.ContentMode = UIViewContentMode.TopLeft;
			View = test;
		}
	}
}

