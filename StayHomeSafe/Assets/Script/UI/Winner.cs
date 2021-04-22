using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    public GameObject P1;
    public GameObject p1;
    public GameObject P2;
    public GameObject p2;
    public GameObject P3;
    public GameObject p3;
    public GameObject P4;
    public GameObject p4;
    public GameObject noWinner;
    public Text text;
    private float a;
    private ConvertToInfector convertToInfector;
    void Start()
    {
        playerwin();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = (a).ToString("00");
    }

    void playerwin()
    {
        if(P1.GetComponent<ConvertToInfector>().playerPoint > P2.GetComponent<ConvertToInfector>().playerPoint && P1.GetComponent<ConvertToInfector>().playerPoint > P3.GetComponent<ConvertToInfector>().playerPoint && P1.GetComponent<ConvertToInfector>().playerPoint > P4.GetComponent<ConvertToInfector>().playerPoint)
        {
            p1.SetActive(true);
            a = P1.GetComponent<ConvertToInfector>().playerPoint;
        }else if (P2.GetComponent<ConvertToInfector>().playerPoint > P1.GetComponent<ConvertToInfector>().playerPoint && P2.GetComponent<ConvertToInfector>().playerPoint > P3.GetComponent<ConvertToInfector>().playerPoint && P2.GetComponent<ConvertToInfector>().playerPoint > P4.GetComponent<ConvertToInfector>().playerPoint)
        {
            p2.SetActive(true);
            a = P2.GetComponent<ConvertToInfector>().playerPoint;
        }else if (P3.GetComponent<ConvertToInfector>().playerPoint > P1.GetComponent<ConvertToInfector>().playerPoint && P3.GetComponent<ConvertToInfector>().playerPoint > P2.GetComponent<ConvertToInfector>().playerPoint && P3.GetComponent<ConvertToInfector>().playerPoint > P4.GetComponent<ConvertToInfector>().playerPoint)
        {
            p3.SetActive(true);
            a = P3.GetComponent<ConvertToInfector>().playerPoint;
        }else if (P4.GetComponent<ConvertToInfector>().playerPoint > P1.GetComponent<ConvertToInfector>().playerPoint && P4.GetComponent<ConvertToInfector>().playerPoint > P2.GetComponent<ConvertToInfector>().playerPoint && P4.GetComponent<ConvertToInfector>().playerPoint > P3.GetComponent<ConvertToInfector>().playerPoint)
        {
            p4.SetActive(true);
            a = P4.GetComponent<ConvertToInfector>().playerPoint;
        }else 
        {
            noWinner.SetActive(true);
            a = 0;
        }
    }
}
