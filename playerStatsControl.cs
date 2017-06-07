using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using UIKit;
using CoreGraphics;

namespace RPG3
{
	public class playerStatsControl
	{


	
		public int _PlayerHealth;
		public int _PlayerDamage;
		public int _PlayerSpeed;


		//=============================== player inheritance

		public void playerIN()
		{
			Player player1 = new Player("human", "knife");

			List<Player> player_1 = new List<Player>()
	{
	   player1
	};

			foreach (var i in player_1)  // veriable returned can be called here
			{
				_PlayerHealth = i._PlayerHealthSet();
				_PlayerSpeed = i._PlayerSpeedSet();
				_PlayerDamage = i._PlayerDamageSet();

			}
		}

		//public void ReturnStats() // when called this method will override the player stats veriables to the runtime values 
		//{

		//	_PlayerHealth = _PlayerHealth;
		//	_PlayerSpeed = _PlayerSpeed;
		//	_PlayerDamage = _PlayerDamage;

		//	IN2();


		//}

		//public void IN2()
		//{
		//	BHVC = new boatHouseVC();

		//	int PlayerH = _PlayerHealth;
		//	BHVC.Player_Health = PlayerH.ToString();




		//	int PlayerD = _PlayerDamage;
		//	BHVC.Player_Damage = PlayerD.ToString();
		

		//	int PlayerS = _PlayerSpeed;
		//	BHVC.Player_Speed = PlayerS.ToString();


		//}
		public playerStatsControl()
		{
		}
	}
}
