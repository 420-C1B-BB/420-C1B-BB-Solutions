using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Classe qui d�place le cube en fonction des entr�es des utilisateurs.
 * Toutefois, le cube ne doit pas d�passer les limites du plan
 * 
 * Auteurs: Enseignants du cours de 420-C1B-BB
 * 
 */
public class DeplacementCubePlan : MonoBehaviour
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
            transform.position = new Vector3(positionX, 2, positionZ);
        }

    }
}
