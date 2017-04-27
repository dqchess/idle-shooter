using UnityEngine;
using System.Collections;

public class moveToMiddle : MonoBehaviour {
    [SerializeField]
    private float sped;
    private Rigidbody me;
    private float xsped;
    private float zsped;
    private GameObject[] other;
	// Use this for initialization
	void Start ()
    {
        xsped = 1;
        zsped = 1;
        me = GetComponent<Rigidbody>();
        other = GameObject.FindGameObjectsWithTag(tag);
        for(int i = 0; i < other.Length - 1; i++)
        if(other[i].gameObject.tag == gameObject.tag)
        {
            Physics.IgnoreCollision(other[i].GetComponent<Collider>(), GetComponent<Collider>());
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        me.AddForce(new Vector3(-transform.position.x, 0f, -transform.position.z).normalized * Time.fixedDeltaTime * sped);
        //me.AddForce(new Vector3(-transform.position.x * xsped - transform.position.x * 0.01f, 0f, -transform.position.z * zsped - transform.position.z * 0.01f).normalized * Time.fixedDeltaTime * sped);
        //xsped = 1;
        //zsped = 1;
    }

    /*
    private void OnCollisionStay(Collision collision)
    {
        float difx = transform.position.x - collision.transform.position.x;
        float difz = transform.position.z - collision.transform.position.z;
        if (Mathf.Abs(difx) > Mathf.Abs(difz))
        {
            xsped = 0;
        }
        if (Mathf.Abs(difz) > Mathf.Abs(difx))
        {
            zsped = 0;
        }
    }
    */
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == gameObject.tag)
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
    }
    */
}
