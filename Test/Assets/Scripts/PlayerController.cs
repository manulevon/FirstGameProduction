using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Vector3 startPosition;
       
   public Vector3 StartPosition{
        get { return startPosition;}
    }
	
	void Start () {
        startPosition = this.transform.position; 
	}
	
	// Update is called once per frame
	void Update () {


    
    }

    void OnMouseDrag()
    {
#if UNITY_EDITOR

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.gameObject.transform.position = new Vector3(mousePos.x, mousePos.y, 0);

#endif
    }
}

