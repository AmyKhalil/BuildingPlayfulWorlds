using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene01 : MonoBehaviour
{
    public GameObject thePlayer; 
    public GameObject cutSceneCam; 

    void OntriggerEnter(Collider other)
    {
    if (other.gameObject.CompareTag("Player")) { 
        cutSceneCam.SetActive(true);
        thePlayer.SetActive(false);

        Debug.Log("collision detected");
    }
    }
        
}
