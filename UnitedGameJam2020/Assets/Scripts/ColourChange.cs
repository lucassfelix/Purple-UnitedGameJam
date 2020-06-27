using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{

    public Material ChangeMaterial;
 
    
    void OnCollisionEnter(Collision other) {
        Debug.Log("Colisao");
        if(other.gameObject.tag == "Obstacles")
            other.gameObject.GetComponent<MeshRenderer>().material = ChangeMaterial;
    }
    


}
