using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {
    public Text Speed;
    public Text Position;
    public RawImage SpeedStick;
    public Transform Player;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = Player.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Speed.text = string.Format("{0}", Mathf.Round(rb.velocity.magnitude));
        SpeedStick.transform.rotation =  Quaternion.Euler(0,0, Mathf.Round(rb.velocity.magnitude));
	}
}
