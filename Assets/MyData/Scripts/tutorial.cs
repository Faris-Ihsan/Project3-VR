using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial : MonoBehaviour
{

    public Text timer;
    public float timeRemaining = 20;
    public GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }else
        {
            hilangkanCanvasTutorial();
        }

        timer.text = timeRemaining.ToString("F0");
        //Debug.Log(timeRemaining);
    }

    void hilangkanCanvasTutorial()
    {
        foreach (GameObject go in objects)
        {
            go.SetActive(false);
        }
    }

}
