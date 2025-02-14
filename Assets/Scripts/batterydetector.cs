using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batterydetector : MonoBehaviour


{
    public float batterynumber = 1;



   private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Battery"))

        batterynumber = batterynumber+1;

    }



}
