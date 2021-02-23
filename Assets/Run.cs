using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Run : MonoBehaviour
{
    public InputField a;
    public TextMesh VM;
    public TextMesh AM;
    public GameObject RS;
    // Start is called before the first frame update
    void Start()
    {
        var se = new InputField.SubmitEvent();
        se.AddListener(Submit);
        a.onEndEdit = se;

    }

    // Update is called once per frame
    void Update()
    {


    }


    private void Submit(string arg0)
    {
        Debug.Log(arg0);
        if (RS.transform.Find("Slider").position.x <= -0.610)
        {
            VM.text = arg0 + "Volts";
            AM.text = 0.7 + "Ampere";
        }
        else if(RS.transform.Find("Slider").position.x > -0.610 && RS.transform.Find("Slider").position.x < -0.500)
        {
            //5%
            float x = float.Parse(arg0);
            float y = (x / 10);
            float z = y / 2;

            VM.text = (x-z).ToString() + "Volts";
            AM.text = 0.6 + "Ampere";
        }
        else if (RS.transform.Find("Slider").position.x > -0.500 && RS.transform.Find("Slider").position.x < -0.400)
        {
            //10%
            float x = float.Parse(arg0);
            float y = x - (x / 10);
            VM.text = y.ToString() + "Volts";
            AM.text = 0.5 + "Ampere";
        }
        else if (RS.transform.Find("Slider").position.x > -0.400 && RS.transform.Find("Slider").position.x < -0.300)
        {
            //25%
            float x = float.Parse(arg0);
            float y = x - (x / 4);
            VM.text = y.ToString() + "Volts";
            AM.text = 0.4 + "Ampere";
        }
        else if (RS.transform.Find("Slider").position.x > -0.300 && RS.transform.Find("Slider").position.x < -0.180)
        {
            //50%
            float x = float.Parse(arg0);
            float y = x - (x / 2);
            VM.text = y.ToString() + "Volts";
            AM.text = 0.3 + "Ampere";
        }
        else if (RS.transform.Find("Slider").position.x > -0.180 && RS.transform.Find("Slider").position.x < 0.001)
        {
            //75%
            float x = float.Parse(arg0);
            float y = x - ((x / 4) + (x / 2));
            VM.text = y.ToString() + "Volts";
            AM.text = 0.25 + "Ampere";
        }
        else if (RS.transform.Find("Slider").position.x > 0.001 && RS.transform.Find("Slider").position.x < 0.1)
        {
            //90%
            float x = float.Parse(arg0);
            float y = (x / 10);
            float z = y / 2;
            y = x - ((x / 4) + (x / 2) + (x / 10) + z);
            VM.text = y.ToString() + "Volts";
            AM.text = 0.15 + "Ampere";
        }
        else if(RS.transform.Find("Slider").position.x >= 0.1)
        {
            VM.text = "0 Volts";

            AM.text = 0 + "Ampere";
        }
    }
}
