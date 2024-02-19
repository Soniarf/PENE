using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuacion : MonoBehaviour
{
    public static Puntuacion instance3;
    public static Puntuacion instance2;
    public static Puntuacion instance1;

    private int puntuacion;
    [SerializeField]
    private TextMeshProUGUI textoPuntuacion;

    private void Awake()
    {
        instance3 = this;
        instance2 = this;
        instance1 = this;
    }
    
    public void SumarPuntos(int puntos)
    {
        puntuacion += puntos;
        textoPuntuacion.text = "Puntuación: " + puntuacion.ToString();
    }

    public int GetPuntuacion()
    {
        return puntuacion;
    }
}
