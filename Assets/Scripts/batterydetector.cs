using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryDetector : MonoBehaviour
{
    public float batterynumber = 1;
    
     public AudioClip battery;
     void start(){





     }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Battery"))
        {
            batterynumber = batterynumber + 1;
             AudioSource.PlayClipAtPoint(battery,transform.position);




        }
    }
}
