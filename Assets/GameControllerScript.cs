using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour {
    public float timeInterval = 5;
    public float timeLeft = 5;
    public Puck puck;
	// Use this for initialization
	void Start () {

       // 
        //puck.GetComponent<Rigidbody2D>().AddForce(transform.forward * Input.GetAxis("Vertical"));
    }


    void GetInput()
    {

    }
	// Update is called once per frame
	void Update () {

        /*
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            
            var x = Random.Range(-1f, 1f);
            var y = Random.Range(-1f, 1f);
            var direction = new Vector3(x, y, 0f);
            puck.ResetPuck();
            puck.ShootThePuck(direction);
            timeLeft = 5;

        }
        
    */
    }
}
