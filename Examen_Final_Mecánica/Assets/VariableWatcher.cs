using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariableWatcher : MonoBehaviour
{
    public Text amplitudeText;
    public Text speedText;
    public Text accelerationText;
    public Text balanceText;
    public Text randomText;
    public Text random;

    private string amplitudeDefault;
    private string speedDefault;
    private string accelerationDefault;
    private string balanceDefault;
    private string randomDefault;

    public Vector3 acceleration;

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
        random.text = currentSphere.random_t;
    }

    // Update is called once per frame
    public void Update()
    {
        speedText.text = speedDefault + currentSphere.GetComponent<Rigidbody>().velocity.magnitude;
        accelerationText.text = accelerationDefault + CalculateAcceleration();
    }

    string CalculateAcceleration()
    {
        if (currentSphere.GetComponent<Rigidbody>().velocity.y == 0)
        {
            acceleration = Vector3.zero;
            return "0";
        }
        else {
            if (currentSphere.GetComponent<Rigidbody>().velocity.y > 0)
            {
                acceleration = Physics.gravity;
                return Physics.gravity.y.ToString();
            }
            else {
                acceleration = -Physics.gravity;
                return (-Physics.gravity.y).ToString();
            }
        }
    }
}
