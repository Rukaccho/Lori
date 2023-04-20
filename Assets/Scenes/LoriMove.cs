using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoriMove : MonoBehaviour
{
    //private Rigidbody _rb;
    //public float StrafeSpeed = 100f;
    //public float RunSpeed = 250f;
    //[SerializeField]
    //private float JumpSpeed = 10f;
    //private bool strafeRight = false;
    //private bool strafeLeft = false;
    //private bool strafeStraight = false;
    //private bool strafeBack = false;
    //private bool jump = false;
    //private float verticalInput;
    //private float horizontalInput;
    //public Transform Orientation;
    // Start is called before the first frame update
    void Start()
    {
        //_rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        /*strafeRight = Input.GetKey("d");
        strafeLeft = Input.GetKey("a");
        strafeStraight = Input.GetKey("w");
        strafeBack = Input.GetKey("s");
        jump = Input.GetKeyDown("space");*/
        //verticalInput = Input.GetAxisRaw("Vertical");
        //horizontalInput = Input.GetAxisRaw("Horizontal");
        //speedcontrol();
    }
    void FixedUpdate()
    {

        //_rb.AddForce(RunSpeed * Time.deltaTime, 0, 0);
        /*if (strafeLeft)
        {
            _rb.AddForce(0, 0, StrafeSpeed * Time.deltaTime);
        }
        if (strafeRight)
        {
            var rotation = transform.rotation;
            rotation.y += 20;
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, 0);
            _rb.AddForce(0, 0, -StrafeSpeed * Time.deltaTime);
        }
        if(strafeStraight)
        {
            _rb.AddForce(-StrafeSpeed * Time.deltaTime, 0, 0);
        }
        if(strafeBack)
        {
            _rb.AddForce(StrafeSpeed * Time.deltaTime, 0, 0);
        }
        if (jump)
        {
            _rb.AddForce(-StrafeSpeed * Time.deltaTime, 0, 0);
            _rb.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
            jump = false;
        }*/
        //Vector3 movediraction = -Orientation.up * horizontalInput - Orientation.right * verticalInput;
        //_rb.AddForce(movediraction.normalized * RunSpeed, ForceMode.Force);
    }   
    private void speedcontrol()
    {
        //Vector3 vector3 = new Vector3(_rb.velocity.x, 0f, _rb.velocity.z);
        //if (vector3.magnitude>50)
        //{
            //Vector3 limited = vector3.normalized * 50;
            //_rb.velocity = new Vector3(limited.x, _rb.velocity.y, limited.z);

        //}
    }
}
