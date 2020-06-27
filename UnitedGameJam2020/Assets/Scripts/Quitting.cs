using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitting : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Debug.Log("Sai daqui");
            Application.Quit();
        }
    }
}
