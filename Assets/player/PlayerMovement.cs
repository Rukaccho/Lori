using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 4.0f;
    public float jumpHeight = 1.0f;
    public float maxSpeed;


    public CameraMovement CameraObject;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {

        float HorizontalMovement = Input.GetAxis("Horizontal");
        float VerticalMovement = Input.GetAxis("Vertical");

        Vector3 move = (CameraObject.characterForward * VerticalMovement) + CameraObject.characterRight * HorizontalMovement;
        if (rb.velocity.magnitude < maxSpeed)
            rb.AddForce(move * playerSpeed);

        if (move != Vector3.zero)
        {
            //gameObject.transform.forward = move;

            rb.MoveRotation(Quaternion.LookRotation(move, Vector3.up));
        }

        if (Input.GetKeyDown(KeyCode.Space) && groundedPlayer)
        {
            Jump();
        }

    }
    private void Jump()
    {
        rb.AddForce(Vector2.up * jumpHeight, ForceMode.Impulse);
        groundedPlayer = false;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            groundedPlayer = true;

        }
    }
}
