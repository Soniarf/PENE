using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(fileName = "Pregunta", menuName = "ScriptableObjects/Pregunta", order = 1)]
public class PreguntaData : ScriptableObject
{
    [SerializeField]
    public AudioMixer audioMixer;
    public string pregunta;
    public string[] respuestas;
    public AudioClip audioInstrumento;


    void Awake()
    {
        
    }
    public void PlayAudio(AudioSource audioSource, AudioMixer audioMixer)
    {
        audioSource.clip = audioInstrumento;
        audioSource.outputAudioMixerGroup = audioMixer.FindMatchingGroups("master")[0];
        audioSource.Play();
    }


    
}