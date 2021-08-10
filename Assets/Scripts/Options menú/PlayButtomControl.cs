using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtomControl : MonoBehaviour
{
    public int nScene;
    // cambio de escena aplicado en 
    public void ChangeScene()
    {
        SceneManager.LoadScene(nScene);
    }
}
