using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    public float restPosition = 0;
    public float pressedPosition = -45;
    public float hitstrength = 10000;
    public float flipperDamper = 150;

    public string inputName;

    private HingeJoint hinge;

    public bool doorOpened = false;

    private bool doorDistance = false;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;

    }


    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitstrength;
        spring.damper = flipperDamper;

        if (Input.GetMouseButtonDown(0) && doorDistance )
        {
            var motor = hinge.motor;
            motor.force = 10000;
            motor.targetVelocity = -90;
            hinge.motor = motor;
            hinge.useMotor = true;
            spring.targetPosition = pressedPosition;
            //Debug.Log("Worked");

            doorOpened = true;
            
        }

        //else
        // {
        // spring.targetPosition = restPosition;
        // }
        hinge.spring = spring;
        hinge.useLimits = true;

    }

    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position , transform.TransformDirection(Vector3.back), out hit, 5.0f))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.back) * hit.distance, Color.yellow);
            //Debug.Log("Did Hit");
            doorDistance = true;

        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.back) * 1000, Color.white);
           // Debug.Log("Did not Hit");
            doorDistance = false;
        }

    }
}
