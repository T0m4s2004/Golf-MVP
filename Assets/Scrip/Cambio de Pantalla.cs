using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiodePantalla : MonoBehaviour
{
    public int NivelNumero;

    public void CambioPantalla()
    {
        SceneManager.LoadScene(NivelNumero);
    }
}