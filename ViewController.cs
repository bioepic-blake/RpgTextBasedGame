using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;



namespace RPG3
{
	public partial class ViewController : UIViewController
	{
		playerStatsControl PSC;
		oldHouseVC OHvc;
		boatHouseVC BHvc;
		mineVC Mvc;
		forestVC FOrestvc;
		fieldVC Fvc;
		lakeVC Lvc;

		public int _playerHealth;
		public static int _playerSpeed;
		public static int _playerDamage;


		private UIButton _subButton;
		private UIButton _AddButton;
		private UIButton _travelBTN;

		private UITextField _TfArea;
		private UITextField _tfAreaString;

		private UILabel _LBLarea;

		private string[] array1;
		private int movementNumber = 0;
		private string areaString;
		public int PH;

		public string Player_Health;
		public string Player_Damage;
		public string Player_Speed;




		public ViewController()
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			NavigationItem.Title = "start";
			View.BackgroundColor = UIColor.White;
			// Perform any additional setup after loading the view, typically from a nib.
			btnADDM();
			TFareaNum();
			btnSub();
			LBLareaM();
			arrayArea();
			_tfAreaM();
			startAreaString();
			TravelBTN();
			playerStatsM();


			_travelBTN.TouchUpInside += BtnTravelC;
			_subButton.TouchUpInside += BtnSubC;
			_AddButton.TouchUpInside += BtnAddC;
		}

