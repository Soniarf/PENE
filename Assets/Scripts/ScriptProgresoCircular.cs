using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ScriptProgresoCircular : MonoBehaviour
{
    public Image ProgresoCircular;
    public float tiempo = 5f; //tiempo, esto se podra variar para darle un valor cuando el nivel se complete
    private float ContadorTiempo;
    public TextMeshProUGUI TextoProgreso;

    // Start is called before the first frame update
    void Start()
    {
        ContadorTiempo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ContadorTiempo <= tiempo)
        {
            ContadorTiempo = ContadorTiempo + Time.deltaTime;
            ProgresoCircular.fillAmount = ContadorTiempo / tiempo;
            TextoProgreso.text = Convert.ToInt32(100 * ProgresoCircular.fillAmount).ToString() + "%";
        }
    }
}
