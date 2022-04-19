using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SW : MonoBehaviour
{
    GameObject textc;
    ExCtextchange script;
    // Start is called before the first frame update
    void Start()
    {
        textc=GameObject.Find("textc");
        script = textc.GetComponent<ExCtextchange>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "eleA"){
            Debug.Log(collision.gameObject.tag);
            script.state_ExC_SW=true;
        }
    }
}
