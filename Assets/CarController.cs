using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CarController : MonoBehaviour
{
    public static CarController instance;
    public Rigidbody2D backTire, frontTire;
    public float Speed, movement;
    public Image fuelImg;


    public float fuel, fuelConsumption;
    // public float gasBreak;
    // Start is called before the first frame update

    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
           
    }

    void Start()
    {
       // gasBreak = Speed;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        fuelImg.fillAmount = fuel;
    }

    private void FixedUpdate()
    {
        if(fuel>0)
        {
            backTire.AddTorque(-movement * Speed * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * Speed * Time.fixedDeltaTime);
            //car.AddTorque(movement * Speed * Time.fixedDeltaTime);


           
        }
        fuel = fuel - fuelConsumption * Time.deltaTime * Mathf.Abs(movement);
    }

    //public void Brake()
    //{
    //    Speed = 0f;
    //    movement = 0f;
    //}
    //public void Gas()
    //{
    //    Speed = gasBreak;
    //    movement = 1f;
    //}
}
