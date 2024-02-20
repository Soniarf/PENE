using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Pregunta",  menuName = "ScriptableObjects/Pregunta", order = 1)]
public class PreguntaData : ScriptableObject
{
    public string pregunta;
    public string[] respuestas;
    AudioSource sounds;
    //La respuesta correcta debe ir listada primera siempre, luego se randomiza
}
