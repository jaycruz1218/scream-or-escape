using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contollerr : MonoBehaviour
{
    ButtonPuzzle0 buttonPuzzle;

    
   
 
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            CheckHitObject();
        }
    }
    
     void CheckHitObject()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit ))
        {
            buttonPuzzle= hit.transform.gameObject.GetComponentInParent<ButtonPuzzle0>();
            if(buttonPuzzle != null)
            {
                string value = hit.transform.name;
                buttonPuzzle.SetValue(value);
            }

         
            

        }
    }
}
