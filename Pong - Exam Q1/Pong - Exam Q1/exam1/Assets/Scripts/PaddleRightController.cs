using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleRightController : MonoBehaviour
{
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, speed, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0, speed, 0);
        }
    }
}
