using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject obj;
    
    public void OnMouseDown()
    {
        Debug.Log("Clicked");
        if (obj.activeInHierarchy==true)
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);
        }
        

     }

    
   
}
