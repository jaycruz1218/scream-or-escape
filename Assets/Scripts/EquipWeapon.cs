using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipWeapon : MonoBehaviour
{
public GameObject Ball;
public Transform WeaponParent;


    // Start is called before the first frame update
    void Start()
    {
        Ball.GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.F))
        {
            Drop();

        }
    }

    void Drop()
    {
        WeaponParent.DetachChildren();
        Ball.transform.eulerAngles = new Vector3(Ball.transform.position.x, Ball.transform.position.y, Ball.transform.position.z);
        Ball. GetComponent<Rigidbody>().isKinematic = false;
        Ball.GetComponent<MeshCollider>().enabled = true;
    }


    void Equip()
    {
        Ball.GetComponent<Rigidbody>().isKinematic = true;

        Ball.transform.position = WeaponParent.transform.position;
        Ball.transform.rotation = WeaponParent.transform.rotation;

        Ball.GetComponent<MeshCollider>().enabled = false;

        Ball.transform.SetParent(WeaponParent);
    }


private void OnTriggerStay(Collider other)
{
    if(other.gameObject.tag == "Player")
    {
            if(Input.GetKey(KeyCode.E))
            {
                Equip();
            }
    }
}

}
