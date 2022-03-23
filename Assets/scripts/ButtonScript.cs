using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  

public class ButtonScript : MonoBehaviour
{
    public InputField input;

    public void joinLobby(string sceneName) {
        string playerName = input.text;
        if (!string.IsNullOrWhiteSpace(playerName)) {
            SceneManager.LoadScene(sceneName);
        } else {
            Debug.Log("Can't change to " + sceneName);
        }
    }
}
