using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public void SingletonMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void ObserverMenu()
    {
        SceneManager.LoadScene(2);
    }
}
