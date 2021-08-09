using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QualityControl : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public int quality;

    // Start is called before the first frame update
    void Start()
    {
        quality = PlayerPrefs.GetInt("qualityNumber", 2);
        dropdown.value = quality;
        QualityConfig();
    }

    // Update is called once per frame
    public void QualityConfig()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("qualityNumber", dropdown.value);
        quality = dropdown.value;
    }
}
