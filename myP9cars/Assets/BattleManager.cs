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
}
