using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinContorl : MonoBehaviour {
    public TextMesh Text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Text.text = "Vectory";
        }
    }
}
