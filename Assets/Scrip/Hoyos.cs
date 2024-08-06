using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoyos : MonoBehaviour
{
    public GameObject pelota;
    public Transform Hoyo;
    public void OnTriggerEnter(Collider other)
    {
        pelota.transform.position = Hoyo.transform.position;
    }
}
