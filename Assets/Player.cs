using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Rigidbody2D m_Rigidbody2D;
    // Use this for initialization
    void Awake()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();



    }


	
	// Update is called once per frame
	void Update () {
        m_Rigidbody2D.AddForce(new Vector2(Input.GetAxis("Horizontal") * 5, Input.GetAxis("Vertical") * 5), ForceMode2D.Impulse);
    }
}
