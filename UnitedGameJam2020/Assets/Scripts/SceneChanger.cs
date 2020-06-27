using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneChanger
{
   
    public static void OnClick()
    {
        SceneManager.LoadScene(1);
    }

    public static void NextScene()
    {
        SceneManager.LoadScene( (SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCount);
    }

    public  static void EndGame()
    {

    }
}
