using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	public bool ActiveTTDestoy = false;
	public float TTDestroy;
	float CurrentTTDestroy;
	void Update () 
	{
		if (ActiveTTDestoy)
		{
			if (TTDestroy > CurrentTTDestroy)
			{
				CurrentTTDestroy += Time.deltaTime;
				if (TTDestroy < CurrentTTDestroy)
				{
					CurrentTTDestroy = 0;
					Destroy(gameObject);
				}
			}
		}
	}

}
