using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SistemaNiveles : MonoBehaviour
{
    public static SistemaNiveles instancia;
    public Button[] botonesNiveles;
    public int desbloaquearNiveles;


    private void Awake()
    {
        if(instancia == null)
        {
            instancia = this;
        }
    }
    void Start()
    {
        if (botonesNiveles.Length > 0)
        {
            for (int i = 0; i < botonesNiveles.Length; i++)
            {
                botonesNiveles[i].interactable = false;
            }

            for (int i = 0; i < PlayerPrefs.GetInt("nivelesDesbloqueados",1); i++)
            {
                botonesNiveles[i].interactable = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
