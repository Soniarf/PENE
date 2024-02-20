using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ScriptProgresoCircular : MonoBehaviour
{

    public Sprite miSprite;
    public Image ProgresoCircular;
    public float tiempo = 5f; //tiempo, esto se podra variar para darle un valor cuando el nivel se complete
    private float ContadorTiempo;
    


    private void Awake()
    {
        Sprite miSprite = Resources.Load<Sprite>("Iconos/Botones repes/Recurso 89_ icono P.E.N.E");
    }
    // Start is called before the first frame update
    void Start()
    {
        ContadorTiempo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (PreguntaSetUp.JuegoCompletado)
        {
            ContadorTiempo += Time.deltaTime;
            ProgresoCircular.fillAmount = ContadorTiempo / tiempo;
            
            ProgresoCircular.sprite = miSprite; // Reemplaza "newSprite" por la referencia a tu nueva imagen
        }
    }
   }

