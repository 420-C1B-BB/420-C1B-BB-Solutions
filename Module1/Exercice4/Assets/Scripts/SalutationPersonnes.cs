using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Programme qui salue deux personnes.
 * 
 * Auteurs: Enseignants de 420-C1B-BB
 */

public class SalutationPersonnes : MonoBehaviour
{
    [SerializeField] private string nomPersonne1;   // Le nom de la premi�re personne
    [SerializeField] private string nomPersonne2;   // Le nom de la deuxi�me personne

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bonjour � " + nomPersonne1 + " et � " + nomPersonne2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
