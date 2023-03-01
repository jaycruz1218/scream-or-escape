using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameManager gameManager;
    public CharacterController controller;
    public float speed = 12f;
     [SerializeField] float gravityModifer;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        

        


       Vector3 moveX = transform.right * x * speed;
        Vector3 moveZ = transform.forward * z * speed;

        Vector3 movement = moveX + moveZ;

        controller.SimpleMove(movement);




       
       
    }
}
