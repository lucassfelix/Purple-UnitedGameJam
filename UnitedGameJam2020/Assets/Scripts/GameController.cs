using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {


    public GameObject SceneMask;
    public Text textPlaceholder;
    public Text space;
    public GameObject red_Player;
    public GameObject blue_Player;
    private GameObject currentPlayer;

    public float tempoEntreTurnos = 5;

    public AudioClip redSong;
    public AudioClip blueSong;
    public AudioClip purpleSong;
    
    public Material purpleMaterial;
    public GameObject winParticle;
    private bool stopTimer = false;

    private float tempoRestante;
    private void Start() {
        space.enabled = false;
        stopTimer = false;
        SceneMask.SetActive(false);
        tempoRestante = tempoEntreTurnos;
        currentPlayer = red_Player;
        
        blue_Player.GetComponent<CampoVisao>().setVisible(false);
        GetComponent<AudioSource>().Play();

    }

    public void WinLevel(Vector3 collisionPoint)
    {
        if(!stopTimer)
        {
            GetComponent<AudioSource>().clip = purpleSong;
            GetComponent<AudioSource>().Play();
            Instantiate(winParticle,collisionPoint, Quaternion.identity);
        }
        stopTimer = true;
        textPlaceholder.text = "CONGRATS";
        space.enabled = true;
        red_Player.GetComponent<MeshRenderer>().material = purpleMaterial;
        red_Player.GetComponent<TrailRenderer>().material = purpleMaterial;
        red_Player.GetComponent<ParticleSystemRenderer>().material = purpleMaterial;

        blue_Player.GetComponent<MeshRenderer>().material = purpleMaterial;
        blue_Player.GetComponent<TrailRenderer>().material = purpleMaterial;
        blue_Player.GetComponent<ParticleSystemRenderer>().material = purpleMaterial;




    }

    public GameObject getCurrentPlayer()
    {
        return currentPlayer;
    }

    private void TrocaPlayer() {
        currentPlayer.GetComponent<CampoVisao>().setVisible(false);

        if(currentPlayer == red_Player)
        {
            GetComponent<AudioSource>().clip = blueSong;
            GetComponent<AudioSource>().Play();
            currentPlayer = blue_Player;
        }
        else   
        {
            GetComponent<AudioSource>().clip = redSong;
            GetComponent<AudioSource>().Play();
            currentPlayer = red_Player;
        }

        currentPlayer.GetComponent<CampoVisao>().setVisible(true);
    }

    private void Update() {
        if (currentPlayer == red_Player)
            blue_Player.GetComponent<CampoVisao>().setVisible(false);

        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(stopTimer)
                SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings);
        }

        if(!stopTimer){
            textPlaceholder.text = tempoRestante.ToString("F2");
            tempoRestante -= Time.deltaTime;
        }

        if(tempoRestante < 0)
        {
            TrocaPlayer();

            tempoRestante = tempoEntreTurnos;
        }

    }
    
}