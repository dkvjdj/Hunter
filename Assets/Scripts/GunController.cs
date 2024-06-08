using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GunController : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float sensitivity = 5;
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Mouse X") * sensitivity;
        vertical = Input.GetAxis("Mouse Y") * sensitivity;
        transform.Rotate(0, horizontal, vertical);
    }
}
