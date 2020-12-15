using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public Text skor;
    public Text finished;
    int score = 0;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frema
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed,0,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed,0,0);
        }
    }
    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Target")
        {
            Destroy(obj.gameObject);
            score += 20;
            skor.text = "Skor : "+ score.ToString();
            GameObject.Find("Suara Target").GetComponent<AudioSource>().Play();
        }
        if (obj.gameObject.tag == "Bomb")
        {
            Destroy(obj.gameObject);
            score += -5;
            skor.text = "Skor : " + score.ToString();
            GameObject.Find("Suara Bom").GetComponent<AudioSource>().Play();
        }
    }
    
    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.name == "Dinding")
        {
            GameObject.Find("Suara Dinding").GetComponent<AudioSource>().Play();
        }
    }
    
}