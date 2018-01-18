using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBGM : MonoBehaviour {



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //unityタグがあった場合、SE音を鳴らす
        if (collision.gameObject.tag == "unity")
        {

        }
        else
        {
            //SE音を鳴らす
            GetComponent<AudioSource>().Play();
        }



    }


}

