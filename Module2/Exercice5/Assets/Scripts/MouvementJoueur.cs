using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Classe qui permet au joueur de bouger
 * Copie de l'exercice 3 sauf que la hauteur a �t� chang�e
 *
 * Auteurs: Enseignants de 420-1CB-BB
 */

public class MouvementJoueur : MonoBehaviour
{
    [SerializeField] private float vitesse = 2.0f; // Pour contr�ler la vitesse de d�placement du cube
                                                   // La valeur par d�faut est 2.0. Elle peut �tre modifi�e dans l'inspecteur�
                                                   // ATTENTION: si la vitesse est de z�ro, alors le cube ne bougera pas

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Lecture de la direction
        float horizontal = Input.GetAxis("Horizontal") * vitesse * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * vitesse * Time.deltaTime;

        // Calcul des nouvelles positions
        float positionX = transform.position.x + horizontal;
        float positionZ = transform.position.z + vertical;

        // On s'assure de rester dans les bornes du plan
        if (positionX >= -15 && positionX <= 15 && positionZ >= -15 && positionZ <= 15)
        {
            // Changement de la position du joueur
            // Ici, la position en y a �t� chang�e par rapport aux exercices 3 et 4
            transform.position = new Vector3(positionX, 0.5f, positionZ);
        }

    }
}
