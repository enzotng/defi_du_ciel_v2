using UnityEngine;

public class EnemyDefeat : MonoBehaviour
{
    public Material defeatedSkyboxMaterial;
    public WallDestruction wallDestructionScript;

    public void OnEnemyDefeated()
    {
        RenderSettings.skybox = defeatedSkyboxMaterial;
        if (wallDestructionScript != null)
        {
            wallDestructionScript.DestroyWall();
        }
    }

    void DefeatEnemy()
    {
        OnEnemyDefeated();
    }
}
