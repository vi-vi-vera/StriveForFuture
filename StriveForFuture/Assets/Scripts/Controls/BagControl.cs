using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagControl : MonoBehaviour
{
    BagView view;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<BagView>();

        view.Btn_Close.onClick.AddListener(() => gameObject.SetActive(false));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
