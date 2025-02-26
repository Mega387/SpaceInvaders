using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI pointsText;
    public static int points = 0;
    void Update()
    {
        pointsText.text = points.ToString();
    }
    private void Start()
    {
        pointsText.text = points.ToString();
    }
}
