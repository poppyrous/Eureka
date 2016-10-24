using UnityEngine;
using System.Collections;

public class CorpseDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

			if(gameObject.name == "ED(Clone)")
			{
				Destroy(gameObject, 5);
			}
		}
	
	}

