using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExDtextchange : MonoBehaviour
{
    public Text textd;
    float sec=0;
    float secA=0;
    float secB=0;
    float secC=0;
    float secD=0;
    float second =0;
    float secondA=0;
    float secondB=0;
    float secondC=0;
    float secondD=0;
    float secondE=0;
    float secondF=0;
    float secondG=0;
    float secondH=0;
    float secondI=0;
    float secondJ=0;
    public bool state_awb_touch_P;
    public bool state_hab_touch_P;
    public bool state_BTB_touch_P;
    public bool state_pwd_touch_P;
    public bool state_aab_touch_P;
    public bool state_shb_touch_P;
    public bool DialogueA;
    public bool DialogueB;
    public bool DialogueC;
    public bool DialogueD;
    public bool DialogueE;
    public bool DialogueF;
    public bool DialogueG;
    public bool DialogueH;
    public bool DialogueI;
    public bool DialogueJ;
    public bool DialogueK;
    public bool DialogueL;
    public bool DialogueA1;
    public bool DialogueB1;
    public bool DialogueA2;
    public bool DialogueB2;
    public bool DialogueA3;
    public bool DialogueB3;
    public bool DialogueA4;
    public bool DialogueB4;
    public bool DialogueA5;
    public bool DialogueB5;
    public bool DialogueA6;
    public bool DialogueB6;
    public bool DialogueA7;
    public bool DialogueB7;
    public bool DialogueA8;
    public bool DialogueB8;
    public bool DialogueA9;
    public bool DialogueB9;
    public bool state_HCl_NH3;
    public bool state_HCl_NaOH;
    public bool state_Na3COOH_NH3;
    public bool state_Na3COOH_NaOH;
    public bool state_HCl_Na3COOH;
    public bool state_NH3_NaOH;
    public bool state_HCl_H2O;
    public bool state_Na3COOH_H2O;
    public bool state_NH3_H2O;
    public bool state_NaOH_H2O;
    public bool tmp;
    public string state_BTB_color;
    public bool state_matome;

    // Start is called before the first frame update
    void Start()
    {
        state_awb_touch_P=false;
        state_hab_touch_P=false;
        state_BTB_touch_P=false;
        state_pwd_touch_P=false;
        state_aab_touch_P=false;
        state_shb_touch_P=false;
        DialogueA=false;
        DialogueB=false;
        DialogueA1=false;
        DialogueB1=false;
        DialogueA2=false;
        DialogueB2=false;
        DialogueA3=false;
        DialogueB3=false;
        DialogueA4=false;
        DialogueB4=false;
        DialogueA5=false;
        DialogueB5=false;
        DialogueA6=false;
        DialogueB6=false;
        DialogueA7=false;
        DialogueB7=false;
        DialogueA8=false;
        DialogueB8=false;
        DialogueA9=false;
        DialogueB9=false;
        DialogueC=true;
        DialogueD=true;
        DialogueE=true;
        DialogueF=true;
        DialogueG=true;
        DialogueH=true;
        DialogueI=true;
        DialogueJ=true;
        DialogueK=true;
        DialogueL=true;
        state_HCl_NH3=true;
        state_HCl_NaOH =false;
        state_Na3COOH_NH3=false;
        state_Na3COOH_NaOH=false;
        state_HCl_Na3COOH=false;
        state_NH3_NaOH=false;
        state_HCl_H2O=false;
        state_Na3COOH_H2O=false;
        state_NH3_H2O=false;
        state_NaOH_H2O=false;
        tmp=false;
        state_matome=false;
    }

    // Update is called once per frame
    void Update()
    {
        second+=Time.deltaTime;
        if(state_HCl_NH3==true){
            HCl_NH3();
            if(state_HCl_NaOH==true){
                HCl_NaOH();
                if(state_Na3COOH_NH3==true){
                    Na3COOH_NH3();
                    if(state_Na3COOH_NaOH==true){
                        Na3COOH_NaOH();
                        if(state_HCl_Na3COOH==true){
                            HCl_Na3COOH(); 
                            if(state_NH3_NaOH==true){
                                NH3_NaOH();
                                if(state_HCl_H2O==true){
                                    HCl_H2O();
                                    if(state_Na3COOH_H2O==true){
                                        Na3COOH_H2O();
                                        if(state_NH3_H2O==true){
                                            NH3_H2O();
                                            if(state_NaOH_H2O==true){
                                                NaOH_H2O();
                                                if(state_matome==true){
                                                    matome();
                                                }
                                            }
                                        }
                                    }
                                }
                            }  
                        }
                    }
                }
            }
        }
    }
    private void HCl_NH3(){
        if(secondA>3 && DialogueC==true){
            state_BTB_color="initial";
            state_awb_touch_P=false;
            state_hab_touch_P=false;
            state_BTB_touch_P=false;
            state_pwd_touch_P=false;
            state_aab_touch_P=false;
            state_shb_touch_P=false;
            DialogueC=false;
            tmp=false;
            state_HCl_NaOH=true;
        }else if(state_awb_touch_P==true && state_hab_touch_P==true && state_BTB_touch_P==true&& tmp==true){
            state_BTB_color="green_HCl";
            textd.text="BTB溶液が緑になった（中性）";
            secondA+=Time.deltaTime;
        }else if(state_awb_touch_P==true && state_hab_touch_P==true && state_BTB_touch_P==true){
            textd.text="BTB溶液を塩酸とアンモニアの混合液に加えてみよう";
            state_hab_touch_P=false;
            tmp=true;
        }else if(state_awb_touch_P==true && state_hab_touch_P==true){
            textd.text="BTB溶液を駒込ピペッドで採取してみよう";
        }else if(state_awb_touch_P==true&&DialogueB==false){
            textd.text="塩酸にアンモニア水を加えてみよう";
            DialogueB=true;
        }else if(second>3 && DialogueA==false){
            textd.text="アンモニア水を駒込ピペッドで採取してみよう";
            DialogueA=true;
        }
    }

    private void HCl_NaOH(){
        if(secondB>3 && DialogueD==true){
            state_BTB_color="initial";
            state_awb_touch_P=false;
            state_hab_touch_P=false;
            state_BTB_touch_P=false;
            state_pwd_touch_P=false;
            state_aab_touch_P=false;
            state_shb_touch_P=false;
            DialogueD=false;
            tmp=false;
            state_Na3COOH_NH3=true;
        }else if(state_shb_touch_P==true && state_hab_touch_P==true && state_BTB_touch_P==true&& tmp==true){
            state_BTB_color="green_HCl";
            textd.text="BTB溶液が緑になった（中性）";
            secondB+=Time.deltaTime;
        }else if(state_shb_touch_P==true && state_hab_touch_P==true && state_BTB_touch_P==true){
            textd.text="BTB溶液を塩酸と水酸化ナトリウム水溶液の混合液に加えてみよう";
            state_hab_touch_P=false;
            tmp=true;
        }else if(state_shb_touch_P==true && state_hab_touch_P==true){
            textd.text="BTB溶液を駒込ピペッドで採取してみよう";
        }else if(state_shb_touch_P==true &&DialogueB1==false){
            textd.text="塩酸に水酸化ナトリウム水溶液を加えてみよう";
            DialogueB1=true;
        }else if(secondA >= 3 && DialogueA1==false){
            textd.text="水酸化ナトリウム水溶液を駒込ピペッドで採取してみよう（全て洗浄済み）";
            DialogueA1=true;
        }
        
    }

    private void Na3COOH_NH3(){
        if(secondC>3 && DialogueE==true){
            state_BTB_color="initial";
            state_awb_touch_P=false;
            state_hab_touch_P=false;
            state_BTB_touch_P=false;
            state_pwd_touch_P=false;
            state_aab_touch_P=false;
            state_shb_touch_P=false;
            DialogueE=false;
            tmp=false;
            state_Na3COOH_NaOH=true;
        }else if(state_awb_touch_P==true && state_aab_touch_P==true && state_BTB_touch_P==true&& tmp==true){
            state_BTB_color="green_Na3COOH";
            textd.text="BTB溶液が緑になった（中性）";
            secondC+=Time.deltaTime;
        }else if(state_awb_touch_P==true && state_aab_touch_P==true && state_BTB_touch_P==true){
            textd.text="BTB溶液を酢酸とアンモニア水の混合液に加えてみよう";
            state_aab_touch_P=false;
            tmp=true;
        }else if(state_awb_touch_P==true && state_aab_touch_P==true){
            textd.text="BTB溶液を駒込ピペッドで採取してみよう";
        }else if(state_awb_touch_P==true &&DialogueB2==false){
            textd.text="酢酸にアンモニア水を加えてみよう";
            DialogueB2=true;
        }else if(secondB >= 3 && DialogueA2==false){
            textd.text="アンモニア水を駒込ピペッドで採取してみよう（全て洗浄済み）";
            DialogueA2=true;
        }
    }

    private void Na3COOH_NaOH(){
        if(secondD>3 && DialogueF==true){
            state_BTB_color="initial";
            state_awb_touch_P=false;
            state_hab_touch_P=false;
            state_BTB_touch_P=false;
            state_pwd_touch_P=false;
            state_aab_touch_P=false;
            state_shb_touch_P=false;
            DialogueF=false;
            tmp=false;
            state_HCl_Na3COOH=true;
        }else if(state_aab_touch_P==true && state_shb_touch_P==true && state_BTB_touch_P==true&& tmp==true){
            state_BTB_color="green_Na3COOH";
            textd.text="BTB溶液が緑になった（中性）";
            secondD+=Time.deltaTime;
        }else if(state_aab_touch_P==true && state_shb_touch_P==true && state_BTB_touch_P==true){
            textd.text="BTB溶液を酢酸と水酸化ナトリウム水溶液の混合液に加えてみよう";
            state_aab_touch_P=false;
            tmp=true;
        }else if(state_aab_touch_P==true && state_shb_touch_P==true){
            textd.text="BTB溶液を駒込ピペッドで採取してみよう";
        }else if(state_shb_touch_P==true &&DialogueB3==false){
            textd.text="酢酸に水酸化ナトリウム水溶液を加えてみよう";
            DialogueB3=true;
        }else if(secondC >= 3 && DialogueA3==false){
            textd.text="水酸化ナトリウム水溶液を駒込ピペッドで採取してみよう（全て洗浄済み）";
            DialogueA3=true;
        }
    }

    private void HCl_Na3COOH(){
        if(secondE>3 && DialogueG==true){
            state_BTB_color="initial";
            state_awb_touch_P=false;
            state_hab_touch_P=false;
            state_BTB_touch_P=false;
            state_pwd_touch_P=false;
            state_aab_touch_P=false;
            state_shb_touch_P=false;
            DialogueG=false;
            tmp=false;
            state_NH3_NaOH=true;
        }else if(state_aab_touch_P==true && state_hab_touch_P==true && state_BTB_touch_P==true&& tmp==true){
            state_BTB_color="yellow_HCl";
            textd.text="BTB溶液が黄になった（酸性）";
            secondE+=Time.deltaTime;
        }else if(state_aab_touch_P==true && state_hab_touch_P==true && state_BTB_touch_P==true){
            textd.text="BTB溶液を酢酸と塩酸の混合液に加えてみよう";
            state_hab_touch_P=false;
            tmp=true;
        }else if(state_aab_touch_P==true && state_hab_touch_P==true){
            textd.text="BTB溶液を駒込ピペッドで採取してみよう";
        }else if(state_aab_touch_P==true &&DialogueB4==false){
            textd.text="塩酸に酢酸を加えてみよう";
            DialogueB4=true;
        }else if(secondD >= 3 && DialogueA4==false){
            textd.text="酢酸を駒込ピペッドで採取してみよう（全て洗浄済み）";
            DialogueA4=true;
        }
    }
    private void NH3_NaOH(){
        if(secondF>3 && DialogueH==true){
            state_BTB_color="initial";
            state_awb_touch_P=false;
            state_hab_touch_P=false;
            state_BTB_touch_P=false;
            state_pwd_touch_P=false;
            state_aab_touch_P=false;
            state_shb_touch_P=false;
            DialogueH=false;
            tmp=false;
            state_HCl_H2O=true;
        }else if(state_shb_touch_P==true && state_awb_touch_P==true && state_BTB_touch_P==true&& tmp==true){
            state_BTB_color="blue_NH3";
            textd.text="BTB溶液が青になった（塩基性）";
            secondF+=Time.deltaTime;
        }else if(state_shb_touch_P==true && state_awb_touch_P==true && state_BTB_touch_P==true){
            textd.text="BTB溶液を水酸化ナトリウム水溶液とアンモニア水の混合液に加えてみよう";
            state_awb_touch_P=false;
            tmp=true;
        }else if(state_shb_touch_P==true && state_awb_touch_P==true){
            textd.text="BTB溶液を駒込ピペッドで採取してみよう";
        }else if(state_shb_touch_P==true &&DialogueB5==false){
            textd.text="アンモニア水に水酸化ナトリウム水溶液を加えてみよう";
            DialogueB5=true;
        }else if(secondE >= 3 && DialogueA5==false){
            textd.text="水酸化ナトリウム水溶液を駒込ピペッドで採取してみよう（全て洗浄済み）";
            DialogueA5=true;
        }
    }

    private void HCl_H2O(){
        if(secondG>3 && DialogueI==true){
            state_BTB_color="initial";
            state_awb_touch_P=false;
            state_hab_touch_P=false;
            state_BTB_touch_P=false;
            state_pwd_touch_P=false;
            state_aab_touch_P=false;
            state_shb_touch_P=false;
            DialogueI=false;
            tmp=false;
            state_Na3COOH_H2O=true;
        }else if(state_pwd_touch_P==true && state_hab_touch_P==true && state_BTB_touch_P==true&& tmp==true){
            state_BTB_color="semi_yellow_HCl";
            textd.text="BTB溶液が薄黄になった（弱酸性）";
            secondG+=Time.deltaTime;
        }else if(state_pwd_touch_P==true && state_hab_touch_P==true && state_BTB_touch_P==true){
            textd.text="BTB溶液を精製水と塩酸の混合液に加えてみよう";
            state_hab_touch_P=false;
            tmp=true;
        }else if(state_pwd_touch_P==true && state_hab_touch_P==true){
            textd.text="BTB溶液を駒込ピペッドで採取してみよう";
        }else if(state_pwd_touch_P==true &&DialogueB6==false){
            textd.text="塩酸に精製水を加えてみよう";
            DialogueB6=true;
        }else if(secondF >= 3 && DialogueA6==false){
            textd.text="精製水を駒込ピペッドで採取してみよう（全て洗浄済み）";
            DialogueA6=true;
        }
    }

    private void Na3COOH_H2O(){
        if(secondH>3 && DialogueJ==true){
            state_BTB_color="initial";
            state_awb_touch_P=false;
            state_hab_touch_P=false;
            state_BTB_touch_P=false;
            state_pwd_touch_P=false;
            state_aab_touch_P=false;
            state_shb_touch_P=false;
            DialogueJ=false;
            tmp=false;
            state_NH3_H2O=true;
        }else if(state_pwd_touch_P==true && state_aab_touch_P==true && state_BTB_touch_P==true&& tmp==true){
            state_BTB_color="semi_yellow_Na3COOH";
            textd.text="BTB溶液が薄黄になった（弱酸性）";
            secondH+=Time.deltaTime;
        }else if(state_pwd_touch_P==true && state_aab_touch_P==true && state_BTB_touch_P==true){
            textd.text="BTB溶液を精製水と酢酸の混合液に加えてみよう";
            state_aab_touch_P=false;
            tmp=true;
        }else if(state_pwd_touch_P==true && state_aab_touch_P==true){
            textd.text="BTB溶液を駒込ピペッドで採取してみよう";
        }else if(state_pwd_touch_P==true &&DialogueB7==false){
            textd.text="酢酸に精製水を加えてみよう";
            DialogueB7=true;
        }else if(secondG >= 3 && DialogueA7==false){
            textd.text="精製水を駒込ピペッドで採取してみよう（全て洗浄済み）";
            DialogueA7=true;
        }
    }

    private void NH3_H2O(){
        if(secondI>3 && DialogueK==true){
            state_BTB_color="initial";
            state_awb_touch_P=false;
            state_hab_touch_P=false;
            state_BTB_touch_P=false;
            state_pwd_touch_P=false;
            state_aab_touch_P=false;
            state_shb_touch_P=false;
            DialogueK=false;
            tmp=false;
            state_NaOH_H2O=true;
        }else if(state_pwd_touch_P==true && state_awb_touch_P==true && state_BTB_touch_P==true&& tmp==true){
            state_BTB_color="semi_blue_NH3";
            textd.text="BTB溶液が薄青になった（弱塩基性）";
            secondI+=Time.deltaTime;
        }else if(state_pwd_touch_P==true && state_awb_touch_P==true && state_BTB_touch_P==true){
            textd.text="BTB溶液を精製水とアンモニア水の混合液に加えてみよう";
            state_awb_touch_P=false;
            tmp=true;
        }else if(state_pwd_touch_P==true && state_awb_touch_P==true){
            textd.text="BTB溶液を駒込ピペッドで採取してみよう";
        }else if(state_pwd_touch_P==true &&DialogueB8==false){
            textd.text="アンモニア水に精製水を加えてみよう";
            DialogueB8=true;
        }else if(secondH >= 3 && DialogueA8==false){
            textd.text="精製水を駒込ピペッドで採取してみよう（全て洗浄済み）";
            DialogueA8=true;
        }
    }

    private void NaOH_H2O(){
        if(secondJ>3 && DialogueL==true){
            state_BTB_color="initial";
            state_awb_touch_P=false;
            state_hab_touch_P=false;
            state_BTB_touch_P=false;
            state_pwd_touch_P=false;
            state_aab_touch_P=false;
            state_shb_touch_P=false;
            DialogueL=false;
            tmp=false;
            state_matome=true;
        }else if(state_pwd_touch_P==true && state_shb_touch_P==true && state_BTB_touch_P==true&& tmp==true){
            state_BTB_color="semi_blue_NaOH";
            textd.text="BTB溶液が薄青になった（弱塩基性）";
            secondJ+=Time.deltaTime;
        }else if(state_pwd_touch_P==true && state_shb_touch_P==true && state_BTB_touch_P==true){
            textd.text="BTB溶液を精製水と水酸化ナトリウム水溶液の混合液に加えてみよう";
            state_shb_touch_P=false;
            tmp=true;
        }else if(state_pwd_touch_P==true && state_shb_touch_P==true){
            textd.text="BTB溶液を駒込ピペッドで採取してみよう";
        }else if(state_pwd_touch_P==true &&DialogueB9==false){
            textd.text="水酸化ナトリウム水溶液に精製水を加えてみよう";
            DialogueB9=true;
        }else if(secondH >= 3 && DialogueA9==false){
            textd.text="精製水を駒込ピペッドで採取してみよう（全て洗浄済み）";
            DialogueA9=true;
        } 
    }

    private void matome(){
        sec+=Time.deltaTime;
        textd.text="まとめ";
        if(sec>2){
            textd.text="各水溶液の液性は以下の通り\n";
            textd.text+="・精製水　…　中性\n";
            textd.text+="・塩酸　…　酸性";
            secA+=Time.deltaTime;
            if(secA>3){
                textd.text="・酢酸　…　酸性\n";
                textd.text+="・水酸化ナトリウム\n水溶液　…　塩基性\n";
                textd.text+="・アンモニア水　…　塩基性";
                secB+=Time.deltaTime;
                if(secB>3){
                    textd.text="酸性の水溶液と塩基性の水溶液を混合して中性の液体を生成することを中和という";
                    secC+=Time.deltaTime;
                    if(secC>3){
                        textd.text="実験終了\n";
                        textd.text+="VRゴーグルを外してください";
                        secD+=Time.deltaTime;
                        if(secD>3){
                            SceneManager.LoadScene("New_Experiment_Choice");  
                        }
                    }
                }
            }
        }
    }
}