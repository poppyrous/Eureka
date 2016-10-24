using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int Health = 100;
	public AudioClip GunSound;
	public GameObject DestroyPrefab;


	// Use this for initialization
	void ApplyDamage (int Damage) 

	{

		Health -= Damage;

		if (Health <= 0)

		{

			Dead();
		}

	}
	
	// Update is called once per frame
	void Dead () 

	{
		Destroy(this.gameObject);
		Instantiate (DestroyPrefab, transform.position, transform.rotation);
		AudioSource.PlayClipAtPoint(GunSound, transform.position);
	}
}
