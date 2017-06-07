using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;
using System.Threading.Tasks;

namespace RPG3
{
	public class lakeVC : UIViewController
	{



DeadViewControler dcv;
		oldHouseVC OHvc;
		boatHouseVC BHvc;
		mineVC Mvc;
		forestVC FOrestvc;
		fieldVC Fvc;
		lakeVC Lvc;

		public int _PlayerHealthIntOut;
		public int _PlayerSpeedIntOut;
		public int _PlayerDamageIntOut;

		public string _playerHealthOut;
		public string _PlayerSpeedOut;
		public string _PlayerDamageOut;

		public string Player_Health;
		public string Player_Damage;
		public string Player_Speed;

		public UITextField _HealthPots;
		public UITextField _PlayerHealth;
		public UITextField _PlayerDamage;
		public UITextField _PlayerSpeed;

		private UITextField _EnermyHealth;
		private UITextField _Enermydamage;
		private UITextField _EnermySpeed;

		private UITextField _TfArea;
		private UITextField _tfAreaString;

		private UILabel _LblNarrater;
		private UILabel _lblPspeed;
		private UILabel _lblPdamage;
		private UILabel _lblPheath;

		private UILabel _lblEhealth;
		private UILabel _lblEdamage;
		private UILabel _lblEspeed;

		private UILabel _tears;
		private UILabel _shield;
		private UILabel _holyWeapon;

		private UIButton _subButton;
		private UIButton _AddButton;
		private UIButton _travelBTN;

		private UIButton _PlayerAttackBtn;
		private UIButton _PlayerDefendBtn;
		private UIButton _playerHealBtn;
		private UIButton _playerRunBtn;

		private string[] array1;
		private int movementNumber = 0;
		public int escape = 0;
		private string areaString;
		public string HealthPotsString;

		public bool travel = false;
		public bool enermyDead = false;
		public bool defendYN = false;

		string EnermyName;
		string EnermyWeapon;

		public bool shieldB = false;
		public bool holy = false;
		public bool spectral = false;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			NavigationItem.Title = "Lake";
			View.BackgroundColor = UIColor.White;

			//======textfields
			PHealth();
			PDamage();
			PSpeed();
			EHealth();
			EDamage();
			ESpeed();

			//============ labels

			lblPdamageM();
			lblPspeedM();
			lblPhealth();
			lblEspeedM();
			lblEdamageM();
			lblEhealth();
			StearsM();
			ShieldM();
			HolyWeaponM();

			//================movement text field's
			TFareaNum();
			_tfAreaM();
			TfHealPOts();
			//=================buttons
			btnADDM();
			btnSub();
			TravelBTN();
			PlayerAttackBTN();
			PlayerDefendBtnM();
			PlayerHealBtnM();
			PlayerRunBtnM();

