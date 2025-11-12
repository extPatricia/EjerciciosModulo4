using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    // Public varaibles
    public float rotationSpeed = 10f;
    public float orbitSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate around its own axis
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

        // Orbit movement
        if(transform.parent != null)
        {
            transform.RotateAround(transform.parent.position, Vector3.up, orbitSpeed * Time.deltaTime);
        }

        // Debugging rays
        // Rotation axis
        Debug.DrawRay(transform.position, transform.up * 2, Color.green);

        // Orbit axis
        if(transform.parent != null)
        {
            Vector3 orbitDirection = Vector3.Cross((transform.position - transform.parent.position).normalized, Vector3.up);
            Debug.DrawRay(transform.parent.position, orbitDirection * 2, Color.blue);
        }

        // Line to parent
        if(transform.parent != null)
        {
            Debug.DrawLine(transform.position, transform.parent.position, Color.red);
        }
    }
}
