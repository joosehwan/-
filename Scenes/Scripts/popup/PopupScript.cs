using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupScript : MonoBehaviour
{
    public void Popup_explane()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
        "튜토리얼",
        "안녕하세요 로딩암 시뮬레이션에 오신걸 환영합니다\r\n\r\n" +
        "로딩암은 기름, 케미칼, LNG 및 LPG 화물의 선적이나 하역을 위해 사용되는 장비로서 원유 운반선 화학제품 운반선, " +
        "LNG운반선 및 LPG 운반선 등에 설치된 메니 폴드 부두와 부두에 설치된 로딩암을 통해 하역 작업이 이루어지게 합니다. \r\n 로딩암은 통상 마린로딩암 또는 칙산으로 지칭 되고 있으며," +
        " 주로대량의 액체나 기체의 화울을 이송하기위해 이용됩니다.\r\n\r\n" +
        "( F 를 눌러 팝업을 닫습니다.)");
        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("ffffffffffffffff");
            GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();

            //  gotutorial();
        }
    }

    public void Popup_good()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
        "튜토리얼", "훌륭한 조작입니다! 다음 단계로 넘어가겠습니다.\r\n\r\n" +
        "( F 를 눌러 팝업을 닫습니다.)");

    }
    public void Popup_good2()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
        "튜토리얼", "훌륭한 조작입니다! \r\n" + "자유조종시에는 E키를 눌러 동시에 조종할 수 있습니다." +
        "다음 단계로 넘어가겠습니다.\r\n\r\n" +
        "( F 를 눌러 팝업을 닫습니다.)");

    }
    public void Popup_end()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
        "튜토리얼", "축하합니다! 이제 모든조작을 배웠습니다. \r\n다음은 지금까지 배운 지식을 활용하여 배와의 연결을 시도해 보십시오.\r\n\r\n" +
        "( F 를 눌러 팝업을 닫습니다.)");

    }

    public void Popup_1()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
        "튜토리얼", " 로딩암 시뮬레이션을 시작합니다. \r\n조작법에 대해 배워봅시다.\r\n\r\n" + "( F 를 눌러 팝업을 닫습니다.)")
         ;

    }

    public void Popup_2()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
       "튜토리얼", "먼저 조작을 배워봅니다.로딩암의 조종은 크게 3파트로 나뉩니다. \r\n 로딩암을 기울이는 것 두개. 중심축을 회전시키는 것 하나입니다. " +
       "[Q] 를 누르면 활성화가 가능합니다\r\n" +
       "[좌] [우] 화살표를 눌러 파트1번을 조종 해보세요.\r\n\r\n" +
       " (F 를 눌러 팝업을 닫습니다.)");

    }

    public void Popup_3()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
       "튜토리얼", "이번에는 주입구 파트를 조종하겠습니다.\r\n 이 부분을 조종하여 선박의 연결부와 가까워지면 자연스럽게 연결이 시작됩니다. \r\n" +
       "[W] 를 누르면 활성화가 가능합니다\r\n" +
       "[좌] [우] 화살표를 눌러 파트2번을 조종 해보세요.\r\n\r\n" + "( F 를 눌러 팝업을 닫습니다.)");

    }
    public void Popup_4()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
       "튜토리얼", "이번에는 로딩암 중심축을 조종하겠습니다. \r\n 이 부분을 조종하여 로딩암의 좌우를 회전시켜 더욱 자세한 조종이 가능해 집니다. \r\n " +
       "[U] [I] 키를 눌러 기둥을 조종 해보세요. \r\n\r\n " + "( F 를 눌러 팝업을 닫습니다.)");

    }
    public void Popup_5()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
       "튜토리얼", "이번에는 카메라를 전환해 보겠습니다.\r\n왼쪽 쉬프트(Shift)키를 누르면 카메라 전환을 통해 좀더 섬세한 조종이 가능합니다.\r\n 3가지 시점을 활용하여 선박과의 연결을 성공시킬 수 있습니다. "
       + " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)");

    }
    public void Popup_Ani_In()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "튜토리얼", "로딩암은 선박에 액체화물을 주입할 수 있습니다. \r\n \r\n" +
     "로딩의 사전적 의미는 선박이나 화물차에 짐을 싣다 라는 뜻으로\r\n \r\n " +
     "로딩암에서의 로딩은 LNG, LPG, 석유화학물질 등을 선박에 선적하는 것을 의미합니다"

     + " \r\n \r\n( F 를 눌러 연결을 시작하세요.)");
    }
  
    public void Popup_Ani_out()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "튜토리얼", "로딩암 해제시 남아있는 부유물로 인한 사고 위험성이 더욱 높아져 각별한 주의가 필요합니다.\r\n \r\n " +
     "때문에 현장에서는 부유물을 제거한 후 조종 시 유의하여 해제 시킵니다."

     + " \r\n \r\n( F 를 눌러 해제을 시작하세요.)");
    }
    
   


    public void Popup_endSimul()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "튜토리얼", "\r\n 축하합니다! 모든 튜토리얼 성공적으로 마쳤습니다. \r\n\r\n조금더 실제같고 어려운 조작을 원한다면 난이도 [상] 모드를 플레이해 보십시오. "

     );
    }
    public void Popup_1_hard()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "하드모드", "HardMode에 오신 여러분을 환영합니다. 이 모드는 EasyMode를 완료한,로딩암 조종견습생 및 전문가를 위한 모드입니다. \r\n\r\n" +
     "로딩암에 대한 절차적인 정보가 제공되며, 실제 로딩암 조종을 위한 좋은 연습방법이 될 것 입니다. \r\n\r\n" +
     " 저희가 이번에 사용할 로딩암은 RCMA (Rotary Counterweighted Marine Arm)으로 이러한 구조의 로딩 암은 중형 탱커나 대형 탱커의 하역에 주로 사용됩니다. \r\n\r\n" +
     " RCMA는 단일 평형추를 이용하여 인 보 드 암과 아웃 보드 암의 균형을 동시에 균형을 이루며, RCMA는 구형의 커다란 로딩 암 구조(DCMA)와 비교해 서 훨씬 가벼운 구조로 이루어져 있습니다  " 
     + " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)"

     );
    }
    public void Popup_2_hard()
        {
            PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
         "하드모드", "로딩암 운전시 유의점으로 로딩암의 암(Arm)의 운동 각도범위는 10°이상 70°이하인 것으로 하며 \r\n\r\n" +
         "로딩암은 차량과 로딩암의 위치가 직각에서 ±20°에서도 이입·충전 작업이 가능한 것으로 합니다." +
 
         " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)"
         );
        }
    public void Popup_3_hard()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
    "하드모드", "  로딩암작업의 순서로는 \r\n\r\n " +
    "부두에 선박 접안->\r\n" +
    "선박 안전점검 실시->\r\n" +
    "액체화물 이송 작업 준비->\r\n" +
    "액체화물 이송 작업 시작->\r\n" +
    "액체화물 이송작업 진행->\r\n" +
    "액체화물 이송작업 종료 로 이뤄집니다. \r\n" +
     " 현재 진행중인 작업은 액체화물 이송작업 준비입니다." +
     "\r\n \r\n 조종기를 이용하여 로딩암이 선박의 파이프 연결부위(빨간색)과 닿으면 연결장면으로 넘어갑니다." +

     " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)"
     );
    }
    public void Popup_connection_hard()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "하드모드", " 로딩암과 선박의 연결부위가 매치되었습니다 \r\n\r\n" +
     "• 로딩암 연결 전 선박 측 매니폴드 주변을 포함한 갑판상의 밸브 잠김 상태를 확인한 후, 연결 작업을 진행합니다.\r\n\r\n" +
     "• 로딩암 연 후 연결부위에 대한 누설 시험(Leak Test) 을 실시하여 이상 유무를 확인 하고 육상에 통보합니다.\r\n\r\n" +
     "• 누설 시험(Leak Test) 실시 후 이상이 없으면 해당 로딩암 밸브는 다시 닫힘 상태로 복귀시켜 놓아야 합니다." +

     " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)"
     );
    }
    public void Popup_Ani_In_hard()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "하드모드", "라인업(Line-up) 및 펌핑(Pumping) 준비\r\n\r\n" +
     "• 선박 측 하역 책임사관 및 충분한 수의 하역 당직선원이 하역제어실(CCR), 선박의 매니폴드 및 육상과 연결된 사다리(Gangway) 근처를 포함한 갑판 상에 배치되어야 합니다.\r\n\r\n" +
     "• 하역시작 전 본선 책임사관으로부터 본선의 라인업(Line - Up) 상태를 확인하고 터미널의 라인업(Line - Up) 상태를 확인받은 후 하역작업에 임합니다.\r\n\r\n" +
     "• VOC화물유를양하하는선박은불활성가스시스템(IGS) 이 가동 될 수 있도록 확인하여 미리가동해두거나 가동준비를 요청합니다. "

     + " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)");
    }
    public void Popup_Ani_In_hard2()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "하드모드", " 로딩암이 연결 되어있는 동안에는 다음의 예방조치를 준수하여야 합니다. \r\n \r\n " +
     "• 선박 계류 시, 유동에 의해 로딩암의 작동에 문제가 발생치 않도록 수시로 확인할 것  \r\n\r\n" +
     "• 만약 경보가 울리면 모든 이송작업은 중지하여야 하며, 비상대책을 세워 실행할 것  \r\n\r\n" +
     "• 암은 선박의 이동에 따라 움직임이 자유로울 것  \r\n\r\n" +
     "• 암은 각기 서로 충돌하지 아니할 것  \r\n\r\n" +
     "• 과도한 진동을 피할 것  \r\n\r\n" +
     "• 모든 연결플랜지는 빠짐없이 볼트로 조여져 있어야합니다  "

     + " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)");
    }
    public void Popup_Ani_In_hard3()    //두번째배 연결
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "하드모드", "선박 파이프와 로딩 암을 연결할 때\r\n\r\n 유압으로 작동하는 QC/DC 기구를 이용하여 메니폴드를 신속하고 강하게 잡아주는 역할을 하기 때문에\r\n\r\n " +
     "액체나 기체의 화물을 이송하는 데에 불편함이 없습니다."

     + " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)");
    }
    public void Popup_Ani_out_hard()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "하드모드", "해제 작업을 정리하면 \r\n\r\n" +
     "• Pump Stop \r\n\r\n" +
     "• 탱크 계측 \r\n\r\n" +
     "• 로딩암 밸브 닫음 \r\n\r\n" +
     "• 로딩암(호스) Drain \r\n\r\n" +
     "• 로딩암(호스) 분리로  이루어지게됩니다."

     + " \r\n \r\n( F 를 눌러 해제을 시작하세요.)");
    }
    public void Popup_Ani_out_hard2()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "하드모드", "로딩암 해제가 성공적으로 완료되었습니다. 이제 선박은 항만을 떠나갑니다." +
     " \r\n \r\n 곧 2번째 배가 들어오니 지금까지 한 내용을 떠올리며 조종해보십시오.  \r\n \r\n " 
      );
    }
    public void Popup_Ani_out_hard3()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "하드모드", "선박 유류 선적작업의 마지막 단계를 토핑 오프라고 합니다 \r\n\r\n" +
     " 이는  유류를 보내는 속도를 낮추고, 탱크별로 동시에 작업을 끝내는 것이 아니고" +
     " 순차적으로 작업이 끝나도록 하여 유류의 목적했던 양과 일치시키는 작업입니다. \r\n\r\n" +
     "화물창이 Topping-off 단계에가까워지면선박의요청에따라 Slow Rate로낮춰서안전한 하적 종료가 되도록 감독합니다.\r\n\r\n " +
     "하역이 종료되면 로딩암밸브 및 선박의게이트밸브가 닫혀진 상태인지 확인합니다.\r\n\r\n" +
     "하역작업이 종료되면 본선 선원의 협조를 받아 로딩암을 분리하기 전에 로딩암내의 잔유를 충분히드레인시켜야합니다.\r\n\r\n" +
     "드레인후 로딩암을 분리해제후 원래 위치로 복귀시킵니다. \r\n\r\n" +
     "선박은 출항을 실시합니다  \r\n\r\n( F 를 눌러 해제을 시작하세요.)");
    }
    public void Popup_mockup()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "목업", "목업 연결 성공 \r\n\r\n( F 를 눌러 해제을 시작하세요.)"
      );
    }
    public void Popup_shipside()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "경고", "배옆면과 충돌했습니다. 실제로는 사고로 이어질 수 있으므로 주의해야합니다, \r\n\r\n 로딩암은 다시 원상태로 초기화 됩니다.\r\n \r\n 재조종 하십시오\r\n( F 를 눌러 해제을 시작하세요.)"
      );
    }
    public void Popup_plane()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "경고", "바닥과 충돌했습니다. 실제로는 사고로 이어질 수 있으므로 주의해야합니다, \r\n\r\n 로딩암은 다시 원상태로 초기화 됩니다.\r\n \r\n 재조종 하십시오\r\n( F 를 눌러 해제을 시작하세요.)"
      );
    }
}