			//===================other methods to call 
			arrayArea();
			enermyIN();
			LblNt();
			startAreaString();
			playerStatsM();
			pickups();
			//================== button event handlers
			_travelBTN.TouchUpInside += BtnTravelC;
			_subButton.TouchUpInside += BtnSubC;
			_AddButton.TouchUpInside += BtnAddC;
			_PlayerAttackBtn.TouchUpInside += PlayerAttackBtnC;
			_playerRunBtn.TouchUpInside += PlayerRunBtnC;
			_playerHealBtn.TouchUpInside += PlayerHealBtnC;
			_PlayerDefendBtn.TouchUpInside += PlayerDefendBtnC;


		}
		//==============enermy attack method ==================================
		public void enermyAttack()
		{
			int Phelth = Int32.Parse(_PlayerHealth.Text);
			int Edamage = Int32.Parse(_Enermydamage.Text);
			int result = Phelth - Edamage;
			string resultS = result.ToString();

			if (enermyDead == false)
			{
				_PlayerHealth.Text = resultS;

				string narator = $" the {EnermyName} atacked you with {EnermyWeapon} for {_Enermydamage.Text} damage";
				_LblNarrater.Text = _LblNarrater.Text + narator;
			}
			else
			{
				string narator = $" the enermy is dead";
				_LblNarrater.Text = _LblNarrater.Text + narator;
				travel = true;
			}
			int PH = Int32.Parse(_PlayerHealth.Text);
			if (PH <= 0)
			{
				string healed = "you have died your corps shall join the damed in hanting this place";
				_LblNarrater.Text = healed;
				_PlayerHealth.Text = "dead";
			}
            Exit();
		}
		public void enermyAttackDouble()//================enermy doble damage=========
		{
			int Phelth = Int32.Parse(_PlayerHealth.Text);
			int Edamage = Int32.Parse(_Enermydamage.Text);
			Edamage = Edamage * 2;
			int result = Phelth - Edamage;
			string resultS = result.ToString();

			if (enermyDead == false)
			{
				_PlayerHealth.Text = resultS;


				string narator = $" the {EnermyName} atacked you with {EnermyWeapon} for {Edamage} damage";
				_LblNarrater.Text = _LblNarrater.Text + narator;
			}
			else
			{
				string narator = $" the enermy is dead";
				_LblNarrater.Text = _LblNarrater.Text + narator;
				travel = true;
			}
			int PH = Int32.Parse(_PlayerHealth.Text);
			if (PH <= 0)
			{
				string healed = "you have died your corps shall join the damed in hanting this place";
				_LblNarrater.Text = healed;
				_PlayerHealth.Text = "dead";
			}
            Exit();
		}
		public void enermyAttackHalf()//============================== enermy half damage
		{
			int Phelth = Int32.Parse(_PlayerHealth.Text);
			int Edamage = Int32.Parse(_Enermydamage.Text);
			Edamage = Edamage / 4;
			int result = Phelth - Edamage;
			string resultS = result.ToString();

			if (enermyDead == false)
			{
				_PlayerHealth.Text = resultS;


				string narator = $" the {EnermyName} atacked you with {EnermyWeapon} for {Edamage} damage";
				_LblNarrater.Text = _LblNarrater.Text + narator;
			}
			else
			{
				string narator = $" the enermy is dead";
				_LblNarrater.Text = _LblNarrater.Text + narator;
				travel = true;
			}
			int PH = Int32.Parse(_PlayerHealth.Text);
			if (PH <= 0)
			{
				string healed = "you have died your corps shall join the damed in hanting this place";
				_LblNarrater.Text = healed;
				_PlayerHealth.Text = "dead";
			}
            Exit();
		}
		//============== player attack buttons  ===================================================
		private void PlayerAttackBtnC(object sender, EventArgs e)
		{
			try
			{
				if (spectral == true)
				{
					int Ehealth = Int32.Parse(_EnermyHealth.Text);
					int Pdamage = Int32.Parse(_PlayerDamage.Text);
					int result = Ehealth - Pdamage;
					string resultS = result.ToString();

					if (Ehealth <= 7)
					{ travel = true; }

					if (result >= 1)
					{
						_EnermyHealth.Text = resultS;

						string narator = $"you attacked for {_PlayerDamage.Text} damage";
						_LblNarrater.Text = narator;
						enermyAttack();
					}
					else if (result <= 0)
					{
						_EnermyHealth.Text = "dead";
						enermyDead = true;
						travel = true;


						string narator = $"the {EnermyName} has retreated back under water ";
						_LblNarrater.Text = narator;
						string pots = "2";
						_HealthPots.Text = pots;
					}
					int PH = Int32.Parse(_PlayerHealth.Text);
					if (PH <= 0)
					{
						string healed = "you have died your corps shall join the damed in hanting this place";
						_LblNarrater.Text = healed;
						_PlayerHealth.Text = "dead";
					}
				}
				else
				{
					string narator = "no efective wepon paddle faster";
					_LblNarrater.Text = narator;
				}
			}
			catch
			{
				string EnermyIsDead = "you cant attack a dead enermy";
				_LblNarrater.Text = EnermyIsDead;
			}
		}
		private void PlayerDefendBtnC(object sender, EventArgs e)//============================defend button
		{
			if (defendYN == true)
			{
				string narator = $" you hid behind the shiled taking no damage ";
				_LblNarrater.Text = narator;
				enermyAttackHalf();
			}
			else
			{
				string narator = $"you dont have a shiled doble damage taken ";
				_LblNarrater.Text = narator;
				enermyAttackDouble();
			}
			int PH = Int32.Parse(_PlayerHealth.Text);
			if (PH <= 0)
			{
				string healed = "you have died your corps shall join the damed in hanting this place";
				_LblNarrater.Text = healed;
				_PlayerHealth.Text = "dead";
			}
		}
		private void PlayerRunBtnC(object sender, EventArgs e)  //=============================run button
		{
			int Pspeed = Int32.Parse(_PlayerSpeed.Text);
			int Espeed = Int32.Parse(_EnermySpeed.Text);
			if (Pspeed >= Espeed)
			{
				string healed = "take your chance to travel befor it's to late";
				_LblNarrater.Text = healed;
				travel = true;
			}
			else if (Pspeed <= Espeed)
			{
				string healed = $"your to slow to run away {EnermyName} has a dobble hit";
				_LblNarrater.Text = healed;
				travel = false;
				enermyAttackDouble();
				escape++;
			}
			if (escape == 3)
			{
				string healed = $"{EnermyName} has fallen, take a chance and run now!!!";
				_LblNarrater.Text = healed;
				travel = true;
				escape = 0;
			}

			int PH = Int32.Parse(_PlayerHealth.Text);//=====================player death text 
			if (PH <= 0)
			{
				string healed = "you have died your corps shall join the damed in hanting this place";
				_LblNarrater.Text = healed;
				_PlayerHealth.Text = "dead";
			}
		}
		private void PlayerHealBtnC(object sender, EventArgs e)//======================heal button
		{
			try
			{
				int pots = Int32.Parse(_HealthPots.Text);
				if (pots >= 1)
				{
					int healAmount = 20;
					int heal = Int32.Parse(_PlayerHealth.Text);
					heal = heal + healAmount;
					_PlayerHealth.Text = heal.ToString();

					string healed = "healed for 20 hit points";
					_LblNarrater.Text = healed;
					pots--;
					_HealthPots.Text = pots.ToString();
					enermyAttack();
				}
				else
				{
					string healed = $"you have no pots to heal with free hit for the {EnermyName}";
					_LblNarrater.Text = healed;
					enermyAttack();
				}
			}
			catch { }
		}


