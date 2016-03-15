using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Controller : MonoBehaviour {
    Rigidbody r;
	// Use this for initialization
	void Start () {
        r = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float x=CrossPlatformInputManager.GetAxis("Horizontal");
        float y=CrossPlatformInputManager.GetAxis("Vertical");
        float x1 = CrossPlatformInputManager.GetAxis("Mouse X");
        float y1 = CrossPlatformInputManager.GetAxis("Mouse Y");
        r.velocity = new Vector3(x,y,0);
        Quaternion a = Quaternion.Euler(0,0,Mathf.Atan2(y1,x1)*180/Mathf.PI);
        transform.rotation = Quaternion.Slerp(r.rotation,a,10);
    }
}
