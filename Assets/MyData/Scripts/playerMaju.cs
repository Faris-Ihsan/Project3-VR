using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMaju : MonoBehaviour
{
	
    public int kecepatanPlayer;
    public float x, y, z;
    public double xcek, ycek, zcek;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        Maju();
        GetPosisi();
        cek();
    }

    void Maju()
    {
        if(Input.GetButton("Fire1"))
        {
        	transform.position = transform.position + Camera.main.transform.forward * kecepatanPlayer * Time.deltaTime;
        }
    }

    void GetPosisi()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;

        Vector3 point = new Vector3(x,y,z);

        //Debug.Log(point);
    }

    void cek()
    { 
        /*
        xcek =  0.0;
        ycek =  1.4;
        zcek = -8.0;

        if (x >= xcek && y >= ycek && z >= zcek)
        {
            Debug.Log("POSISI TEPAT");
        }
        */
    }
}
