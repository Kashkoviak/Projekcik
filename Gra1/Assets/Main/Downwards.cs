using UnityEngine;
using System.Collections;
using UnityEditor.Experimental.GraphView;

public class Downwards : MonoBehaviour
{
	Rigidbody2D ammoDown;
	// Use this for initialization
	void Start()
	{
		ammoDown = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		ammoDown.AddForce(-transform.up * 10);
	}
}