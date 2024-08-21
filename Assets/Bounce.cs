using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Smoke")
        {
            transform.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 3, 0) * 15, ForceMode.Impulse);
        }
    }
}
