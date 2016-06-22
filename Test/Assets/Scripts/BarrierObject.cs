using UnityEngine;
using System.Collections;



public class BarrierObject : MonoBehaviour {

    public delegate bool BarrierTrigger(bool isCollision);
    public BarrierTrigger isCollision;

    void OnTriggerEnter2D(Collider2D other)
    {
        //isCollision = IsCollision;
        isCollision(true);
        other.gameObject.transform.position = other.gameObject.GetComponent<PlayerController>().StartPosition;
    }

    bool IsCollision(bool value)
    {
        return value;
    }
}
