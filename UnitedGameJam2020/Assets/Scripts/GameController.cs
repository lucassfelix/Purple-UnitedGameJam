using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour {


    public GameObject SceneMask;
    public Text textPlaceholder;
    public GameObject red_Player;
    public GameObject blue_Player;
    private GameObject currentPlayer;

    public float tempoEntreTurnos = 5;

    private float tempoRestante;
    private void Start() {
        SceneMask.SetActive(false);
        tempoRestante = tempoEntreTurnos;
        currentPlayer = red_Player;
        blue_Player.GetComponent<CampoVisao>().setVisible(false);
    }


    public GameObject getCurrentPlayer()
    {
        return currentPlayer;
    }

    private void TrocaPlayer() {
        currentPlayer.GetComponent<CampoVisao>().setVisible(false);

        if(currentPlayer == red_Player)
            currentPlayer = blue_Player;
        else   
            currentPlayer = red_Player;

        currentPlayer.GetComponent<CampoVisao>().setVisible(true);
    }

    private void Update() {
        if (currentPlayer == red_Player)
            blue_Player.GetComponent<CampoVisao>().setVisible(false);

        textPlaceholder.text = tempoRestante.ToString("F2");
        
        tempoRestante -= Time.deltaTime;
        if(tempoRestante < 0)
        {
            TrocaPlayer();

            tempoRestante = tempoEntreTurnos;
        }

    }
    
}