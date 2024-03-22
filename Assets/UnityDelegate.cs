using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// 유니티에서 사용할 수 있는 대리자 유형
// 1. Action : 유니티에서 반환 값이 따로 없는 void 형태의 대리자
// 2. Func : 유니티에서 반환 값이 있는 형태의 대리자
// 3. UnityEvent : 인스펙터 내에서 이벤트를 노출시켜 할당할 수 있게 해주는 도구
// 4. event : 
// 5. delegate : 

public class UnityDelegate : MonoBehaviour
{
    public UnityEvent onDead;   // 3

    public void Awake()
    {
        onDead.AddListener(Dead);   // 스크립트를 통해 onDead에 이벤트 함수 등록
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            onDead?.Invoke();
        }
    }

    void Dead()
    {
        Debug.Log("깨꼬닥");
    }

    /****************************************************************/

    Action testAction01;    // 1
    void Method01() { }
    void Method02() { }
    void Method03() { }
    int Method04() { return 1; }

    Action<int> testAction02;   //  Action의 <> 안에 넣는 값은 delegate로 호출할 함수의 매개변수입니다.
    void Method05(int a) { }
    void Method06(int b) { }
    void Method07(int c) { }

    /****************************************************************/

    Func<bool> testFunc01;  // 2
    bool Method08() {  return true; }
    bool Method09() {  return false; }

    Func<int, int, int> testFunc02; // 맨 마지막에 적어놓은 타입 int는 return 타입,
    // 그 앞의 값은 전부 매개변수 처리합니다.
    int Method10(int a, int b) { return a + b; }
    int Method11(int a, int b) { return a - b; }

    
    void Start()
    {
        testAction01 += Method01;
        testAction01 += Method02;
        testAction01 += Method03;
        // testAction01 += Method04;    // ERROR!!!
        testAction01();

        testAction02 += Method05;
        testAction02 += Method06;
        testAction02 += Method07;
        testAction02(10);   // 대리자 호출
        testAction02?.Invoke(10);   // 대리자의 Invoke 기능 실행 = 지연함수 아님!!! 실행 요청을 하는 함수로 이해하기
        // 아래의 코드는 ?를 통해 NULL체크를 진행할 수 있어 NullReferenceException에 대한 상황을 피할 수 있습니다.
        // 따라서 아래 코드를 권장함. 위 코드는 NullReference를 고려해야 하므로...


        testFunc01 += Method08;
        testFunc01 += Method09;
        if(testFunc01?.Invoke() == true)
        {
            Debug.Log("작업 성공");
        }
        if(testFunc01())
        {
            Debug.Log("작업 성공");
        }
        testFunc02 += Method10;
        testFunc02 += Method11;
        Debug.Log(testFunc02?.Invoke(10, 5));

    }

}
