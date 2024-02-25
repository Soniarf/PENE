using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Volumen : MonoBehaviour
{
    public AudioMixer AudioMixer;
    public Slider volumen;
    public string ConfSonido;
    void Start()
    {
        volumen.value = PlayerPrefs.GetFloat("master", 0.5f);
        ConfSonido = SceneManager.GetActiveScene().name;
    }
    public void SetmasterVolume(float volumeValue)
{
    AudioMixer.SetFloat("master", volumeValue);
    // Guardamos el volumen de la escena actual
    PlayerPrefs.SetFloat("master" + SceneManager.GetActiveScene().name, volumeValue); 
    PlayerPrefs.SetString("escenaActual", ConfSonido); 
}


    public float GetmasterVolume()
    {
        return volumen.value;
    }

}