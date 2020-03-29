using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene01 : MonoBehaviour
{
    public GameObject thePlayer; 
    public GameObject cutSceneCam; 

    void OnCollisionEnter(Collision other){
        Debug.Log("CollisionOther");
        if(other.gameObject.tag == "Player"){
    
       cutSceneCam.SetActive(true);

        thePlayer.SetActive(false);


        this.gameObject.SetActive(false); 

        Debug.Log("collision");
        }
    }
        
}
