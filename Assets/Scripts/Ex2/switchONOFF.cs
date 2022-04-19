using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchONOFF : MonoBehaviour
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
        if(collision.gameObject.tag == "wireAR" ||collision.gameObject.tag == "wireAL"||collision.gameObject.tag == "wireBR"||collision.gameObject.tag == "wireBL"||collision.gameObject.tag == "wireC"){
            Debug.Log("衝突");
            Debug.Log(collision.gameObject.tag);
            script.stateExB_C=true;
        }
    }
}
