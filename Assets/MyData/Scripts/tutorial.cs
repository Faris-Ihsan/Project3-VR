using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial : MonoBehaviour
{

    public Text timer; //deklarasi variabel timer dengan objek Text
    public float timeRemaining = 20; //deklarasi variabel sisa waktu timer dengan tipe data float
    public GameObject[] objects; //deklarasi variabel objects dengan tipe data array ([])

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Untuk menghitung mundur waktu (timer)
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

    //Method untuk menyembunyikan canvas tutorial (tampilan tutorial)
    void hilangkanCanvasTutorial()
    {
        foreach (GameObject go in objects)
        {
            go.SetActive(false);
        }
    }

}
