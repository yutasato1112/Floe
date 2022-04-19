using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipette : MonoBehaviour
{
    GameObject textd;
    ExDtextchange script;
    // Start is called before the first frame update
    void Start()
    {
        textd=GameObject.Find("textd");
        script = textd.GetComponent<ExDtextchange>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "awb"){
            Debug.Log(collision.gameObject.tag);
            script.state_awb_touch_P=true;
        }
        if(collision.gameObject.tag == "pwd"){
            Debug.Log(collision.gameObject.tag);
            script.state_pwd_touch_P=true;
        }
        if(collision.gameObject.tag == "hab"){
            Debug.Log(collision.gameObject.tag);
            script.state_hab_touch_P=true;
        }
        if(collision.gameObject.tag == "aab"){
            Debug.Log(collision.gameObject.tag);
            script.state_aab_touch_P=true;
        }
        if(collision.gameObject.tag == "shb"){
            Debug.Log(collision.gameObject.tag);
            script.state_shb_touch_P=true;
        }
        if(collision.gameObject.tag == "btb"){
            Debug.Log(collision.gameObject.tag);
            script.state_BTB_touch_P=true;
        }
    }
}
