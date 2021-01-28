using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerKeluar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pemanggilan method
        keluar();
    }

    //method untuk keluar apikasi 
    void keluar()
    {
        //mengambil inputan user berupa tombol x dan tombol back (pada hp)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
