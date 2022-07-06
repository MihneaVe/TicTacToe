using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doge : MonoBehaviour
{
    private void OnMouseEnter()
    {
        transform.localPosition = Vector3.zero;
    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.localPosition += new Vector3(x: 0, y: 1.1f, z: 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += new Vector3(x: 0.1f, y: 0, z: 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += new Vector3(x: 0, y: 0.1f, z: 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += new Vector3(x: 0.1f, y: 0, z: 0);
        }
    }
}

