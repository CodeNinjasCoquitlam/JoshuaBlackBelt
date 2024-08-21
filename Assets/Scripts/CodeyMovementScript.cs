using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodeyMovementScript : MonoBehaviour
{
    public float Speed = 15f;
    Animator anim;
    public bool running = false;
    public bool canMove = true;
    public Vector3 move;
    public float _rotationSpeed = 50f;
    private Rigidbody rb;
    public bool rayDidHit;
    public int Jomp = 1;
    public Vector3 startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
            Vector3 rotation = new Vector3(0, horizontal * _rotationSpeed * Time.deltaTime, 0);
            move = transform.forward * Speed * Time.deltaTime * vertical;
            transform.Rotate(rotation);
            rb.AddForce(move, ForceMode.VelocityChange);
            anim.SetBool("isRunning", move != Vector3.zero);
        }
        if (Input.GetKeyDown("space")&& Jomp > 0)
        {
            rb.AddForce(new Vector3(0, 3, 0) * 3, ForceMode.Impulse);
            Jomp--;
        }
        rayDidHit = Physics.Raycast(transform.position, Vector3.down, 1f);
        Debug.DrawRay(transform.position, Vector3.down, Color.red, 1f);
        if (rayDidHit)
        {
            Jomp = 1;
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.tag == "Respawn Part")
        {
            transform.position = startingPosition;
        }
        if (collision.gameObject.tag == "Checkpoint 1")
        {
            SceneManager.LoadScene("Level2");
        }
        if (collision.gameObject.tag == "Checkpoint 2")
        {
            SceneManager.LoadScene("Level3");
        }
        if (collision.gameObject.tag == "Checkpoint 3")
        {
            SceneManager.LoadScene("CutScene Scene");
        }
        if (collision.gameObject.tag == "Checkpoint 5")
        {
            SceneManager.LoadScene("Level5");
        }
        if (collision.gameObject.tag == "Checkpoint 6")
        {
            SceneManager.LoadScene("Level6");
        }
    }
}