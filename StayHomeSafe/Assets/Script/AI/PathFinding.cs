using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class PathFinding : MonoBehaviour
{

	NavMeshAgent NM;
	public ConvertToInfector convert;
	public float distance;
	public int randComponent;
	public int randLocation;
	public Collider coll;
	public ParticleSystem area;


	private void Awake()
    {
		randComponent = Random.Range(0, 2);
		randLocation = Random.Range(0, 3);
    }

    void Start()
	{
		
		NM = GetComponent<NavMeshAgent>();
		convert = GetComponentInChildren<ConvertToInfector>();
		if (randComponent == 0)
		{
			convert.HaveBuff = true;
		}

		else
		{
			convert.HaveBuff = false;
		}
		area.Stop();
	}

	void Update()
	{
		if (convert.sleep == false)
		{
			if (convert.HaveBuff == true)
			{

				NM.SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
				StartCoroutine(time());

			}
			else
			{
				if (randLocation == 0)
					NM.SetDestination(GameObject.FindWithTag("location1").transform.position);
				else if (randLocation == 1)
					NM.SetDestination(GameObject.FindWithTag("location2").transform.position);
				else
					NM.SetDestination(GameObject.FindWithTag("location3").transform.position);
			}
		}
		else
			NM.SetDestination(transform.position);
	}

    private void OnTriggerEnter(Collider other)
    {
		if (other.tag == "location1" || other.tag == "location2" || other.tag == "location3")
			Destroy(gameObject);
		if (other.tag == "Player")
			area.Play();
			
    }
    private void OnTriggerExit(Collider other)
    {
		if (other.tag == "Player")
			area.Stop();
    }

    IEnumerator time()
	{
		yield return new WaitForSeconds(7f);
		Destroy(gameObject);
	}
}