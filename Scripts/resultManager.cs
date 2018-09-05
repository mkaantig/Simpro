using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultManager : MonoBehaviour {

    int result;
    int hitNumber;
    operationManager om;
    public Text resultText;
    public GameObject checkResult;
    scoreManager sm;
    public GameObject scoreManager;
    int getDecimal;
    int hitNumberDecimal;
    string cmpResult;
    public GameObject gameOverUI;
    int resultForDivision;
	// Use this for initialization
	void Start () {
        getDecimal = 0;
        resultForDivision = 0;
        hitNumberDecimal = 0;
        resetResult();
        om = checkResult.GetComponent<operationManager>();
        sm = scoreManager.GetComponent<scoreManager>();
	}

    public void writeResult(int hit)
    {
        
        cmpResult += hit.ToString();
        hitNumber = int.Parse(cmpResult);
        resultText.text = resultText.text + hit.ToString();
        hitNumberDecimal++;
        compareResult(hitNumber);
        




    }
    private void calculateDecimal()
    {
        getDecimal = 0;
        resultForDivision = om.result;
        while (resultForDivision > 0)
        {
            resultForDivision = resultForDivision / 10;
            getDecimal += 1;
        }
        
    }
    private void compareResult(int resultNumber)
    {
        
        result = om.result;

        if (resultNumber == result)
        {
            om.operationSetting();
            sm.addNewScore();
            resetResult();
        }
        else
        {
            calculateDecimal();
            resultForDivision = om.result;
            getDecimal = getDecimal - hitNumberDecimal;
            for (int i = 0; i < getDecimal; i++)
            {
                resultForDivision = resultForDivision / 10;
            }


            if (resultNumber != resultForDivision)
            {
                gameOverUI.SetActive(true);
            }
         
        }
        
         
       
       

    }
    private void resetResult()
    {
        resultText.text = "Result: ";
        cmpResult = "";
        hitNumber = 0;
        resultForDivision = 0;
        getDecimal = 0;
        hitNumberDecimal = 0;
    }
	
	
}
