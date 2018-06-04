using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Present : MonoBehaviour {

    public Rigidbody2D m_rb;

    void Start ()
    {
        m_rb = GetComponent<Rigidbody2D>();
        //Vector2 v = new Vector2(Random.Range(-300, -150), Random.Range(150, 400));
        Vector2 v = new Vector2(-200, 300);
        m_rb.AddForce(v);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
