using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate1 : MonoBehaviour
{
    public int speed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, (-speed *10* Time.deltaTime));
    }
}
