using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_magnet : MonoBehaviour
{
    GameObject texta;
    textchange script;
    // Start is called before the first frame update
    void Start()
    {
        texta = GameObject.Find ("texta");
        script = texta.GetComponent<textchange>();   
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(script.stateA);
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "metal"){
            Debug.Log("当たった!");
            Debug.Log(collision.gameObject.tag);
            script.stateB = true;

        }
    }
}
