using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float rotDeg = 1;
    public int turnSpeed = 100;
    public int speed = 1;
    public bool turning = false;
    public int direction = 1;
    public float cond = 0;
    public float minZ = 0f;
    public float maxZ = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = speed / Mathf.Abs(speed);
        if (turning == false)
        {
            cond = 0;
            transform.position = new Vector3(transform.position.z + speed * Time.deltaTime, 0, 0);
            if (transform.position.z > maxZ)
            {
                speed = -speed;
                turning = true;
                rotDeg = 0;
                transform.position = new Vector3(0, 0, maxZ - 0.1f);
            }
            if (transform.position.z < minZ)
            {
                speed = Mathf.Abs(speed);
                turning = true;
                rotDeg = 180;
                transform.position = new Vector3(0, 0, minZ + 0.1f);
            }
        }
        else
        { 
            rotDeg = rotDeg + turnSpeed * Time.deltaTime;
            cond = cond + turnSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, rotDeg * -direction, 0);
            if (cond > 180)
            {
                turning = false;
                if (speed < 0)
                {
                    transform.rotation = Quaternion.Euler(0, 180, 0);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
        }
    }
}
