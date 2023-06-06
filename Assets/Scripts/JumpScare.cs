using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public GameObject JumpScarImg;

    public AudioSource audioSource;
    public AudioSource hall;
    
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
            hall.Play();
        }
    }
   
   IEnumerator DisableImg()
   {
        yield return new WaitForSeconds(2);
    JumpScarImg.SetActive(false);
   }
}
