using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour {

    public Text textPlaceholder;
    public GameObject red_Player;
    public GameObject blue_Player;
    private GameObject currentPlayer;

    public float tempoEntreTurnos = 5;

    private float tempoRestante;
    private void Start() {
        tempoRestante = tempoEntreTurnos;
        currentPlayer = red_Player;
    }

    public GameObject getCurrentPlayer()
    {
        return currentPlayer;
    }

    private void TrocaPlayer() {
        if(currentPlayer == red_Player)
            currentPlayer = blue_Player;
        else   
            currentPlayer = red_Player;
    }

    private void Update() {

        textPlaceholder.text = tempoRestante.ToString("F2");
        
        tempoRestante -= Time.deltaTime;
        if(tempoRestante < 0)
        {
            TrocaPlayer();
            tempoRestante = tempoEntreTurnos;
        }

    }
    
}