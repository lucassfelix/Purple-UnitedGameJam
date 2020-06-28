using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ColourChange : MonoBehaviour
{

    public Material changeMaterial;
    public Material winChangeMaterial;

    public GameController gameController;
    
    void OnCollisionEnter(Collision other) {
         if(other.gameObject.tag ==  "Obstacles")
        {
            if(other.gameObject.GetComponent<MeshRenderer>().material != changeMaterial)
                gameObject.GetComponent<AudioSource>().Play();

            gameObject.GetComponent<ParticleSystem>().Play();
            other.gameObject.GetComponent<MeshRenderer>().material = changeMaterial;
        }
        else if (other.gameObject.tag == "Player")
        {
            
            changeMaterial = winChangeMaterial;
            gameController.WinLevel(other.GetContact(0).point);
        }
    }
    


}
