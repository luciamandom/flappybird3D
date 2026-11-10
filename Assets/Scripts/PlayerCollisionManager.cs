using UnityEngine;

public class PlayerCollisionManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    internal void ProcessHit()
    {
        LevelController levelController = FindAnyObjectByType<LevelController>();
        levelController.TriggerReloadLevel();
    }
}
