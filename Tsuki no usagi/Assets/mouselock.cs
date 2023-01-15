using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselock : MonoBehaviour
{
    void Update() 
    {
        if(Input.GetKeyDown("h"))
        {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        }

        if(Input.GetKeyDown("u"))
        {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        }
    }
}
