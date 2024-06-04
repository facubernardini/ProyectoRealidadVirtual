using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject topo1, topo2, topo3, topo4, topo5, topo6, topo7, topo8, topo9, topo10, topo11, topo12, topo13, topo14, topo15;
    public GameObject ARCamera;
    public Text textoPuntuacionIzquierda, textoPuntuacionDerecha, textoTimerIzquierda, textoTimerDerecha;
    public AudioSource sonidoGolpe, sonidoMenu;
    private bool modoPausa, juegoComenzado, gameOver;
    private int puntuacion, cantToposActivos;
    private int segundosRestantes;

    void Start()
    {
        puntuacion = 0;
        cantToposActivos = 0;
        segundosRestantes = 60;
        modoPausa = false;
        juegoComenzado = false;
        gameOver = false;

        ActualizarPuntuacion();
        DesactivarTopos();
    }

    void Update()
    {
        if (juegoComenzado)
        {
            GameOver();
            FijarPosicionARCamera();
            ActualizarTiempo();
        }
    }

    private void ComenzarJuego()
    {
        juegoComenzado = true;
        ActualizarPuntuacion();
        InvokeRepeating("GenerarTopoAleatorio", 2, 4f);
        InvokeRepeating("ContarTiempo", 0, 1f);
    }

    private void GenerarTopoAleatorio()
    {
        int topo = Random.Range(1, 16);

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

        if (topo == 9 && !topo9.activeSelf)
        {
            topo9.SetActive(true);
            cantToposActivos++;
        }

        if (topo == 10 && !topo10.activeSelf)
        {
            topo10.SetActive(true);
            cantToposActivos++;
        }

        if (topo == 11 && !topo11.activeSelf)
        {
            topo11.SetActive(true);
            cantToposActivos++;
        }

        if (topo == 12 && !topo12.activeSelf)
        {
            topo12.SetActive(true);
            cantToposActivos++;
        }

        if (topo == 13 && !topo13.activeSelf)
        {
            topo13.SetActive(true);
            cantToposActivos++;
        }

        if (topo == 14 && !topo14.activeSelf)
        {
            topo14.SetActive(true);
            cantToposActivos++;
        }

        if (topo == 15 && !topo15.activeSelf)
        {
            topo15.SetActive(true);
            cantToposActivos++;
        }

        // Reproducir sonido 
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

        if (indice == 9)
        {
            topo9.SetActive(false);
        }

        if (indice == 10)
        {
            topo10.SetActive(false);
        }

        if (indice == 11)
        {
            topo11.SetActive(false);
        }

        if (indice == 12)
        {
            topo12.SetActive(false);
        }

        if (indice == 13)
        {
            topo13.SetActive(false);
        }

        if (indice == 14)
        {
            topo14.SetActive(false);
        }

        if (indice == 15)
        {
            topo15.SetActive(false);
        }

        cantToposActivos--;
        puntuacion++;
        ActualizarPuntuacion();
        sonidoGolpe.Play();
    }

    private void GameOver()
    {
        if (segundosRestantes == 0)
        {
            CancelInvoke ("GenerarTopoAleatorio");
            CancelInvoke("ContarTiempo");
            DesactivarTopos();

            textoPuntuacionDerecha.text = "¡Se terminó el tiempo! \n" + "Puntuación total: " + puntuacion;
            textoPuntuacionIzquierda.text = "¡Se terminó el tiempo! \n" + "Puntuación total: " + puntuacion;

            textoTimerDerecha.text = "";
            textoTimerIzquierda.text = "";

            gameOver = true;
            // Cambia a escena GameOver donde muestra puntuacion, animacion, otro sonido, etc
        }
    }

    private void DesactivarTopos()
    {
        topo1.SetActive(false);
        topo2.SetActive(false);
        topo3.SetActive(false);
        topo4.SetActive(false);
        topo5.SetActive(false);
        topo6.SetActive(false);
        topo7.SetActive(false);
        topo8.SetActive(false);
        topo9.SetActive(false);
        topo10.SetActive(false);
        topo11.SetActive(false);
        topo12.SetActive(false);
        topo13.SetActive(false);
        topo14.SetActive(false);
        topo15.SetActive(false);
    }

    private void ActualizarPuntuacion()
    {
        if (!juegoComenzado)
        {
            textoPuntuacionIzquierda.text = "";
            textoPuntuacionDerecha.text = "";
            textoTimerIzquierda.text = "";
            textoTimerDerecha.text = "";
        }
        else
        {
            textoPuntuacionIzquierda.text = "Puntuación: " + puntuacion;
            textoPuntuacionDerecha.text = "Puntuación: " + puntuacion;
        }
    }

    private void FijarPosicionARCamera()
    {
        ARCamera.transform.position = new Vector3(0f, 1.2f, 0f);
    }

    public void AbrirMenu()
    {
        if (!juegoComenzado)
        {
            ComenzarJuego();
        }
        else
        {
            if (!modoPausa)
        {
            textoPuntuacionDerecha.text = "Menu abierto";
            textoPuntuacionIzquierda.text = "Menu abierto";
            modoPausa = true;
            sonidoMenu.Play();
        }
        else
        {
            textoPuntuacionDerecha.text = "Menu cerrado";
            textoPuntuacionIzquierda.text = "Menu cerrado";
            modoPausa = false;
        }
        }
    }

    private void ActualizarTiempo()
    {
        if (!gameOver)
        {
            textoTimerIzquierda.text = "Tiempo restante: " + segundosRestantes + " seg";
            textoTimerDerecha.text = "Tiempo restante: " + segundosRestantes + " seg";
        }
    }

    private void ContarTiempo()
    {
        segundosRestantes--;
    }

}
