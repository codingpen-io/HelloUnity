using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) {
            GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("key R");
        } 
        if(Input.GetKeyDown(KeyCode.G)) {
            GetComponent<Renderer>().material.color = Color.green;
            Debug.Log("key R");
        } 
        if(Input.GetKeyDown(KeyCode.B)) {
            GetComponent<Renderer>().material.color = Color.blue;
            Debug.Log("key R");
        } 
        else if(Input.anyKey == false) {
            Debug.Log("keyUp");
            GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
