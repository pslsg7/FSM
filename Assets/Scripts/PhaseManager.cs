using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseManager : MonoBehaviour
{
    private bool _Phase1 = false;
    private bool _Phase2 = false;
    public GameObject Slime;
    public GameObject Slime2;
    public GameObject Matpi;
    public GameObject Matpi2;
    public GameObject Goblin;

    // Use this for initialization
    void Awake()
    {
        _Phase1 = true;
        _Phase2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (_Phase1)
        {
            if (Slime.activeSelf == false && Slime2.activeSelf == false)
            {
                _Phase1 = false;
                _Phase2 = true;
            }
        }
        if (_Phase2)
        {
            Matpi.SetActive(true);
            Matpi2.SetActive(true);
            Goblin.SetActive(true);
            _Phase2 = false;
        }
    }
           
}
