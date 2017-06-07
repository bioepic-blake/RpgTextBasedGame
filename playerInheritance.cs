using System;
namespace RPG3
{
public abstract class playerInheritance
{
	public string _Name { get; set; }
	protected int _PlayerHealth = 0;
	protected int _PlayerSpeed = 0;
	protected int _PlayerWeaponDamage = 0;

	public virtual int _PlayerDamageSet() { return _PlayerWeaponDamage; }
	public virtual int _PlayerSpeedSet() { return _PlayerSpeed; }
	public virtual int _PlayerHealthSet() { return _PlayerHealth; }

	public playerInheritance(string name)
	{
		_Name = name;
	}

	public override string ToString()
	{
		return $"enermy; {_Name}";
	}
}
}