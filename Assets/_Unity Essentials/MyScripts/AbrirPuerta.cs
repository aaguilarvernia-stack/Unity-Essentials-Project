using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    private Animator Dr;
    // Start is called before the first frame update
    void Start()
    {
        Dr = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if (Dr != null)
            {
                Dr.SetTrigger("Door_Open");
            }
        }
    }
}
