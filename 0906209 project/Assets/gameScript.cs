using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class gameScript : MonoBehaviour
{
    public void Clickplaygame()
    {
        SceneManager.LoadScene("2SCENE");
    }
    public void Clicksetting()
    {
        Application.Quit();
    }
    public void Clickquit()
    {
        Application.Quit();
    }
}
