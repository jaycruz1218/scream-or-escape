using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class DoorController : MonoBehaviour
{
    public GameObject Door;
    public bool doorIsOpening;
    bool button1On{ get; set; }
    bool button2On = false;
    public GameObject button1;
    public GameObject button2;

    float startTime = 5;

    void Start()
    {
        //this function will detect the mouse click on a collider, in our case will detect the click on the button
    }

    // Update is called once per frame
    void Update()
    {
        

        
        if(doorIsOpening == true )
        {
            //if the bool is true open the door
            DoorOpen();
        }
        if (Door.transform.position.y>20f)
        {
            doorIsOpening = false;
            //if the y of the door is > than 7 we want to stop the door
        }

        if(button1On)
        {
            startTime -= Time.deltaTime;
            
            if (startTime < 1 && !button2On)
            {
                button1On = false;
                startTime = 5;
            }
        }
    }

    public bool SetTimer()
    {
        startTime = 5;
        button1On = true;

        return button1On;
    }

    public void ButtonPuzzleComplete()
    {
        Debug.Log("Button 1 On: " + button1On);
        if(button1On == true)
        {
            button2On = true;   
            doorIsOpening = true; 
        }else 
        {
            button2On = false;
            Debug.Log("Puzzle Incomplete");
        }
    }

    void DoorOpen()
    {
         Door.transform.Translate(Vector3.up*Time.deltaTime * 5 );
    }
}
