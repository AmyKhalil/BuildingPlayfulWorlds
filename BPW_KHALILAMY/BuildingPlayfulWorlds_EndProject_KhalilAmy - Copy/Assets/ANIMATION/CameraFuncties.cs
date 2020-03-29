using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFuncties : MonoBehaviour
{
   
   public GameObject thePlayer; 
   public GameObject heksenketel; 
   public GameObject cutscenemusic;

   void CutsceneStart(){
    heksenketel.SetActive (true); 
    cutscenemusic.SetActive(true); 
   }

   void CutsceneDone(){

        Debug.Log("Cutsceneklaar");
        this.gameObject.SetActive (false); 
        cutscenemusic.SetActive(false); 
        thePlayer.SetActive(true); 
   }
}
