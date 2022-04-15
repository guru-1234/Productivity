using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CatchDrop : MonoBehaviour,IDropHandler{

    [SerializeField] GameObject AlertText;
    public static DragDrop Drag;
    public static Timer Timer;
    private float Take;
    private bool AlertBool=false;

    private void Start() {
        AlertText.SetActive(false);
    }
    private void Update() 
    {
        if(AlertBool)
        {
            AlertText.SetActive(false);
            AlertBool=false;
        }
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        Take= DragDrop.TimeTaked;
        Debug.Log(DragDrop.TimeTaked);
        Equals();
        if(eventData.pointerDrag!=null&&Timer.timeValue<Take)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition=GetComponent<RectTransform>().anchoredPosition;
            StartCoroutine(Alert());
            Debug.Log("Working Working");
        }
    }
    public void Equals()
    {
        Timer.TimeTaken(Take);
    }

    IEnumerator Alert()
    {
        AlertText.SetActive(true);
        yield return new WaitForSeconds(2);
        AlertBool=true;
    }
}
