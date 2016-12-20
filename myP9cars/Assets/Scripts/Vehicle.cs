using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
	public GameObject GraphicObject;
	public Brain Brain;
	public VehicleUI UI;
	public Attributes Attributes = new Attributes();
	public List<Command> Commands = new List<Command>();
	public string Name = "Vehicle";
	public int Team = 1;




	[HideInInspector]
	public float TurnTimer = 0;


	public void Tick()
	{
		if (TurnTimer < 1)
		{
			IncreaseTurn();
		}
		else
		{
			Brain.Tick();
		}
	}

	void IncreaseTurn()
	{
		TurnTimer += BattleManager.TickDuration * Attributes.Speed;
	}

	void Awake()
	{
		UI.Init(this);
	}
}
