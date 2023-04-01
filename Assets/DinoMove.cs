using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMove : MonoBehaviour
{
    public float Speed;
    public float JumpPower;
    public Vector3 smallSkale;
    private Rigidbody rbDino;
    // Start is called before the first frame update
    void Start()
    {
        rbDino = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, Input.GetAxis("Horizontal"), 0f);
        transform.Translate(Input.GetAxis("Vertical"), 0f, 0f);
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * Speed, 
            0f,
            Input.GetAxis("Vertical") * Time.deltaTime * Speed);
        if(Input.GetKeyDown(KeyCode.C))
        {
            transform.localScale = smallSkale;
        }
        if(Input.GetKeyDown(KeyCode.N))
        {
            transform.localScale = Vector3.one;
        }
    }
}
