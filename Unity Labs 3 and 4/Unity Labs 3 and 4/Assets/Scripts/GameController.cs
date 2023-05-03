using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public TMP_Text ScoreText;
    public Button PlayAgainButton;
    public GameObject OneBallPrefab;
    public int Score;
    public int NumberOfBalls;
    public int MaximumBalls = 15;
    public bool GameOver;

    private void Start()
    {
        InvokeRepeating("AddABall", 1.5f, 1);
    }

	private void Update()
	{
		ScoreText.text = Score.ToString();
	}

	public void StartGame()
    {
        foreach (GameObject ball in GameObject.FindGameObjectsWithTag("GameController"))
        {
            Destroy(ball);
        }
        PlayAgainButton.gameObject.SetActive(false);
        Score = 0;
        NumberOfBalls = 0;
        GameOver = false;
    }

    private void AddABall()
    {
        if (!GameOver)
        {
			Instantiate(OneBallPrefab);
            NumberOfBalls++;
            if (NumberOfBalls >= MaximumBalls)
            {
                GameOver = true;
                PlayAgainButton.gameObject.SetActive(true);
            }
		}
    }

    public void ClickedOnBall()
    {
        Score++;
        NumberOfBalls--;
    }
}
