using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public GameObject PickUpText;

    // Start is called before the first frame update
    void Start()
    {
         PickUpText.SetActive(false); 

       
    }

  private void OnTriggerStay(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
               StartCoroutine(Open());
        }
    }
    IEnumerator Open()
{
    PickUpText.SetActive(true); 
Debug.Log("On");
     yield return new WaitForSeconds(4);

     PickUpText.SetActive(false); 
     Debug.Log("Off");
}
}
