using UnityEngine;

public class EnemyDefeat : MonoBehaviour
{
    public Material defeatedSkyboxMaterial; // Assignez cela dans l'inspecteur

    public void OnEnemyDefeated()
    {
        // Changer la skybox
        RenderSettings.skybox = defeatedSkyboxMaterial;
        // Vous pouvez également utiliser DynamicGI.UpdateEnvironment() si l'éclairage global doit être mis à jour
    }

    // Supposons que cette fonction est appelée lorsque l'ennemi est vaincu
    void DefeatEnemy()
    {
        OnEnemyDefeated();
    }
}
