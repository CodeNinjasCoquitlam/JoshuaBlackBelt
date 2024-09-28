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
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, transform.rotation.y + 180f, 0), Time.deltaTime * 2);
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
            if (transform.position.z <= -9.9 || transform.position.z > 31)
            {
                if (transform.position.z > 31 && speed > 0)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, 30.5f);
                    //transform.Rotate(0.0f,180.0f, 0.0f, Space.Self);
                    //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, transform.rotation.y + 180f, 0), Time.deltaTime * 2);
                    //get better game
                    
                    speed = -speed;
                }
                else if (transform.position.z <= -9.9f && speed < 0)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, -9.5f);
                    //transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);

                    //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, transform.rotation.y + 180f, 0), Time.deltaTime * 2);
                    speed = -speed;
                }
                
                turn = true;
            }
        }
        else
        {
            //StartCoroutine(RotateSlowly());

            /*if(transform.rotation.y > 165)
            {
                turn = false;
                transform.Rotate(0.0f, 0.0f, 0.0f, Space.Self);
            }*/

            for (int i = 0; i < 360; i++)
            {
                transform.Rotate(0, i, 0, Space.Self);

            }

            turn = false;
            //if (transform.rotation.y < 180)
            //{
            //float newYrotation = GetComponentInChildren<Transform>().rotation.y + speed * Time.deltaTime;
            //transform.Rotate(Vector3.up * Time.deltaTime * 90);
            //RotateSlowly();


            //Vector3 newRotation = new Vector3(GetComponentInChildren<Transform>().rotation.x, newYrotation, GetComponentInChildren<Transform>().rotation.z);
            //GetComponentInChildren<Transform>().Rotate(newRotation);


            //}
            //else
            //{
            //    turn = false;
            //}


        }
    }
    IEnumerator RotateSlowly()
    {
        for(int i = 0; i < 179; i++)
        {
            yield return new WaitForSeconds(1f);
            transform.Rotate(0, 1.0f, 0, Space.Self);
            Debug.Log(i);
            Debug.Log('\n');
            if (i == 179)
            {
                turn = false;
            }
        }
        
        //yield return new WaitForSeconds(0.5f);
        //turn = false;
        
        


    }
}
          ////////             
                      //////// 
           //////      //////  
         //  //  //  //  //  //
           //////      //////  
                               
         ///                ///
            ////////////////    