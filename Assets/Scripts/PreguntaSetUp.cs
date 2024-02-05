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

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GetQuestionAssets()
    {
        preguntas = new List<PreguntaData>(Resources.LoadAll<PreguntaData>("Preguntas"));
    }
}
