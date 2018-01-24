using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
    static MusicPlayer instance = null;

    void Awake()
    {
     //   Debug.Log("Music player" + GetInstanceID());
        if (instance != null)
        {
            Destroy(gameObject);
            print("Duplicate music player self-desstructing!");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
    //controler dzwiekow niedublujacych sie na innych scenach
    // jezeli w innym miejscu mamy gameObject zostanie usuniety

	// Use this for initialization
	void  Start () {
      //  Debug.Log("Music player" + GetInstanceID());

        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
