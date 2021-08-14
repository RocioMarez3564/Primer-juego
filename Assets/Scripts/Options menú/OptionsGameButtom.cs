using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsGameButtom : MonoBehaviour
{
    // Se crea una variable del script OptionsControl llamada optionsPanel
    public OptionsControl optionsPanel;

    // Start is called before the first frame update
    void Start()
    {
        // Se iguala dicha variable con el objeto con el tag "Options" dentro del objeto con el script de "OptionsControl"
        optionsPanel = GameObject.FindGameObjectWithTag("Options").GetComponent<OptionsControl>();
    }

    public void PauseMenu()
    {
        // Se activa el panel de opciones
        optionsPanel.optionsScreen.SetActive(true);
    }
}
