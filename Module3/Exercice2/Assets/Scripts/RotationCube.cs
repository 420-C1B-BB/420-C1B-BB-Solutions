using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe servant � faire une d�monstration sur les rotations
/// 
/// Auteurs: Enseignants de 420-C1B-BB
/// </summary>
public class RotationCube : MonoBehaviour
{
    /// <summary>
    /// L'axe de rotation de l'objet
    /// </summary>
    [SerializeField] private Vector3 axeRotation;
    /// <summary>
    /// La vitesse de la rotation
    /// </summary>
    [SerializeField] private float vitesseRotation;

    void Start()
    {
        
    }

    void Update()
    {
        // La vitesse est utilis�e pour d�terminer un angle de rotation
        float angle = vitesseRotation * Time.deltaTime;
        // La rotation se fait en fonction de l'angle et de l'axe
        transform.Rotate(axeRotation, angle);
    }
}
