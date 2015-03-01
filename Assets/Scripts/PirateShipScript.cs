using UnityEngine;
using System.Collections;

public class PirateShipScript : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.GetComponent<Transform>().Translate(
			Input.GetAxis("Horizontal") * Time.deltaTime * (GameManager.GetSpeed() + 3),
			Input.GetAxis("Vertical") * Time.deltaTime * (GameManager.GetSpeed() + 3),
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
