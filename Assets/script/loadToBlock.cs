using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadToBlock : MonoBehaviour
{
    public string gameBlock;

    public void LoadScene()
    {
        SceneManager.LoadScene(gameBlock);
    }



}
