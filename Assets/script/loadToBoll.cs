using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadToBoll : MonoBehaviour
{
    public string gameScene;

    public void screenManager()
    {
        SceneManager.LoadScene(gameScene);

    }
}
