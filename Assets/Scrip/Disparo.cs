using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject objeto; // Objeto a disparar
    public float velocidadMinima = 1f; // Velocidad mínima de disparo
    public float velocidadMaxima = 10f; // Velocidad máxima de disparo

    private Vector3 puntoInicial; // Punto inicial del drag
    private Vector3 puntoFinal; // Punto final del drag

    public AudioSource audioSource;

    void Update()
    {
        // Comienza el drag
        if (Input.GetMouseButtonDown(0))
        {
            puntoInicial = Input.mousePosition;
        }

        // Finaliza el drag
        if (Input.GetMouseButtonUp(0))
        {
            puntoFinal = Input.mousePosition;
            float distancia = Vector3.Distance(puntoInicial, puntoFinal);
            float velocidad = Mathf.Lerp(velocidadMinima, velocidadMaxima, distancia / Screen.width);
            Vector3 direccion = (puntoFinal - puntoInicial).normalized;
            objeto.GetComponent<Rigidbody>().AddForce(new Vector3(direccion.x, 0,direccion.y) * velocidad, ForceMode.Impulse);
            audioSource.Play();
        }
    }
}

