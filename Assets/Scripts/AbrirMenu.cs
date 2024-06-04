using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirMenu : MonoBehaviour
{
    public GameManager gameManager;
 
    private void OnTriggerEnter(Collider objecto)
    {
        if (objecto.gameObject.tag == "HitboxMenu")
        {
            gameManager.AbrirMenu();
        }
    }
}