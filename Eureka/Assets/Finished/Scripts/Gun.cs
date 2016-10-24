using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public GameObject Bullet;
	public Transform BulletSpawn;
	public AudioClip GunSound;
	public float NextFire;
	public float FireRate; 

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton(0) & Time.time > NextFire)
			
		{
			Instantiate(Bullet, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
			AudioSource.PlayClipAtPoint(GunSound, transform.position);
			NextFire = Time.time + FireRate;
		}

	}
}
