using UnityEngine;
using System.Collections;

       

    public class EndLevel : MonoBehaviour {

    [SerializeField]
    GameObject panelEndLevl;

    void OnTriggerEnter2D(Collider2D other)
    {
        panelEndLevl.SetActive(true);
    }

    }
