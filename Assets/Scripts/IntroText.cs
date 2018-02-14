﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroText : MonoBehaviour {

    public TextMesh introtext;
    public Transform tf;
    public MeshRenderer text;
	
    // Use this for initialization
	void Start () {
        StartCoroutine(SwitchScene());
    }
	
	// Update is called once per frame
	void Update () {
        tf.Translate(0,  0.5f * Time.deltaTime, 0);
	}

    IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(83);
        SceneManager.LoadScene(1);
    }
}
