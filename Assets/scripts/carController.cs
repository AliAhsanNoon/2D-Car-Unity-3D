using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {



    public float carSpeed;
    public float maxPos = 2.2f;


    Vector3 position;
    public uIManager ui;
    public AudioManager am;

	// Use this for initialization
	void Start () {
        position = transform.position; //current position of carrr and assign current position to vector
        am.carSound.Play();
	
	}
	
	// Update is called once per frame
	void Update () {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime; //since we move in right and left direction so we assigning value to x component& increment
       position.x= Mathf.Clamp(position.x, -2.2f, 2.2f); //mathf.clamp return me value from minimum of -2.2 to 2.2. to catch that value position.
        
        
        transform.position = position;

      }


    void OnCollisionEnter2D(Collision2D col) //for make collision b/w enemy car this function is used
    {
        if (col.gameObject.tag == " Enemy Car")
        {
            Destroy(gameObject); //if our car get collided it will destroyed   
            ui.gameOverActivated();
            am.carSound.Stop();                             
        }
    
    }
}

 