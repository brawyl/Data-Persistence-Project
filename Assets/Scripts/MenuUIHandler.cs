using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public InputField playerName;

    public void StartGame()
    {
        if (playerName.text.Length > 0)
        {
            GameManager.Instance.playerName = playerName.text;
        }
        else
        {
            GameManager.Instance.playerName = "noname";
        }

        SceneManager.LoadScene("main");
    }
}
