using UnityEngine;
using System.Collections;

public class carSpawner : MonoBehaviour {

   
    public GameObject[] cars;
    int carNo;
    public float maxPos = 2.2f;
    public float delayTimer=1f;//time which we want to delay our car generate 
    float timer;


	// Use this for initialization
	void Start () {
        timer = delayTimer;

	}
	
	// Update is called once per frame
	void Update () {

        timer -=Time.deltaTime;//in each frame value will be decremented
        if (timer <= 0)
        {
            Vector3 carPos = new Vector3(Random.Range(-2.2f, 2.2f), transform.position.y, transform.position.z);//cars will be created randomly at x,y, and position

            carNo = Random.Range (0,5);
            Instantiate(cars[carNo], carPos, transform.rotation);//car will start from a posssition that will rotate and transllate from blue point in scene in unity
            //here above carpos instead of  transform.position 
            timer = delayTimer;

        }


	}
}
