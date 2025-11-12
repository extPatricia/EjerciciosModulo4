using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Public variables
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;

    void Update()
    {
        // Movement
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);

        // Rotation around Y axis
        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime);
    }
}
