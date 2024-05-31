using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public GameManager gameManager;
 
    private void OnTriggerEnter(Collider objecto)
    {
        if (objecto.gameObject.tag == "Topo1")
        {
            gameManager.GolpeTopo(1);
        }

        if (objecto.gameObject.tag == "Topo2")
        {
            gameManager.GolpeTopo(2);
        }

        if (objecto.gameObject.tag == "Topo3")
        {
            gameManager.GolpeTopo(3);
        }

        if (objecto.gameObject.tag == "Topo4")
        {
            gameManager.GolpeTopo(4);
        }

        if (objecto.gameObject.tag == "Topo5")
        {
            gameManager.GolpeTopo(5);
        }

        if (objecto.gameObject.tag == "Topo6")
        {
            gameManager.GolpeTopo(6);
        }

        if (objecto.gameObject.tag == "Topo7")
        {
            gameManager.GolpeTopo(7);
        }

        if (objecto.gameObject.tag == "Topo8")
        {
            gameManager.GolpeTopo(8);
        }
    }
}
