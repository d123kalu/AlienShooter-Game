using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int health = 100;
    public GameObject spawncoin;


	public void TakeDamage (int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
	}

	void Die ()
	{
        Destroy(gameObject);
        Instantiate(spawncoin, transform.position, Quaternion.identity);
        Instantiate(spawncoin, transform.position, Quaternion.identity);
        Instantiate(spawncoin, transform.position, Quaternion.identity);

    }

}
