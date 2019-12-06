using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingView : MonoBehaviour
{
    Button btn_Begin;

    // Start is called before the first frame update
    void Start()
    {
        if (btn_Begin == null)
        {
            btn_Begin = transform.Find("Btn_Begin").GetComponent<Button>();
        }
        btn_Begin.onClick.AddListener(() => SceneManager.LoadScene("RestaurantScene"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
