using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorPelotas : MonoBehaviour
{
    public GameObject pelota;
    public GameObject instance;
    private float[] noiseValues;
    private int x_trans;
    void Start()
    {
        x_trans = -28;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            x_trans+=4;
            instance=Instantiate(pelota);
            instance.transform.position = new Vector3(x_trans, instance.transform.position.y, instance.transform.position.z);
        }
    }
}
