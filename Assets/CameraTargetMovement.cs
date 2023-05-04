using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTargetMovement : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset;

    private void FixedUpdate()
    {
        transform.position = target.transform.position + offset;
    }
}
