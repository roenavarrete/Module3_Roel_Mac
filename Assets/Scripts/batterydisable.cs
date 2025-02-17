using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Valve.VR.InteractionSystem;
public class batterydisable : MonoBehaviour
{
    public GameObject battery;
   


    
    void Start()
    {

        this.GetComponent<Interactable>().enabled = true;
    }




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("batteryholder"))

            this.GetComponent <Interactable>().enabled = false;  

    }

}
