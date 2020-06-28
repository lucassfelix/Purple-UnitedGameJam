using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger: MonoBehaviour
{


    public void NextScene()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings);
    }

    public void SelectScene(int scene_id)
    {
        SceneManager.LoadScene(scene_id);
    }

    public void EndGame()
    {

    }
}
