using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Valve.VR.InteractionSystem;
public class BatteryDisable1 : MonoBehaviour
{
    public GameObject battery;
       private Vector3 savedPosition;
       public float batterynumber = 1;
   private void Start()
    {

      
        }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("hand")){
    
            transform.position = new Vector3(10.1f, .6f, -13.7f);
        }

    }

}
