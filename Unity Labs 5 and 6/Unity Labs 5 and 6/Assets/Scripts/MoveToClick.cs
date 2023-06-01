using UnityEngine;
using UnityEngine.AI;

public class MoveToClick : MonoBehaviour
{
	[SerializeField] private Camera camera;
	private NavMeshAgent agent;

	private void Awake()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	void Update()
    {
        if (Input.GetMouseButtonDown(0))
		{
			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 100))
			{
				agent.SetDestination(hit.point);
			}
		}
    }
}
