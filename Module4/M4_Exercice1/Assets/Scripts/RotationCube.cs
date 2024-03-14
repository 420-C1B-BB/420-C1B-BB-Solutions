using UnityEngine;

public class RotationCube : MonoBehaviour
{
    [SerializeField] private Vector3 axeRotation;
    [SerializeField] private float vitesse;  // Repr�sente le nombre de degr�s par seconde

    // Update is called once per frame
    void Update()
    {
        float angle = vitesse * Time.deltaTime;
        transform.Rotate(axeRotation, angle);
    }
}
