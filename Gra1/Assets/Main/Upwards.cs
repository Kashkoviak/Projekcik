﻿using UnityEngine;
using System.Collections;
using UnityEditor.Experimental.GraphView;

public class Upwards : MonoBehaviour
{
	Rigidbody2D ammoUp;
	// Use this for initialization
	void Start()
	{
		ammoUp = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		ammoUp.AddForce(transform.up * 10);
	}
}