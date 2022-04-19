using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class circuit : MonoBehaviour
{
    GameObject texta;
    textchange script;
    public bool state_circuitA;
    public bool state_circuitB;
    public bool state_circuitC;
    public bool state_circuitD;
    // Start is called before the first frame update
    void Start()
    {
        texta = GameObject.Find ("texta");
        script = texta.GetComponent<textchange>();
        state_circuitA=false;
        state_circuitB=false;
        state_circuitC=false;
        state_circuitD=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(state_circuitA==true&& state_circuitC==true){
            script.stateC=true;
        }
    }
}
