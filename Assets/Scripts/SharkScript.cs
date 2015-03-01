using UnityEngine;

public class SharkScript : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
	{
		Transform t = this.GetComponent<Transform>();
		t.Translate(new Vector2(0, (GameManager.GetSpeed() + 2) * Time.deltaTime));
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "TopCollider")
		{
			Destroy(this.gameObject);
		}
	}
}
