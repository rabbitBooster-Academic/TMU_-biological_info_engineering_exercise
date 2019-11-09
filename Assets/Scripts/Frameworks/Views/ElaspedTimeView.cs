using UnityEngine;
using UnityEngine.UI;

public class ElaspedTimeView : MonoBehaviour, IElaspeTimeView
{
    Text text;
    public void SetText(ElaspeTimeViewModel viewmodel)
    {
        if (text == null)
        {
            text = GetComponent<Text>();
        }
        text.text = viewmodel.text;
    }
}
