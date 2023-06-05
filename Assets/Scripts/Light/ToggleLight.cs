using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{
   public GameObject LightScorce;

   private bool isOn = false;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E))
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
    {
        LightScorce.SetActive(true);
        isOn = true;
    }
    void LightOff()
    {
        LightScorce.SetActive(false);
        isOn = false;
    }
}
