using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Respuestas : MonoBehaviour
{
    private bool isCorrect;
    [SerializeField]
    private TextMeshProUGUI textoRespuesta;

    public void SetTextoRespuesta(string texto)
    {
        textoRespuesta.text = texto;
    }

    public void SetIsCorrect (bool newBool)
    {
        isCorrect = newBool;
    }

    public void OnClick()
    {
        if(isCorrect)
        {
            Debug.Log("Correcto");
        }
        else
        {
            Debug.Log("Incorrecto");
        }
    }
}
