using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUnlock : MonoBehaviour
{
  public GameObject door = null;
  public GameObject doorLock = null;
  public GameObject key = null;
    // Start is called before the first frame update
    void Start()
    {
        // make sure our active objects are set to true
        door.SetActive(true); 
        doorLock.SetActive(true);
    }

    // called when the collider assigned with a trigger is hit
    void OnTriggerEnter(Collider other)
    {
        // check to make sure the assigned object is the collision object
        if (other.gameObject == key)
        {
            // toggle active state in the hiearchy
            if (door.activeInHierarchy)
            {
              door.SetActive(false);
              doorLock.SetActive(false);
            }
        }
    }
}
