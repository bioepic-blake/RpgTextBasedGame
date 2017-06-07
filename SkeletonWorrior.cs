using System;
namespace RPG3
{
	public class SkeletonWorrior : enermy
	{

		public string weaponName { get; set; }
		public string Name { get; set; }

		public SkeletonWorrior(string name, string WeaponS)
			: base(name, WeaponS)

		{
			Name = name;
		weaponName = WeaponS;
		}

		public string getWeapon()
		{
			string weapon = "sword";
			return weapon;

		}

		public override int _DamageSet()
		{
			_weaponDamage += 9;
			return _weaponDamage;

		}

		public override int _HealthSet()
		{
			_health += 40;
			return _health;
		}

		public override int _speedSet()
		{
			_speed += 5;
			return _speed;
		}

		public override string ToString()
		{
			return $"enermy name"; // = {_Name} {Environment.NewLine} health = {_health} {Environment.NewLine} speed = {_speed} {Environment.NewLine} weapon = {weaponName} {Environment.NewLine} weapon damage = {_weaponDamage}";
		}


	}
}
