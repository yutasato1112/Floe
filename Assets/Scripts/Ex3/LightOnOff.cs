using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject textc;
    public GameObject flashLight;
    ExCtextchange script;
    void Start()
    {
        textc=GameObject.Find("textc");
        script = textc.GetComponent<ExCtextchange>();
        flashLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(script.orderA==true&&script.orderB==true&&script.orderC==true&&script.orderD==true&&script.orderE==true&&script.orderF==true&&script.orderG==true&&script.orderH==true&&script.orderI==true&&script.orderJ==true&&script.orderK==true){
            //消灯
            flashLight.SetActive(false);
        }else if(script.orderA==true&&script.orderB==true&&script.orderC==true&&script.orderD==true&&script.orderE==true&&script.orderF==true&&script.orderG==true&&script.orderH==true&&script.orderI==true&&script.orderJ==true){
            //消灯
            flashLight.SetActive(false);
        }else if(script.orderA==true&&script.orderB==true&&script.orderC==true&&script.orderD==true&&script.orderE==true&&script.orderF==true&&script.orderG==true&&script.orderH==true&&script.orderI==true){
            //点灯
            flashLight.SetActive(true);
        }else if(script.orderA==true&&script.orderB==true&&script.orderC==true&&script.orderD==true&&script.orderE==true&&script.orderF==true&&script.orderG==true&&script.orderH==true){
            //消灯
            flashLight.SetActive(false);
        }else if(script.orderA==true&&script.orderB==true&&script.orderC==true&&script.orderD==true&&script.orderE==true&&script.orderF==true&&script.orderG==true){
            //点灯
            flashLight.SetActive(true);
        }else if(script.orderA==true&&script.orderB==true&&script.orderC==true&&script.orderD==true&&script.orderE==true&&script.orderF==true){
            //消灯
            flashLight.SetActive(false);
        }else if(script.orderA==true&&script.orderB==true&&script.orderC==true&&script.orderD==true&&script.orderE==true){
            //消灯
            flashLight.SetActive(false);
        }else if(script.orderA==true&&script.orderB==true&&script.orderC==true&&script.orderD==true){
            //消灯s
            flashLight.SetActive(false);
        }else if(script.orderA==true&&script.orderB==true&&script.orderC==true){
            //点灯
            flashLight.SetActive(true);
        }else if(script.orderA==true&&script.orderB==true){
            //消灯
            flashLight.SetActive(false);
        }else if(script.orderA==true){
            //消灯
            flashLight.SetActive(false);
        }
    }
}
