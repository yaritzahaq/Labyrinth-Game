using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public GameObject Player;
    public float Jarak;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = new Vector3(Player.transform.localPosition.x + (Player.transform.localScale.x * Jarak), Player.transform.localPosition.y + (Player.transform.localScale.y * Jarak), Player.transform.localPosition.z + (Player.transform.localScale.z * Jarak));
        transform.localPosition = Vector3.Slerp(transform.localPosition, pos, 0.15f);
    }
}
