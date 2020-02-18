using UnityEngine;
using System.Collections;

public class Camerafollow : MonoBehaviour {

    public Transform target;

    Vector3 offset;

    public float y;
    public float x;

    void Start()
    {
        // Calculate the initial offset.
        offset = transform.position - target.position;
    }
	
	// Update is called once per frame
	void Update () 
    {
        Vector3 targetCamPos = target.position + offset;

        transform.position = Vector3.Lerp(transform.position, new Vector3(x,y,targetCamPos.z), 5f * Time.deltaTime);
	}
}
