using UnityEngine;

public class OneBallBehaviour : MonoBehaviour
{
    public float XSpeed;
    public float YSpeed;
    public float ZSpeed;
    public float Multiplier = 0.75f;
    public float TooFar = 5f;
    public int BallNumber;

    private static int BallCount = 0;

    private void Start()
    {
        
        BallCount++;
        BallNumber = BallCount;
        ResetBall();
    }

    private void Update()
    {
        transform.Translate(Time.deltaTime * XSpeed, Time.deltaTime * YSpeed, Time.deltaTime * ZSpeed);

		XSpeed += Multiplier - Random.value * Multiplier * 2;
		YSpeed += Multiplier - Random.value * Multiplier * 2;
		ZSpeed += Multiplier - Random.value * Multiplier * 2;

		if (Mathf.Abs(transform.position.x) > TooFar || Mathf.Abs(transform.position.y) > TooFar || Mathf.Abs(transform.position.z) > TooFar)
        {
			ResetBall();
		}
    }

    private void ResetBall()
    {
		XSpeed = Random.value * Multiplier;
		YSpeed = Random.value * Multiplier;
		ZSpeed = Random.value * Multiplier;

		transform.position = new Vector3(3 - Random.value * 6, 3 - Random.value * 6, 3 - Random.value * 6);
	}

	private void OnMouseDown()
	{
		GameController controller = Camera.main.GetComponent<GameController>();
        if (!controller.GameOver)
        {
			controller.ClickedOnBall();
			Destroy(gameObject);
		}
	}
}
