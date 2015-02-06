using UnityEngine;

public class LivesTextScript : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
	{
		this.GetComponent<UnityEngine.UI.Text>().text = "Lives: " + GameManager.Lives;
	}
}
