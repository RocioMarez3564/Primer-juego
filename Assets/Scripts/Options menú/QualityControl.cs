using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QualityControl : MonoBehaviour
{
    // variables donde se almacenará el dropdown (lista) de la calidad y sus valores 
    public TMP_Dropdown dropdown;
    public int quality;

    // Start is called before the first frame update
    void Start()
    {
        // establecer el valor predeterminado de la calidad en 2 (medio)
        quality = PlayerPrefs.GetInt("qualityNumber", 2);
        dropdown.value = quality;
        QualityConfig();
    }

    public void QualityConfig()
    {
        // ajusta la calidad dependiendo del valor de la lista
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("qualityNumber", dropdown.value);
        quality = dropdown.value;
    }
}
