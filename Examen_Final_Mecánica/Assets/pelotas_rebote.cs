using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelotas_rebote : MonoBehaviour
{
    public float amplitud;
    public Rigidbody rigi;
    public float altura_init;
    public int rebotes;
    private int random;
    public float random_variable;

    // Start is called before the first frame update

    private void Awake()
    {

    }

    void Start()
    {
        random = Random.Range(0, 2);
        random = 1;
        rigi = gameObject.GetComponent<Rigidbody>();
        if ( random == 1)
        {
            random_variable = Random.Range(0f, 20f);
            print("amplitud");
            transform.position = new Vector3(transform.position.x, random_variable , transform.position.z);
        }
        else {
            random_variable = Random.Range(1f, 100f);
            print("masa");
            rigi.mass = random_variable;
        }
        amplitud = transform.position.y;
        altura_init = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= altura_init) {
            rigi.velocity = Vector3.zero;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        rebotes++;
    }
}
