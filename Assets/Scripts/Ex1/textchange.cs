using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class textchange : MonoBehaviour
{
    public Text texta;
    float seconds;
    float secondsABCDEF;
    float secondsABCDE;
    float secondsABCD;
    float secondsABC;
    float secondsAB;
    float secondsA;
    public bool stateA;
    public bool stateB;
    public bool stateC;
    public bool stateAA;
    public bool stateBB;
    public bool stateCC;
 
    // Use this for initialization
    void Start()
    {
        stateA = false;
        stateB = false;
        stateC = false;
        stateAA = false;
        stateBB = false;
        stateCC = false;
    }
 
    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= 5){
            texta.text="ハンマーで金属をたたいてみよう";
            if(stateA == true && stateB == true && stateC == true && secondsABC >= 5 && stateAA == true && stateBB == true && stateCC == true && secondsABCD >=5 && secondsABCDE >=5 && secondsABCDEF>=5){
                SceneManager.LoadScene("New_Experiment_Choice");
            }else if(stateA == true && stateB == true && stateC == true && secondsABC >= 5 && stateAA == true && stateBB == true && stateCC == true && secondsABCD >=5 && secondsABCDE >=5){
                texta.text="実験を終了します\n";
                texta.text+="VRゴーグルを外してください";
                secondsABCDEF+=Time.deltaTime;
            }else if(stateA == true && stateB == true && stateC == true && secondsABC >= 5 && stateAA == true && stateBB == true && stateCC == true && secondsABCD >=5){
                texta.text="・金属と磁石は互いに引かれ合う\n";
                texta.text+="・金属には導電性がある\n";
                secondsABCDE += Time.deltaTime;
            }else if(stateA == true && stateB == true && stateC == true && secondsABC >= 5 && stateAA == true && stateBB == true && stateCC == true){
                texta.text = "まとめ\n";
                texta.text+="金属には以下の共通な性質があることがわかる\n";
                texta.text+="・金属には展性がある\n";
                secondsABCD +=Time.deltaTime;
            }else if(stateA == true && stateB == true && stateC == true){
                texta.text = "電球が光った(金属の導電性)";
                stateCC = true;
                secondsABC += Time.deltaTime;
            }else if(stateA == true && stateB == true && secondsAB >= 5 && stateAA == true && stateBB == true){
                texta.text = "電池と金属線、電球で回路を作ってみよう";
            }else if(stateA == true && stateB == true){
                texta.text = "金属と磁石は互いに引かれあった";
                stateBB = true;
                secondsAB += Time.deltaTime;
            }else if(stateA ==true && secondsA >= 5 && stateAA == true){
                texta.text = "金属を磁石にくっつけてみよう";
            }else if(stateA == true){
                texta.text = "金属がつぶれた（展性）";
                stateAA = true;
                secondsA +=Time.deltaTime;
            }
        }

        
    }
}
