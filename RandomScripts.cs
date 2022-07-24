using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region Abs
        //Menfi ededi musbet edir 
        //print(Mathf.Abs(-2.5f));
        #endregion
        #region Ceil 
        //Verilmis edede en boyuk olan edede yuvarlaqlasdirir 5.1 olsa bele 6 di cavab
        //print(Mathf.Ceil(-5.0f));
        //print(Mathf.Ceil(-5.2f));
        //print(Mathf.Ceil(-5.8f));
        //print(Mathf.Ceil(5.3f));
        //print(Mathf.Ceil(5.8f));
        //print(Mathf.Ceil(5.0f));
        #endregion
        #region Floor
        // Floor un tam tersidi 
        //print(Mathf.Floor(5.0f));
        //print(Mathf.Floor(5.3f));
        //print(Mathf.Floor(5.4f));
        //print(Mathf.Floor(-5.2f));

        #endregion
        #region Round
        //duz yuvarlaqlasdirma mentiqi amma belirli ferqler var 
        /* 1. duz yuvarlaqlasdirma mentiqi 
         2.(Meselen 11.5 ve ya 10.5) eger yuvarlaqlasdiracaqi eded tekdirse o zaman :
        
                print(Mathf.Round(10.5f)); // Cavab 10 dur 
            Cutdurse :
                print(Mathf.Round(11.5f)); // Cavab 12 dur 
         */
        //print(Mathf.Round(-5.3f));
        //print(Mathf.Round(5.3f));
        //print(Mathf.Round(-5.6f));
        //print(Mathf.Round(5.7f));
        #endregion
        #region Clamp
        // verilmis araliq esasinda eded goturu eger min dan asagidisa min deyeri max dan coxdursa maks deyeri goturur 
        //float heal = 10;
        //print(Mathf.Clamp(heal,1,100));
        #endregion
        #region Clamp01
        //Eger - deger gonderilirse geriye 0 ; + deyer gonderilirse 1 qaytarir
        //print(Mathf.Clamp01(1));
        #endregion
        #region Max/Min
        // Ta ayibdi bunun ne oldugunu yazmiram prosta icine array de atsan isliyir
        //Mathf.Max();
        //Mathf.Min();
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
