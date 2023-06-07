using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] GameObject horror;
    [SerializeField] GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            gameManager.gameOver = true;
            Instantiate(horror, transform.position, Quaternion.identity);
             horror.SetActive(true);
            Destroy(gameObject, 0.1f);
        }
        
         horror.SetActive(false);
    }
    
         
}
