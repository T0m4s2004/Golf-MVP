using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cronometro : MonoBehaviour
{
    public float tiempo = 300;
    public Text Textotiempo;


    void Update()
    {
        tiempo -= Time.deltaTime;
        Textotiempo.text ="Tiempo: " + tiempo.ToString("f0");
        if (tiempo < 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
