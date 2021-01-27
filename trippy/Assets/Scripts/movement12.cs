using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movement12 : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 20.0f;
    public GameObject target;
    private int count;
    public Text countText;
    public Collider collider;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        InvokeRepeating("SetCountText",0,1);
        /// collider = GetComponent<Collider>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       

            transform.position += (transform.forward * (-speed) * Time.deltaTime);

       /* if (Input.GetKey("c"))
        {
            collider.enabled = false;
        }
        if (Input.GetKey("v"))
        {
            collider.enabled = true;
        }
        if (Input.GetKey("s"))
        {

            transform.position += (transform.forward * (speed) * Time.deltaTime);

        }*/
       
        

        {
            if (Input.GetKey("d"))
            {
               transform.RotateAround(target.transform.position,Vector3.forward,  (speed * 5) * Time.deltaTime);

            }

            else if (Input.GetKey("a"))
            {
                transform.RotateAround(target.transform.position, Vector3.forward, (-speed * 5) * Time.deltaTime);
            }

            else rb.angularVelocity = rb.transform.up * 0;
        }
       
       

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "plane" || collisionInfo.collider.tag == "bar") { Scene(); }

    }
    void OnTriggerEnter(Collider other)
    {
        Scene1();

    }
    public void Scene()
    {
        SceneManager.LoadScene("game Over");


    }
    public void Scene1()
    {
        SceneManager.LoadScene("level Complete");


    }
    void SetCountText()
    {
        count = count + 1;
        countText.text = "SCORE:" + count;
    }
   
}
