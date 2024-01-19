using UnityEngine;

public class HealthBarFollow : MonoBehaviour
{
    public Transform enemyTransform; // La position de l'ennemi
    public Vector3 offset; // Décalage de la barre de vie par rapport à l'ennemi

    void Update()
    {
        if (enemyTransform != null)
        {
            // Convertir la position de l'ennemi en position d'écran pour l'UI
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(enemyTransform.position + offset);
            transform.position = screenPosition;
        }
    }
}
