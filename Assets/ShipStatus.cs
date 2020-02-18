using UnityEngine;
using System.Collections;

public class ShipStatus : MonoBehaviour {
	public float health;
	public int ammo;
	bool fry;
	bool leela;
	bool bender;
	// Use this for initialization
	void Start () {
		health = 100;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Asteroid")
		{
			health -= 25;
		}
	}

}
