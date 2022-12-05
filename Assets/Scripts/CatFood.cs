using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFood : MonoBehaviour
{
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        Destroy(gameObject, 3); // 3���A�R���ۤv
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject); // �I�즳�I���骺�F��N�R���ۤv
        if (collision.tag == "CatFood")
        {
            gameManager.GetComponent<GameManager>().IncreaseScore();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
