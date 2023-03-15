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
        FlashlightOnPlayer.SetActive(false);

    }

    private void OnTriggerStay(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            if(Input.GetKey(KeyCode.F))
            {
                this.gameObject.SetActive(false);
                FlashlightOnPlayer.SetActive(true);
            }
        }
    }
}
