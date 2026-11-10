using UnityEngine;

public class triggerActivator : MonoBehaviour
{
    [SerializeField] Dropper target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("triggerActivator activo en: " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
         Debug.Log("TRIGGER con: " + other.name + " | tag: " + other.tag);
        if (other.CompareTag("Player"))
        {
            if (target == null) Debug.LogWarning("Target vacío");
            else target.Activate();
        }
    }
}
