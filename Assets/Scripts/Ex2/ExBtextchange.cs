using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExBtextchange : MonoBehaviour
{
    public Text textb;
    float seconds;
    float SecondA;
    float secondB;
    float secondC;
    public bool stateExB_A;
    public bool stateExB_B;
    public bool stateExB_C;
    public bool stateExB_D;
    public bool stateExB_E;
    public bool stateExB_AA;
    public bool stateExB_switch;
    public bool  state_lamp;
    // Start is called before the first frame update
    void Start()
    {
        stateExB_A=false;
        stateExB_B=false;
        stateExB_C=false;
        stateExB_D=false;
        stateExB_E=false;
        stateExB_AA=false;
        stateExB_switch=false;
        state_lamp=false;
    }

    // Update is called once per frame
    void Update()
    {
        seconds+=Time.deltaTime;
        if(seconds>=5){
            textb.text="電流の大きさを図る回路を作ってみよう";
            if(stateExB_A == true &&stateExB_B == true && stateExB_C == true &&stateExB_D == true && stateExB_AA==true && stateExB_E==true && SecondA>= 5 && secondB>=5 && secondC>=5){
                SceneManager.LoadScene("New_Experiment_Choice");
            }else if(stateExB_A == true &&stateExB_B == true && stateExB_C == true &&stateExB_D == true && stateExB_AA==true && stateExB_E==true && SecondA>= 5 && secondB>=5){
                textb.text="実験終了\n";
                textb.text+="VRゴーグルを外してください";
                secondC+=Time.deltaTime;
            }else if(stateExB_A == true &&stateExB_B == true && stateExB_C == true &&stateExB_D == true && stateExB_AA==true && stateExB_E==true && SecondA>= 5){
                textb.text="まとめ\n";
                textb.text+="・回路の電流はスイッチで操作\n";
                textb.text+="・直列回路での電流値は一定";
                secondB+=Time.deltaTime;
            }else if(stateExB_A == true &&stateExB_B == true && stateExB_C == true &&stateExB_D == true && stateExB_AA==true && stateExB_E==true){
                textb.text="電球が光った\n";
                textb.text+="電流計の値を読んでみよう";
                SecondA+=Time.deltaTime;
                state_lamp=true;
            }else if(stateExB_A == true &&stateExB_B == true && stateExB_C == true && stateExB_D == true && stateExB_AA==true){
                textb.text="回路のスイッチを入れて電流を流してみよう";
                stateExB_switch=true;
            }else if(stateExB_A == true &&stateExB_B == true && stateExB_C == true && stateExB_D == true){
                textb.text="回路が完成した";
                stateExB_AA=true;
            }
        }
    }
}
