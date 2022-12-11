using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SelectWatch : MonoBehaviour
{
    //create six object and then attach bulb->watch 1, charmander->watch 2, gengar->watch 3
    public GameObject bulb;
    public GameObject charmander;
    public GameObject gengar;
    public GameObject bulbwindow;
    public GameObject charwindow;
    public GameObject gengarwindow;

    Animation bulbWinAnimation;
    Animation charWinAnimation;
    Animation gengarWinAnimation;
    
    void Start()
    {
        bulbWinAnimation=bulbwindow.GetComponent<Animation>();
        charWinAnimation=charwindow.GetComponent<Animation>();
        gengarWinAnimation=gengarwindow.GetComponent<Animation>();
    }
    public void bulbButtonClicked(){
        bulb.SetActive(true);
        charmander.SetActive(false);
        gengar.SetActive(false);
        bulbWinAnimation["w1animation"].speed=1;
        bulbWinAnimation.Play();
    }
    public void charButtonClicked(){
        bulb.SetActive(false);
        charmander.SetActive(true);
        gengar.SetActive(false);
        charWinAnimation["w2animation"].speed=1;
        charWinAnimation.Play();
    }
    public void gengarButtonClicked(){
        bulb.SetActive(false);
        charmander.SetActive(false);
        gengar.SetActive(true);
        gengarWinAnimation["w3animation"].speed=1;
        gengarWinAnimation.Play();
    }
    public void handleClose(){
        //get the current close button name 
        string gotButton=EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(gotButton);
        if(gotButton=="w1close"){
            //reverse the previous animation
            bulbWinAnimation["w1animation"].speed=-1;
            bulbWinAnimation["w1animation"].time=bulbWinAnimation["w1animation"].length;
            bulbWinAnimation.Play();
        }
        else if (gotButton=="w2close"){
            charWinAnimation["w2animation"].speed=-1;
            charWinAnimation["w2animation"].time=charWinAnimation["w2animation"].length;
            charWinAnimation.Play();
        }
        else if (gotButton=="w3close"){
            gengarWinAnimation["w3animation"].speed=-1;
            gengarWinAnimation["w3animation"].time=gengarWinAnimation["w3animation"].length;
            gengarWinAnimation.Play();
        }
    }
    
}
