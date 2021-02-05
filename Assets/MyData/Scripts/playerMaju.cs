using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMaju : MonoBehaviour
{
	
    public int kecepatanPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        Maju();
    }

    /*  Method untuk user maju dengan inputan tombol klik atau tap pada layar
    *   transform.position --> untuk mengambil posisi dari user
    *   Camera.main.transform.forward --> untuk mendapatkan posisi z dari kamera (bagian depan kamera)
    *   kecepatanPlayer --> variabel untuk mengatur kecepatan maju kedepan
    *   Time.deltaTime --> untuk mengambil data waktu dari sistem
    */
    void Maju()
    {
        if(Input.GetButton("Fire1"))
        {
        	transform.position = transform.position + Camera.main.transform.forward * kecepatanPlayer * Time.deltaTime;
        }
    }
}
