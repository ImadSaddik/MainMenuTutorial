using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchBetweenScenes : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    public void OpenPPEScene()
    {
        SceneManager.LoadScene("PPE");
    }

    public void OpenFireScene()
    {
        SceneManager.LoadScene("Fire");
    }
}
