using RootMotion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManamge : MonoBehaviour
{
    public AudioSource TipAudio;
    public Text text;
    private void Awake()
    {
        Time.timeScale = 1;
    }
    public GameObject[] ddf;
    void Start()
    {
    }

    public Text ttd;
    [HideInInspector]
    public  int a=0;
    [HideInInspector]
    public int a2 = 0;
    public void DF()
    {
        a++;
        ttd.text = a+"/3";
        TipAudio.Play();
        anis.Play("1");
    }
    public Animator anis;
    void Update()
    {
    }
   
}