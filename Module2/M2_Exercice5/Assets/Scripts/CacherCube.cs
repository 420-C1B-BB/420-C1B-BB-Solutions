using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Classe qui place l'objet � une des trois positions sp�cifi�es dans l'inspecteur.
 * L'endroit est d�termin� au hasard.
 *
 * Auteurs: Enseignants de 420-1CB-BB
 */
public class CacherCube : MonoBehaviour
{
    [SerializeField] private Vector3 cachette1; // La premi�re cachette
    [SerializeField] private Vector3 cachette2; // La deuxi�me cachette
    [SerializeField] private Vector3 cachette3; // La troisi�me cachette

    // Start is called before the first frame update
    void Start()
    {
        // D�termine une cachette al�atoire
        int valeurAleatoire = UnityEngine.Random.Range(1, 4);
        Debug.Log(valeurAleatoire);

        // On fait un if pour placer l'�l�ment � la bonne place
        if (valeurAleatoire == 1)
        {
            transform.position = cachette1;
        }
        else if (valeurAleatoire == 2)
        {
            transform.position = cachette2;
        }
        else if (valeurAleatoire == 3)
        {
            transform.position = cachette3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
