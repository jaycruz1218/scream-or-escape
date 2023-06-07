using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{
   public GameObject LightScorce;

   private bool isOn = false;
    public AudioSource Click;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(!isOn)
            {
                
                Invoke("LightOn", 0.3f);
            }
            else
            {
               
                Invoke("LightOff", 0.3f);
            }
        }
    }

    void LightOn()
    { Click.Play();
        LightScorce.SetActive(true);
        isOn = true;
    }
    void LightOff()
    {Click.Play();
        LightScorce.SetActive(false);
        isOn = false;
    }
}
