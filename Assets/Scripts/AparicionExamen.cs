using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AparicionExamen : MonoBehaviour
{
    public Image iconoExamen;
    // Start is called before the first frame update
    void Start()
    {
        iconoExamen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PreguntaSetUp.JuegoCompletado)
        {
            iconoExamen.gameObject.SetActive(true);
        }
    }
}
