using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public GameObject batteryHolder;
    private BatteryDetector batteryDetectorScript;
    public float doorOpenY = 5.0f;
    public float openSpeed = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        batteryDetectorScript = batteryHolder.GetComponent<BatteryDetector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (batteryDetectorScript.batterynumber >= 4)
        {
            openDoor();
        }
    }

    void openDoor()
    {
        float step = openSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, doorOpenY, transform.position.z), step);
    }
}