		//===================== sets player stat textfields==============
		public void playerStatsM()
		{


			_PlayerHealth.Text = Player_Health;
			_PlayerSpeed.Text = Player_Speed;
			_PlayerDamage.Text = Player_Damage;
			_HealthPots.Text = HealthPotsString;
			if (string.IsNullOrEmpty(_HealthPots.Text))// if empty health pots text field = 0;
			{
				_HealthPots.Text = "0";
			}
		}


		public void enermyIN()
		{
			enermy siren = new siren("siren", "voice of the damed");

			List<enermy> enermys = new List<enermy>()
			{
				siren
			};

			foreach (var i in enermys)
			{
				_Enermydamage.Text = i._DamageSet().ToString();
				_EnermySpeed.Text = i._speedSet().ToString();
				_EnermyHealth.Text = i._HealthSet().ToString();

			}
			siren s = new siren("sireen", "voice of the damed");
			string name = s.Name;
			EnermyName = name;
			string weapon = s.weaponName;
			EnermyWeapon = weapon;
		}


		//=================================  travel ( view controler ) button //controles 
		private void BtnTravelC(object sender, EventArgs e)
		{
			if (travel == true)
			{


				if (movementNumber == 0)
				{
					OHvc = new oldHouseVC();
					this.NavigationController.PushViewController(OHvc, true);

					OHvc.Player_Health = _PlayerHealth.Text;
					OHvc.Player_Speed = _PlayerSpeed.Text;
					OHvc.Player_Damage = _PlayerDamage.Text;
					OHvc.HealthPotsString = _HealthPots.Text;

					if (shieldB == true)
					{
						OHvc.shieldB = true;
						OHvc.defendYN = true;
					}

					if (holy == true)
					{
						OHvc.holy = true;

					}
					if (spectral == true)
					{
						OHvc.spectral = true;
					}


				}
				else if (movementNumber == 1)
				{
					BHvc = new boatHouseVC();
					this.NavigationController.PushViewController(BHvc, true);

					BHvc.Player_Health = _PlayerHealth.Text;
					BHvc.Player_Speed = _PlayerSpeed.Text;
					BHvc.Player_Damage = _PlayerDamage.Text;
					BHvc.HealthPotsString = _HealthPots.Text;

					if (shieldB == true)
					{
						BHvc.shieldB = true;
						BHvc.defendYN = true;
					}

					if (holy == true)
					{
						BHvc.holy = true;

					}
					if (spectral == true)
					{
						BHvc.spectral = true;
					}
				}
				else if (movementNumber == 2)
				{
					Mvc = new mineVC();
					this.NavigationController.PushViewController(Mvc, true);

					Mvc.Player_Health = _PlayerHealth.Text;
					Mvc.Player_Speed = _PlayerSpeed.Text;
					Mvc.Player_Damage = _PlayerDamage.Text;
					Mvc.HealthPotsString = _HealthPots.Text;

					if (shieldB == true)
					{
						Mvc.shieldB = true;
						Mvc.defendYN = true;
					}

					if (holy == true)
					{
						Mvc.holy = true;

					}
					if (spectral == true)
					{
						Mvc.spectral = true;
					}

				}
				else if (movementNumber == 3)
				{
					FOrestvc = new forestVC();
					this.NavigationController.PushViewController(FOrestvc, true);

					FOrestvc.Player_Health = _PlayerHealth.Text;
					FOrestvc.Player_Speed = _PlayerSpeed.Text;
					FOrestvc.Player_Damage = _PlayerDamage.Text;
					FOrestvc.HealthPotsString = _HealthPots.Text;

					if (shieldB == true)
					{
						FOrestvc.shieldB = true;
						FOrestvc.defendYN = true;
					}

					if (holy == true)
					{
						FOrestvc.holy = true;

					}
					if (spectral == true)
					{
						FOrestvc.spectral = true;
					}
				}
				else if (movementNumber == 4)
				{
					Fvc = new fieldVC();
					this.NavigationController.PushViewController(Fvc, true);

					Fvc.Player_Health = _PlayerHealth.Text;
					Fvc.Player_Speed = _PlayerSpeed.Text;
					Fvc.Player_Damage = _PlayerDamage.Text;
					Fvc.HealthPotsString = _HealthPots.Text;

					if (shieldB == true)
					{
						Fvc.shieldB = true;
						Fvc.defendYN = true;
					}

					if (holy == true)
					{
						Fvc.holy = true;

					}
					if (spectral == true)
					{
						Fvc.spectral = true;
					}
				}
				else if (movementNumber == 5)
				{
					Lvc = new lakeVC();
					this.NavigationController.PushViewController(Lvc, true);

					Lvc.Player_Health = _PlayerHealth.Text;
					Lvc.Player_Speed = _PlayerSpeed.Text;
					Lvc.Player_Damage = _PlayerDamage.Text;
					Lvc.HealthPotsString = _HealthPots.Text;

					if (shieldB == true)
					{
						Lvc.shieldB = true;
						Lvc.defendYN = true;
					}

					if (holy == true)
					{
						Lvc.holy = true;

					}
					if (spectral == true)
					{
						Lvc.spectral = true;
					}
				}
			}
			else
			{
				string healed = "enermy alive travel inposible try run!!";
				_LblNarrater.Text = healed;
			}
			int PH = Int32.Parse(_PlayerHealth.Text);
			if (PH <= 0)
			{
				string healed = "you have died your corps shall join the damed in hanting this place";
				_LblNarrater.Text = healed;
				_PlayerHealth.Text = "dead";

			}
		}   //==========================================================pickup labels controler
		public void pickups()
		{
			if (shieldB == false)
			{ _shield.Text = ""; }
			else
			{ _shield.Text = "shield"; }


			if (holy == false)
			{
				_holyWeapon.Text = "";
			}
			else
			{
				_holyWeapon.Text = "holy weapon";
			}


			if (spectral == false)
			{
				_tears.Text = "";
			}
			else
			{
				_tears.Text = "spectral tear";
			}
		}



