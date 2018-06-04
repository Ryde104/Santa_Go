using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleigh : MonoBehaviour {

    public Rigidbody2D m_rb;
    public int m_nScore = 0;
    void Start ()
    {
        m_rb = GetComponent<Rigidbody2D>();

        for (int nIndex = 0; nIndex < 50; nIndex++)
        {
            float fr = (float)Random.Range(5, 10);
            float f = (float)nIndex * fr;
            Vector2 v = new Vector2(f, -2.22f);
            Instantiate(GameObject.Find("House").GetComponent<Rigidbody2D>(), v, UnityEngine.Quaternion.identity);
        }
    }    

    void Update ()
    {
        switch (m_nScore)
        {
            case 1:
                {
                    GameObject.Find("Green1").GetComponent<Renderer>().enabled = true;
                    GameObject.Find("Green2").GetComponent<Renderer>().enabled = false;
                    GameObject.Find("Green3").GetComponent<Renderer>().enabled = false;
                    GameObject.Find("Green4").GetComponent<Renderer>().enabled = false;
                    GameObject.Find("Green5").GetComponent<Renderer>().enabled = false;
                    break;
                }
            case 2:
                {
                    GameObject.Find("Green1").GetComponent<Renderer>().enabled = true;
                    GameObject.Find("Green2").GetComponent<Renderer>().enabled = true;
                    GameObject.Find("Green3").GetComponent<Renderer>().enabled = false;
                    GameObject.Find("Green4").GetComponent<Renderer>().enabled = false;
                    GameObject.Find("Green5").GetComponent<Renderer>().enabled = false;
                    break;
                }
            case 3:
                {
                    GameObject.Find("Green1").GetComponent<Renderer>().enabled = true;
                    GameObject.Find("Green2").GetComponent<Renderer>().enabled = true;
                    GameObject.Find("Green3").GetComponent<Renderer>().enabled = true;
                    GameObject.Find("Green4").GetComponent<Renderer>().enabled = false;
                    GameObject.Find("Green5").GetComponent<Renderer>().enabled = false;
                    break;
                }
            case 4:
                {
                    GameObject.Find("Green1").GetComponent<Renderer>().enabled = true;
                    GameObject.Find("Green2").GetComponent<Renderer>().enabled = true;
                    GameObject.Find("Green3").GetComponent<Renderer>().enabled = true;
                    GameObject.Find("Green4").GetComponent<Renderer>().enabled = true;
                    GameObject.Find("Green5").GetComponent<Renderer>().enabled = false;
                    break;
                }
            case 5:
                {
                    GameObject.Find("Green1").GetComponent<Renderer>().enabled = true;
                    GameObject.Find("Green2").GetComponent<Renderer>().enabled = true;
                    GameObject.Find("Green3").GetComponent<Renderer>().enabled = true;
                    GameObject.Find("Green4").GetComponent<Renderer>().enabled = true;
                    GameObject.Find("Green5").GetComponent<Renderer>().enabled = true;
                    break;
                }

        }
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("fire");

            Vector2 v = new Vector2(0, 2.74f);
            Instantiate(GameObject.Find("Present").GetComponent<Rigidbody2D>(), v, UnityEngine.Quaternion.identity);            
        }
    }
}
