using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static int Score;
	public static int Lives;

	public GameObject GoldChestPrefab;
	public GameObject SharkPrefab;
	public Canvas GameOverCanvas;

	// Use this for initialization
	void Start()
	{
		GameOverCanvas.enabled = false;
		Time.timeScale = 1.0f;
		Score = 0;
		Lives = 3;
	}

	public void RestartGame()
	{
		Application.LoadLevel(Application.loadedLevel);
	}

	void Update()
	{
		if (Lives <= 0)
		{
			GameOver();
		}
		else
		{
			if (Random.value > (0.995 - Score / 1000.0))
			{
				CreateGoldChest();
			}

			if (Random.value > (0.99 - Score / 1000.0))
			{
				CreateShark();
			}
		}
	}

	private void GameOver()
	{
		GameOverCanvas.enabled = true;
		Time.timeScale = 0.0f; // pause game
	}

	public void CreateGoldChest()
	{
		GameObject goldchest = Instantiate(GoldChestPrefab) as GameObject;
		Transform t = goldchest.GetComponent<Transform>();
		t.position = new Vector2(Random.Range(-5.0f, 5.0f), -5.0f);
	}

	public void CreateShark()
	{
		GameObject shark = Instantiate(SharkPrefab) as GameObject;
		Transform t = shark.GetComponent<Transform>();
		t.position = new Vector2(Random.Range(-5.0f, 5.0f), -5.0f);
	}

	public static float GetSpeed()
	{
		return 1 + (Score * 0.5f); 
	}
}
