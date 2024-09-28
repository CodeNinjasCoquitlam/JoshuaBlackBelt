using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float Sauce;
    // Start is called before the first frame update
    void Start()
    {
        Sauce = Random.Range(3, 5);
        StartCoroutine (Soos());
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.deltaTime > Sauce)
            {
            SceneManager.LoadScene("Level1");
            }
    }
    IEnumerator Soos()
    {
        yield return new WaitForSeconds(Sauce);
        SceneManager.LoadScene("Level1");
    }
}
