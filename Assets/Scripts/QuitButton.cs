using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quit");

        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
