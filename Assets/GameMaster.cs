using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
	ShipStatus player;
	// Use this for initialization
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<ShipStatus>();
	}
	// Update is called once per frame
	void Update () 
	{
		if (player.health <= 0 ) 
		{
			KillPlayer();
		}
	}
	void KillPlayer()
	{
		Destroy (player.gameObject);
	}
}
