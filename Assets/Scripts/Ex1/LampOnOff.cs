using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampOnOff : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject texta;
    public GameObject lightpoint;
    textchange script;
    void Start()
    {
        texta = GameObject.Find ("texta");
        script = texta.GetComponent<textchange>();
        lightpoint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(script.stateCC==true){
            lightpoint.SetActive(true);
        }
    }
}
