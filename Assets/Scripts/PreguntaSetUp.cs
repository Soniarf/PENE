using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PreguntaSetUp : MonoBehaviour
{

    [SerializeField]
    private List<PreguntaData> preguntas;
    private PreguntaData preguntaactual;

    [SerializeField]
    private TextMeshProUGUI textoPregunta;
    [SerializeField]
    private Respuestas[] botonesRespuestas;

    [SerializeField]
    private int eleccionRespuestaCorrecta;
 
    // Start is called before the first frame update
    void Awake()
    {
        GetQuestionAssets();
    }

    void Start()
    {
        selectNewQuestion();
        setQuestionValues();
        setAnswerValues();
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    private void GetQuestionAssets()
    {
        preguntas = new List<PreguntaData>(Resources.LoadAll<PreguntaData>("Preguntas"));
    }



    private void selectNewQuestion()
    {
        int randomQuestionIndex = Random.Range(0, preguntas.Count);
        preguntaactual = preguntas[randomQuestionIndex];
        preguntas.RemoveAt(randomQuestionIndex);
    }


    private void setQuestionValues()
    {
        textoPregunta.text = preguntaactual.pregunta;
    }


    private void setAnswerValues()
    {
        List<string> respuestas = randomizeRespuestas(new List<string>(preguntaactual.respuestas));

        for (int i = 0; i < botonesRespuestas.Length; i++)
        {
            bool isCorrect = false;

            if (i == eleccionRespuestaCorrecta)
            {
                isCorrect = true;
            }

            botonesRespuestas[i].SetIsCorrect(isCorrect);
            botonesRespuestas[i].SetTextoRespuesta(respuestas[i]);
        }
    }

    private List<string> randomizeRespuestas(List<string> originalList)
    {

    }
}
