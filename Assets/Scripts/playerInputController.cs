//using System.Numerics;
//using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    public Vector2 move;
    bool jump, isGrounded;
    Rigidbody rb;
    float directionX, directionZ;
    [SerializeField] float speed = 1f;
    [SerializeField] float ThrustForce = 10000f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rb = GetComponentInChildren<Rigidbody>();
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (jump)
        {
        Jump();
        }
    }
    private void Move(){

        directionX = move.x;
        directionZ = move.y;

        transform.Translate(directionX * speed * Time.deltaTime, 0, directionZ * Time.deltaTime * speed);
    }
        
    
    public void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }

    private void Jump()
    {
        Debug.Log("Jumping!");//Para ver en la consola si está corriendo en Unity
        //if (!isGrounded) return;
        //rb.AddRelativeForce(Vector3.up * ThrustForce * Time.fixedDeltaTime);
        Vector3 v = rb.linearVelocity;
        v.y = 0;
        rb.linearVelocity = v;
        rb.AddForce(Vector3.up * ThrustForce * Time.fixedDeltaTime);
        //rb.GetAccumulatedForce(Vector3.down,)
        jump = false;
    }
   
   
   
   public void OnJump(InputValue value)
    {
        jump = value.isPressed;
    }

    /*private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ground Trigger!");
        isGrounded = true;
    }
    private void OnTriggerExit(Collider other)
    {
        isGrounded = false;
    }*/


}

