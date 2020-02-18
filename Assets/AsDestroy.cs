using UnityEngine;
using System.Collections;

public class AsDestroy : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
       if (other.tag == "TriggerDestroy")
        {
            Destroy(other.gameObject);
        }
    }
}
