using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropener : MonoBehaviour
{

    public GameObject door;
    private batterydetector batterydetector;


    // Start is called before the first frame update
    void Start()
    {
        batterydetector = door.GetComponent<batterydetector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (batterydetector.batterynumber >= 3)
        {
            openDoor();
        }
    }

    void openDoor()
    {

    }
}
