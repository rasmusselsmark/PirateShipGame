using UnityEngine;
using System.Collections;

public class PirateShipScript : MonoBehaviour
{
	public float Speed = 4.0f;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.GetComponent<Transform>().Translate(
			Input.GetAxis("Horizontal") * Time.deltaTime * Speed,
			Input.GetAxis("Vertical") * Time.deltaTime * Speed,
			0.0f);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name.Contains("GoldChest"))
		{
			GameManager.Score = GameManager.Score + 1;
			Destroy(other.gameObject);
		}
		if (other.name.Contains("Shark"))
		{
			GameManager.Lives = GameManager.Lives - 1;
			Destroy(other.gameObject);
		}
	}
}
