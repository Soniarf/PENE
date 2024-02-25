
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;    //biblioteca bot�n 
using UnityEngine.Audio;

public class otraEscena : MonoBehaviour
{
    public AudioMixer AudioMixer;
    public void ChangeLevel(string cambiarA)  //variable para cambiar de escena 
    {
        SceneManager.LoadScene(cambiarA);     //especificaci�n de q hace esa variable
        float volumenGuardado = PlayerPrefs.GetFloat("master" + cambiarA, 0.5f);
        AudioMixer.SetFloat("master", volumenGuardado);
    }

    public void Salida()        //funci�n para salir 
    {
        Application.Quit();     //salir de la aplicaci�n 
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))  //bot�n escape 
        {
            Application.Quit();     //salir de la aplicaci�n 
        }
    }
    public void AbrirUrl(string url)   //variable para despu�s asignar a un bot�n para ir a una url 
    { 
        Application.OpenURL(url);       //bot�n para abrir una url 
    } 
} 