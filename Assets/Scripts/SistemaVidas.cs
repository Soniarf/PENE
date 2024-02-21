using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaVidas : MonoBehaviour
{
    
    public static int health;
    public Image[] vidas;
    public Sprite spriteVidas;


    void Awake()
    {
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < vidas.Length; i++)
        {
            if (i < health)
            {
                vidas[i].sprite = spriteVidas;
                vidas[i].enabled = true;
            }

            else
            {
                vidas[i].sprite = null;
                vidas[i].enabled = false;
            }
        }
    }
}
