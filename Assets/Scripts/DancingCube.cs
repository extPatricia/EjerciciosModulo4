using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DancingCube : MonoBehaviour
{
    // Public variables
    public float moveSpeed = 5f;
    public float rotateSpeed = 100f;
    public float jumpHeight = 2f;

    // Private variables
    private bool goingUp = false;

    // Update is called once per frame
    void Update()
    {
        // Movement
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);

        // Rotation dancing
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }

        // Jumping dancing
        if (Input.GetKeyDown(KeyCode.Space))
        {
            goingUp = !goingUp;
        }

        float targetY = goingUp ? Mathf.PingPong(Time.time * 2f, jumpHeight) : 0f;
        transform.position = new Vector3(transform.position.x, targetY, transform.position.z);
    }
}
