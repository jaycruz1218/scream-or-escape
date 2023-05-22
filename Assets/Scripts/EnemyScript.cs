using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform playerLocation;
    public float speed;
    bool playerInSight = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (playerInSight)
        {
            transform.LookAt(new Vector3(playerLocation.position.x, transform.position.y, playerLocation.position.z));
            transform.position = Vector3.MoveTowards(transform.position, playerLocation.transform.position, 1 * speed * Time.deltaTime);
        }
        else if (!playerInSight)
        {
            transform.position = transform.position;
        }

        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInSight = true;
            Debug.Log("Player Seen");
            
        }

    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            transform.LookAt(new Vector3(playerLocation.position.x, transform.position.y, playerLocation.position.z));
        }
        
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            playerInSight = false;
            Debug.Log("Player Lost");
        }
    }


}
