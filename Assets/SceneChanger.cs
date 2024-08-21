using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public float timmy; //22
    public string next;
    // Start is called before the first frame update
    void Start()
    {
        //22
    }

    // Update is called once per frame
    void Update()
    {
        timmy -= Time.deltaTime;
        if (timmy <= 0)
        {
            SceneManager.LoadScene("Level4");
        }

    }
}
