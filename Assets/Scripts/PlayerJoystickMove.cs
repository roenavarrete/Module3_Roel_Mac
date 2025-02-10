using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerJoystickMove : MonoBehaviour
{
    public SteamVR_Action_Vector2 input;
    public float speed = 1;
    private CharacterController controller;
    private bool isAlive = true;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {   
        if(isAlive)
        {
            Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x, 0, input.axis.y));
            controller.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up) - new Vector3(0, 9.81f, 0) * Time.deltaTime);
        }
    }
}
