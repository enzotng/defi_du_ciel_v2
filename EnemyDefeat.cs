using UnityEngine;

public class EnemyDefeat : MonoBehaviour
{
    public Material defeatedSkyboxMaterial;
    public GameObject wall // Assignez cela dans l'inspecteur

    public void OnEnemyDefeated()
    {
        // Changer la skybox
        RenderSettings.skybox = defeatedSkyboxMaterial;
        wall.SetActive(false);

    }

    // Supposons que cette fonction est appelée lorsque l'ennemi est vaincu
    void DefeatEnemy()
    {
        OnEnemyDefeated();
    }
}
