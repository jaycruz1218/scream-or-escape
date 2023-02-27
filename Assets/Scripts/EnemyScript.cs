using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform playerLocation;
    public float speed;
     bool playerInSight = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (playerInSight)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerLocation.transform.position, 1 * speed * Time.deltaTime);
        }
        else if (!playerInSight)
        {
            transform.position = transform.position;
        }
    }
}
