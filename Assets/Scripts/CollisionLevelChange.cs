using UnityEngine;

public class CollisionLevelChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerCollisionManager pcm = other.gameObject.GetComponent<PlayerCollisionManager>();
            if (pcm != null) pcm.ProcessHit();
            else Debug.LogWarning("El Player no tiene PlayerCollisionManager");
        }
        
    }
        
}
