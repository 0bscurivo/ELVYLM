using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectible : MonoBehaviour
{
    private int Collectibless = 0;

    public TimeCount time;

    private void Start()
    {
        time = GameObject.FindWithTag("Time").GetComponent<TimeCount>();
    }

    [SerializeField] private Text collectext;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("collect"))
        {
            Destroy(collision.gameObject);
            Collectibless++;
            collectext.text = "Energia:" + Collectibless;

            time.startingTime += 2f;
        }       

    }
}
