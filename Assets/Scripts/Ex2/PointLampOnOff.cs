using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLampOnOff : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject textb;
    ExBtextchange script;
    public GameObject Ex3lamp;
    void Start()
    {
        textb=GameObject.Find("textb");
        script = textb.GetComponent<ExBtextchange>(); 
        Ex3lamp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(script.state_lamp==true){
            Ex3lamp.SetActive(true);
        }
    }
}
