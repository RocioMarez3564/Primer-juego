using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumeSound", 0.5f);
        AudioListener.volume = slider.value;
    }

    public void ChangeSlider(float val)
    {
        sliderValue = val;
        PlayerPrefs.SetFloat("volumeSound", sliderValue);
        AudioListener.volume = slider.value;
    }
}
