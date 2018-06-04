using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleigh : MonoBehaviour {

    public Rigidbody2D m_rb;

    void Start ()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown("space"))
        {
            Debug.Log("fire");

            Vector2 v = new Vector2(0, 2.74f);

            Instantiate(GameObject.Find("Present").GetComponent<Rigidbody2D>(), v, UnityEngine.Quaternion.identity);

        }


    }
}
