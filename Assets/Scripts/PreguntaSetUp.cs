using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PreguntaSetUp : MonoBehaviour
{
    public static PreguntaSetUp instance;
    int contadorCorrectas;
    int contadorIncorrectas;

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
        instance = this;
        GetQuestionAssets();
    }

    void Start()
    {
        selectNewQuestion();
        setQuestionValues();
        setAnswerValues();
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
        bool respuestaCorrectaEscogida = false;

        List<string> newList = new List<string>();

        for (int i = 0; i < botonesRespuestas.Length; i++)
        {
            int random = Random.Range(0, originalList.Count);

            if (random == 0 && !respuestaCorrectaEscogida)
            {
                eleccionRespuestaCorrecta = i;
                respuestaCorrectaEscogida = true;
            }

            newList.Add(originalList[random]);
            originalList.RemoveAt(random);
        }

        return newList;
    }

    public void CargarSiguientePregunta()
    {
        //Verificar si no quedan más vidas (Derrota)
        if (SistemaVidas.health <= 0)
        {
            SceneManager.LoadScene("perder");
            return;
        }

        // Verificar si ya no hay más preguntas (Victoria)
        if (preguntas.Count == 0)
        {
            SceneManager.LoadScene("ganar");
            return;
        }

        // Si no se da alguna de esas condiciones, carga la siguiente pregunta
        selectNewQuestion();
        setQuestionValues();
        setAnswerValues();

    }

    }


