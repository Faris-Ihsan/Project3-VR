﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;

public class deskripsi : MonoBehaviour
{
    public Text textnamaruangan, textposisi, textdeskripsiruangan;
    public float x, y, z;
    public bool canvas = false;
    public string check, posisiruangan;

    public GameObject[] objects;    


    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        getposisi();

        if (check == posisiruangan)
        {
            ambilDataNamaDeskripsiRuangan();
        }else
        {
            hilangkanCanvas();
        }
    }

    // Method untuk mencari posisi player(camera/user)
    private void getposisi()        
    {
        //variable mencari posisi GameObject yang berupa player 
        var pos = GameObject.Find("Player").transform.position;
        var cetak = x.ToString("F0")+ "," +y.ToString("F0")+ "," +z.ToString("F0");
        check = x.ToString("F0")+y.ToString("F0")+z.ToString("F0");
        
        //memasukan posisi ke dalam variable x,y,z yang berupa float
        x = pos.x;
        y = pos.y;
        z = pos.z;
        Vector3 point = new Vector3(x,y,z);
        
        //print posisi ke text UI (canvas)
        textposisi.text = "Posisi(x,y,z): "+ cetak;


        //Ambil Data Posisi Ruangan dari firebase menggunakan REST API
        //Debug.Log(check);
       
        RestClient.Get("https://vr-proyek3-default-rtdb.firebaseio.com/ga/" + check + "/posisi.json").Then(response => 
        { 
            posisiruangan = response.Text;
        });

         
    }

    //Method yang untuk mengambil data nama dan deskripsi ruangan.
    void ambilDataNamaDeskripsiRuangan()
    {
        //Ambil Data nama ruangan dari firebase menggunakan REST API
         RestClient.Get("https://vr-proyek3-default-rtdb.firebaseio.com/ga/" + check + "/nama_ruangan.json").Then(response => 
        { 
            if (response.Text == "null")
            {
                hilangkanCanvas();
                textnamaruangan.text = "Ruangan: ";
            }else
            {
                munculkanCanvas();
                textnamaruangan.text = "Ruangan: " + response.Text;
            }
        });

        //Ambil data Deskripsi Ruangan dari firebase menggunakan REST API
        RestClient.Get("https://vr-proyek3-default-rtdb.firebaseio.com/ga/" + check + "/deskripsi_ruangan.json").Then(response => 
        { 
            if (response.Text == "null")
            {
                textdeskripsiruangan.text = " ";
            }else
            {
                textdeskripsiruangan.text = response.Text;
            }
        });
    }

    //Method untuk menghilangkan canvas (tempat untuk text informasi ruangan)
    void hilangkanCanvas()
    {
        //looping untuk setiap GameObject yang disimpan pada array objects
        foreach (GameObject go in objects)
        {
            go.SetActive(false);
        }
    }

    //Method untuk memunculkan canvas (tempat untuk text informasi ruangan)
    void munculkanCanvas()
    {
        //looping untuk setiap GameObject yang disimpan pada array objects
        foreach (GameObject go in objects)
        {
            go.SetActive(true);
        }
    }
    
}