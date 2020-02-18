using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

    public float speed;

	// Update is called once per frame
	void Update () 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(moveHorizontal * speed * Time.deltaTime, moveVertical * speed * Time.deltaTime));

        

        
	}


}
