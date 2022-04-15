using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarProductivity : MonoBehaviour
{
    private Image Bar;
    public Text ScoreText;
    public float Playerscore; 
    private float MaxPoints=270f;

    private void Start() {
        Bar = GetComponent<Image>();
    }

    private void Update() {
        Playerscore=DragDrop.Score;
        Bar.fillAmount = Playerscore/MaxPoints;
        ScoreText.text = string.Format("{0:P2}",Playerscore/MaxPoints);
    }
}
