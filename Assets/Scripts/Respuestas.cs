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
            PreguntaSetUp.instance.CargarSiguientePregunta();
        }
        else
        {
            SistemaVidas.health--;
            PreguntaSetUp.instance.CargarSiguientePregunta();
        }

        // Cargar la siguiente pregunta.
        
    }
}
