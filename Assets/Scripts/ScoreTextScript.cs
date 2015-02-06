using UnityEngine;

public class ScoreTextScript : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
	{
		this.GetComponent<UnityEngine.UI.Text>().text = "Score: " + GameManager.Score;
	}
}
