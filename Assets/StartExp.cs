using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartExp : MonoBehaviour
{
    public int a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var input = gameObject.transform.parent.parent.parent.Find("Battery").Find("Canvas").Find("InputField");
        var se = new InputField.SubmitEvent();
        se.AddListener(SubmitName);
        //input.onEndEdit = se;

        
    }

    private void SubmitName(string arg0)
    {
        Debug.Log(arg0);
    }
}
