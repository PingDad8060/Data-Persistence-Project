using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMain : MonoBehaviour
{
    public void GoBackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
