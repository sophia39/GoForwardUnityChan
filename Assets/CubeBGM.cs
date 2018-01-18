using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBGM : MonoBehaviour {

    public AudioClip se;
    public int SEon;
    private int speed = 40;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(this.SEon >= 0)
        {
            GetComponent<AudioSource>().PlayOneShot(se);
            this.SEon -= this.speed;
        }
       
    }
   
    

    void OnCollisionEnter(Collision2D collision)
    {
        this.SEon = 180;

    }


}
