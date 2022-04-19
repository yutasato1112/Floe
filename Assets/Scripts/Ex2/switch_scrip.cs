using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_scrip : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject textb;
    ExBtextchange script;
    void Start()
    {
        textb=GameObject.Find("textb");
        script = textb.GetComponent<ExBtextchange>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision collision){
        if(script.stateExB_switch==true){
            if(collision.gameObject.tag == "hand"){
                Debug.Log("衝突");
                Debug.Log(collision.gameObject.tag);
                script.stateExB_E=true;
            }
        }
    }
}
