using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AMFigure : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject textb;
    ExBtextchange script;
    public GameObject AMText;
    void Start()
    {
        textb=GameObject.Find("textb");
        script = textb.GetComponent<ExBtextchange>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(script.stateExB_E == true){
            Debug.Log("20mA");
            AMText.GetComponent<TextMesh>().text="20mA";
        }
    }
}
