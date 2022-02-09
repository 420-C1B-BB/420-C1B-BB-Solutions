using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Classe qui fait grandir et rapetisser la sph�re
/// 
/// Auteurs: Enseignants de 420-1CB-BB
/// </summary>
public class CoeurQuiBat : MonoBehaviour
{
    /// <summary>
    /// La vitesse de croissance et d�croissance
    /// </summary>
    [SerializeField]
    private float vitesse;
    /// <summary>
    /// Un texte pour dire si on est en train d'agrandir ou de diminuer la taille
    /// </summary>
    [SerializeField]
    private Text textMessage;
    /// <summary>
    /// Permet de d�terminer si on agrandit la sph�re ou on la r�duit
    /// </summary>
    private bool agrandissementActif;

    void Start()
    {
        agrandissementActif = true;
        textMessage.text = "Agrandissement";
        transform.localScale = Vector3.one * 2;
    }

    void Update()
    {
        // On agrandit ou on rapetisse selon la valeur du bool�en
        if (agrandissementActif)
        {
            transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * vitesse;
        }
        else
        {
            transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime * vitesse;
        }

        // On met � jour le bool�en pour la prochaine it�ration
        if (transform.localScale.magnitude >= 8.0f)
        {
            agrandissementActif = false;
            textMessage.text = "R�tr�cissement";
        }

        if (transform.localScale.magnitude <= 2.0f)
        {
            agrandissementActif = true;
            textMessage.text = "Agrandissement";
        }
    }
}
