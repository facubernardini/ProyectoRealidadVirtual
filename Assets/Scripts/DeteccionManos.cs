using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionManos : MonoBehaviour
{
    public GameObject panelIzquierdo, panelDerecho;

    void Start()
    {
        panelDerecho.SetActive(false);
        panelIzquierdo.SetActive(false);
    }

    public void ManoDerechaDetectada()
    {
        panelDerecho.SetActive(true);
    }

    public void ManoIzquierdaDetectada()
    {
        panelIzquierdo.SetActive(true);
    }

    public void ManoDerechaPerdida()
    {
        panelDerecho.SetActive(false);
    }

    public void ManoIzquierdaPerdida()
    {
        panelIzquierdo.SetActive(false);
    }
}
