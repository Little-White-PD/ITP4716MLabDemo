using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeHit : MonoBehaviour
{
    public FatGuySkill fGS;
    public Collider col;
    

    void Start()
    {
        col = GetComponent<Collider>();
        fGS.source = GetComponent<AudioSource>();
        fGS.source.PlayOneShot(fGS.useSkill);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        fGS.source.PlayOneShot(fGS.hit);
        fGS.Hit();
    }
}