		//====================================================== - button controles


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

		//============================================= + button controles
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
		//=========================== // fill in the travel textfild's at start of runtime
		private void startAreaString()
		{
			if (movementNumber == 0)
			{
				movementNumber = 0;
				_TfArea.Text = movementNumber.ToString();
				areaString = array1[0];
				_tfAreaString.Text = areaString;
				//============================================= test's



			}
		}

		//===========================if player is dead
		public async Task Exit()
		{
			if (_PlayerHealth.Text == "dead")
			{
				await Task.Delay(1000);
				dcv = new DeadViewControler();
				this.NavigationController.PushViewController(dcv, true);

			}
		}



		private void PlayerAttackBTN()
		{
			var rect = new CGRect(25, 445, 100, 50);
			_PlayerAttackBtn = new UIButton(rect);
			_PlayerAttackBtn.Layer.BorderWidth = 3f;
			_PlayerAttackBtn.Layer.CornerRadius = 15f;
			_PlayerAttackBtn.Layer.BorderColor = UIColor.Green.CGColor;
			_PlayerAttackBtn.Layer.BackgroundColor = UIColor.LightGray.CGColor;
			_PlayerAttackBtn.SetTitle("Attack", UIControlState.Normal);
			View.Add(_PlayerAttackBtn);
		}
		private void PlayerDefendBtnM()
		{
			var rect = new CGRect(130, 445, 100, 50);
			_PlayerDefendBtn = new UIButton(rect);
			_PlayerDefendBtn.Layer.BorderWidth = 3f;
			_PlayerDefendBtn.Layer.CornerRadius = 15f;
			_PlayerDefendBtn.Layer.BorderColor = UIColor.Green.CGColor;
			_PlayerDefendBtn.Layer.BackgroundColor = UIColor.LightGray.CGColor;
			_PlayerDefendBtn.SetTitle("Defend", UIControlState.Normal);
			View.Add(_PlayerDefendBtn);
		}
		private void PlayerHealBtnM()
		{
			var rect = new CGRect(25, 390, 100, 50);
			_playerHealBtn = new UIButton(rect);
			_playerHealBtn.Layer.BorderWidth = 3f;
			_playerHealBtn.Layer.CornerRadius = 15f;
			_playerHealBtn.Layer.BorderColor = UIColor.Green.CGColor;
			_playerHealBtn.Layer.BackgroundColor = UIColor.LightGray.CGColor;
			_playerHealBtn.SetTitle("Heal", UIControlState.Normal);
			View.Add(_playerHealBtn);
		}
		private void PlayerRunBtnM()
		{
			var rect = new CGRect(235, 445, 100, 50);
			_playerRunBtn = new UIButton(rect);
			_playerRunBtn.Layer.BorderWidth = 3f;
			_playerRunBtn.Layer.CornerRadius = 15f;
			_playerRunBtn.Layer.BorderColor = UIColor.Green.CGColor;
			_playerRunBtn.Layer.BackgroundColor = UIColor.LightGray.CGColor;
			_playerRunBtn.SetTitle("Run", UIControlState.Normal);
			View.Add(_playerRunBtn);
		}
		private void TfHealPOts()
		{
			var rect = new CGRect(130, 390, 50, 50);
			_HealthPots = new UITextField(rect);
			_HealthPots.Layer.BorderColor = UIColor.Green.CGColor;
			_HealthPots.TextAlignment = UITextAlignment.Center;
			_HealthPots.Layer.BorderWidth = 3f;
			_HealthPots.Text = "0";
			View.Add(_HealthPots);
		}
		//================================ page UI button eliments 
		private void TravelBTN()
		{
			var rect = new CGRect(135, 555, 150, 50);
			_travelBTN = new UIButton(rect);
			_travelBTN.Layer.BorderWidth = 3f;
			_travelBTN.Layer.BorderColor = UIColor.Blue.CGColor;
			_travelBTN.Layer.CornerRadius = 15f;
			_travelBTN.BackgroundColor = UIColor.LightGray;
			_travelBTN.SetTitle("travel", UIControlState.Normal);
			View.Add(_travelBTN);
		}
		private void btnSub()
		{
			var rect = new CGRect(80, 555, 50, 50);
			_subButton = new UIButton(rect);
			_subButton.Layer.BorderWidth = 3f;
			_subButton.Layer.BorderColor = UIColor.Blue.CGColor;
			_subButton.Layer.CornerRadius = 15f;
			_subButton.BackgroundColor = UIColor.LightGray;
			_subButton.SetTitle("_", UIControlState.Normal);
			View.Add(_subButton);
		}
		private void btnADDM()
		{
			var rect = new CGRect(25, 555, 50, 50);
			_AddButton = new UIButton(rect);
			_AddButton.Layer.BorderWidth = 3f;
			_AddButton.Layer.BorderColor = UIColor.Blue.CGColor;
			_AddButton.Layer.CornerRadius = 15f;
			_AddButton.BackgroundColor = UIColor.LightGray;
			_AddButton.SetTitle("+", UIControlState.Normal);
			View.Add(_AddButton);
		}
		//====================================== text field eliments
		private void _tfAreaM()
		{
			var rect = new CGRect(80, 500, 150, 50);
			_tfAreaString = new UITextField(rect);
			_tfAreaString.Layer.BorderWidth = 3f;
			_tfAreaString.Layer.BorderColor = UIColor.Black.CGColor;
			_tfAreaString.Layer.CornerRadius = 5f;
			//_tfAreaString.Text = "Old House";
			_tfAreaString.TextAlignment = UITextAlignment.Center;

			View.Add(_tfAreaString);
		}
		private void TFareaNum()
		{
			var rect = new CGRect(25, 500, 50, 50);
			_TfArea = new UITextField(rect);
			_TfArea.Layer.BorderColor = UIColor.Black.CGColor;
			_TfArea.Layer.BorderWidth = 3f;
			_TfArea.Layer.CornerRadius = 5f;
			//	_TfArea.Text = "0";
			_TfArea.TextAlignment = UITextAlignment.Center;
			View.Add(_TfArea);
		}
		//===================================== labels==================================
		private void LblNt()
		{
			var rect = new CGRect(25, 60, 300, 130);
			_LblNarrater = new UILabel(rect);
			UILineBreakMode NSLineBreakByWordWrapping = default(UILineBreakMode);
			_LblNarrater.LineBreakMode = NSLineBreakByWordWrapping;
			_LblNarrater.Lines = 10;
			//_LblNarraterText.Layer.BorderWidth = 1f;
			//_LblNarraterText.Layer.BorderColor = UIColor.Black.CGColor;
			_LblNarrater.Text = $"you take the boat onto the lake and are attacked by a {EnermyName} using a {EnermyWeapon} ";
			View.Add(_LblNarrater);
		}
		public void lblPspeedM()
		{
			var rect = new CGRect(25, 300, 100, 50);
			_lblPspeed = new UILabel(rect);
			_lblPspeed.Text = "Speed";
			View.Add(_lblPspeed);
		}
		public void lblPdamageM()
		{
			var rect = new CGRect(25, 240, 100, 50);
			_lblPdamage = new UILabel(rect);
			_lblPdamage.Text = " Damage";
			View.Add(_lblPdamage);
		}
		public void lblPhealth()
		{
			var rect = new CGRect(25, 180, 100, 50);
			_lblPheath = new UILabel(rect);
			_lblPheath.Text = "Health";
			View.Add(_lblPheath);
		}
		public void lblEspeedM()
		{
			var rect = new CGRect(225, 300, 100, 50);
			_lblEspeed = new UILabel(rect);
			_lblEspeed.Text = "Speed";
			View.Add(_lblEspeed);
		}
		public void lblEdamageM()
		{
			var rect = new CGRect(225, 240, 100, 50);
			_lblEdamage = new UILabel(rect);
			_lblEdamage.Text = "Damage";
			View.Add(_lblEdamage);
		}
		public void lblEhealth()
		{
			var rect = new CGRect(225, 180, 100, 50);
			_lblEhealth = new UILabel(rect);
			_lblEhealth.Text = "Health";
			View.Add(_lblEhealth);
		}
		//========================================player items labels
		public void StearsM()
		{
			var rect = new CGRect(190, 380, 100, 100);
			_tears = new UILabel(rect);
			//_tears.Text = "Spectral tear";
			View.Add(_tears);
		}
		public void ShieldM()
		{
			var rect = new CGRect(190, 365, 100, 50);
			_shield = new UILabel(rect);
			//_shield.Text = "shield";
			View.Add(_shield);
		}
		public void HolyWeaponM()
		{
			var rect = new CGRect(190, 385, 100, 50);
			_holyWeapon = new UILabel(rect);
			//	_holyWeapon.Text = "holy weapon";
			View.Add(_holyWeapon);
		}


