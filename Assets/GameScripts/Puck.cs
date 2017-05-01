using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour {
    public Rigidbody2D m_Rigidbody2D;
	// Use this for initialization
	void Awake () {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();

       

    }

    public void ShootThePuck(Vector2 dir)
    {
        
        m_Rigidbody2D.AddForce(new Vector2(dir.x * 25, dir.y * 10), ForceMode2D.Impulse);
    }

    public void ResetPuck()
    {
        m_Rigidbody2D.velocity = Vector3.zero;
        m_Rigidbody2D.angularVelocity = 0;
        m_Rigidbody2D.position = Vector3.zero;
    }
    // Update is called once per frame
    void Update() {

        

    }
}
