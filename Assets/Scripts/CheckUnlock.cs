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
        door.SetActive(true); 
        doorLock.SetActive(true);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == key)
    {
       if (door.activeInHierarchy)
      {
        door.SetActive(false);
        doorLock.SetActive(false);
      }
    }
    }
}