		//======================= player stats text fields
		public void PHealth()
		{
			var rect = new CGRect(25, 215, 100, 40);
			_PlayerHealth = new UITextField(rect);
			_PlayerHealth.Layer.BorderWidth = 3f;
			_PlayerHealth.Layer.BorderColor = UIColor.Green.CGColor;
			_PlayerHealth.TextAlignment = UITextAlignment.Center;
			//	_PlayerHealth2.Text = "0";
			View.Add(_PlayerHealth);
		}
		public void PDamage()
		{
			var rect = new CGRect(25, 275, 100, 40);
			_PlayerDamage = new UITextField(rect);
			_PlayerDamage.Layer.BorderColor = UIColor.Green.CGColor;
			_PlayerDamage.Layer.BorderWidth = 3f;
			_PlayerDamage.TextAlignment = UITextAlignment.Center;
			//	_PlayerDamage2.Text = $"{0}";
			View.Add(_PlayerDamage);

		}
		public void PSpeed()
		{
			var rect = new CGRect(25, 335, 100, 50);
			_PlayerSpeed = new UITextField(rect);
			_PlayerSpeed.Layer.BorderWidth = 3f;
			_PlayerSpeed.Layer.BorderColor = UIColor.Green.CGColor;
			_PlayerSpeed.TextAlignment = UITextAlignment.Center;
			//	_PlayerSpeed2.Text = $"{0}";
			View.Add(_PlayerSpeed);

		}
		//============================================== enermy stats text fields
		public void EHealth()
		{
			var rect = new CGRect(225, 215, 100, 40);
			_EnermyHealth = new UITextField(rect);
			_EnermyHealth.Layer.BorderWidth = 3f;
			_EnermyHealth.Layer.BorderColor = UIColor.Red.CGColor;
			_EnermyHealth.TextAlignment = UITextAlignment.Center;
			//	_EnermyHealth.Text = "100";
			View.Add(_EnermyHealth);
		}
		public void EDamage()
		{
			var rect = new CGRect(225, 275, 100, 40);
			_Enermydamage = new UITextField(rect);
			_Enermydamage.Layer.BorderColor = UIColor.Red.CGColor;
			_Enermydamage.Layer.BorderWidth = 3f;
			_Enermydamage.TextAlignment = UITextAlignment.Center;
			//_Enermydamage.Text = "10";
			View.Add(_Enermydamage);

		}
		public void ESpeed()
		{
			var rect = new CGRect(225, 335, 100, 40);
			_EnermySpeed = new UITextField(rect);
			_EnermySpeed.Layer.BorderWidth = 3f;
			_EnermySpeed.Layer.BorderColor = UIColor.Red.CGColor;
			_EnermySpeed.TextAlignment = UITextAlignment.Center;
			//	_EnermySpeed.Text = "5";
			View.Add(_EnermySpeed);
		}

		//========================== arrays 
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

		//=================== constructor
		public lakeVC()
		{
		}
	}
}
