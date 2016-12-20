using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Attributes
{
	public float ResistancePoints = 5;
	public float ResistancePointsMax = 5;
	public float Speed = 0.1f;


	public void Reset()
	{
		ResistancePoints = ResistancePointsMax;
	}


}
