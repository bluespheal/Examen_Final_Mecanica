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
    public float max_vel;
    public Material shader_inicial;
    public Material shader_iluminado;

    // Start is called before the first frame update

    void Start()
    {
        shader_inicial = gameObject.GetComponent<Renderer>().material;
        max_vel = 0;
        random = Random.Range(0, 2);
        rigi = gameObject.GetComponent<Rigidbody>();
        if ( random == 1)
        {
            random_variable = Random.Range(3f, 20f);
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
        if (transform.position.y >= altura_init/2 - 1 && transform.position.y <= altura_init/2 + 1)
        {
            gameObject.GetComponent<Renderer>().material = shader_iluminado;
        }
        else {
            gameObject.GetComponent<Renderer>().material = shader_inicial;
        }

        if (transform.position.y >= altura_init) {
            rigi.velocity = Vector3.zero;
        }
        if (rigi.velocity.magnitude > max_vel) {
            max_vel = rigi.velocity.magnitude;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        rebotes++;
    }
}
