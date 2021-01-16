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
    Vector3 posInicial;
    public Color velocidad;
    public float velMax;
    public string valVector;
    // Start is called before the first frame update
    private void Awake()
    {
        velMax = 20.7972f;
        posInicial = transform.position;
    }
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        blanco = Color.yellow;
        vecVelocidad = GameObject.Find(valVector).GetComponent<LineRenderer>();

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
        velocidad = new Color((rb.velocity.magnitude / velMax) + 0.1f, (rb.velocity.magnitude / velMax) + 0.1f, 0, 1);
        vecVelocidad.SetColors(velocidad, velocidad);
        vecVelocidad.SetPosition(0, transform.position);
        vecVelocidad.SetPosition(1, referencia.position);
    }
}
