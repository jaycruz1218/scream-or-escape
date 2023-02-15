using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public GameObject horror;
    public GameObject player;

    private void Update()
    {
       //is the game over?
    }

    void GameOver() {
        player.GetComponent<PlayerMovement>().enabled = false;
        Destroy(player.GetComponent<Rigidbody>());
        horror.SetActive(true);
        gameObject.SetActive(false);
    }
}
