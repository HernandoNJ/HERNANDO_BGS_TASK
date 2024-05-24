using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("collision with object: " + collision.name);
		Debug.Log("counter ++");
		Destroy(gameObject, 0.1f);
	}
}