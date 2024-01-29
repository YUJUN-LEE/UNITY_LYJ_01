using UnityEngine;
using UnityEngine.UIElements;

public class FirstStudy : MonoBehaviour
{
	// 스크립트가 활성화 되었을 때 호출
	void Awake()
	{
		// 로그 출력 방법 : Debug.Log(내용);
		Debug.Log("Awake함수 호출됨");
		/*
		int iNum = 0;
		iNum = Sum(10, 20);
        iNum = Sum(50, 30);
        iNum = Sum(40, 20);
        iNum = Sum(100, 50);
		*/

    }

    /*int Sum(int iNum1, int iNum2)
	{
		int Result = iNum1 + iNum2;
		return Result;
	}*/
	// Start is called before the first frame update
	void Start()
	{
        Debug.Log("Start함수 호출됨");
    }
	// 설정된 프레임보다 낮게 나올 때 그만큼 더 호출
	// 설정된 프레임보다 높게 나올 때 그만큼 덜 호출
	// 이동/물리 등 작성
	void FixedUpdate()
	{
        Debug.Log("FixedUpdate함수 호출됨");
		
		// transform.Translate(0f, 0f, 0.01f); // transform.Translate(x, y, z, 기준) 기준에 Space.World를 하면 position과 같아짐
		// transform.position += new Vector3(0f, 0f, 0.01f); position은 좌표에 직접 더함(Rotate 방향 무시)
		// transform.Rotate(5f, 5f, 5f);
    }
	// Update is called once per frame
	void Update()
	{
        Debug.Log("Update함수 호출됨");


        // Input.GetKey(KeyCode) : KeyCode에 해당하는 키가 눌려잇는 동안 true
        // Input.GetKeyDown(KeyCode) : KeyCode에 해당하는 키가 눌린 프레임에 true
        // Input.GetKeyUp(KeyCode) : KeyCode에 해당하는 키가 놓인 프레임에 true

        bool isInputUp = Input.GetKey(KeyCode.UpArrow);
        bool isInputDown = Input.GetKey(KeyCode.DownArrow);
        bool isInputRight = Input.GetKey(KeyCode.RightArrow);
        bool isInputLeft = Input.GetKey(KeyCode.LeftArrow);
        if(isInputLeft && isInputUp)
		{
			Debug.Log("왼쪽 위 입력");
			transform.Translate(-0.2f, 0.2f, 0f);
		}
		else if(isInputRight && isInputDown)
		{
			Debug.Log("오른쪽 밑 입력");
			transform.Translate(0.2f, -0.2f, 0f);
		}
        else if (isInputRight && isInputUp)
        {
            Debug.Log("오른쪽 위 입력");
            transform.Translate(0.2f, 0.2f, 0f);
        }
        else if (isInputLeft && isInputDown)
        {
            Debug.Log("왼쪽 밑 입력");
            transform.Translate(-0.2f, -0.2f, 0f);
        }
        else if (isInputUp)
		{
			Debug.Log("위쪽 방향키");
			transform.Translate(0f, 0.2f, 0f);
		}
		else if (isInputDown)
		{
			Debug.Log("아래 방향키");
            transform.Translate(0f, -0.2f, 0f);
        }
		else if(isInputRight)
		{
			Debug.Log("오른쪽 방향키");
            transform.Translate(0.2f, 0f, 0f);
        }
		else if(isInputLeft) {
			Debug.Log("왼쪽 방향키");
            transform.Translate(-0.2f, 0f, 0f);
        }
		else
		{
			// 처리 X
		}
    }
	//업데이트 이후에 호출
	void LateUpdate()
	{
        Debug.Log("LateUpdate함수 호출됨");
    }
}