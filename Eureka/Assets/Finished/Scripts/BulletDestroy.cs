﻿using UnityEngine;
using System.Collections;

public class BulletDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(gameObject.name == "BS(Clone)")
		{
			Destroy(gameObject, 5);
		}
	}

}

