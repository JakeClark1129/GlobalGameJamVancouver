using UnityEngine;
using System.Collections;

public class DeathController : MonoBehaviour 
{


	public ParticleSystem particle;
	public Transform charTrans;
	public Transform rayTrans;
	private NavMeshAgent agent;

	private float spawnRadius;
	private float attackRadius;

	private bool teleported = false;
	// Use this for initialization
	void Start ()
	{
		agent = GetComponent<NavMeshAgent> ();
		spawnRadius = particle.shape.radius;
		attackRadius = particle.shape.radius -  20 ;
	}
		
	// Update is called once per frame
	void Update () 
	{
		spawnRadius = particle.shape.radius;
		attackRadius = particle.shape.radius -  20 ;

		if (charTrans.position.magnitude > attackRadius)
		{
			Vector3 newPos = charTrans.position;
			newPos.Normalize ();
			newPos *= spawnRadius;
			newPos.y = 200;
			NavMeshHit hit;
			agent.Raycast (newPos, out hit);
			agent.Warp (hit.position);

			if(agent.isOnNavMesh)
			{
				agent.Raycast (charTrans.position, out hit);
				agent.SetDestination (hit.position);
			}
			teleported = false;
		}
		else if (!teleported) 
		{
			FXManager.Instance.Spawn ("DeathDeath", transform.position, transform.rotation);
			NavMeshHit hit;
			agent.Raycast ((new Vector3 (1, 0, 1) * spawnRadius)  + new Vector3(0,200,0), out hit);
			agent.Warp (hit.position);
			teleported = true;
		}
		else if (charTrans.position.magnitude < attackRadius) 
		{
			Vector3 temp = charTrans.position; 
			agent.SetDestination (temp.normalized * spawnRadius);
		}
	}


	void OnCollisionEnter(Collision collision) 
	{
		if(collision.gameObject == charTrans.gameObject)
		{
			//Game Over
		}
	}
}
