using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    // Variables donde se almacenará el slider de volumen y su valor
    public Slider slider;
    public float sliderValue;

    // Start is called before the first frame update
    void Start()
    {
        // Establecer el sonido y su valor predeterminado del slider en 0.5
        slider.value = PlayerPrefs.GetFloat("volumeSound", 0.5f);
        AudioListener.volume = slider.value;
    }

    public void ChangeSlider(float val)
    {
        // Ajusta el volumen dependiendo la posicion del slider 
        sliderValue = val;
        PlayerPrefs.SetFloat("volumeSound", sliderValue);
        AudioListener.volume = slider.value;
    }
}
