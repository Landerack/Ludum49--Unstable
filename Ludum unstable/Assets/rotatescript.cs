using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatescript : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 15f;

    void Update()
    {

        // Rotation on y axis
        this.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
