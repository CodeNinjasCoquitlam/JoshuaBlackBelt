using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnSound : MonoBehaviour
{
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        //sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnTriggerEnter(Collider collision)
    {
        sound.Play();
    }
}
