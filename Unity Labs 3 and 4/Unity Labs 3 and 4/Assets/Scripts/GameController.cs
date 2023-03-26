using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject OneBallPrefab;

    private void Start()
    {
        InvokeRepeating("AddABall", 1.5f, 1);
    }

    private void AddABall()
    {
        Instantiate(OneBallPrefab);
    }
}
