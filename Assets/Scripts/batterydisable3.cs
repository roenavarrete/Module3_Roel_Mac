using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Valve.VR.InteractionSystem;
public class BatteryDisable3 : MonoBehaviour
{
    public GameObject battery;
       private Vector3 savedPosition;
       public float batterynumber = 1;
       public bool lightcontrol = false;
   private void Start()
    {

      
        }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("hand")){
    
            transform.position = new Vector3(11.8f, .6f, -13.7f);
             
            GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag ("light");

        foreach(GameObject go in gameObjectArray)
        {
            go.SetActive (false);
        }


        }

    }

}
