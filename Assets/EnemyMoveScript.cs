using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour
{
    public float speed;
    public bool turn;
    // Start is called before the first frame update
    void Start()
    {
        turn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //if (transform.position.z <= 447 || transform.position.z >= 480)
        //{
        //speed = speed * -1;
        //transform.localScale.z = transform.localScale.z * -1;
        //}
        //float newZposition = transform.position.z + speed * Time.deltaTime;

        //Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, newZposition);
        //transform.position = newPosition;

        if (turn == false)
        {

            float newZposition = transform.position.z + speed * Time.deltaTime;

            Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, newZposition);
            transform.position = newPosition;
            if (transform.position.z <= -9.9 || transform.position.z > 19.2)
            {
                if (transform.position.z > 19.2 && speed > 0)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, 19);
                    transform.Rotate(0.0f,180.0f, 0.0f, Space.Self);
                    speed = speed * -1;
                }
                else if (transform.position.z <= -9.9 && speed < 0)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, -9);
                    transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
                    speed = speed * -1;
                }
                
                turn = true;
            }
        }
        else

        {

            if ((transform.rotation.y < 10 && transform.rotation.y > -10))
            {
                //float newYrotation = GetComponentInChildren<Transform>().rotation.y + speed * Time.deltaTime;

                //Vector3 newRotation = new Vector3(GetComponentInChildren<Transform>().rotation.x, newYrotation, GetComponentInChildren<Transform>().rotation.z);
                //GetComponentInChildren<Transform>().Rotate(newRotation);
                turn = false;
            }
           // transform.Rotate(0, Time.deltaTime * 20, 0);

        }
    }
}
          ////////
                      ////////
           //////      //////
         //  //  //  //  //  //
           //////      //////
           
         ///                ///
            ////////////////