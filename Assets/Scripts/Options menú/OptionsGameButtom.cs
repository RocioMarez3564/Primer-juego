using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsGameButtom : MonoBehaviour
{
    public OptionsControl optionsPanel;

    // Start is called before the first frame update
    void Start()
    {
        optionsPanel = GameObject.FindGameObjectWithTag("Options").GetComponent<OptionsControl>();
    }

    // Update is called once per frame
    public void PauseMenu()
    {
        optionsPanel.optionsScreen.SetActive(true);
    }
}
