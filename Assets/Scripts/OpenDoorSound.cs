using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorSound : MonoBehaviour
{
    DoorScript doorScript;
    AudioSource door;
    public AudioClip openSound;
    // Start is called before the first frame update
    void Start()
    {
        door = GetComponent<AudioSource>();
        doorScript = GetComponent<DoorScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(doorScript.doorOpened == true)
        {
            door.PlayOneShot(openSound, 0.7F);
        }
        
    }
}
