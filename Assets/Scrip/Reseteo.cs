using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reseteo : MonoBehaviour
{
    public GameObject[] destinos; // Arreglo de GameObjects destinos

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto que colision� tiene el Tag objetivo
        if (collision.gameObject.tag == "Suelo")
        {
            // Si se especificaron destinos, teletransporta el objeto al m�s cercano
            if (destinos.Length > 0)
            {
                GameObject destinoCercano = FindClosest(destinos, transform.position);
                collision.gameObject.transform.position = destinoCercano.transform.position;
            }
        }
    }

    // Funci�n para encontrar el GameObject m�s cercano
    GameObject FindClosest(GameObject[] objects, Vector3 position)
    {
        GameObject closest = null;
        float distance = Mathf.Infinity;

        foreach (GameObject obj in objects)
        {
            float dist = Vector3.Distance(position, obj.transform.position);
            if (dist < distance)
            {
                closest = obj;
                distance = dist;
            }
        }

        return closest;
    }
}

