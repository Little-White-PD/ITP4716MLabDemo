using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatGuySkill : MonoBehaviour
{
    public float speed = 3f;
    public PlayerController playerController;
    public ConvertToInfector convertToInfector;
    public bool skillCD;
    public GameObject bike;

    public AudioSource source;
    public AudioClip useSkill;
    public AudioClip hit;
    public AudioClip wakeUp;
    public AudioSource music;
    public AudioClip fatmusic;

    public Collider col;

    void Start()
    {
        playerController = GetComponentInParent<PlayerController>();
        convertToInfector = GetComponentInParent<ConvertToInfector>();

        playerController.speed = 3f;
    }

    
    void Update()
    {
        if (skillCD == false && convertToInfector.sleep == false)
        {
            if (Input.GetKeyDown(playerController.skill))
            {
                source.PlayOneShot(useSkill);
                music.PlayOneShot(fatmusic);
                skillCD = true;
                bike.SetActive(true);
                col.enabled = true;
                transform.position += new Vector3(0,0.3f,0);
                playerController.speed = 10f;
                
            }
        }
    }

    public void Hit()
    {
        music.Stop();
        col.enabled = false;
        bike.SetActive(false);
        transform.position -= new Vector3(0, 0.3f, 0);
        convertToInfector.sleep = true;
        StartCoroutine(SkillCD());
        StartCoroutine(Wake());
        convertToInfector.skillTime = 10f;
        playerController.speed = 3f;
    }

    IEnumerator SkillCD()
    {
        yield return new WaitForSeconds(10);
        skillCD = false;
    }

    IEnumerator Wake()
    {
        yield return new WaitForSeconds(5);
        convertToInfector.sleep = false;
        source.PlayOneShot(wakeUp);
    }

    public void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(hit);
        Hit();
    }
}
