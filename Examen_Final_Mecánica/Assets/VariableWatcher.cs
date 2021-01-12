using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariableWatcher : MonoBehaviour
{
    private Text amplitudeText;
    private Text speedText;
    private Text accelerationText;
    private Text balanceText;
    private Text randomText;

    private string amplitudeDefault;
    private string speedDefault;
    private string accelerationDefault;
    private string balanceDefault;
    private string randomDefault;

    public Vector3 acceleration;
    public Vector3 distancemoved = Vector3.zero;
    public Vector3 lastdistancemoved = Vector3.zero;
    public Vector3 last;

    private pelotas_rebote currentSphere;

    // Start is called before the first frame update
    void Start()
    {
        amplitudeText = GameObject.Find("amplitude").GetComponent<Text>();
        speedText = GameObject.Find("speed").GetComponent<Text>();
        accelerationText = GameObject.Find("acceleration").GetComponent<Text>();
        balanceText = GameObject.Find("balance_point").GetComponent<Text>();
        randomText = GameObject.Find("random_var").GetComponent<Text>();

        amplitudeDefault = amplitudeText.text;
        speedDefault = speedText.text;
        accelerationDefault = accelerationText.text;
        balanceDefault = balanceText.text;
        randomDefault= randomText.text;
    }

    public void UpdateText(pelotas_rebote _currentSphere)
    {
        currentSphere = _currentSphere;
        amplitudeText.text = amplitudeDefault + currentSphere.amplitud;
        balanceText.text = balanceDefault + currentSphere.altura_init/2;
        randomText.text = randomDefault + currentSphere.random_variable;
    }

    // Update is called once per frame
    public void Update()
    {
        speedText.text = speedDefault + currentSphere.GetComponent<Rigidbody>().velocity.magnitude;
        accelerationText.text = accelerationDefault + CalculateAcceleration();
    }

    string CalculateAcceleration()
    {
        distancemoved = (transform.position - last) * Time.deltaTime;
        acceleration = distancemoved - lastdistancemoved;
        lastdistancemoved = distancemoved;
        last = transform.position;

        return acceleration.magnitude.ToString();
    }
}
