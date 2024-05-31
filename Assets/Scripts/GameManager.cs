using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int puntuacion, cantToposActivos;
    public GameObject topo1, topo2, topo3, topo4, topo5, topo6, topo7, topo8;
    public Text textoPuntuacionIzquierda, textoPuntuacionDerecha;

    void Start()
    {
        puntuacion = 0;
        cantToposActivos = 0;

        textoPuntuacionIzquierda.text = "Puntuación: " + puntuacion;
        textoPuntuacionDerecha.text = "Puntuación: " + puntuacion;

        InvokeRepeating("GenerarTopoAleatorio", 2, 4f);
        topo1.SetActive(false);
        topo2.SetActive(false);
        topo3.SetActive(false);
        topo4.SetActive(false);
        topo5.SetActive(false);
        topo6.SetActive(false);
        topo7.SetActive(false);
        topo8.SetActive(false);

        // PROBAR CAMARA DE VUFORIA PARA TENER MAS MOVILIDAD, PONER "CAJA" DE COLISION PARA PODER LIMITAR LA MOVILIDAD DEL PERSONAJE
    }

    void Update()
    {
        GameOver();
    }

    private void GenerarTopoAleatorio()
    {
        int topo = Random.Range(1, 9);

        if (topo == 1 && !topo1.activeSelf)
        {
            topo1.SetActive(true);
            cantToposActivos++;
        }

        if (topo == 2 && !topo2.activeSelf)
        {
            topo2.SetActive(true);
            cantToposActivos++;
        }

        if (topo == 3 && !topo3.activeSelf)
        {
            topo3.SetActive(true);
            cantToposActivos++;
        }

        if (topo == 4 && !topo4.activeSelf)
        {
            topo4.SetActive(true);
            cantToposActivos++;
        }

        if (topo == 5 && !topo5.activeSelf)
        {
            topo5.SetActive(true);
            cantToposActivos++;
        }

        if (topo == 6 && !topo6.activeSelf)
        {
            topo6.SetActive(true);
            cantToposActivos++;
        }

        if (topo == 7 && !topo7.activeSelf)
        {
            topo7.SetActive(true);
            cantToposActivos++;
        }

        if (topo == 8 && !topo8.activeSelf)
        {
            topo8.SetActive(true);
            cantToposActivos++;
        }

        Debug.Log("Topo generado, cant topos activos: " + cantToposActivos);
    }

    public void GolpeTopo(int indice)
    {

        if (indice == 1)
        {
            topo1.SetActive(false);
        }

        if (indice == 2)
        {
            topo2.SetActive(false);
        }

        if (indice == 3)
        {
            topo3.SetActive(false);
        }

        if (indice == 4)
        {
            topo4.SetActive(false);
        }

        if (indice == 5)
        {
            topo5.SetActive(false);
        }

        if (indice == 6)
        {
            topo6.SetActive(false);
        }

        if (indice == 7)
        {
            topo7.SetActive(false);
        }

        if (indice == 8)
        {
            topo8.SetActive(false);
        }

        cantToposActivos--;
        puntuacion++;
        textoPuntuacionIzquierda.text = "Puntuación: " + puntuacion;
        textoPuntuacionDerecha.text = "Puntuación: " + puntuacion;

        Debug.Log("Topo golpeado, puntuacion: " + puntuacion);
    }

    private void GameOver()
    {
        if (cantToposActivos == 4)
        {
            Debug.Log("GameOver");
            CancelInvoke ("GenerarTopoAleatorio");
            // Cambia a escena GameOver donde muestra puntuacion, animacion, otro sonido, etc
        }
    }

}
