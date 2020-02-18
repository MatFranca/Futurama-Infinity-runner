using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public int speed;
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}
