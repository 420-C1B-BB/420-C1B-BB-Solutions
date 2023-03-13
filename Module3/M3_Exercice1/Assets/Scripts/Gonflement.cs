using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Classe qui fait grandir et rapetisser la sph�re
/// 
/// Auteurs: Enseignants de 420-1CB-BB
/// </summary>
public class Gonflement : MonoBehaviour
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
    private TMP_Text textMessage;
    /// <summary>
    /// Permet de d�terminer si on agrandit la sph�re ou on la r�duit
    /// </summary>
    private bool gonflementActif;

    void Start()
    {
        gonflementActif = true;
        textMessage.text = "On gonfle";
        transform.localScale = Vector3.one * 2;
    }

    void Update()
    {
        // On agrandit ou on rapetisse selon la valeur du bool�en
        if (gonflementActif)
        {
            transform.localScale += Vector3.one * Time.deltaTime * vitesse;
        }
        else
        {
            transform.localScale -= Vector3.one * Time.deltaTime * vitesse;
        }

        // On met � jour le bool�en pour la prochaine it�ration
        if (transform.localScale.x >= 7.0f && transform.localScale.y >= 7.0f &&
            transform.localScale.z >= 7.0f)
        {
            gonflementActif = false;
            textMessage.text = "On d�gonfle";
        }

        if (transform.localScale.x <= 2.0f && transform.localScale.y <= 2.0f &&
            transform.localScale.z <= 2.0f)
        {
            gonflementActif = true;
            textMessage.text = "On gonfle";
        }
    }
}
