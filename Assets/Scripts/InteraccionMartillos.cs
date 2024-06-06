using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionMartillos : MonoBehaviour
{
    public GameManager gameManager;
 
    private void OnTriggerEnter(Collider objecto)
    {
        if (objecto.gameObject.tag == "HitboxInteraccionMartillo")
        {
            gameManager.InteraccionMartillos();
        }
    }
}