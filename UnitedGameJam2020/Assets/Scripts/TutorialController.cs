using UnityEngine;

public class TutorialController : MonoBehaviour {
    
    public GameObject paredeFalse;
    public GameObject novaParede;
    public GameController gameController;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "RedPlayer")
        {
            novaParede.SetActive(true);
            paredeFalse.SetActive(false);
            gameController.tutorialTrigger();    
        }
    }

}