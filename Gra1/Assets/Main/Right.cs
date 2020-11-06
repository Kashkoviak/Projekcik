using UnityEngine;
using System.Collections;
using UnityEditor.Experimental.GraphView;

public class Right : MonoBehaviour
{
	Rigidbody2D ammoRight;
	// Use this for initialization
	void Start()
	{
		ammoRight = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		ammoRight.AddForce(transform.right * 10);
	}
}