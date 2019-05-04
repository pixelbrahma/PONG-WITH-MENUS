using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleLeftController : MonoBehaviour {
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, speed, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, speed, 0);
        }
    }
}
