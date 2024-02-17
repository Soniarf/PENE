using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Respuestas : MonoBehaviour
{
    private bool isCorrect;
    [SerializeField]
    private TextMeshProUGUI textoRespuesta;

    public PreguntaSetUp preguntaSetUp;

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
        // Si la respuesta es correcta, mostrar feedback positivo.
        if (isCorrect)
        {
            // Mostrar feedback visual de respuesta correcta.
        }
        else
        {
            // Mostrar feedback visual de respuesta incorrecta.
        }

        // Cargar la siguiente pregunta.
        PreguntaSetUp.instance.CargarSiguientePregunta();
    }
}
