using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedVector : MonoBehaviour
{
    public LineRenderer vecVelocidad;
    Rigidbody rb;
    public Transform refArriba;
    public Transform refAbajo;
    Transform referencia;
    Color blanco;
    public Color velocidad;
    public float velMax;
    // Start is called before the first frame update
    private void Awake()
    {
        velMax = 20.7972f;
    }
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        blanco = Color.yellow;

    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.y < 0)
        {
            referencia = refAbajo;
        }
        else
        {
            referencia = refArriba;
        }
        velocidad = new Color((rb.velocity.magnitude / velMax), 0, 0, 1);
        vecVelocidad.SetColors(blanco, velocidad);
        vecVelocidad.SetPosition(0, transform.position);
        vecVelocidad.SetPosition(1, referencia.position);
    }
}
