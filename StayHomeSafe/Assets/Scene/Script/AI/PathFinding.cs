using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class PathFinding : MonoBehaviour
{

	NavMeshAgent NM;
<<<<<<< HEAD
	public ConvertToInfector convert;
	public float distance;
	public int randComponent;
	public int randLocation;


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
			convert.HaveBuff = true;
		else
			convert.HaveBuff = false;
		if (randLocation == 0)
			NM.SetDestination(GameObject.FindWithTag("location1").transform.position);
		else if(randLocation == 1)
			NM.SetDestination(GameObject.FindWithTag("location2").transform.position);
		else
			NM.SetDestination(GameObject.FindWithTag("location3").transform.position);
	}

	void Update()
	{		
		
	}

    private void OnTriggerEnter(Collider other)
    {
		if (other.tag == "location1" || other.tag == "location2" || other.tag == "location3")
			Destroy(gameObject);
    }
	
=======
	Transform Player;
	public ConvertToInfector convert;
	

	void Start()
	{
		NM = GetComponent<NavMeshAgent>();
		
	}

	void Update()
	{
		if (convert.citizen.tag == "Infector")
		{
			Player = GameObject.FindWithTag("Citizens").transform;
			NM.SetDestination(Player.position);

		}
		else
		{

			Player = GameObject.FindWithTag("GasMask").transform;
			NM.SetDestination(Player.position);
			Player = GameObject.FindWithTag("Mask").transform;
			NM.SetDestination(Player.position);

			

		}	
			
		Player = GameObject.FindWithTag("Syringe").transform;
			NM.SetDestination(Player.position);
	}
>>>>>>> f8204a62b7f010aa535d4677c4157d25e12f4886
}