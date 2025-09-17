using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private Vector3 posicionInicial;
    public float amplitud = 0.05f; //altura max
    public float frecuencia = 1f; //velocidad
    public float rotationSpeed;

    public GameObject onCollectEffect;

    
    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotationSpeed,0);
        float nuevaY = posicionInicial.y + Mathf.Sin(Time.time * frecuencia) * amplitud;
        transform.position = new Vector3(posicionInicial.x, nuevaY, posicionInicial.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        //Destroy the collectible
        if (other.CompareTag("Player"))
        {


            Destroy(gameObject);

            Instantiate(onCollectEffect, transform.position, transform.rotation);

        }

    }
}
