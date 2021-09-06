using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public Rigidbody2D backTire, frontTire;
    public float Speed, movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        backTire.AddTorque(-movement * Speed * Time.fixedDeltaTime);
        frontTire.AddTorque(-movement * Speed * Time.fixedDeltaTime);
        //car.AddTorque(movement * Speed * Time.fixedDeltaTime);
    }
}
