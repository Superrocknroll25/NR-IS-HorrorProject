using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Controls()
    {
        SceneManager.LoadScene(2);
    }
    public void About()
    {
        SceneManager.LoadScene(3);
    }
}
