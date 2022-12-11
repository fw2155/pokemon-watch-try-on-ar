using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BandSwitch : MonoBehaviour
{
    public Material bulbband;
    public Material charband;
    public Material gengarband;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void bulbBandSwitch(){
        string getButton=EventSystem.current.currentSelectedGameObject.name;
        if(getButton=="black button"){
            Color thisColor=new Color();
            ColorUtility.TryParseHtmlString("#212524", out thisColor);
            bulbband.color=thisColor;
        }
        else if(getButton=="green button"){
            Color thisColor=new Color();
            ColorUtility.TryParseHtmlString("#A5E7DF", out thisColor);
            bulbband.color=thisColor;
        }
    }
    public void charBandSwitch(){
        string getButton=EventSystem.current.currentSelectedGameObject.name;
        if(getButton=="black button"){
            Color thisColor=new Color();
            ColorUtility.TryParseHtmlString("#212524", out thisColor);
            charband.color=thisColor;
        }
        else if(getButton=="orange button"){
            Color thisColor=new Color();
            ColorUtility.TryParseHtmlString("#B84E29", out thisColor);
            charband.color=thisColor;
        }
    }
    public void gengarBandSwitch(){
        string getButton=EventSystem.current.currentSelectedGameObject.name;
        if(getButton=="black button"){
            Color thisColor=new Color();
            ColorUtility.TryParseHtmlString("#2E2929", out thisColor);
            gengarband.color=thisColor;
        }
        else if(getButton=="purple button"){
            Color thisColor=new Color();
            ColorUtility.TryParseHtmlString("#A696C3", out thisColor);
            gengarband.color=thisColor;
        }
    }
    
}
