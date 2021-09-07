using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CarController.instance.fuel = 1.0f;
        Destroy(gameObject);
    }
}
