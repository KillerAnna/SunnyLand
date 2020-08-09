using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float count = 0f;
    bool get_in;
    GameObject count_star;
    GameObject notice;
    // Start is called before the first frame update
    void Start()
    {
        count_star = GameObject.Find("count_star");
        notice = GameObject.Find("Notice");
    }

    public void Count()
    {
        count++;
        count_star.GetComponent<Text>().text = "먹은 별 : " + count + "개";
        if(count == 4)
        {
            Debug.Log("앙기모찌");
            get_in = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (get_in == true)
        {
            SceneManager.LoadScene("ClearScene");
        }
        else
        {
            notice.GetComponent<Text>().text = "알림 : 별을 다 먹으세요!!!";
        }
    }
}
