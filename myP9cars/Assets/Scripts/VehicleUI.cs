using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VehicleUI : MonoBehaviour
{
	public Image RPBar;
	public Image TurnBar;
	Vehicle myVehicle = null;

	public void Init(Vehicle vehicle)
	{
		myVehicle = vehicle;
	}

	void Update()
	{
		if (myVehicle == null)
			return;

		Refresh();
	}

	public void Refresh()
	{
		float RP = myVehicle.Attributes.ResistancePoints / myVehicle.Attributes.ResistancePointsMax;
		float Turn = myVehicle.TurnTimer;;

		RPBar.fillAmount = RP;

		TurnBar.fillAmount = Turn;
	}
}
