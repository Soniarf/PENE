using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SonidoBotones: MonoBehaviour
{
    public AudioSource fuente;
    public AudioClip botonuco;

    private void Start()
    {
        fuente.clip = botonuco;
    }
    public void Reproducir()
    {
        fuente.Play ();
    }
}
