using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour {

    public Rigidbody2D m_rb;
    public float m_fSpeed = 0f;
    void Start ()
    {
        m_rb = GetComponent<Rigidbody2D>();

        GameObject.Find("Green1").GetComponent<Renderer>().enabled = false;
        GameObject.Find("Green2").GetComponent<Renderer>().enabled = false;
        GameObject.Find("Green3").GetComponent<Renderer>().enabled = false;
        GameObject.Find("Green4").GetComponent<Renderer>().enabled = false;
        GameObject.Find("Green5").GetComponent<Renderer>().enabled = false;
    }

    void Update ()
    {
        m_fSpeed += .005f;
        transform.Translate(Time.deltaTime * -1 * m_fSpeed, 0, 0, Space.World);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Contains("Present"))
        {
            GameObject go = GameObject.Find("santa-sleigh");
            Sleigh s = go.GetComponent<Sleigh>();
            s.m_nScore++;
            Vector2 vPresent = col.gameObject.transform.position;
            //Instantiate(GameObject.Find("PS").GetComponent<Rigidbody2D>(), vPresent, UnityEngine.Quaternion.identity);

            Destroy(col.gameObject);
        }
    }
}