		public void playerStatsM()
		{
			PSC = new playerStatsControl();

			PSC.playerIN();

			int PlayerH = PSC._PlayerHealth;
			Player_Health = PlayerH.ToString();



			int PlayerD = PSC._PlayerDamage;
			Player_Damage = PlayerD.ToString();


			int PlayerS = PSC._PlayerSpeed;
			Player_Speed = PlayerS.ToString();

		}





		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}


		//------------------------------------------------
		private void BtnTravelC(object sender, EventArgs e)
		{



			if (movementNumber == 0)
			{
				OHvc = new oldHouseVC();
				this.NavigationController.PushViewController(OHvc, true);

				OHvc.Player_Health = Player_Health;
				OHvc.Player_Speed = Player_Speed;
				OHvc.Player_Damage = Player_Damage;


			}
			else if (movementNumber == 1)
			{
				BHvc = new boatHouseVC();
				this.NavigationController.PushViewController(BHvc, true);

				BHvc.Player_Health = Player_Health;
				BHvc.Player_Speed = Player_Speed;
				BHvc.Player_Damage = Player_Damage;


			}
			else if (movementNumber == 2)
			{
				Mvc = new mineVC();
				this.NavigationController.PushViewController(Mvc, true);

				Mvc.Player_Health = Player_Health;
				Mvc.Player_Speed = Player_Speed;
				Mvc.Player_Damage = Player_Damage;



			}
			else if (movementNumber == 3)
			{
				FOrestvc = new forestVC();
				this.NavigationController.PushViewController(FOrestvc, true);

				FOrestvc.Player_Health = Player_Health;
				FOrestvc.Player_Speed = Player_Speed;
				FOrestvc.Player_Damage = Player_Damage;


			}
			else if (movementNumber == 4)
			{
				Fvc = new fieldVC();
				this.NavigationController.PushViewController(Fvc, true);

				Fvc.Player_Health = Player_Health;
				Fvc.Player_Speed = Player_Speed;
				Fvc.Player_Damage = Player_Damage;


			}
			else if (movementNumber == 5)
			{
				Lvc = new lakeVC();
				this.NavigationController.PushViewController(Lvc, true);

				Lvc.Player_Health = Player_Health;
				Lvc.Player_Speed = Player_Speed;
				Lvc.Player_Damage = Player_Damage;


			}
		}



		private void BtnSubC(object sender, EventArgs e)
		{

			if (movementNumber <= 0)
			{
				movementNumber = 0;
				_TfArea.Text = movementNumber.ToString();
			}
			else
			{
				movementNumber--;
				_TfArea.Text = movementNumber.ToString();
			}


			if (movementNumber == 0)
			{
				areaString = array1[0];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 1)
			{
				areaString = array1[1];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 2)
			{
				areaString = array1[2];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 3)
			{
				areaString = array1[3];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 4)
			{
				areaString = array1[4];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 5)
			{
				areaString = array1[5];
				_tfAreaString.Text = areaString;
			}

		}


		private void BtnAddC(object sender, EventArgs e)
		{

			if (movementNumber >= 5)
			{
				movementNumber = 5;
				_TfArea.Text = movementNumber.ToString();
			}
			else
			{
				movementNumber++;
				_TfArea.Text = movementNumber.ToString();
			}
			if (movementNumber == 0)
			{
				areaString = array1[0];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 1)
			{
				areaString = array1[1];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 2)
			{
				areaString = array1[2];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 3)
			{
				areaString = array1[3];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 4)
			{
				areaString = array1[4];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 5)
			{
				areaString = array1[5];
				_tfAreaString.Text = areaString;
			}
		}

		private void startAreaString()
		{
			if (movementNumber == 0)
			{
				areaString = array1[0];
				_tfAreaString.Text = areaString;
			}
		}

		private void btnADDM()
		{
			var rect = new CGRect(25, 155, 50, 50);
			_AddButton = new UIButton(rect);
			_AddButton.Layer.BorderWidth = 3f;
			_AddButton.Layer.BorderColor = UIColor.Blue.CGColor;
			_AddButton.Layer.CornerRadius = 15f;
			_AddButton.BackgroundColor = UIColor.LightGray;
			_AddButton.SetTitle("+", UIControlState.Normal);
			View.Add(_AddButton);
		}



		private void TFareaNum()
		{
			var rect = new CGRect(25, 75, 50, 50);
			_TfArea = new UITextField(rect);
			_TfArea.Layer.BorderColor = UIColor.Black.CGColor;
			_TfArea.Layer.BorderWidth = 3f;
			_TfArea.Layer.CornerRadius = 5f;
			_TfArea.Text = "0";
			_TfArea.TextAlignment = UITextAlignment.Center;
			View.Add(_TfArea);
		}

		private void _tfAreaM()
		{
			var rect = new CGRect(80, 75, 150, 50);
			_tfAreaString = new UITextField(rect);
			_tfAreaString.Layer.BorderWidth = 3f;
			_tfAreaString.Layer.BorderColor = UIColor.Black.CGColor;
			_tfAreaString.Layer.CornerRadius = 5f;
			_tfAreaString.TextAlignment = UITextAlignment.Center;

			View.Add(_tfAreaString);
		}

		private void btnSub()
		{
			var rect = new CGRect(80, 155, 50, 50);
			_subButton = new UIButton(rect);
			_subButton.Layer.BorderWidth = 3f;
			_subButton.Layer.BorderColor = UIColor.Blue.CGColor;
			_subButton.Layer.CornerRadius = 15f;
			_subButton.BackgroundColor = UIColor.LightGray;
			_subButton.SetTitle("_", UIControlState.Normal);
			View.Add(_subButton);
		}

		private void TravelBTN()
		{
			var rect = new CGRect(80, 370, 150, 50);
			_travelBTN = new UIButton(rect);
			_travelBTN.Layer.BorderWidth = 3f;
			_travelBTN.Layer.BorderColor = UIColor.Blue.CGColor;
			_travelBTN.Layer.CornerRadius = 15f;
			_travelBTN.BackgroundColor = UIColor.LightGray;
			_travelBTN.SetTitle("travel", UIControlState.Normal);
			View.Add(_travelBTN);

		}

		private void LBLareaM()
		{
			var rect = new CGRect(25, 210, 300, 175);
			_LBLarea = new UILabel(rect);
			UILineBreakMode NSLineBreakByWordWrapping = default(UILineBreakMode);
			_LBLarea.LineBreakMode = NSLineBreakByWordWrapping;
			_LBLarea.Lines = 10;
			_LBLarea.Text = $"where would you like to go:{Environment.NewLine} 0 = old house {Environment.NewLine} 1 = boat house {Environment.NewLine} 2 = mine {Environment.NewLine} 3 = forest {Environment.NewLine} 4 = field {Environment.NewLine} 5 = lake";
			View.Add(_LBLarea);
		}

		private void arrayArea()
		{
			array1 = new string[6];
			array1[0] = "old house";
			array1[1] = "boat house";
			array1[2] = "mine";
			array1[3] = "forest";
			array1[4] = "field";
			array1[5] = "lake";
		}
	}
}
