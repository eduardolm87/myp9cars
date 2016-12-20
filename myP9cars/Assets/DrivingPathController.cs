using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class DrivingPathController : MonoBehaviour
{
	public bool Active = true;
	public GameObject Marker;

	List<GameObject> Path = new List<GameObject>();

	public float PathSpacing = 20;

	void Update()
	{
		if (Active)
		{
			TrackPath();
		}	
	}

	void TrackPath()
	{
		if (Input.GetMouseButton(0))
		{
			Vector3 pos = Input.mousePosition;
			pos.z = 20;
			pos = Camera.main.ScreenToWorldPoint(pos);
			var ray = new Ray(pos, Vector3.down);
			RaycastHit hit = new RaycastHit();

			if (Physics.Raycast(ray, out hit))
			{
				InstantiateMarkerIfAppropiate(hit.point);
			}
		}
		else if (Path.Count > 0)
		{
			StopTrack();
		}
		
	}

	void InstantiateMarkerIfAppropiate(Vector3 position)
	{
		if (Path.Count > 0)
		{
			if ((Path.Last().transform.position - position).sqrMagnitude < PathSpacing)
				return;
		}

		GameObject newMarker = GameObject.Instantiate(Marker, position, Quaternion.identity) as GameObject;
		newMarker.transform.position = position;
		newMarker.transform.SetParent(gameObject.transform);

		Path.Add(newMarker);
	}

	void StopTrack()
	{
		while (Path.Count > 0)
		{
			Destroy(Path[0]);
			Path.RemoveAt(0);
		}
	}
}
