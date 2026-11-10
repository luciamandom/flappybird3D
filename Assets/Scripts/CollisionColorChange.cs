using UnityEngine;

public class CollisionColorChanges : MonoBehaviour
{
    [SerializeField] public Color hitColor, normalColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        normalColor = GetComponent<MeshRenderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") GetComponent<MeshRenderer>().material.color = hitColor;
    }
    private void OnCollisionExit(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = normalColor;
    }

}
