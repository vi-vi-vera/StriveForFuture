using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : MonoBehaviour
{
    MainView view;
    public RoleInfoView roleInfoView;
    public BagView bagView;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<MainView>();

        view.Btn_RoleInfoView.onClick.AddListener(() => roleInfoView.gameObject.SetActive(true));
        view.Btn_BagView.onClick.AddListener(() => bagView.gameObject.SetActive(true));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
