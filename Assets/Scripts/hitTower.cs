using UnityEngine;
using System.Collections;

public class hitTower : MonoBehaviour {

    private GameObject tower;
	// Use this for initialization
	void Start ()
    {
        tower = GameObject.FindGameObjectWithTag("player");
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "player")
        {
        }
    }
}
