using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
	public GameObject GraphicObject;
	public Brain Brain;
	public Attributes Attributes = new Attributes();
	public List<Command> Commands = new List<Command>();
	public string Name = "Vehicle";
	public int Team = 1;




	[HideInInspector]
	public float Timer = 0;




}
