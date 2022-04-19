using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampA : MonoBehaviour
{
    GameObject lamp;
    circuit script;
    // Start is called before the first frame update
    void Start()
    {
        lamp=GameObject.Find("lamp");
        script=lamp.GetComponent<circuit>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "wireAR" || collision.gameObject.tag == "wireAL" || collision.gameObject.tag == "wireBR" || collision.gameObject.tag == "wireBL"){
            Debug.Log("conect");
            Debug.Log(collision.gameObject.tag);
            script.state_circuitA=true;
        }
    }
}
