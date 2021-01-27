using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antirotate : MonoBehaviour
{
    private int speed = 10;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right, (-speed * Time.deltaTime));
    }
}
