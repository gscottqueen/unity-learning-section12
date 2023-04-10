using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
  // assign our canvas object in the inspector
  public GameObject winMessage;
    // Start is called before the first frame update
    void Start()
    {
        // make sure our active objects are set to true
        winMessage.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        // when our xr origin with the main camera is the collider object
        if (other.gameObject.CompareTag("MainCamera"))
        {
            // we won!
            // check to make canvas is not already active
            if (!winMessage.activeInHierarchy)
            {
                winMessage.SetActive(true);
            }
        }
    }
}
