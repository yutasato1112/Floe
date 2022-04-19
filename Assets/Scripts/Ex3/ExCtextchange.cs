using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExCtextchange : MonoBehaviour
{
    public Text textc;
    float second =0;
    float secondA=0;
    float secondB=0;
    float secondC=0;
    float secondD=0;
    float secondE=0;
    float secondF=0;
    float secondG=0;
    float secondH=0;
    public bool state_ExC_PW;
    public bool state_ExC_SB;
    public bool state_ExC_SW;
    public bool state_ExC_HA;
    public bool state_ExC_SH;
    public bool state_ExC_EB;
    public bool orderA;
    public bool orderB;
    public bool orderC;
    public bool orderD;
    public bool orderE;
    public bool orderF;
    public bool orderG;
    public bool orderH;
    public bool orderI;
    public bool orderJ;
    public bool orderK;
    // Start is called before the first frame update
    void Start()
    {
        state_ExC_PW=false;
        state_ExC_SB=false;
        state_ExC_SW=false;
        state_ExC_HA=false;
        state_ExC_SH=false;
        state_ExC_EB=false;
        orderA=false;
        orderB=false;
        orderC=false;
        orderD=false;
        orderE=false;
        orderF=false;
        orderG=false;
        orderH=false;
        orderI=false;
        orderJ=false;
        orderK=false;
    }

    // Update is called once per frame
    void Update()
    {
        second+=Time.deltaTime;
        if(second >= 3){
            textc.text="精製水が電気を通すか実験してみよう";
            if(secondH>=5){
                SceneManager.LoadScene("New_Experiment_Choice");    
            }else if(secondG>=5){
                textc.text="実験を終了します\n";
                textc.text+="VRゴーグルを外してください";
                secondH+=Time.deltaTime;
            }else if(state_ExC_EB ==true&& secondF>=5&&orderK==true){
                textc.text="まとめ\n";
                textc.text+="電解質：電気を通す物質\n";
                textc.text+="非電解質：電気を通さない物質";
                secondG+=Time.deltaTime;
            }else if(state_ExC_EB ==true &&orderJ==true){
                textc.text="エタノールは電気を通さなかった";
                secondF+=Time.deltaTime;
                orderK=true;
            }else if(state_ExC_SH ==true && secondE>=5&&orderI==true){
                textc.text="エタノールが電気を通すか実験してみよう";
                orderJ=true;
            }else if(state_ExC_SH ==true &&orderH==true){
                textc.text="水酸化ナトリウムは電気を通した";
                secondE+=Time.deltaTime;
                orderI=true;
            }else if(state_ExC_HA ==true && secondD>=5&&orderG==true){
                textc.text="水酸化ナトリウムが電気を通すか実験してみよう";
                orderH=true;
            }else if(state_ExC_HA ==true&&orderF==true){
                textc.text="塩酸は電気を通した";
                secondD+=Time.deltaTime;
                orderG=true;
            }else if(state_ExC_SW ==true&& secondC>=5&&orderE==true){
                textc.text="塩酸が電気を通すか実験してみよう";
                orderF=true;
            }else if(state_ExC_SW ==true &&orderD==true){
                textc.text="砂糖水は電気を通さなかった";
                secondC+=Time.deltaTime;
                orderE=true;
            }else if(state_ExC_SB ==true && secondB>=5&&orderC==true){
                textc.text="砂糖水が電気を通すか実験してみよう";
                orderD=true;
            }else if(state_ExC_SB ==true&&orderB==true){
                textc.text="食塩水は電気を通した";
                secondB+=Time.deltaTime;
                orderC=true;
            }else if(state_ExC_PW ==true&& secondA>=5 && orderA==true){
                textc.text="食塩水が電気を通すか実験してみよう";
                orderB=true;
            }else if(state_ExC_PW ==true){
                textc.text="精製水は電気を通さなかった";
                secondA+=Time.deltaTime;
                orderA=true;

            }
        }
        
    }
}
