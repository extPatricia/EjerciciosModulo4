using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraMovement : MonoBehaviour
{
    // Public variables
    public float orbitSpeed = 500;
    public float zoomSpeed = 500;
    public Transform playerTransform;
    public float minDistance = 2f;  // Camera minimum distance
    public float maxDistance = 10f; // Camera maximum distance

    // Private variables
    private float _currentDistance;
    private bool _isOrbiting = false;

    void Start()
    {
        if (playerTransform != null)
            _currentDistance = Vector3.Distance(transform.position, playerTransform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            //Camera orbit
            _isOrbiting = true;
            transform.RotateAround(playerTransform.position, Vector3.up, Input.GetAxis("Mouse X") * orbitSpeed * Time.deltaTime);
            transform.RotateAround(playerTransform.position, transform.right, -Input.GetAxis("Mouse Y") * orbitSpeed * Time.deltaTime);
        }
        else if (_isOrbiting)
        {
            _isOrbiting = false;
        }

        if(!_isOrbiting)
        {
            Vector3 desiredPosition = playerTransform.position - playerTransform.forward * _currentDistance + Vector3.up * 1.5f;
            transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * 5f);
        }

        //Zoom camera
        transform.LookAt(playerTransform.position);
        _currentDistance = Mathf.Clamp(_currentDistance - Input.GetAxis("Mouse ScrollWheel") * zoomSpeed* Time.deltaTime, minDistance, maxDistance);
    }
}
