using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private bool isReload;
    [SerializeField] private float reloadLapseLime = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isReload = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isReload)
        {
        isReload = false;
        Invoke("ReloadLevel", reloadLapseLime);
        }
    }
    public void TriggerReloadLevel()
    {
        isReload = true;
    }
    public void LoadNextLevel()
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene((CurrentScene+1)%SceneManager.sceneCountInBuildSettings);
    }
    void ReloadLevel()
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentScene);
    }
}
