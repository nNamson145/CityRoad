using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class AnimationController : MonoBehaviour
{
    // public delegate 
    // public Event eventExample;

    const string STR_IS_HOOKING = "isHook";
    const string STR_TRIGGER_PRAY = "triggerPray";
    public Animator animatorController;

    public bool bReloadingState = false;

    bool isPrinted = false;
    IEnumerator alarmCoroutine;
    UnityAction onLoginSuccess;
    Action action;



    // Start is called before the first frame update
    void Start()
    {

        // eventExample -=

        //unregister 
        // DontDestroyOnLoad(this.gameObject);
        // alarmCoroutine = StartCoroutine(Alarm(1));
        // StartCoroutine(nameof(Alarm), 8);
        //  Login();
        //StartCoroutine("Alarm", 1);

        //StopCoroutine("Alarm");
        //StopCoroutine(alarmCoroutine);
        //StopAllCoroutines();

        //while (true)
        //{
        //    Debug.Log("infinite here");
        //}
        //for (int i = 0;i < 3; i++)
        //{

        //    Debug.Log("FOR HERE " + i);
        //}

        // tránh vi?c ph?i edit ch?nh s?a các object trong scene l?p l?i  nhi?u l?n => khó maintain 
        // ch? ??ng qu?n lý tài nguyên : b? nh?
        //t?ng hi?u su?t game 

        //gameplay 1 scene rieng prefab level1 / destroy insta  
        //menu 1 scene rieng


    }

    void Login()
    {
        onLoginSuccess = OnLoginSucess;
        Debug.Log("start login here");
        SendLoginCommandToServer(onLoginSuccess);
        Debug.Log("something here");

        ///


        ////
    }


    public void OnLoginSucess()
    {
        Debug.Log(" login success");
        //memory 
        //prefab
    }


    public async void AsyncExample()
    {
        Debug.Log("start await");

        // await  LoadSceneAsync()
        Debug.Log("end await");
    }

    void Visual()
    {
        //chay thanh bar hien loading 
    }

    public void SendLoginCommandToServer(UnityAction callback)
    {
        callback?.Invoke();
    }

    IEnumerator Alarm(int seconds)
    {

        while (true)
        {
            yield return new WaitForSeconds(seconds);//  yield return ; // wait 1 frame
            Debug.Log("infinite here");
            //do some heavy task  here
        }

        // Debug.Log("ALARM");
        // yield return null; // wait 1 frame
        //  yield return new WaitForSeconds(seconds);
        // Debug.Log("ALARM");

    }
    void Update()
    {

        ///if (!isPrinted)
        //{
        //    Debug.Log("update  here");
        //    isPrinted = true;
        //}
        //Debug.Log("update here");
        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("press K key");
            SetBoolHook(true);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("press L key");
            SetBoolHook(!bReloadingState);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("press T key");
            SetTriggerPray();
        }


    }
    public void SetBoolHook(bool isHook)
    {
        animatorController.SetBool(STR_IS_HOOKING, isHook);
        bReloadingState = isHook;
    }
    public void SetTriggerPray()
    {
        animatorController.SetTrigger(STR_TRIGGER_PRAY);
        //bReloadingState = isReload;
    }

    public void OnAnimationReloadEventRaised()
    {
        Debug.Log("event called");
    }
    // Update is called once per frame

}