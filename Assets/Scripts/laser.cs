using UnityEngine;
using System.Collections;

public class laser : MonoBehaviour
{
    LineRenderer line;
	void Start()
    {
        line = gameObject.GetComponent<LineRenderer>();
        line.enabled = true;
	}

	void Update()
    {
	    
	}

    GameObject GetClosestByTag(string tag)
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(tag);
        GameObject closest = null;
        float minDist = Mathf.Infinity;
        foreach (GameObject t in enemies)
        {
            float dist = Vector3.Distance(t.transform.position, transform.position);
            if (dist < minDist)
            {
                closest = t;
                minDist = dist;
            }
        }
        return closest;
    }

}
