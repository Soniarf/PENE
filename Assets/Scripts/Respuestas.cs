using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Respuestas : MonoBehaviour
{
   
    private bool isCorrect;
    [SerializeField]
    private TextMeshProUGUI textoRespuesta;
    

    private PreguntaSetUp preguntaSetUp;

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
            if (SistemaVidas.health == 3)
            {
                Puntuacion.instance3.SumarPuntos(100);
            }
            else if (SistemaVidas.health == 2)
            {
                Puntuacion.instance2.SumarPuntos(50);
            }
            else if (SistemaVidas.health == 1)
            {
                Puntuacion.instance1.SumarPuntos(25);
            }
        }
        else
        {
            SistemaVidas.health--;
            PreguntaSetUp.instance.CargarSiguientePregunta();
        }

        // Cargar la siguiente pregunta.
        
    }
}
