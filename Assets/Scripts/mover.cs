//using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Vector3 directionVector =  new Vector3(1f,0f,0f);
    float tiempo;
    [SerializeField] float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 2f; //inicializo la velocidad
    }

    // Update is called once per frame
    void Update()
    {
        //Transalate lo que hace es trasladar el objeto de sitio a las coordenadas que coloco
        //En este caso las variables las multiplico por speed (la cual la decidimos)
        //deltaTime lo que hace es compensar el tiempo que hay entre frame y frame (que no siempre es el mismo)
        //o el tiempo entre updates
        transform.Translate(directionVector.x *speed *Time.deltaTime,
        directionVector.y * speed * Time.deltaTime ,directionVector.z * speed* Time.deltaTime);

        
    }
    //Cuando detecta una colisión aplica un cambio en el movimiento del objeto  
    void OnCollisionEnter(Collision collision)
    {
        Vector3 direction = collision.GetContact(0).normal; //sustuituimos por el normal(literalmente el opuesro)
        Debug.Log(direction);
        if (collision.gameObject.tag == "Wall")
        {
        this.ChangeDirection(direction);          
        }
    }
    void ChangeDirection(Vector3 direction)
        {
            this.directionVector = direction;
        }
}



//NO tenemos control sobre la arquitectura del proyecto, es Unity el que toma el control
//Unity esconde la estructura básica
//Solo tenemos que hacer el trozo de código que se encargue de la lógica específica de lo que queremos
//realizar (en este caso movimiento)