using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;				//biblioteca bot�n

public class CambiarEscena : MonoBehaviour
{
    public void ChangeLevel(string SceneName)  //variable para cambiar de escena
    {
        SistemaNiveles.instancia.AumentarNiveles();
        SceneManager.LoadScene(SceneName);     //especificaci�n de q hace esa variable
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
