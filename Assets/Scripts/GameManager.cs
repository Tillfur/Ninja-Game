using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 別忘了要追加 UI 必要程式

public class GameManager : MonoBehaviour
{
    public GameObject arrowPrefab; //置放Prefab的公開變數
    public GameObject catfoodPrefab;
    float span = 1.0f;             //時間間隔
    float delta = 0;               //現在已經累積的時間
    public GameObject hpGauge;     //置放血環的公開變數
    public Text ScoreText;
    int Score = 0;                 // 分數

    void Start()
    {
        ScoreText.text = $"分數：{Score}";
        //ScoreText.text = "分數：" + Score.ToString();
        InvokeRepeating("GenerateArrow", 0, 1);
        InvokeRepeating("GenerateCatFood", 5, 5);
    }

    void Update()
    {

    }
    void GenerateArrow()
    {
        float px = Random.Range(-6.0f, 7.0f);
        Instantiate(arrowPrefab, new Vector3(px, 7, 0), Quaternion.identity);
    }
    void GenerateCatFood()
    {
        float px = Random.Range(-6.0f, 7.0f);
        Instantiate(catfoodPrefab, new Vector3(px, 7, 0), Quaternion.identity);
    }
    // 公開（Public）的方法（DecreaseHp），每執行一次，Fill Amount的數值就減少0.1
    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
    public void IncreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount += 0.2f;
    }
    public void IncreaseScore()
    {
        Score += 10;
        ScoreText.text = $"分數：{Score}";
    }
}
