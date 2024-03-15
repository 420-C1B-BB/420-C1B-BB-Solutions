using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionJoueur : MonoBehaviour
{
    private GameObject _joueur;

    // Start is called before the first frame update
    void Start()
    {
        _joueur = GameObject.Find("Joueur");   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _joueur)
        {
            Debug.Log("Le joueur est entr� dans la zone de d�tection");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == _joueur)
        {
            Debug.Log("Le joueur est sorti de la zone de d�tection");
        }
    }
}
