using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public static float timeValue=101f;
    public Text TimerText;
    private static float Reduction=0f;
    public static bool deter=true;
    public static float Score;
    public GameManager GameManager;

    private void Awake() {
        timeValue=101f;
    }
    public static void TimeTaken(float GetReduct)
    {
        Reduction=GetReduct;
        Score+=Reduction;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Reduction>timeValue)
        {
            deter=false;
        }else{
            timeValue-=Reduction;
        }
        
        if(timeValue>0)
        {
            timeValue-=Time.deltaTime;//timevalue
            Reduction=0f;
        }else{
            
            timeValue =0f;
        }
        Displaytime(timeValue);
    }

    void Displaytime(float timetoDisplay)
    {
        if(timetoDisplay<0)
        {
            timetoDisplay=0;
        }

        //float minutes = Mathf.FloorToInt(timetoDisplay/60);
        float seconds = Mathf.FloorToInt(timetoDisplay%100);
          //float seconds = timetoDisplay%100;
        //TimerText.text = string.Format("{0:00}:{1:00}",minutes,seconds);
        TimerText.text = seconds.ToString();
    }
}
