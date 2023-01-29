using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TMP_InputField input;

    public void StartGame()
    {
        SetPlayerName();
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        MainManager.Instance.playerName = input.text;
    }
}
