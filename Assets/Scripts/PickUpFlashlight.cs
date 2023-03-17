using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFlashlight : MonoBehaviour
{
    public GameObject FlashlightOnPlayer;
    public GameObject PickUpText;

    // Start is called before the first frame update
    void Start()
    {
          PickUpText.SetActive(false);
        FlashlightOnPlayer.SetActive(false);

    }

    private void OnTriggerStay(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
             PickUpText.SetActive(true);
            if(Input.GetKey(KeyCode.F))
            {
                this.gameObject.SetActive(false);
                FlashlightOnPlayer.SetActive(true);
                  PickUpText.SetActive(false);
            }
        }
    }
}
