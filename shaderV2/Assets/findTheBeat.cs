using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findTheBeat : MonoBehaviour {
    public int specStat1 = 700, specStat2 = 750; // this is the spectrum data position.
    public float spectrumScale, curveEnhancer = 950f;
    AudioSource audio;

    public Material testShader;



    private void Awake()
    {
        audio = this.GetComponent<AudioSource>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float[] spectrum = audio.GetSpectrumData(1024, 1, FFTWindow.BlackmanHarris);
        spectrumScale = 1f + ((spectrum[specStat1] + spectrum[specStat2]) * curveEnhancer);
        //testShader.SetFloat("Base", spectrumScale);
        
    }
}
