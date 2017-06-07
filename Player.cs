using System;
namespace RPG3
{
	public class Player : playerInheritance
	{
		public string weaponName { get; set; }

		public Player(string name, string weaponZ)
			: base(name)
		{
			weaponName = weaponZ;
		}

		public override int _PlayerDamageSet()
		{
			_PlayerWeaponDamage += 7;
			return _PlayerWeaponDamage;
		}
		public override int _PlayerHealthSet()
		{
			_PlayerHealth += 100;
			return base._PlayerHealth;
		}

		public override int _PlayerSpeedSet()
		{
			_PlayerSpeed += 4;
			return _PlayerSpeed;
		}

		public override string ToString()
		{
			return $"enermy name = {_Name} {Environment.NewLine} health = {_PlayerHealth} {Environment.NewLine} speed = {_PlayerSpeed} {Environment.NewLine} weapon = {weaponName} {Environment.NewLine} weapon damage = {_PlayerWeaponDamage}";
		}
	}
}