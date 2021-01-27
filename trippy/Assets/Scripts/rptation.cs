using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rptation : MonoBehaviour
{
    public float speed = 4.0f;
    private float a;
   

    //private Vector3 motion;

    // Start is called before the first frame update
    void Start()
    {
         a = Random.Range(-8.0f, 10.0f);
       

       

    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate( Vector3.forward, (-speed *a* Time.deltaTime));
        transform.position += (transform.up * (Mathf.Sin(Time.time)*a) * Time.deltaTime);


    }
}
