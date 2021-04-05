using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class PathFinding : MonoBehaviour
{

	NavMeshAgent NM;
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
}