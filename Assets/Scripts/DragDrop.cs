using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour,IPointerDownHandler,IBeginDragHandler,IEndDragHandler,IDragHandler{
    
    public static float TimeTaked;
    public static float Score;
    private RectTransform rectTrasnform;

    private CanvasGroup canvasGroup;

    private void Awake()
    {
        Score=0f;
        rectTrasnform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnDrag(PointerEventData eventData){
        Debug.Log("onDragStart");
        rectTrasnform.anchoredPosition+=eventData.delta;
    }

    public void OnBeginDrag(PointerEventData eventData){
        Debug.Log("onBeginDrag");
        canvasGroup.blocksRaycasts=false;
    }

    public void OnEndDrag(PointerEventData eventData){
        Debug.Log("onEndDrag");
        canvasGroup.blocksRaycasts=true;
    }

    public void OnPointerDown(PointerEventData eventData){
        Debug.Log("Pointer Down");
    }

    public void NumberGet(string Number)
    {
        switch(Number)
        {
            case "45":
                TimeTaked = 45f;
                Score+=100f;
                break;

            case "30":
                TimeTaked = 30f;
                Score+=100f;
                break;

            case "20":
                TimeTaked = 20f;
                Score+=50f;
                break;

            case "15":
                TimeTaked = 15f;
                Score+=10f;
                break;

            case "10":
                TimeTaked = 10f;
                Score+=10f;
                break;    
        }  
                                             
    }
}
