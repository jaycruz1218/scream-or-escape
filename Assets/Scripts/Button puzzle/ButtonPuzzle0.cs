using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPuzzle0 : MonoBehaviour
{
    int coLength;
    int placeInCod;
    public GameObject Door;
    
    public string code = "";
    public string attemptedCode;

    public Transform toOpen;

    private void Start()
{
    
    coLength = code.Length;
}
    void CheckCode()
    {
        if(attemptedCode == code)
        {
            Debug.Log("Isopen");
                StartCoroutine(Open());
        }
        else
        {
            Debug.Log("Wrong Code");
        }
    }
IEnumerator Open()
{
    Vector3 opendoor = toOpen.transform.position;
    Debug.Log("Door should open");
    opendoor.y = 20f;

    yield return new WaitForSeconds(4);

    opendoor.y = 20f;
}
  
    public void SetValue(string value)
    {
        placeInCod++;

        if(placeInCod <= coLength)
        {
            attemptedCode += value;
        }
        if(placeInCod == 3)
        {
            CheckCode();

            attemptedCode = "";
            placeInCod = 0;
        }
    }


}
