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
    [SerializeField]
    private float vitesseDeplacement;  // Pour la vitesse de d�placement

    // Update is called once per frame
    void Update()
    {
        // Lecture du d�placement selon les axes
        float horizontal = Input.GetAxis("Horizontal") * vitesseDeplacement * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * vitesseDeplacement * Time.deltaTime;

        // Calcul des nouvelles positions
        float positionX = transform.position.x + horizontal;
        float positionY = transform.position.y; // On ne change pas la hauteur
        float positionZ = transform.position.z + vertical;


        if (positionX >= -13.5f && positionX <= 13.5f && positionZ >= -13.5f && positionZ <= 13.5f)
        {
            // Changement de la position du joueur
            transform.position = new Vector3(positionX, positionY, positionZ);
        }

        // ou en utilisant un bool�en
        // bool surLePlan = positionX >= -13.5f && positionX <= 13.5f && positionZ >= -13.5f && positionZ <= 13.5f;
        // if (surLePlan)
        // {
        //    // Changement de la position du joueur
        //    transform.position = new Vector3(positionX, positionY, positionZ);
        // }

    }

}

