using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject target;
    public float cameraSpeed;
    public Vector3 rotationAxis;
    public Vector3 targetOffset;
    public Vector3 characterForward;
    public Vector3 characterRight;
    public LayerMask groundMask;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {

        
        float rotateHorizontal = Input.GetAxis("Mouse X");
        transform.RotateAround(target.transform.position, Vector3.up, rotateHorizontal * cameraSpeed);

        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, Mathf.Infinity, groundMask))
        {
            characterForward = Vector3.Cross(transform.right, Vector3.up);
            characterRight = transform.right;
        }
    }
}
