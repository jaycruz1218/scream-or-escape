using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    public float restPosition = 0;
    public float pressedPosition = 45;
    public float hitstrength = 10000;
    public float flipperDamper = 150;

    public string inputName;

    private HingeJoint hinge;

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            spring.targetPosition = pressedPosition;
            Debug.Log("Worked");
            
        }

        //else
        // {
        // spring.targetPosition = restPosition;
        // }
        hinge.spring = spring;
        hinge.useLimits = true;

    }
}
