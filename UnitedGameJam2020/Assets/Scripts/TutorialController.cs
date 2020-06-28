using UnityEngine;

public class TutorialController : MonoBehaviour {
    
    public GameObject paredeFalse;
    public GameObject novaParede;
    public GameController gameController;
    private void OnCollisionEnter(Collision other) {
        novaParede.SetActive(true);
        paredeFalse.SetActive(false);
        gameController.tutorialTrigger();    
        Destroy(this);
        
    }

}