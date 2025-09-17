using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float daylenght = 120f;
    public Vector3 rotationaxis = Vector3.right;


    // Start is called before the first frame update
    void Start()
    {
        rotationaxis = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (daylenght <= 0f) return;

        float degreesPerSecond = 360f / daylenght;
        transform.Rotate(Vector3.up, degreesPerSecond * Time.deltaTime, Space.World);
        
    }
}
