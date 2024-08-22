using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitate : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
         
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Rise")
        {
           
            transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
            gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    private void OnTriggerExit()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}
