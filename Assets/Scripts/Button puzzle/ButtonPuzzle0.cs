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
    Debug.Log(coLength);
    coLength = code.Length;
    Debug.Log(code.Length);
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
    
    Debug.Log("Door should open");
    toOpen.Rotate(new Vector3(-90,0, 0), Space.World);

    yield return new WaitForSeconds(4);

    toOpen.Rotate(new Vector3(90,0, 0), Space.World);
}
  
    public void SetValue(string value)
    {
        placeInCod++;

        if(placeInCod <= coLength)
        {
            attemptedCode += value;
        }
        if(placeInCod == 4)
        {
            CheckCode();

            attemptedCode = "";
            placeInCod = 0;
        }
    }


}
