using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamSwitch : MonoBehaviour
{
    public GameObject[] screens;
    public int screenNo = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < screens.Length; i++)
        {
            screens[i].SetActive(false);
        }
        screens[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (screenNo > 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                for (int i = 0; i < screens.Length; i++)
                {
                    screens[i].SetActive(false);
                }
                screenNo -= 1;
                screens[screenNo].SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            for (int i = 0; i < screens.Length; i++)
            {
                screens[i].SetActive(false);
            }
            screenNo += 1;
            screens[screenNo].SetActive(true);
        }

        if (screenNo == 5)
        {
            SceneManager.LoadScene("End");
        }
    }
}
