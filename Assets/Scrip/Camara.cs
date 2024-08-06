using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camara : MonoBehaviour
{
    public GameObject jugador; 
    public float distancia = 5f; 
    public float altura = 2f; 
    public float velocidadGiro = 2f; 
    public Slider sliderHorizontal; 

    void LateUpdate()
    {
        Vector3 posicionCamara = jugador.transform.position + new Vector3(0, altura, -distancia);

        transform.position = posicionCamara;

        transform.LookAt(jugador.transform);

        float giroHorizontal = sliderHorizontal.value * velocidadGiro;

        transform.RotateAround(jugador.transform.position, Vector3.up, giroHorizontal);
    }
}
