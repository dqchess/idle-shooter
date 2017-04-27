using UnityEngine;
using System.Collections;

public class vars : MonoBehaviour
{
    [SerializeField]
    private float live;

	// Use this for initialization
	void Start () {
        live += Time.time;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public float getLive()
    {
        return live;
    }

    public void setLive(float newLive)
    {
        live = newLive;
    }
}
