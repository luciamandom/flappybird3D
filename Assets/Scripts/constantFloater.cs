using UnityEngine;

public class constantFloater : MonoBehaviour
{
    // Declaración de variables
    
    //SerializeField nos permite editar en Unity los valores de la variable que anteceden
    //Siempre que escriba para floats pongo una f a continuación del número
    //Si en SerializeField coloco un rango de valores pondrá un máximo y un mínimo de valores 
    //que puedo usar 
    [SerializeField][Range (-5f,5f)] float amplitude = 0.5f;
    [SerializeField] float final_frequency = 1f;
    Vector3 StartPos; // para declarar posiciones
    float time;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // Queremos qu el objeto se mueva, en este caso verticalmente, modificando su transformada (por eso
        // introducimos un seno
        // solo queremos transformar la y que es la que nos da la posición en vertical. Actualizo solo un poco la
        // posición de la y

        //Mathf es una clase estática a la cual solo voy a tener que llamarla para recurrir a sus métodos
        //Time.time dependiendo de este tiempo voy a conseguir puntos distintos
        //final_frequency va a ser la velocidad a la que suba o baje
        //amplitude va a ser la distancia que va a recorrer mientras sube y baja

        float newY = StartPos.y + Mathf.Sin(Time.time * final_frequency)* amplitude;
        
        //Una vez calculado el nuevo valor de la componente y la coloco en la transformada
        transform.localPosition = new Vector3(StartPos.x,newY, StartPos.z);
    }
}
