using UnityEngine;

public class Dropper : MonoBehaviour
{
    Rigidbody myRigidBody; 
    MeshRenderer myMeshRenderer; // Toma la geometría del filtro de malla y lo renderiza a la posición definida
    // en la componente Transform.
    float startTime; // Declaro la variable de tiempo de comienzo

    //Condiciones de inicio
    void Start()
    {
        startTime = Time.time; // Guardo el momento en el que empieza el juego
        myRigidBody = GetComponent<Rigidbody>(); // Encuentra cualquier componente que pertenezca al objeto
        //al que pertenece este script, en caso de que el objeto no tenga asociado ese componente (en este caso
        //Rigidbody) nos devolverá null, se quedará vacía y no se le asignarará nada y nos dará un error de 
        //ejecución más adelante
        myMeshRenderer = GetComponent<MeshRenderer>();// Lo mismo, pero esta vez lo que busca es el MeshRenderer

    }

    //Es una especie de bucle que se repite cada poco tiempo
    void Update()
    {
        //if(Time.time - startTime < 3)
        //{
          //  myRigidBody.useGravity = true; // Activo la gravedad a los 3 segundos
            //La graveadad se encuentra asociada a rigidbody, así que tengo que encontrarlo antes
            //myMeshRenderer.enabled = true;
       // }
    }
    public void Activate()
    {
        myRigidBody.useGravity = true;
    }
}
