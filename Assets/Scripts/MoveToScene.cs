using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene : MonoBehaviour
{
    public void OpenPPEScene()
    {
        SceneManager.LoadScene("PPE");
    }

    public void OpenFireScene()
    {
        SceneManager.LoadScene("Fire");
    }
}
