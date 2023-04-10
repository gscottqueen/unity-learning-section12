using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUnlock : MonoBehaviour
{
  public GameObject door = null;
  public GameObject doorLock = null;
    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true); 
        doorLock.SetActive(true);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
    {
       if (door.activeInHierarchy)
      {
        door.SetActive(false);
        doorLock.SetActive(false);
      }
    }
    }
}
