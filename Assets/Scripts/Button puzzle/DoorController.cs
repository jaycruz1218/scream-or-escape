using UnityEngine;
using System.Collections;


public class DoorController : MonoBehaviour
{
    public GameObject Door;
    public bool doorIsOpening ;
   

    // Update is called once per frame
    void Update()
    {
        if(doorIsOpening == true )
        {
            Door.transform.Translate(Vector3.up*Time.deltaTime* 5 );
            //if the bool is true open the door
        }
        if (Door.transform.position.y>20f)
        {
            doorIsOpening = false;
            //if the y of the door is > than 7 we want to stop the door
        }
    }

    void OnMouseDown()
    {
        //this function will detect the mouse click on a collider, in our case will detect the click on the button
        doorIsOpening = true;

    } 
}
