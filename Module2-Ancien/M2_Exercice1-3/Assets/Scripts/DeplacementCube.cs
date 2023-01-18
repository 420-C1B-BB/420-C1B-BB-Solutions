using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Classe qui d�place le cube en fonction des entr�es des utilisateurs.
 * 
 * Auteurs: Enseignants du cours de 420-C1B-BB
 * 
 */
public class DeplacementCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Lecture du d�placement selon les axes
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        // Calcul des nouvelles positions
        float positionX = transform.position.x + horizontal;
        float positionZ = transform.position.z + vertical;

        // Changement de la position du joueur
        transform.position = new Vector3(positionX, 2, positionZ);
        
    }
}
