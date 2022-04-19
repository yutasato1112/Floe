using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cancel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag=="hand"){
            Debug.Log("cancel");
            SceneManager.LoadScene("New_Experiment_Choice");
        }
    }
}
