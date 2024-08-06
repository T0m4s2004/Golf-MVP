using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
   public void pausa()
    {
            Time.timeScale = 0;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }    
    public void continuar()
    {
        Time.timeScale = 1;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
}
