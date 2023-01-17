using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorSound : MonoBehaviour
{
    AudioSource openSound;
    // Start is called before the first frame update
    void Start()
    {
        openSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(openSound == true)
        openSound.Play();
    }
}
