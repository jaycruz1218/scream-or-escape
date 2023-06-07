using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contoller : MonoBehaviour
{
    CodeLock codelock;

    DoorController doorController;

    int reachRange = 100;
 
       public AudioSource Click;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            CheckHitObj();
            
        }
    }
    
     void CheckHitObj()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, reachRange))
        {
            codelock = hit.transform.gameObject.GetComponentInParent<CodeLock>();
            if(codelock != null)
            {Click.Play();
                string value = hit.transform.name;
                codelock.SetValue(value);
            }

         
            

        }
    }
}
