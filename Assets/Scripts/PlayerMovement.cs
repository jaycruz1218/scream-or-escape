using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameManager gameManager;
    public CharacterController controller;
    public float speed = 12f;
    public float secspeed = 12f;
     [SerializeField] float gravityModifer;
    Rigidbody rb;

    private GameObject playerCamera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerCamera = GameObject.Find("Main Camera");
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

        if(Input.GetKey(KeyCode.Z))
        {
            speed = 18;
        }else
        {
            speed = 12;
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("IsWorking");
           var playerCameraPosition = playerCamera.transform.position;

           playerCameraPosition.y = 0;
        }


       
       
    }
}
