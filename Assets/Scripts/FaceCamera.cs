using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    void Update()
    {
        // Facce the camera
        transform.forward = Camera.main.transform.forward;
    }
}
