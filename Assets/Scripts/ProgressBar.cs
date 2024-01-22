using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] GameObject playerGo;
    [SerializeField] GameObject finishGo;

    Image progressBar;
    float maxDistance;

    // Start is called before the first frame update
    void Start()
    {
        progressBar = GetComponent<Image>();
        maxDistance = finishGo.transform.position.z;

        progressBar.fillAmount = playerGo.transform.position.z / maxDistance;
    }

    // Update is called once per frame
    void Update()
    {
        if (progressBar.fillAmount < 1)
        {
            progressBar.fillAmount = playerGo.transform.position.z / maxDistance;
        }
    }
}
