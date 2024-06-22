using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject topo1, topo2, topo3, topo4, topo5, topo6, topo7, topo8, topo9, topo10, topo11, topo12, topo13, topo14, topo15;
    public GameObject ARCamera, renderizadoIzquierdoCamara, renderizadoDerechoCamara;
    public Text textoPuntuacionIzquierda, textoPuntuacionDerecha, textoTimerIzquierda, textoTimerDerecha;
    public AudioSource sonidoGolpe, sonidoMenu, sonidoInicioDeJuego, sonidoGameover, gameplayBackground, lobbyBackground;
    private bool modoPausa, juegoComenzado, gameOver;
    private int puntuacion, segundosRestantes;

    void Start()
    { 
        modoPausa = false;
        juegoComenzado = false;
        gameOver = false;

        renderizadoDerechoCamara.SetActive(false);
        renderizadoIzquierdoCamara.SetActive(false);

        ActualizarPuntuacion();
        DesactivarTopos();
    }

    void Update()
    {
        if (juegoComenzado)
        {
            GameOver();
            ActualizarTiempo();
            ActualizarPuntuacion();
        }
    }

    private void ComenzarJuego()
    {
        puntuacion = 0;
        segundosRestantes = 60;
        juegoComenzado = true;
        gameOver = false;

        ActualizarPuntuacion();
        PosicionarARCamera();
        
        InvokeRepeating("GenerarTopoAleatorio", 5, 2.5f);
        InvokeRepeating("ContarTiempo", 0, 1f);
        Invoke("ReproducirSonidoDeFondo", 2f);

        sonidoInicioDeJuego.Play();
        lobbyBackground.Stop();
    }

    private void GenerarTopoAleatorio()
    {
        if (!modoPausa)
        {
            bool topoGenerado = false;
            float duracionTopo = Random.Range(6f, 10f);

            while (!topoGenerado)
            {
                int topo = Random.Range(1, 16);

                if (topo == 1 && !topo1.activeSelf)
                {
                    topo1.SetActive(true);
                    Invoke("OcultarTopo1", duracionTopo);
                    topoGenerado = true;
                }

                if (topo == 2 && !topo2.activeSelf)
                {
                    topo2.SetActive(true);
                    Invoke("OcultarTopo2", duracionTopo);
                    topoGenerado = true;
                }

                if (topo == 3 && !topo3.activeSelf)
                {
                    topo3.SetActive(true);
                    Invoke("OcultarTopo3", duracionTopo);
                    topoGenerado = true;
                }

                if (topo == 4 && !topo4.activeSelf)
                {
                    topo4.SetActive(true);
                    Invoke("OcultarTopo4", duracionTopo);
                    topoGenerado = true;
                }

                if (topo == 5 && !topo5.activeSelf)
                {
                    topo5.SetActive(true);
                    Invoke("OcultarTopo5", duracionTopo);
                    topoGenerado = true;
                }

                if (topo == 6 && !topo6.activeSelf)
                {
                    topo6.SetActive(true);
                    Invoke("OcultarTopo6", duracionTopo);
                    topoGenerado = true;
                }

                if (topo == 7 && !topo7.activeSelf)
                {
                    topo7.SetActive(true);
                    Invoke("OcultarTopo7", duracionTopo);
                    topoGenerado = true;
                }

                if (topo == 8 && !topo8.activeSelf)
                {
                    topo8.SetActive(true);
                    Invoke("OcultarTopo8", duracionTopo);
                    topoGenerado = true;
                }

                if (topo == 9 && !topo9.activeSelf)
                {
                    topo9.SetActive(true);
                    Invoke("OcultarTopo9", duracionTopo);
                    topoGenerado = true;
                }

                if (topo == 10 && !topo10.activeSelf)
                {
                    topo10.SetActive(true);
                    Invoke("OcultarTopo10", duracionTopo);
                    topoGenerado = true;
                }

                if (topo == 11 && !topo11.activeSelf)
                {
                    topo11.SetActive(true);
                    Invoke("OcultarTopo11", duracionTopo);
                    topoGenerado = true;
                }

                if (topo == 12 && !topo12.activeSelf)
                {
                    topo12.SetActive(true);
                    Invoke("OcultarTopo12", duracionTopo);
                    topoGenerado = true;
                }

                if (topo == 13 && !topo13.activeSelf)
                {
                    topo13.SetActive(true);
                    Invoke("OcultarTopo13", duracionTopo);
                    topoGenerado = true;
                }

                if (topo == 14 && !topo14.activeSelf)
                {
                    topo14.SetActive(true);
                    Invoke("OcultarTopo14", duracionTopo);
                    topoGenerado = true;
                }

                if (topo == 15 && !topo15.activeSelf)
                {
                    topo15.SetActive(true);
                    Invoke("OcultarTopo15", duracionTopo);
                    topoGenerado = true;
                }
            }
        }
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

        puntuacion++;
        sonidoGolpe.Play();
    }

    private void GameOver()
    {
        if (segundosRestantes <= 0 && !gameOver)
        {
            CancelInvoke ("GenerarTopoAleatorio");
            CancelInvoke("ContarTiempo");
            CancelInvoke("ReproducirSonidoDeFondo");
            DesactivarTopos();

            textoTimerDerecha.text = "¡Se terminó el tiempo! \n" + "Puntuación total: " + puntuacion;
            textoTimerIzquierda.text = "¡Se terminó el tiempo! \n" + "Puntuación total: " + puntuacion;

            textoPuntuacionDerecha.text = "\n \n Golpea los martillos para reiniciar el juego";
            textoPuntuacionIzquierda.text = "\n \n Golpea los martillos para reiniciar el juego"; 

            gameOver = true;
            sonidoGameover.Play();
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

    private void ActualizarTiempo()
    {
        if (!gameOver && !modoPausa)
        {
            textoTimerIzquierda.text = "Tiempo restante: " + segundosRestantes + " seg";
            textoTimerDerecha.text = "Tiempo restante: " + segundosRestantes + " seg";
        }
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
            if (!modoPausa && !gameOver)
            {
                textoPuntuacionIzquierda.text = "Puntuación: " + puntuacion;
                textoPuntuacionDerecha.text = "Puntuación: " + puntuacion;
            }
        }
    }

    private void PosicionarARCamera()
    {
        ARCamera.transform.position = new Vector3(0f, 1.2f, 0f);
    }

    public void InteraccionMartillos()
    {
        if (!juegoComenzado || gameOver)
        {
            ComenzarJuego();
        }
        else
        {
            if (!modoPausa)
            {
                textoPuntuacionDerecha.text = "PAUSA";
                textoPuntuacionIzquierda.text = "PAUSA";
                textoTimerIzquierda.text = "";
                textoTimerDerecha.text = "";

                renderizadoDerechoCamara.SetActive(true);
                renderizadoIzquierdoCamara.SetActive(true);

                modoPausa = true;
                sonidoMenu.Play();
            }
            else
            {
                modoPausa = false;
                renderizadoDerechoCamara.SetActive(false);
                renderizadoIzquierdoCamara.SetActive(false);
            }
        }
    }

    private void ContarTiempo()
    {
        if (!modoPausa)
        {
            segundosRestantes--;
        }
    }

    private void ReproducirSonidoDeFondo()
    {
        gameplayBackground.Play();
    }

    private void OcultarTopo1()
    {
        topo1.SetActive(false);
    }

    private void OcultarTopo2()
    {
        topo2.SetActive(false);
    }

    private void OcultarTopo3()
    {
        topo3.SetActive(false);
    }

    private void OcultarTopo4()
    {
        topo4.SetActive(false);
    }

    private void OcultarTopo5()
    {
        topo5.SetActive(false);
    }

    private void OcultarTopo6()
    {
        topo6.SetActive(false);
    }

    private void OcultarTopo7()
    {
        topo7.SetActive(false);
    }

    private void OcultarTopo8()
    {
        topo8.SetActive(false);
    }

    private void OcultarTopo9()
    {
        topo9.SetActive(false);
    }

    private void OcultarTopo10()
    {
        topo10.SetActive(false);
    }

    private void OcultarTopo11()
    {
        topo11.SetActive(false);
    }

    private void OcultarTopo12()
    {
        topo12.SetActive(false);
    }

    private void OcultarTopo13()
    {
        topo13.SetActive(false);
    }

    private void OcultarTopo14()
    {
        topo14.SetActive(false);
    }

    private void OcultarTopo15()
    {
        topo15.SetActive(false);
    }

}