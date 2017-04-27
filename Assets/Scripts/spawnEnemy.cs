using UnityEngine;
using System.Collections;

public class spawnEnemy : MonoBehaviour {
    private float angle;
    private float nextX;
    private float nextZ;
    private float elapsedTime;
    private bool spawning;
    [SerializeField]
    private float timeNeeded;
    [SerializeField]
    private float distance;
    [SerializeField]
    public Transform enemy;

	// Use this for initialization
	void Start ()
    {
        elapsedTime = 0;
        spawning = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(Time.deltaTime > 1)
        {
            spawning = false;
        }
        elapsedTime += Time.deltaTime;
        if(spawning)
        {
            spawn();
        }
    }

    private void spawn()
    {
        while(elapsedTime > timeNeeded && timeNeeded > 0)
        {
            angle = Random.Range(0.0f, 360.0f);
            elapsedTime -= timeNeeded;
            nextX = Mathf.Cos(angle);
            nextZ = Mathf.Sin(angle);
            Instantiate(enemy, new Vector3(nextX * distance, 0.5f, nextZ * distance), Quaternion.identity);
        }
    }
}
