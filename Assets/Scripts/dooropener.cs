using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public GameObject batteryHolder;
    private BatteryDetector batteryDetectorScript;
    public float doorOpenY = 5.0f;
    public float openSpeed = 1.0f;
    private bool gameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        batteryDetectorScript = batteryHolder.GetComponent<BatteryDetector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (batteryDetectorScript.batterynumber >= 4 && !gameOver)
        {
            openDoor();
            gameOver = true;
        }
    }

    void openDoor()
    {
        transform.position = new Vector3(transform.position.x, doorOpenY, transform.position.z);
    }
}
