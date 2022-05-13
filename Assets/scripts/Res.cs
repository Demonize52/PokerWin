using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Res : MonoBehaviour{
    
    public Text otvet; //Переменная для изменения текста 
    public int mastOne;// Переменная для запоминания индекса 1го Dropdown мастей
    public int mastSecond;//Переменная для запоминания индекса 2го Dropdown мастей
    private int InputOne;//Переменная для запоминания индекса 1го Dropdown карт
    private int InputSecond;//Переменная для запоминания индекса 2го Dropdown карт

    public void InputSeconde(int c){//Проверка индекса 2го Dropdown карт
        switch(c){
            case 0:
            InputSecond=6;
            break;
            case 1:
            InputSecond=7;
            break;
            case 2:
            InputSecond=8;
            break;
            case 3:
            InputSecond=9;
            break;
            case 4:
            InputSecond=10;
            break;
            case 5:
            InputSecond=11;
            break;
            case 6:
            InputSecond=12;
            break;
            case 7:
            InputSecond=13;
            break;
            case 8:
            InputSecond=14;
            break;
        }
        
    }
    public void InputOnee(int d){//Проверка индекса 1го Dropdown карт
        switch(d){
            case 0:
            InputOne=6;
            break;
            case 1:
            InputOne=7;
            break;
            case 2:
            InputOne=8;
            break;
            case 3:
            InputOne=9;
            break;
            case 4:
            InputOne=10;
            break;
            case 5:
            InputOne=11;
            break;
            case 6:
            InputOne=12;
            break;
            case 7:
            InputOne=13;
            break;
            case 8:
            InputOne=14;
            break;
        }
        
    }
    
    public void MastOne(int a){//Проверка индекса 1го Dropdown мастей
        switch(a){
            case 0:
            mastOne=0;
            break;
            case 1:
            mastOne=1;
            break;
            case 2:
            mastOne=2;
            break;
            case 3:
            mastOne=3;
            break;
        }
        
    }
    public void MastSecond(int b){//Проверка индекса 2го Dropdown мастей
        switch(b){
            case 0:
            mastSecond=0;
            break;
            case 1:
            mastSecond=1;
            break;
            case 2:
            mastSecond=2;
            break;
            case 3:
            mastSecond=3;
            break;
        }
        
    }

    public void Result() {// функция для кнопки РЕЗУЛЬТАТ проверяет все условия и выдает ответ
        if(mastOne==mastSecond)
        otvet.text = "A chance to win 10%";
        if(InputOne==InputSecond)
        otvet.text = "A chance to win 19%";
        if((InputOne==InputSecond)&&(InputOne>10))
        otvet.text = "A chance to win >30%";
        if((InputOne==InputSecond)&&(InputOne>12))
        otvet.text = "A chance to win >48%";
        if((mastOne!=mastSecond)&&(InputOne!=InputSecond))
        otvet.text = "A chance to win<10%";
        if((mastOne==mastSecond)&&(InputOne==InputSecond))
        otvet.text = "Error";
    }
}
