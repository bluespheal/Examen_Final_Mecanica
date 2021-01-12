using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorPelotas : MonoBehaviour
{
    public GameObject pelota;
    public GameObject instance;
    private int x_trans;
    private int pelotas; 

    void Start()
    {
        x_trans = -31;
        pelotas = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && pelotas<5) {
            pelotas++;
            x_trans+=8;
            instance=Instantiate(pelota);
            instance.transform.position = new Vector3(x_trans, instance.transform.position.y, instance.transform.position.z);
        }
    }
}
