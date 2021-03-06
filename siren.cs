﻿using System;
namespace RPG3
{
	public class siren : enermy
	{

		public string weaponName { get; set; }
		public string Name { get; set; }

		public siren(string name, string WeaponS)
			: base(name, WeaponS)
		{
			Name = name;
			weaponName = WeaponS;
		}

		public override int _DamageSet()
		{
			_weaponDamage += 15;
			return _weaponDamage;
		}
		public override int _HealthSet()
		{
			_health += 130;
			return base._health;
		}

		public override int _speedSet()
		{
			_speed += 7;
			return _speed;
		}

		public override string ToString()
		{
			return $"enermy name = {_Name} {Environment.NewLine} health = {_health} {Environment.NewLine} speed = {_speed} {Environment.NewLine} weapon = {weaponName} {Environment.NewLine} weapon damage = {_weaponDamage}";
		}
	}
}