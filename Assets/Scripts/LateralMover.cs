using UnityEngine;

public class LateralMover : MonoBehaviour
{
    [SerializeField] Vector3 direction = Vector3.right;   // eje de movimiento (X = lateral)
    [SerializeField] float amplitude = 3f;                // distancia a cada lado del punto inicial
    [SerializeField] float frequency = 1f;                // velocidad de ida y vuelta
    [SerializeField] bool randomOffset = false;           // para desincronizar varios enemigos

    Vector3 startPos;
    float offset;

    void Start()
    {
        startPos = transform.localPosition;
        if (randomOffset) offset = Random.Range(0f, 2f * Mathf.PI);
    }

    void Update()
    {
        float d = Mathf.Sin(Time.time * frequency + offset) * amplitude;
        transform.localPosition = startPos + direction.normalized * d;
    }
}