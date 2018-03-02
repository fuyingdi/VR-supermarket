using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {
   
    //private Animation doorOpen;
    private Animator anim;
	// Use this for initialization
	void Start () {
         anim = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ok");
        anim.SetBool("isPlay",true);
    }

    //void OnTriggerExit(Collider other)
    //{
    //    anim.clip = doorClose;
    //    anim.Play();
    //}


}
