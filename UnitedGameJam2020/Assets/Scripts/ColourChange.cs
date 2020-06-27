using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ColourChange : MonoBehaviour
{

    public Material ChangeMaterial;

    
    
    void OnCollisionEnter(Collision other) {
        Debug.Log("Colisao");
        if(other.gameObject.tag == "Obstacles")
        {
            gameObject.GetComponent<ParticleSystem>().Play();
            other.gameObject.GetComponent<MeshRenderer>().material = ChangeMaterial;
        }
        else if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings);
        }
    }
    


}
