using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    private int speed = 10; 
    
    void Update()
    {
        transform.Rotate(Vector3.right, (speed * Time.deltaTime));
    }


  
    

}
