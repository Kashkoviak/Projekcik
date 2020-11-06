﻿using UnityEngine;
using System.Collections;
using System.Collections.Specialized;

public class Upwards : MonoBehaviour
{
	Rigidbody2D ammoUp;
	Vector3 shotDirection = new Vector3(0,0,0);
	void Start()
	{
		ammoUp = GetComponent<Rigidbody2D>();
	}
	public void Shot(Vector3 direction)
    {
		shotDirection = direction;
		ammoUp.AddForce(shotDirection * 300 * Time.deltaTime);
	}
}