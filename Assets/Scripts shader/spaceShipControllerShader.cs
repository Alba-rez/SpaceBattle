using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class spaceShipControllerShader : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float force;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    
    void FixedUpdate()
    {
        CheckMove(); 
    }

    private void CheckMove()
    {
        Vector2 direction=new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
        direction.Normalize();

        // aplicamos una fuerza en esa dirección 
        rb.AddForce(direction * force,ForceMode2D.Impulse);
    }
}
