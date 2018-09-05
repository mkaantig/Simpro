using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class operationManager : MonoBehaviour {

    public Text operationText;
    int firstNumber, secondNumber;
    int opValue;
    public int result;
    string opSign;
    

	// Use this for initialization
	void Start () {
        firstNumber = 0;
        secondNumber = 0;
        result = 0;
        opValue = 0;
        opSign = "";
        operationSetting();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void operationSetting()
    {
        firstNumber = Random.Range(1, 10);
        secondNumber = Random.Range(1, 10);
        opValue = Random.Range(1, 4);
        result = 0;
        switch (opValue)
        {
            case 1:
                opSign = "x";
                result = firstNumber * secondNumber;
                writeOperation(firstNumber, secondNumber, opSign);
                break;
            case 2:
                opSign = "+";
                result = firstNumber + secondNumber;
                writeOperation(firstNumber, secondNumber, opSign);
                break;
            case 3:
                opSign = "-";
                if (firstNumber>secondNumber)
                {
                    result = firstNumber - secondNumber;
                    writeOperation(firstNumber, secondNumber, opSign);
                }
                else
                {
                    result = secondNumber-firstNumber;
                    writeOperation(secondNumber, firstNumber, opSign);
                }
                break;
            case 4:
                opSign = "/";
                if (firstNumber % secondNumber==0)
                {
                    result = firstNumber / secondNumber;
                    writeOperation(firstNumber, secondNumber, opSign);
                }
                else if(secondNumber%firstNumber==0)
                {
                    result = secondNumber / firstNumber;
                    writeOperation(secondNumber, firstNumber, opSign);
                }
                else
                {
                    operationSetting();
                }
                break;
        }

    }

    private void writeOperation(int st, int nd, string txt)
    {
        operationText.text = "Operation: " + st.ToString() + txt + nd.ToString();

    }
}
