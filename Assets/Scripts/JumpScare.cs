using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public GameObject JumpScarImg;

    public AudioSource audioSource;

    
    void Start()
    {
        JumpScarImg.SetActive(false);

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            JumpScarImg.SetActive(true);
            audioSource.Play();
            StartCoroutine(DisableImg());
        }
    }
   
   IEnumerator DisableImg()
   {
        yield return new WaitForSeconds(2);
    JumpScarImg.SetActive(false);
   }
}
