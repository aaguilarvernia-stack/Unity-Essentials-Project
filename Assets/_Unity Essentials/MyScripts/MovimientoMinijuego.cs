using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMinijuego : MonoBehaviour
{

    public float salto;
    public float speed = 5.0f; // Set player's movement speed.


    public float rotationSpeed = 120.0f; // Set player's rotation speed.





    private Rigidbody rb; // Reference to player's Rigidbody.





 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()


    {


        // Move player based on vertical input.


        float moveVertical = Input.GetAxis("Vertical");


        Vector3 movement = transform.forward * moveVertical * speed * Time.fixedDeltaTime;


        rb.MovePosition(rb.position + movement);





        // Rotate player based on horizontal input.

        float turn = Input.GetAxis("Horizontal") * rotationSpeed * Time.fixedDeltaTime;


        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);


        rb.MoveRotation(rb.rotation * turnRotation);

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("salto");
            rb.AddForce(Vector3.up * salto, ForceMode.VelocityChange);
        }

    }
}
