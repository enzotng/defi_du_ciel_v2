using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera mainCamera; // Assignez la caméra principale dans l'inspecteur
    public Camera menuCamera; // Assignez la caméra du menu dans l'inspecteur

    private void Start()
    {
        // Assurez-vous que la caméra principale est active au début
        mainCamera.gameObject.SetActive(true);
        menuCamera.gameObject.SetActive(false);
    }

    public void SwitchCamera()
    {
        // Vérifiez quelle caméra est actuellement active et basculez
        if (mainCamera.gameObject.activeInHierarchy)
        {
            mainCamera.gameObject.SetActive(false);
            menuCamera.gameObject.SetActive(true);
        }
        else
        {
            mainCamera.gameObject.SetActive(true);
            menuCamera.gameObject.SetActive(false);
        }
    }
}
