using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("GameScene");

    }

    public void QuitButton()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        Application.Quit();
    }
}
