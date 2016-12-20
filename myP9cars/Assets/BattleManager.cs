using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
	public static BattleManager Instance = null;

	void Awake()
	{
		Instance = this;
	}


	public const float TickDuration = 0.1f;
	public DrivingPathController DrivingPathController;
	public Camera GameCamera;




	public List<Vehicle> Team1 = new List<Vehicle>();
	public List<Vehicle> Team2 = new List<Vehicle>();





	void Start()
	{
		StartCoroutine(GameLoop());
	}

	IEnumerator GameLoop()
	{
		while (!HasBattleEnded())
		{
			foreach (Vehicle v in Team1)
			{
				v.Tick();
			}
			foreach (Vehicle v in Team2)
			{
				v.Tick();
			}

			yield return new WaitForSeconds(TickDuration);
		}

	}


	bool HasBattleEnded()
	{
		//todo 
		return false;
	}
}
