using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{

    public void LoadSceneIndex() //Memanggil Scenemanager dengan Index  
    {
        SceneManager.LoadScene(3); // Memasuki Scene Index 3
    }
}
