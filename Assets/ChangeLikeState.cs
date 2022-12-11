using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ChangeLikeState : MonoBehaviour
{
    public GameObject likebutton1;
    public GameObject likebutton2;
    public GameObject likebutton3;
    // Start is called before the first frame update
    // private bool button1Like;
    // private bool button2Like;
    bool button1Like=false;
    bool button2Like=false;
    bool button3Like=false;
    
    void Start()
    {
        // button1Like=false;
        // button2Like=false;
        
    }

    public void likeButton1Clicked(){
        string buttonName=EventSystem.current.currentSelectedGameObject.name;
        if(buttonName=="likebutton1"){
            if(button1Like==false){
                button1Like=true;
                // Text ButtonText = buttonName.GetComponentInChildren<Text>();
                // ButtonText="Dislike"
                GameObject.Find("likebutton1").GetComponentInChildren<Text>().text = "Dislike";
            }
            else{
                button1Like=false;
                GameObject.Find("likebutton1").GetComponentInChildren<Text>().text = "Like";
            }
        }
    }
    public void likeButton2Clicked(){
        string buttonName=EventSystem.current.currentSelectedGameObject.name;
        if(buttonName=="likebutton2"){
            if(button2Like==false){
                button2Like=true;
                // Text ButtonText = buttonName.GetComponentInChildren<Text>();
                // ButtonText="Dislike"
                GameObject.Find("likebutton2").GetComponentInChildren<Text>().text = "Dislike";
            }
            else{
                button2Like=false;
                GameObject.Find("likebutton2").GetComponentInChildren<Text>().text = "Like";
            }
        }
    }
    public void likeButton3Clicked(){
        string buttonName=EventSystem.current.currentSelectedGameObject.name;
        if(buttonName=="likebutton3"){
            if(button3Like==false){
                button3Like=true;
                // Text ButtonText = buttonName.GetComponentInChildren<Text>();
                // ButtonText="Dislike"
                GameObject.Find("likebutton3").GetComponentInChildren<Text>().text = "Dislike";
            }
            else{
                button3Like=false;
                GameObject.Find("likebutton3").GetComponentInChildren<Text>().text = "Like";
            }
        }
    }
}
