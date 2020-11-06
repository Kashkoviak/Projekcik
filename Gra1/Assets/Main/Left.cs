using UnityEngine;
using System.Collections;
using UnityEditor.Experimental.GraphView;

public class Left : MonoBehaviour
{
	Rigidbody2D ammoLeft;
	// Use this for initialization
	void Start()
	{
		ammoLeft = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		ammoLeft.AddForce(-transform.right * 10);
	}
}