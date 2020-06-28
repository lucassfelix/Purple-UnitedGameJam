using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {


    public GameObject SceneMask;
    public Text textPlaceholder;
    public Text space;
    public GameObject redPlayer;
    public GameObject bluePlayer;
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
        stopTimer = false;

        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            stopTimer = true;
        }

        space.enabled = false;
        SceneMask.SetActive(false);

        tempoRestante = tempoEntreTurnos;
        currentPlayer = redPlayer;
        textPlaceholder.text = "";

        bluePlayer.GetComponent<CampoVisao>().setVisible(false);
        this.GetComponent<AudioSource>().Play();
    }

    public void tutorialTrigger()
    {
        textPlaceholder.text = tempoRestante.ToString("F2");
        stopTimer = false;
        TrocaPlayer();
    }

    public void WinLevel(Vector3 collisionPoint)
    {
        if(!stopTimer)
        {
            this.GetComponent<AudioSource>().clip = purpleSong;
            this.GetComponent<AudioSource>().Play();
            Instantiate(winParticle,collisionPoint, Quaternion.identity);
        }
        stopTimer = true;
        textPlaceholder.text = "CONGRATS";
        space.enabled = true;
        redPlayer.GetComponent<MeshRenderer>().material = purpleMaterial;
        redPlayer.GetComponent<TrailRenderer>().material = purpleMaterial;
        redPlayer.GetComponent<ParticleSystemRenderer>().material = purpleMaterial;

        bluePlayer.GetComponent<MeshRenderer>().material = purpleMaterial;
        bluePlayer.GetComponent<TrailRenderer>().material = purpleMaterial;
        bluePlayer.GetComponent<ParticleSystemRenderer>().material = purpleMaterial;

    }

    public GameObject getCurrentPlayer()
    {
        return currentPlayer;
    }

    private void TrocaPlayer() {
        currentPlayer.GetComponent<CampoVisao>().setVisible(false);

        if(currentPlayer == redPlayer)
        {
            GetComponent<AudioSource>().clip = blueSong;
            GetComponent<AudioSource>().Play();
            currentPlayer = bluePlayer;
        }
        else   
        {
            GetComponent<AudioSource>().clip = redSong;
            GetComponent<AudioSource>().Play();
            currentPlayer = redPlayer;
        }

        currentPlayer.GetComponent<CampoVisao>().setVisible(true);
    }

    private void Update() {
        if (currentPlayer == redPlayer)
            bluePlayer.GetComponent<CampoVisao>().setVisible(false);

        
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