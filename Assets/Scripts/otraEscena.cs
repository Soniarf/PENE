
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;    //biblioteca botón 
using UnityEngine.Audio;

public class otraEscena : MonoBehaviour
{
    public AudioMixer AudioMixer;
    public void ChangeLevel(string cambiarA)  //variable para cambiar de escena 
    {
        SceneManager.LoadScene(cambiarA);     //especificación de q hace esa variable
        float volumenGuardado = PlayerPrefs.GetFloat("master" + cambiarA, 0.5f);
        AudioMixer.SetFloat("master", volumenGuardado);
    }

    public void Salida()        //función para salir 
    {
        Application.Quit();     //salir de la aplicación 
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))  //botón escape 
        {
            Application.Quit();     //salir de la aplicación 
        }
    }
    public void AbrirUrl(string url)   //variable para después asignar a un botón para ir a una url 
    { 
        Application.OpenURL(url);       //botón para abrir una url 
    } 
} 