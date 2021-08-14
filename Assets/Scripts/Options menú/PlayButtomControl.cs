using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtomControl : MonoBehaviour
{
    // Cambio de escena al valor de nScene
    public void ChangeScene(int nScene)
    {
        SceneManager.LoadScene(nScene);
    }
}
