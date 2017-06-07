using System;
using UIKit;
using CoreGraphics;
namespace RPG3
{


	public class DeadViewControler : UIViewController
	{

		public UILabel _lblDead;

		public DeadViewControler()
		{
		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			endGameLbl();
			NavigationItem.Title = "Lake";
			View.BackgroundColor = UIColor.White;

		}
		public void endGameLbl()
		{
			var rect = new CGRect(150, 250,150,50);
			_lblDead = new UILabel(rect);
			_lblDead.Text = "you are dead";
			View.Add(_lblDead);
		}
	}
}
