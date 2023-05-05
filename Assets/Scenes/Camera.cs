using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform Player;
    public Vector3 OffSet;

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position + OffSet;
    }
}
