using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode PlayerCode;
    [SerializeField] private Rigidbody Rig;
    [SerializeField] private float Boost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(PlayerCode))
        {
            Rig.AddForce(transform.up * 100 * Boost);
        }
    }
}
