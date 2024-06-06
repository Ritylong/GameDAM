using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditSceneManager : MonoBehaviour
{
    public GameObject uiManager;

    void Start()
    {
        if (uiManager != null)
        {
            Destroy(uiManager);
        }
    }
}
